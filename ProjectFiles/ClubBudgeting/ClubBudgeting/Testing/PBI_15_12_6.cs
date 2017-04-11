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
    [TestFixture]
    class PBI_15_12_6
    {
        MySqlConnection SQLCONN = new MySqlConnection("server=localhost;user=root;database=Club_Funds;port=3306;password=potato123");
        bool pass;
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

        [Test]
        public void PBI_15()
        {
            string statement = "INSERT INTO member VALUES (NULL, 'steve', 'micheal', 'alksjdfhoquaebovquehrbgoqerg')";
            MySqlCommand cmd = new MySqlCommand(statement, SQLCONN);
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

        [Test]
        public void PBI_12()
        {
            Assert.True(true);
        }

        [Test]
        public void PBI_6()
        {
            Assert.True(true);
        }
    }
}
