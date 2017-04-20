using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;
using MySql.Data;
using MySql.Data.MySqlClient;

/*
namespace ClubBudgeting.Testing
{ 
   [TestFixture]
   class PBI_TESTING
   {
      private static string server_details = "server=localhost;"
                                           + "user=root;"
                                           + "database=Club_Funds;"
                                           + "port=3306;password=pasword";
      private MySqlConnection SQLCONN = new MySqlConnection(server_details);
      private MySqlCommand cmd;
      private MySqlDataReader rd;

      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      private bool pass = false;
      private string statement, temp;

      // tests that happen before every test is run
      [SetUp]
      public void beforeTests()
      {
         // open database
         try { SQLCONN.Open(); }
         catch { pass = false; }
         statement = temp = "";
         Assert.True(pass);
      }

      // tests that happen after every test is run
      [TearDown]
      public void afterTests()
      {
         // open database
         try { SQLCONN.Close(); }
         catch { pass = false; }
         Assert.True(pass);
      }
      //#####################################################################//
      // basic testing for a connection to the database
      [Test]
      public void basic_connection_test()
      {
         statement =
            "INSERT INTO member VALUES (NULL, 'steve', 'micheal', 'password')";
         MySqlCommand cmd = new MySqlCommand(statement, SQLCONN);
         cmd.ExecuteNonQuery();
         try
         {
            statement = "SELECT * FROM member";
            cmd = new MySqlCommand(statement, SQLCONN);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (!rd[1].Equals("steve"))
               pass = false;
         }
         catch
         {
            pass = false;
         }
         Assert.True(pass);
      }
      //#####################################################################//
      // DESCRIPTION of Issue #2
      // As a club leader, I want to be able to add receipts in the form of
      // PDFs so they can be processed by the administrator. This can be 
      // done by using a BLOB in the database to contain the receipt in PDF
      // format. The entry itself will need to have all the specified data 
      // that will make the submission processeasier for the administrator,
      // such as the receipt, the total amount of the purchase, the location
      // of the purchase, and the time purchased. Testing will be handled in 
      // both C# and MySQL by trying to add objects other than a picture or 
      // PDF to the database. 
      //#####################################################################//
      [Test]
      public void PBI_2_3()
      {
         string pdf = "some series of bytes",
            accountId = "123534",
            clubId = "1234534";
         try
         {
            sql.addPDFReceipt(new Parameters("",".pdf",""));
            statement = "SELECT * FROM Receipt";
            cmd = new MySqlCommand(statement, SQLCONN);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (!rd[1].Equals(pdf)
               || !rd[2].Equals(accountId)
               || !rd[1].Equals(clubId))
            {
               pass = false;
            }
         } // end try
         catch
         { pass = false; }
         Assert.True(pass);
      } // end of PBI_2_AddReceipt
      //#####################################################################//
      [Test]
      public void PBI_2_2()
      {
         try
         {
            SQL.getPDF(new Parameters());
         }
         catch
         {
            pass = false;
         }
         Assert.True(pass);
      } // PBI_2_getPDF
      //#####################################################################//
      [Test]
      public void PBI_2_1()
      {
         try
         {
            string accountId = fm.getAccountId(),
               clubId = fm.getClubId(),
               receiptId = fm.getReceiptId();
            SQL.removeReceipt(accountId, clubId, receiptId);
         }
         catch
         {
            pass = false;
         }
         Assert.False(pass);
      } // end of PBI_2_AttemptNegative
      //#####################################################################//
      // DESCRIPTION of Issue #5
      // As an administrator, I want to be able to view the overall club 
      // funds budget so I can track the budgets as a whole and the 
      // percentage that each club has been allocated. This can be handled
      // through another table in the MySQL database. This one can contain a
      // single entry for the overall budget and another for each of the 
      // clubs and what percent of the budget that each uses. These can 
      // either be updated through MySQL code or via the C# code that is 
      // connected to the database. For testing, determining whether a 
      // club’s budget will exceed the maximum allotted for the term as well
      // as trying to add a budget that will exceed the maximum amount or 
      // just push over the limit of the overall budget.These test will need
      // to be hand coded in C# using a testing library known as nUnit.
      //#####################################################################//      
      [Test]
      public void PBI_5()
      {
         try
         {
            string accountId = fm.getAccountId(),
               clubId = fm.getClubId(),
               money = fm.getBudget();
            SQL.AddToBudget(clubId, accountId, money);
         }
         catch
         {
            pass = false;
         }
         Assert.True(pass);
      }
      //#####################################################################//
      [Test]
      public void PBI_5()
      {
         try
         {
            int budgetLimit = 5000;
            string clubId = us.CLUB_ID, 
               money = sql.getCurrClubBudg(new Parameters(us.CLUB_ID));

            sql.addBudget(new Parameters(2, 8, 1000.00, 500.00, 200.00));

            statement = "SELECT * FROM Budget";
            cmd = new MySqlCommand(statement, SQLCONN);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (rd[1].Equals(budgetLimit)
               || (int)rd[1] <= budgetLimit
               || (int)rd[1] >= 0)
            {
               pass = false;
            }
         }
         catch
         {
            pass = false;
         }
         Assert.True(pass);
      } // end PBI_5_OverLimit//

   } // end of scope 
} // end of namespace

*/

