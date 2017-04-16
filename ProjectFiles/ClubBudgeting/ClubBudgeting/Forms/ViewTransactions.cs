using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubBudgeting.Source;

namespace ClubBudgeting.Forms
{
   public partial class ViewTransactions : Form
   {
      // static instance methods so we can access this information
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      public ViewTransactions()
      {
         InitializeComponent();
      }

      //#####################################################################//
      private void ViewTransactions_Load(object sender, EventArgs e)
      {
         
      }
   }
}
