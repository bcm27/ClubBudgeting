using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ClubBudgeting.Testing
{
   
   // SQL is our unimplemented interface (C# does not have interfaces, so we imporvised)
   [TestFixture]
   class PBI_15_12_6
   {
      MySqlConnection SQLCONN = new MySqlConnection
         ("server=localhost;user=root;database=Club_Funds;port=3306;"
         +"password=potato123");
      bool pass;
      SQL sql = SQL.Instance;


      [SetUp]
      public void beforeTests()
      {
         SQLCONN.Open();
         pass = true;
      }

      [TearDown]
      public void afterTests()
      {
         SQLCONN.Close();
         pass = true;
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
         Parameters pList = new Parameters();
         pList.addParams( "NULL", "NULL", "2017-04-20", );
         // correct format for a purchase
         sql.addTransaction("2017-04-20", 20.20, file.ToString()); 
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
         Assert.AreEqual("20.20", temp);

         // correct format for a return
         sql.addTransaction("2017-04-21", -20.20, file.ToString()); 

         try
         {
            statement = "SELECT * FROM Transactions WHERE purchaseDate = "
               +"'2017-04-21'";
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
         sql.addTransaction("2017-04-22", 20000.20, file.ToString()); 

         try
         {
            statement = "SELECT * FROM Transactions WHERE purchaseDate = "
               +"'2017-04-22'";
            cmd = new MySqlCommand(statement, SQLCONN);
            rd = cmd.ExecuteReader();
            rd.Read();
            temp = rd[2].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(true);
         }

         Assert.True(false);
      }

      /*
      /// <summary>
      /// testing for user logins, correct passwords, incorect passwords, 
      /// bad user, different types of users
      /// </summary>
      [Test]
      public void PBI_12()
      {
         bool accessed = false;

         // correct user/pass for a user
         accessed = sql.LogIn("Steve", "1234567890"); 
         Assert.True(accessed);

         // false pass for a correct user user
         accessed = sql.LogIn("Steve", "cat"); 
         Assert.True(accessed);

         // incorrect user
         accessed = sql.LogIn("joe", "dog");
         Assert.True(accessed);

         // correct user/pass for a admin
         accessed = sql.LogIn("mike", "1234567890"); 
         Assert.True(accessed);

         // incorrect pass for a correct user
         accessed = sql.LogIn("mike", "1234567890"); 
         Assert.True(accessed);
      }


      /// <summary>
      /// tests for adding a XML file to the database, incorrect ones, 
      /// correct ones
      /// </summary>
      [Test]
      public void PBI_6()
      {
         string statement, temp = "";
         MySqlCommand cmd;
         MySqlDataReader rd;

         // correct file and type
         sql.addBudget(@"C:\path\to\the\budgetProposal.XML", "'2017-04-20'"); 

         try
         {
            statement = "SELECT * FROM BudgetProposals WHERE dateAdded = " 
               + "'2017-04-20'";
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

         Assert.True(false);
      }
   }
   */
}
