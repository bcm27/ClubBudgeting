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
          sql.getCurrClubBalance(new Parameters(clubListForm.getClubIndex));
         lab_totalDebt.Text = 
          sql.getDebt(new Parameters(clubListForm.getClubIndex));
      }

      /// <summary>
      /// Add and approve transaction - transaction amount must be a number 
      /// and the date must be the proper number of characters (10)
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but1_submitTransaction_Click(object sender, EventArgs e)
      {
         double parsedVal;
         Boolean didAdd;

         try
         {
            // add transaction and update labels
            if (double.TryParse(txtbx1_transAmt.Text, out parsedVal) &&
             txtbx2_date.Text.ToString().Length == kDateLength)
            {
               didAdd = sql.addTransaction(new Parameters(txtbx2_date.Text, 
                  txtbx1_transAmt.Text, null, clubListForm.getClubIndex));
               lab_budget.Text = sql.getCurrClubBalance
                (new Parameters(clubListForm.getClubIndex));
               lab_totalDebt.Text =
                sql.getDebt(new Parameters(clubListForm.getClubIndex));

               if (didAdd)
                  lab_transStatus.Text = "Success";
               else
                  MessageBox.Show("Error: invalid transaction");
            }
            else
               throw new Exception();
         }
         catch
         {
            lab_transStatus.Text = "Failed";
            MessageBox.Show("Error: could not add transaction -" 
             + " check date formatting");
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
            us.CLUB_ID = clubListForm.getClubIndex;
            ViewTransactions transactionsForm = new ViewTransactions();
            transactionsForm.StartPosition = FormStartPosition.CenterParent;
            transactionsForm.Show(ParentForm);
         }
         catch
         {
            MessageBox.Show("Error: could not show transactions form");
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {       
         CreateAccount createAccount = new CreateAccount();
         createAccount.StartPosition = FormStartPosition.CenterParent;
         createAccount.Show(ParentForm);
         
      }
   }
}