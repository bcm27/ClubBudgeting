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
         lab_totalDebt.Text = 
          sql.getDebt(new Parameters(clubListForm.getClubIndex));
      }

      /// <summary>
      /// Add transaction - transaction amount must be a number and the date
      /// must be the proper number of characters (10)
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but1_submitTransaction_Click(object sender, EventArgs e)
      {
         double parsedVal;

         try
         {
            if (double.TryParse(txtbx1_transAmt.Text, out parsedVal) &&
             txtbx2_date.Text.ToString().Length == kDateLength)
            {
               sql.addTransaction(new Parameters(txtbx2_date.Text, null, null,
                txtbx1_transAmt.Text, null, clubListForm.getClubIndex));
               lab_transStatus.Text = "Successfully added";
            }
            else
               throw new Exception();
         }
         catch
         {
            lab_transStatus.Text = "Failed";
            MessageBox.Show("Error: could not add transaction - " 
             + "check budget and date formatting");
         }
         
      }

      /// <summary>
      /// Add club - club must have both a name and description to get added
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but_addClub_Click(object sender, EventArgs e)
      {
         try
         {
            if (!string.IsNullOrEmpty(txtbx_clubDesc.Text) &&
             !string.IsNullOrEmpty(txtbx_clubName.Text))
            {
               sql.addClub(new Parameters(txtbx_clubName.Text,
                txtbx_clubDesc.Text));
               lab_clubStatus.Text = "Successfully added";
            }
            else
               throw new Exception();
         }
         catch 
         {
            lab_transStatus.Text = "Failed";
            MessageBox.Show("Error: could not add club - make sure"
             + " club name and description are not blank");
         }
      }

      /// <summary>
      /// View transactions - pull up transactions window
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but_viewTransactions_Click(object sender, EventArgs e)
      {
         try
         {
            ViewTransactions transactionsForm = new ViewTransactions();
            transactionsForm.StartPosition = FormStartPosition.CenterParent;
            transactionsForm.Show(ParentForm);
         }
         catch
         {
            MessageBox.Show("Error: could not show transactions");
         }
      }
   }
}
