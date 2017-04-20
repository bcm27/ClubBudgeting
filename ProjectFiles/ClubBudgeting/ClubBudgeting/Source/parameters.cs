using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBudgeting
{
   class Parameters
   {
      ArrayList prams;
      
      public Parameters() { prams = new ArrayList(); }

      /// <summary>
      /// Create new param list and add every param to it
      /// </summary>
      /// <param name="sList"></param>
      public Parameters(params object[] sList)
      {
         prams = new ArrayList();
         prams.Clear();
         foreach (object o in sList)
            prams.Add(o);
      }

      /// <summary>
      /// Add a parameter to the parameter list
      /// </summary>
      public void addParams(params object[] sList)
      {
         prams.Clear();
         foreach (object o in sList)
            prams.Add(o);
      }

      /// <summary>
      /// Get/set functions to get/set param list
      /// </summary>
      public ArrayList PARAM_LIST
      {
         get { return prams; }
         set { prams = value; }
      }
   }
}
