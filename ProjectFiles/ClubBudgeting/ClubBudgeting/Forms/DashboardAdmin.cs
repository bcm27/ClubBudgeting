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

      /// <summary>
      /// Load and display the budget info for the selected club
      /// </summary>
      public void budgetInfo()
      {
         lab_clubName.Text = clubListForm.getClubName;
         lab_budget.Text = sql.getCurrClubBudg(new Parameters(clubListForm.getClubIndex));
      }

      /// <summary>
      /// Add a purchase transaction
      /// </summary>
      private void but1_submitPurchase_Click(object sender, EventArgs e)
      {
         sql.addTransaction(new Parameters(clubListForm.getClubIndex));
      }

      /// <summary>
      /// Add a refund transaction
      /// </summary>
      private void but2_submitRefund_Click(object sender, EventArgs e)
      {
         sql.addTransaction(new Parameters(clubListForm.getClubIndex));
      }
   }
}
