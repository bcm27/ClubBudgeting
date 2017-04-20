using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubBudgeting.Forms;

namespace ClubBudgeting.Forms
{
   public partial class DashboardMember : Form
   {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      public DashboardMember()
      {
         InitializeComponent();
      }


      //#####################################################################//
      /// <summary>
      /// loads all essential components
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void DashboardMember_Load(object sender, EventArgs e)
      { loadData(); }


      //#####################################################################//
      /// <summary>
      /// loads budgetInfo(),
      /// </summary>
      private void loadData()
      {
         budgetInfo();
      }

      //#####################################################################//
      /// <summary>
      /// load account and budget information
      /// </summary>
      private void budgetInfo()
      {
         lab1_accountName.Text = "Club Name: " 
          + sql.getClubName(new Parameters(us.CLUB_ID));

         lab3_budget.Text = "Budget Total: $"
          + sql.getCurrClubBudg(new Parameters(us.CLUB_ID));

         lab4_debt.Text = "Debt Total: $" 
          + sql.getDebt(new Parameters(us.CLUB_ID));

      }

      //#####################################################################//
      /// <summary>
      /// opens the transaction window when the button is clicked
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but1_view_transactions_Click(object sender, EventArgs e)
      {
         try
         {
            ViewTransactions newForm = new ViewTransactions(); // Instantiate a Form3 object.
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.Show(ParentForm);
         }
         catch
         {
            System.Diagnostics.Debug.WriteLine("Failed to view transactions");
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         openFileD_budget_prop.Filter = ".pdf Files | *.pdf;";
         openFileD_budget_prop.InitialDirectory = @"C:\Users";

         if (openFileD_budget_prop.ShowDialog() == DialogResult.OK)
         {
            string SOURCE_FILE = openFileD_budget_prop.SafeFileName;
            string SOURCE_DIR = openFileD_budget_prop.InitialDirectory;
         }
      }
   }
}
