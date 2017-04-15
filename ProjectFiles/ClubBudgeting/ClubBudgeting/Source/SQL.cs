using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using ClubBudgeting.Source;

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
      private ArrayList clubArray = new ArrayList();

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
      /// security for passwords
      /// </summary>
      private Security sec =  Security.Instance;

      /// <summary>
      /// open file locations to save, select from 
      /// </summary>
      private FolderBrowserDialog fbd = new FolderBrowserDialog();

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

      internal string getAccountName(string cLUB_ID)
      {
         throw new NotImplementedException();
      }

      internal string getDefund(string cLUB_ID)
      {
         throw new NotImplementedException();
      }

      internal string getBudget(string cLUB_ID)
      {
         throw new NotImplementedException();
      }

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
      /// if user/pass combo exists, then it is a user
      /// </summary>
      /// <param name="user">name</param>
      /// <param name="pass">password</param>
      /// <returns></returns>
      public bool checkPass(string user, string pass)
      {
         string[] pList = { user, pass};
         statement = "SELECT * FROM Member"
            + " WHERE userName = @user AND pass = @pass;";
         string[] listing = { "@user", "@pass"};
         cmd = new MySqlCommand(statement, SQLCONN);
         try
         {
            Reader = addParams(cmd, listing, pList).ExecuteReader();
            Reader.Read();
         }
         catch
         { 
            return false;
         }
         return true;
      }

      /// <summary>
      /// log in function, if any errors happen, throws exception
      /// </summary>
      /// <param name="user">case sensitive</param>
      /// <param name="pass">already hashed</param>
      /// <returns>Tuple(adminPrivleges, clubId)</returns>
      public Tuple<bool, string> logIn(string user, string pass)
      {
         string[] pList = { user, sec.hash(pass) };
         statement = "SELECT * FROM Member"
            + " WHERE userName = @user AND pass = @pass;";
         string[] listing = { "@user", "@pass" };
         cmd = new MySqlCommand(statement, SQLCONN);
         if (checkPass(user, sec.hash(pass)))
         {
            try
            {
               Reader = addParams(cmd, listing, pList).ExecuteReader();
               Reader.Read();
               return new Tuple<bool, string>(Reader[0].ToString().ToUpper() ==
                  "FALSE", Reader[1].ToString());
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
               MessageBox.Show("Error " + ex.Number + " has occurred: " 
                  + ex.Message,"Error", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
               return null;
            }
         }
         return null;
      }

      /// <summary>
      /// Adding a transaction to the database, checking prior
      /// capped if null add NULL, the rest cannot be null
      /// {@date, @FILE, @EXT, @price, @DESC, @club}
      /// </summary>
      /// <param name="date">Will be checked</param>
      /// <param name="file">Byte array to a string</param>
      /// <param name="price">@date, @FILE, @EXT, @price, @DESC, @club</param>
      /// <returns>Whether or not the user is an admit</returns>
      public bool addTransaction(Parameters pLists)
      {
         string[] listing = { "@Date", "@File", "@Ext", "@price", "@desc", "@club" };
         statement = "INSERT INTO Transactions VALUES "
            + "(null, @Date, @File, @Ext, @price, @desc, @club, false);";
         cmd = new MySqlCommand(statement, SQLCONN);
         cmd.Prepare();
         try
         {
            addParams(cmd, listing, pLists.PARAM_LIST).ExecuteNonQuery();     
         }
         catch (MySql.Data.MySqlClient.MySqlException ex)
         {
            MessageBox.Show("Error " + ex.Number +" has occurred: "+ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
         statement = "INSERT INTO Club VALUES "
            + "(null, @club, @desc);";
         cmd = new MySqlCommand(statement, SQLCONN);
         cmd.Prepare();
         try
         {
            addParams(cmd, listing, pLists.PARAM_LIST).ExecuteNonQuery();
         }
         catch (MySql.Data.MySqlClient.MySqlException ex)
         {
            MessageBox.Show("Error "+ex.Number + " has occurred: " +ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
         }
         return true;
      } // addClub

      /// <summary>
      /// creates a new user to add to the database
      /// </summary>
      /// <param name="pLists">@club, @admin, @user, @first,
      ///                      @last, @pass</param>
      /// <returns>completed</returns>
      public bool addMember(Parameters pLists)
      {
         string[] listing = { "@club", "@admin", "@user", "@first",
            "@last", "@pass" };
         statement = "INSERT INTO Club VALUES "
            + "(null, @club, @admin, @user, @first, @last, @pass);";
         cmd = new MySqlCommand(statement, SQLCONN);
         cmd.Prepare();
         try
         {
            addParams(cmd, listing, pLists.PARAM_LIST).ExecuteNonQuery();
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
      /// <param name="pLists">@file, @ext, @transId</param>
      /// <returns>completed</returns>
      public bool addPDFReceipt(Parameters pLists)
      {
         string[] listing = { "@file", "@ext", "@transId" };
         statement = "UPDATE Transactions SET invoice = @file " 
            + "AND fileExtention = @ext WHERE id = @transId;";
         cmd = new MySqlCommand(statement, SQLCONN);
         cmd.Prepare();
         try
         {
            addParams(cmd, listing, pLists.PARAM_LIST).ExecuteNonQuery();
         }
         catch
         {
            return false;
         }
         return true;
      }

      /// <summary>
      /// retrieves PDF from DB
      /// </summary>
      /// <param name="pLists">@transId</param>
      /// <returns></returns>
      public bool getPDF(Parameters pLists)
      {
         string[] listing = { "@transId" };
         statement = "SELECT invoice, fileExtention FROM Transactions"
            + "WHERE id = @transId;";
         cmd = new MySqlCommand(statement, SQLCONN);
         cmd.Prepare();

         try
         {
            Reader =
               addParams(cmd, listing, pLists.PARAM_LIST).ExecuteReader();
            Reader.Read();

            // Choose and set path
            if (fbd.ShowDialog() == DialogResult.OK)
            {
               System.IO.File.WriteAllBytes(fbd.SelectedPath + "\\invoice."
                  + Reader[1].ToString(), (byte[])Reader[0]);
            }
         }
         catch 
         {
            return false;
         }
         return true;
      }

      /// <summary>
      /// closes everything needed
      /// </summary>
      public void close()
      {
         SQLCONN.Close();
      } // close

      /// <summary>
      /// adds sterilized params to the command
      /// </summary>
      /// <param name="cmd">initial command</param>
      /// <param name="listing">what order the prams are in</param>
      /// <param name="prams">the parameters</param>
      /// <returns>sterilized command</returns>
      private MySqlCommand addParams
         (MySqlCommand cmd, string[] listing, string[] prams)
      {
         for (int i = 0; i < listing.Length; i++)
            cmd.Parameters.AddWithValue(listing[i], prams[i]);
         
         return cmd;
      }

      /// <summary>
      /// fills the club array list
      /// </summary>
      /// <returns></returns>
      private ArrayList fillClubArray()
      {
         statement = "SELECT id, name FROM Club";
         cmd = new MySqlCommand(statement, SQLCONN);

         try
         {
            Reader = cmd.ExecuteReader();

            // read in and store each club's name
            while (Reader.Read())
            {
               ArrayList clubInfo = new ArrayList();
               clubInfo.Add(Reader[0].ToString());
               clubInfo.Add(Reader[1].ToString());
               clubArray.Add(clubInfo);
            }
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
      public ArrayList CLUB_LIST
      {
         get { return clubArray; }
      }

   }
}
