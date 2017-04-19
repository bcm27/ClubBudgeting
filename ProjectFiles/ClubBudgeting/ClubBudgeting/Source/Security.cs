using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClubBudgeting.Source
{
   class Security
   {
      /// <summary>
      /// Static instance of this class
      /// </summary>
      private static Security SecInstance;

      /// <summary>
      /// To prevent access by more than one thread. This is the specific lock 
      /// belonging to the FileManager Class object.
      /// </summary>
      private static Object sLock = typeof(User);

      /// <summary>
      /// Management for static instance of this class
      /// </summaryUser
      public static Security Instance
      {
         get
         {
            lock (sLock)
            {
               // if no instnace exists, we need to create one
               if (SecInstance == null)
               {
                  SecInstance = new Security();
               }
               return SecInstance; // return the only instance of this calss
            }
         }
      } // Instance

      // ability to run SQL 
      private static SQL sql = SQL.Instance;

      //#####################################################################//
      /// <summary>
      /// takes the string as a parameter and returns the hashed version of it.
      /// </summary>
      /// <param name="tohash"></param>
      /// <returns></returns>
      public string hash(string tohash)
      {
         var bytes = new UTF8Encoding().GetBytes(tohash);
         var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash
            (bytes);
         return Convert.ToBase64String(hashBytes);
      }// end of hash

      //#####################################################################//
      /// <summary>
      /// returns the result of the member search for the database, essentially
      /// this varifies the existence of the user through their pass & user Id
      /// </summary>
      /// <param name="userName"></param>
      /// <param name="password"></param>
      /// <returns></returns>
      public bool varifyPassword(string userName, string hashPass)
      { return sql.checkPass(userName, hashPass); } 

   } // end of class Security
} // end of name space
