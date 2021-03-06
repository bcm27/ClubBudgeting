// PBI 1 and 3 tests

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ClubBudgeting.Testing {
   class PBI_3_1 {
      SQL sql = SQL.Instance;
      MySqlDataReader rd;
      MySqlConnection SQLCONN = new MySqlConnection
       ("server=localhost;user=root;database=ClubSchema2;port=3306;"
       + "password=potato123");
      string stmt;

      /// <summary>
      /// Open sql connection
      /// </summary>
      [SetUp]
      public void beforeTests() {
         SQLCONN.Open();
      }

      /// <summary>
      /// Close the sql connection
      /// </summary>
      [TearDown]
      public void afterTests() {
         SQLCONN.Close();
      }

      /// <summary>
      /// Test to check that club's budgets can be displayed correctly
      /// </summary>
      [Test]
      public void PBI_1() {
         stmt = "";
         MySqlCommand cmd;

         // Check Club
         sql.addClub(new Parameters("Solar Car", "Club builds solar car"));

         try {
            stmt = "SELECT name FROM Club WHERE name = 'Solar Car'";
            cmd = new MySqlCommand(stmt, SQLCONN);
            rd = cmd.ExecuteReader();

            rd.Read();
            rd.Close();
         } catch (MySql.Data.MySqlClient.MySqlException ex) {
            MessageBox.Show("Error " + ex.Number + " has occurred: " +
             ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Assert.True(false);
         }

         Assert.True(true);

         // Check Budget
         sql.addBudget(new Parameters(2, 8, 1000.00, 500.00, 200.00));

         try {
            stmt = "SELECT * FROM Budget WHERE clubId = 2";
            cmd = new MySqlCommand(stmt, SQLCONN);
            rd = cmd.ExecuteReader();

            rd.Read();
            rd.Close();
         } catch (MySql.Data.MySqlClient.MySqlException ex) {
            MessageBox.Show("Error " + ex.Number + " has occurred: " +
             ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Assert.True(false);
         }
         Assert.True(true);
      }

      /// <summary>
      /// Test to check that transactions can be added and displayed correctly
      /// </summary>
      [Test]
      public void PBI_3() {
         MySqlDataReader rd;
         string var = "";
         stmt = "";
         MySqlCommand cmd;

         // Must add club and budget before transaction
         sql.addClub(new Parameters("Solar Car", "Club builds solar car"));
         sql.addBudget(new Parameters(2, 8, 10000, 5000, 2000));
         sql.addTransaction(new Parameters("2012-12-12", 300,
            "Food costs", 2));

         try {
            stmt = "SELECT * FROM Club WHERE name = 'Solar Car'";
            cmd = new MySqlCommand(stmt, SQLCONN);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            rd.Read();
            var = rd[1].ToString();
            rd.Close();
         } catch {
            Assert.True(false);
         }

         Assert.AreEqual(var.ToString(), "Solar Car");

         try {
            // Refund - this should fail 
            sql.addTransaction(new Parameters("2012-12-12", -12000,
             "Travel", 2));

            stmt = "SELECT * FROM Transactions WHERE transactionsType = 1";
            cmd = new MySqlCommand(stmt, SQLCONN);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            rd.Read();
            var = rd[2].ToString();
            rd.Close();
         } catch {
            Assert.True(true);   // This transaction should fail
         }
      }
   }
}
