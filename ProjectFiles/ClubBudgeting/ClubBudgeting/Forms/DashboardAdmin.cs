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
 
      private const int kDateLength = 10;  // length of the date string
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
         lab_budget.Text = 
            sql.getCurrClubBudg(new Parameters(clubListForm.getClubIndex));
      }

      /// <summary>
      /// Add a transaction
      /// </summary>
      private void but1_submitTransaction_Click(object sender, EventArgs e)
      {
         double parsedVal;

         // transaction amount must be double and date must be formatted right
         if (txtbx2_date.Text.ToString().Length == kDateLength &&
          double.TryParse(txtbx1_transAmt.Text, out parsedVal))
         {
            sql.addTransaction(new Parameters(txtbx2_date.Text, null, null,
             txtbx1_transAmt.Text, null, clubListForm.getClubIndex));
            lab_transStatus.Text = "Successfully added";
         }
         else
         {
            lab_transStatus.Text = "Failure to add";
            throw new Exception("Unable to add transaction - fix formatting");
         }
      }

      /// <summary>
      /// Add a club
      /// </summary>
      private void but_addClub_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrEmpty(txtbx_clubDesc.Text) && 
          !string.IsNullOrEmpty(txtbx_clubName.Text))
         {
            sql.addClub(new Parameters(null, txtbx_clubName.Text,
             txtbx_clubDesc.Text));
            lab_clubStatus.Text = "Successfully added";
         }
         else
         {
            lab_transStatus.Text = "Failure to add";
            throw new Exception("Unable to add club");
         }
      }
   }
}
