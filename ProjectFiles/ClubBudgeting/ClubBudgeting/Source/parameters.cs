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

      public Parameters(params object[] sList)
      {
         prams = new ArrayList();
         foreach (object o in sList)
            prams.Add(o);
      }

      public void addParams(params object[] sList)
      {
         foreach (object o in sList)
            prams.Add(o);
      }

      /// <summary>
      /// get functions for getting and setting
      /// </summary>
      public ArrayList PARAM_LIST
      {
         get { return prams; }
         set { prams = value; }
      }
   }
}
