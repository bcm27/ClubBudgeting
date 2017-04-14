using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubBudgeting
{
   class Parameters
   {
      string[] prams;
      
      public Parameters() { }

      public Parameters( string[] prams)
      {
         this.prams = prams;
      }


      public void addParams(params string[] sList)
      {
         this.prams = sList;
      }

      /// <summary>
      /// get functions for getting and setting
      /// </summary>
      public string[] PARAM_LIST
      {
         get { return prams; }
         set { prams = value; }
      }
   }
}
