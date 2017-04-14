using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubBudgeting
{
   class SQL
   {
      // Global variables, used in everyFunction, so decalring it out here.
      string statement;
      MySqlConnection SQLCONN;
      MySqlCommand cmd;
      MySqlDataReader Reader;

      // string array to hold list of club names
      private static string[] clubArray;

      /// <summary>
      /// Static instance of this class
      /// </summary>
      private static SQL SQLInstance;

      /// <summary>
      /// To prevent access by more than one thread. This is the specific lock 
      /// belonging to the FileManager Class object.
      /// </summary>
      private static Object fmLock = typeof(User);

      /// <summary>
      /// - Private constructor so no one else can create one.
      /// </summary>
      private SQL() { }

      /// <summary>
      /// starts connections
      /// </summary>
      private void Initilize()
      {
         SQLCONN = new MySqlConnection("server=localhost;"
            + "user=root;"
            + "database=ClubSchema2;"
            + "port=3306;"
            + "password=potato123");
         SQLCONN.Open();

         fillClubArray();
      } // Initilize

      /// <summary>
      /// Management for static instance of this class
      /// </summaryUser
      public static SQL Instance
      {
         get
         {
            lock (fmLock)
            {
               // if no instnace exists, we need to create one
               if (SQLInstance == null)
               {
                  SQLInstance = new SQL();
                  SQLInstance.Initilize();
               }
               return SQLInstance; // return the only instance of this calss
            }
         }
      } // Instance

      /// <summary>
      /// searches for a user in the database and returns a bool for the resultS
      /// </summary>
      /// <param name="userName"></param>
      /// <param name="hashPass"></param>
      /// <returns></returns>
      public bool getUser(string userName, string hashPass)
      {        
         statement = string.Format("SELECT * FROM Member WHERE"
          + "userName = {0} AND pass = {1};", userName, hashPass);

         cmd = new MySqlCommand(statement, SQLCONN);
         try
         {
            Reader = cmd.ExecuteReader();
            Reader.Read();
            return true;
         }
         catch { return false; }
      }

      /// <summary>
      /// log in function, if any errors happen, throws exception
      /// </summary>
      /// <param name="user">case sensitive</param>
      /// <param name="pass">already hashed</param>
      /// <returns>Tuple(adminPrivleges, clubId)</returns>
      public Tuple<bool, string> logIn(string user, string pass)
      {
         statement = string.Format("SELECT adminRight, clubId FROM Member WHERE"
            + "userName = {0} AND pass = {1};", user, pass);
         cmd = new MySqlCommand(statement, SQLCONN);

         try
         {
            Reader = cmd.ExecuteReader();
            Reader.Read();
            return new Tuple<bool, string>(Reader[0].ToString().ToUpper() == "FALSE", Reader[1].ToString());
         }
         catch
         {
            throw new Exception();
         }
      }

      /// <summary>
      /// Adding a transaction to the database, checking prior
      /// </summary>
      /// <param name="date">Will be checked</param>
      /// <param name="file">Byte array to a string</param>
      /// <param name="price">total of purchase</param>
      /// <returns>Whether or not the user is an admit</returns>
      public bool addTransaction(Parameters pLists)
      {
         string[] listing = { "@date", "@ext", "@price", "@desc", "@club" };
         string[] prams = pLists.PARAM_LIST;
         statement = string.Format("INSERT INTO Transactions VALUES "
            + "(null, @date, {0}, @ext, @price, @desc, @club);", prams[4].ToString());
         cmd = new MySqlCommand(statement, SQLCONN);
         cmd.Prepare();
         try
         {
            addParams(cmd, listing, prams).ExecuteNonQuery();
         }
         catch
         {
            return false;
         }
         
         return true;
      } // addTransaction

      /// <summary>
      /// Adding a transaction to the database, checking prior
      /// </summary>
      /// <param name="date">Will be checked</param>
      /// <param name="file">Byte array to a string</param>
      /// <param name="price">total of purchase</param>
      /// <returns>Whether or not the user is an admit</returns>
      public bool addClub(Parameters pLists)
      {
         string[] listing = { "@club", "@desc" };
         string[] prams = pLists.PARAM_LIST;
         statement = "INSERT INTO Club VALUES "
            + "(null, @club, @desc);";
         cmd = new MySqlCommand(statement, SQLCONN);
         cmd.Prepare();
         try
         {
            addParams(cmd, listing, prams).ExecuteNonQuery();
         }
         catch
         {
            return false;
         }
         return true;
      } // addClub


      public void getReceipts()
      {
         statement = "SELECT invoice, fileExtention FROM Transactions WHERE "
            + "id = 1;";
         cmd = new MySqlCommand(statement, SQLCONN);
         Reader = cmd.ExecuteReader();
         Reader.Read();
         byte[] b = Encoding.ASCII.GetBytes(Reader[0].ToString());
         System.IO.File.WriteAllBytes(@"F:\picture." + Reader[1].ToString(), b);
      }

      /// <summary>
      /// closes everything needed
      /// </summary>
      public void close()
      {
         SQLCONN.Close();
      } // close

      private MySqlCommand addParams
         (MySqlCommand cmd, string[] listing, string[] prams)
      {
         for (int i = 0; i < listing.Length; i++)
            cmd.Parameters.AddWithValue(listing[i], prams[i]);
         return cmd;
      }


      private Array fillClubArray()
      {
         int nameCtr = 0;
         statement = "SELECT name FROM Club";
         cmd = new MySqlCommand(statement, SQLCONN);

         try
         {
            Reader = cmd.ExecuteReader();

            // read in and store each club's name
            while (Reader.Read())
               clubArray[nameCtr++] = Reader.GetString(nameCtr);
         }
         catch
         {
            throw new Exception("fillClubArray failed");
         }

         return clubArray;
      }

      /// <summary>
      /// Return a copy of the list of club names in the database
      /// </summary>
      public string[] CLUB_LIST
      {
         get { return clubArray; }
      }

   }
}
