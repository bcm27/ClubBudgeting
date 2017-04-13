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

namespace ClubBudgeting.Testing
{
   class PBI_3_1
   {
      MySqlConnection SQLCONN = new MySqlConnection("server=localhost;"
       + "user=root;database=Club_Funds;port=3306;password=potato123");
      string stmt;

      [SetUp]
      public void beforeTests()
      {
         SQLCONN.Open();
      }

      [TearDown]
      public void afterTests()
      {
         SQLCONN.Close();
      }

      [Test]
      public void PBI_1()
      {
         MySqlDataReader rd;
         string var = "";
         stmt = "";
         MySqlCommand cmd;

         SQL.addClub(null, "Solar Car", "Club builds solar car"); // check Club

         try
         {
            stmt = "SELECT * FROM Club WHERE name = 'Solar Car'";
            cmd = new MySqlCommand(stmt, SQLCONN);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            rd.Read();
            var = rd[1].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(false);
         }

         Assert.True(true);

         SQL.addBudget(null, 10000, 5000, 3000, 2000);   // check Budget

         try
         {
            stmt = "SELECT * FROM Budget where allocatedMoney = 10000";
            cmd = new MySqlCommand(stmt, SQLCONN);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            rd.Read();
            var = rd[1].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(false);
         }

         Assert.True(true);
      }

      [Test]
      public void PBI_3()
      {
         MySqlDataReader rd;
         string var = "";
         stmt = "";
         MySqlCommand cmd;

         // need to add club and budget before transaction
         SQL.addClub(null, "Solar Car", "Club builds solar car");
         SQL.addBudget(null, 10000, 5000, 3000, 2000);
         SQL.addTransaction("null", "2012-12-12", 300, "Food costs", 2, 1);

         try
         {
            stmt = "SELECT * FROM Club WHERE name = 'Solar Car'";
            cmd = new MySqlCommand(stmt, SQLCONN);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            rd.Read();
            var = rd[2].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(false);
         }

         Assert.AreEqual(var.ToString(), "Solar Car");

         try
         {
            // refund so this should fail 
            SQL.addTransaction("null", "2012-12-12", -12000, "Travel", 1, 1, 1);

            stmt = "SELECT * FROM Transactions WHERE transactionsType = 1";
            cmd = new MySqlCommand(stmt, SQLCONN);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            rd.Read();
            var = rd[2].ToString();
            rd.Close();
         }
         catch
         {
            Assert.True(true);   // this transaction should fail
         }

         Assert.True(false);  // shouldn't be true
      }
   }
}
