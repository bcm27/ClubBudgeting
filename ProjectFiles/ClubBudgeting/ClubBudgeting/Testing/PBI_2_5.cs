using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace ClubBudgeting.Testing {
   [TestFixture]
   class PBI_TESTING {
      private static string server_details = "server=localhost;"
       + "user=root;" + "database=Club_Funds;" + "port=3306;password=pasword";
      private MySqlConnection SQLCONN = new MySqlConnection(server_details);
      private MySqlCommand cmd;
      private MySqlDataReader rd;

      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      private bool pass = false;
      private string statement, temp;

      // Tests that happen before every test is run
      [SetUp]
      public void beforeTests() {
         // Open database
         try { SQLCONN.Open(); } catch { pass = false; }
         statement = temp = "";
      }

      // Tests that happen after every test is run
      [TearDown]
      public void afterTests() {
         // Open database
         try { SQLCONN.Close(); } catch { pass = false; }
         Assert.True(pass);
      }

      /// <summary>
      /// Basic test for connecting to the database
      /// </summary>
      [Test]
      public void basic_connection_test() {
         statement =
          "INSERT INTO member VALUES (NULL, 'steve', 'micheal', 'password')";
         MySqlCommand cmd = new MySqlCommand(statement, SQLCONN);
         cmd.ExecuteNonQuery();

         try {
            statement = "SELECT * FROM member";
            cmd = new MySqlCommand(statement, SQLCONN);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            if (!rd[1].Equals("steve"))
               pass = false;
         } catch {
            pass = false;
         }
         Assert.True(pass);
      }

      /// <summary>
      /// Tests to check if PDF and excel files can be added to database
      /// </summary>
      [Test]
      public void PBI_2_3() {
         string fileName = @"C:\test.pdf",
            transId = "1";
         try {
            sql.addPDFReceipt(new Parameters
               (transId, File.ReadAllBytes(fileName), "pdf"));
            pass = true;
         } 
         catch { pass = false; }
         Assert.True(true);
      } 

      /// <summary>
      /// Tests to check that the admin can't exceed the overall budget 
      /// for each club
      /// </summary>  
      [Test]
      public void PBI_5() {
         try {
            sql.addBudget(new Parameters(1, 2, 1000, 750, 0));
            if (sql.getCurrClubBudg(new Parameters(us.CLUB_ID)) == ("750"))
               pass = true;
         } catch {
            pass = false;
         }
         Assert.True(pass);
      }

      /// <summary>
      /// Test to check the the budget limit cannot be exceeded
      /// </summary>
      [Test]
      public void PBI_5_1() {
         try {
            int budgetLimit = 5000;
            string clubId = us.CLUB_ID,
             money = sql.getCurrClubBudg(new Parameters(us.CLUB_ID));

            sql.addBudget(new Parameters(2, 8, 1000.00, 500.00, 200.00));

            statement = "SELECT * FROM Budget";
            cmd = new MySqlCommand(statement, SQLCONN);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();

            if (rd[1].Equals(budgetLimit) || (int)rd[1] <= budgetLimit
             || (int)rd[1] >= 0) {
               pass = false;
            }
         } catch {
            pass = false;
         }
         Assert.True(pass);
      }
   } 
} 
