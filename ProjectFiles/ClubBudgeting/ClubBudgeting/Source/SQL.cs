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


      /*
       * ---------
       * Functions
       * ---------
       */

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
      /// capped if null add NULL, the rest cannot be null
      /// </summary>
      /// <param name="date">Will be checked</param>
      /// <param name="file">Byte array to a string</param>
      /// <param name="price">@date, @FILE, @EXT, @price, @DESC, @club</param>
      /// <returns>Whether or not the user is an admit</returns>
      public bool addTransaction(Parameters pLists)
      {
         string[] listing = { "@date", "@file", "@ext", "@price", "@desc", "@club" };
         string[] prams = pLists.PARAM_LIST;
         statement = "INSERT INTO Transactions VALUES "
            + "(null, @date, @file, @ext, @price, @desc, false,@club);";
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
      /// 
      /// </summary>
      /// <param name="pLists"></param>
      /// <returns></returns>
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

      /// <summary>
      /// creates a new user to add to the database
      /// </summary>
      /// <param name="pLists">@user, @desc</param>
      /// <returns>completed</returns>
      public bool addMember(Parameters pLists)
      {
         string[] listing = { "@user", "@desc" };
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

      /// <summary>
      /// adds a pdf receipts
      /// </summary>
      /// <param name="pLists">@file, @date, @cost, @club</param>
      /// <returns>completed</returns>
      public bool addPDFReceipt(Parameters pLists)
      {
         return true;
      }

      /// <summary>
      /// retrieves PDF from DB
      /// </summary>
      /// <param name="pLists">@date, @cost, @club</param>
      /// <returns></returns>
      public string getPDF(Parameters pLists)
      {
         return "hi";
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
   }
}
