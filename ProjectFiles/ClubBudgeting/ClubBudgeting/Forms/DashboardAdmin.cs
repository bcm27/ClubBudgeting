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

      private ClubList clubListForm = new ClubList();

      public DashboardAdmin()
      {
         InitializeComponent();

         budgetInfo();
      }

      public void budgetInfo()
      {
         //lab_clubName.Text = sql.getAccountName(clubListForm.getClubIndex);
         //lab_num.Text = sql.getDefund(clubListForm.getClubIndex);
         //lab_budget.Text = sql.getCurrentBudget(clubListForm.getClubIndex);
      }

      private void but1_submitPurchase_Click(object sender, EventArgs e)
      {
         //sql.addTransaction();
      }

      private void but2_submitRefund_Click(object sender, EventArgs e)
      {
         //sql.addTransaction();
      }
   }
}
