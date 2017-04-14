using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubBudgeting.Forms
{
   public partial class DashboardAdmin : Form
   {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      public DashboardAdmin()
      {
         InitializeComponent();

         budgetInfo();
      }

      public void budgetInfo()
      {
         //lab1_acctName.Text = "Account Name: " + SQL.getAccountName(us.CLUB_ID);
         //lab2_defundNum.Text = "Defund Number: " + SQL.getDefund(us.CLUB_ID);
         //lab3_budgetTotal.Text = "Budget Total: $" + SQL.getBudget(us.CLUB_ID);
      }
   }
}
