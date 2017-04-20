using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBudgeting
{
   class User
   {
      // Global Variables
      private bool admin,
         loggedIn;
      Parameters pLists;

      // username and club
      private string username, clubId, clubName;

      // instance
      SQL sql = SQL.Instance;

      /// <summary>
      /// Static instance of this class
      /// </summary>
      private static User UsInstance;

      /// <summary>
      /// To prevent access by more than one thread. This is the specific lock 
      /// belonging to the FileManager Class object.
      /// </summary>
      private static Object fmLock = typeof(User);

      /// <summary>
      /// - Private constructor so no one else can create one.
      /// </summary>
      private User() { }

      /// <summary>
      /// Initizlises variables before login.
      /// </summary>
      private void Initilize()
      {
         admin = false;
         loggedIn = false;
      }
      
      /*
       * 
       * Get/Set Methods
       * 
       */

      public string CLUB_ID
      {
         get { return clubId; }
         set { clubId = value; }
      }

      public string CLUB_NAME
      {
         get { return clubName; }
         set { clubName = value; }
      }

      /// <summary>
      /// Management for static instance of this class
      /// </summaryUser
      public static User Instance
      {
         get
         {
            lock (fmLock)
            {
               if (UsInstance == null) // if no instnace exists, we need to create one
               {
                  UsInstance = new User();
                  UsInstance.Initilize();
               }
               return UsInstance; // return the only instance of this calss
            }
         }
      } // Instance


      /*
       * 
       * Functions
       * 
       */

      /// <summary>
      /// checks to see if the user/pass exists in the DB
      /// returns false if any error happens
      /// </summary>
      /// <param name="name">case sensitive</param>
      /// <param name="pass">already hashed</param>
      /// <returns>successful login</returns>
      public bool LogIn(string name, string pass)
      {
         try
         {
            string temp = sql.logIn(name, pass);
            username = name;
            if (temp.Equals("0"))
               admin = true;
            clubId = temp;
            loggedIn = true;
            return true;
         }
         catch
         {
            return false;
         }
      }
   }
}
