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
using System.Collections;
using System.IO;

namespace ClubBudgeting.Forms {
   public partial class DashboardMember : Form {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      private ArrayList trans = new ArrayList();
      private string selectedId = null;
      Parameters pList = new Parameters();

      public DashboardMember() {
         InitializeComponent();
      }

      /// <summary>
      /// Load all essential components of form
      /// </summary>
      private void DashboardMember_Load(object sender, EventArgs e) {
         budgetInfo();

         listView_trans.FullRowSelect = true;
         ViewTransactions_Load(sender, e);
      }

      /// <summary>
      /// Close the application
      /// </summary>
      protected override void OnFormClosing(FormClosingEventArgs e) {
         Environment.Exit(0);
      }

      /// <summary>
      /// Load account and budget information
      /// </summary>
      private void budgetInfo() {
         lab1_accountName.Text = "Club Name: "
          + us.CLUB_NAME;

         lab3_budget.Text = "Budget Total: $"
          + sql.getCurrClubBalance(new Parameters(us.CLUB_ID));

         lab4_debt.Text = "Debt Total: $"
          + sql.getDebt(new Parameters(us.CLUB_ID));

      }

      /// <summary>
      /// Open the transaction window on button click
      /// </summary>
      private void but1_view_transactions_Click(object sender, EventArgs e) {
         try {
            ViewTransactions transForm = new ViewTransactions();

            transForm.StartPosition = FormStartPosition.CenterParent;
            transForm.Show(ParentForm);
         } catch {
            System.Diagnostics.Debug.WriteLine("Failed to view transactions");
         }
      }

      /// <summary>
      /// Load the data from the club onto the list
      /// </summary>
      private void ViewTransactions_Load(object sender, EventArgs e) {
         loadList(sql.getTransactions(new Parameters(us.CLUB_ID)));
      }

      /// <summary>
      /// Load the transactions for the club Id into the viewList
      /// </summary>
      private void loadList(ArrayList trans) {
         listView_trans.View = View.Details;

         listView_trans.Columns.Add("ID", 25, HorizontalAlignment.Center);
         listView_trans.Columns.Add("Purchase Date", 100);
         listView_trans.Columns.Add("Cost");
         listView_trans.Columns.Add("Description", 180);

         foreach (ArrayList dataP in trans) {
            string ID = dataP[0].ToString(),
             purDate = dataP[1].ToString().Substring(0, 9),
             cost = dataP[2].ToString(),
             desc = dataP[3].ToString();

            listView_trans.Items.Add(new ListViewItem(new[] {ID,
               purDate, cost, desc}));
         }
      }

      /// <summary>
      /// Add budget proposal
      /// </summary>
      private void button1_Click(object sender, EventArgs e) {
         OFD_budget_prop.Filter = "Excel Files | *.xlsx; *.xls; *.csv;";
         OFD_budget_prop.InitialDirectory = @"C:\Users";

         if (OFD_budget_prop.ShowDialog() == DialogResult.OK) {
            byte[] file = System.IO.File.ReadAllBytes
               (OFD_budget_prop.FileName);

            pList.addParams(us.CLUB_ID, file,
               Path.GetExtension(OFD_budget_prop.FileName));
            sql.AddBudgetProp(pList);
         }
      }

      /// <summary>
      /// Change the selectedId var when listview is updated
      /// </summary>
      private void LV_trans_SelectedIndexChanged(object sender, EventArgs e) {
         if (listView_trans.SelectedItems.Count == 0)
            return;

         selectedId = listView_trans.SelectedItems[0].SubItems[0].Text;
      }

      /// <summary>
      /// Logout of user account and exit program
      /// </summary>
      private void but6_logout_Click(object sender, EventArgs e) {
         Environment.Exit(0);
      }

      /// <summary>
      /// Upload receipt to database
      /// </summary>
      private void uploadReceipt_Click(object sender, EventArgs e) {
         OFD_budget_prop.Filter = ".pdf Files | *.pdf; *.png; *.jpg;";
         OFD_budget_prop.InitialDirectory = @"C:\Users";

         if (selectedId != null) {
            if (OFD_budget_prop.ShowDialog() == DialogResult.OK) {
               byte[] file = System.IO.File.ReadAllBytes
                  (OFD_budget_prop.FileName);

               pList.addParams(selectedId, file,
                  Path.GetExtension(OFD_budget_prop.FileName));
               sql.addPDFReceipt(pList);
            }
         } else {
            MessageBox.Show("Please select a transaction",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }
   }
}