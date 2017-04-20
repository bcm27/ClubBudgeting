using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;
using MySql.Data;
using MySql.Data.MySqlClient;
using ClubBudgeting.Source;


namespace ClubBudgeting.Testing
{
   
   // SQL is our unimplemented interface (C# does not have interfaces, so we imporvised)
   [TestFixture]
   class PBI_15_12_6
   {
      MySqlConnection SQLCONN = new MySqlConnection
         ("server=localhost;user=root;database=ClubSchema2;port=3306;"
         +"password=potato123");
      SQL sql = SQL.Instance;
      User u = User.Instance;
      Security sec = Security.Instance;
      Parameters pList;

       [SetUp]
      public void beforeTests()
      {
         pList = new Parameters();
         SQLCONN.Open();
      }

      [TearDown]
      public void afterTests()
      {
         SQLCONN.Close();
      }
      

      [Test]
      public void addTest()
      {
         // correct format for a purchase
         pList.addParams("2017-04-27", "20.20", "NULL", "3");
         Assert.True(sql.addTransaction(pList));
      }
      /// <summary>
      /// test for adding transactions, purchases, returns and 
      /// something that goes over a budget
      /// </summary>
      [Test]
      public void PBI_15()
      {
         string statement, temp = "";
         MySqlCommand cmd;
         MySqlDataReader rd;
         // correct format for a purchase
         pList.addParams("2017-04-20", "30.20", "NULL", "3" );
         sql.addTransaction(pList); 
         try
         {
            statement = "SELECT * FROM Transactions WHERE purchaseDate = "
               +"'2017-04-20'";
            cmd = new MySqlCommand(statement, SQLCONN);
            rd = cmd.ExecuteReader();
            rd.Read();
            temp = rd[2].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(false);
         }
         Assert.AreEqual("30.20", temp);

         // correct format for a return
         pList.addParams("2017-04-21", "-20.20", "NULL", "3" );
         sql.addTransaction(pList);

         try
         {
            statement = "SELECT * FROM Transactions WHERE purchaseDate = "
               + "'2017-04-21'";
            cmd = new MySqlCommand(statement, SQLCONN);
            rd = cmd.ExecuteReader();
            rd.Read();
            temp = rd[2].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(false);
         }
         Assert.AreEqual("-20.20", temp);

         // too large of a purchase
         pList.addParams("2017-04-22", "20000.20", "NULL", "3");
         sql.addTransaction(pList);

         try
         {
            statement = "SELECT * FROM Transactions WHERE purchaseDate = "
               + "'2017-04-22'";
            cmd = new MySqlCommand(statement, SQLCONN);
            rd = cmd.ExecuteReader();
            rd.Read();
            temp = rd[4].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(true);
         }
      }

     
      /// <summary>
      /// testing for user logins, correct passwords, incorect passwords, 
      /// bad user, different types of users
      /// </summary>
      [Test]
      public void PBI_12()
      {
         bool accessed = false;

         // add users to test
         sql.addUser(new Parameters(3, 0, "ltarnow", "Lee", "Tarnow", 
            sec.hash("123456789")));
         sql.addUser(new Parameters(5, 0, "ngerber", "nicole", "gerber", 
            sec.hash("Pineapple")));
         sql.addUser(new Parameters(7, 0, "nflanders", "Nick", "Flanders", 
            sec.hash("kitten")));
         sql.addUser(new Parameters(3, 1, "abreneman", "Amanda", "Breneman",
            sec.hash("dog")));
         sql.addUser(new Parameters(3, 1, "admin", "Amanda", "Breneman",
            sec.hash("test")));
         sql.addUser(new Parameters(3, 0, "user", "Amanda", "Breneman",
            sec.hash("test")));

         // correct user/pass for a user
         accessed = sql.checkPass("ltarnow", "1234567890"); 
         Assert.True(accessed);

         // false pass for a correct user user
         accessed = sql.checkPass("ltarnow", "cat"); 
         Assert.True(accessed);

         // incorrect user
         accessed = sql.checkPass("smeier", "dog");
         Assert.True(accessed);

         // correct user/pass for a admin
         accessed = sql.checkPass("ngerber", "Pineapple"); 
         Assert.True(accessed);

         // incorrect pass for a correct user
         accessed = sql.checkPass("ngerber", "pineapple"); 
         Assert.True(accessed);
      }


      /// <summary>
      /// tests for adding a XML file to the database, incorrect ones, 
      /// correct ones
      /// </summary>
      [Test]
      public void PBI_6()
      {
         MySqlCommand cmd;
         MySqlDataReader rd;
         Parameters pList = new Parameters
            (1, System.IO.File.ReadAllBytes
            (@"F:\Documents\GitHub\MeierPiler\Timelog.xlsx"), "xlsx");

         // correct file and type
         sql.AddBudgetProp(pList); 

         try
         {
            string statement = 
               "SELECT * FROM BudgetProposal;";
            cmd = new MySqlCommand(statement, SQLCONN);
            rd = cmd.ExecuteReader();
            rd.Read();
            rd.Close();
         }
         catch
         {
            Assert.True(false);
         }

         Assert.True(true);

         /*
         // not a budgetProposal file
         sql.addBudget(@"C:\path\to\the\Incorrect_file.XML", "'2017-04-21'"); 

         try
         {
            statement = "SELECT * FROM BudgetProposals WHERE dateAdded = "
               + "'2017-04-21'";
            cmd = new MySqlCommand(statement, SQLCONN);
            rd = cmd.ExecuteReader();
            rd.Read();
            temp = rd[2].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(true); // file does not exist.
         }

         Assert.True(false);

         // not a budgetProposal file
         sql.addBudget(@"C:\path\to\the\BudgetProposal.docx", "'2017-04-22'");
          
         try
         {
            statement = "SELECT * FROM BudgetProposals WHERE dateAdded = "
               +"'2017-04-22'";
            cmd = new MySqlCommand(statement, SQLCONN);
            rd = cmd.ExecuteReader();
            rd.Read();
            temp = rd[2].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(true); // file does not exist.
         }

         Assert.True(false);*/
      }
   }
   
}
