using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubBudgeting.Forms {
   public partial class ClubList : Form {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      private static ArrayList clubNames = new ArrayList();
      private static string clubName;
      private static string clubIndex;

      public ClubList() {
         InitializeComponent();

         loadClubNames();
      }

      /// <summary>
      /// Load all of the club names into the listbox from the database
      /// </summary>
      private void loadClubNames() {
         listBox1_clubList.Items.Clear();
         clubNames = sql.CLUB_LIST;

         foreach (ArrayList club in clubNames) {
            listBox1_clubList.Items.Add(club[1]);
         }
      }

      /// <summary>
      /// Save the selected club's info and create new admin dashboard form
      /// </summary>
      private void but1_clubInfo_Click(object sender, EventArgs e) {
         try {
            clubIndex = (listBox1_clubList.SelectedIndex + 1).ToString();
            clubName = listBox1_clubList.SelectedItem.ToString();

            DashboardAdmin adminForm = new DashboardAdmin();
            adminForm.StartPosition = FormStartPosition.CenterParent;
            adminForm.Show(ParentForm);
         } catch {
            MessageBox.Show("Error: please select a club");
         }
      }

      /// <summary>
      /// Get function for club index
      /// </summary>
      public string getClubIndex {
         get {
            return clubIndex;
         }
      }

      /// <summary>
      /// Get function for club name
      /// </summary>
      public string getClubName {
         get {
            return clubName;
         }
      }

      /// <summary>
      /// Open add club form
      /// </summary>
      private void but_addClub_Click(object sender, EventArgs e) {
         try {
            AddClub newForm = new AddClub();
 
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.Show(ParentForm);
         } catch {
            MessageBox.Show("Error: could not open Add Club form");
         }
      }

      /// <summary>
      /// Refresh club list to load newly added clubs
      /// </summary>
      private void but_refresh_Click(object sender, EventArgs e) {
         sql.fillClubArray();
         loadClubNames();
      }

      /// <summary>
      /// Terminate program when club list form is closed
      /// </summary>
      protected override void OnFormClosing(FormClosingEventArgs e) {
         Environment.Exit(1);
      }

      /// <summary>
      /// Get a budget proposal and upload to the database
      /// </summary>
      private void but_getBudgProp_Click(object sender, EventArgs e) {
         try {
            sql.getBudgetProp(new Parameters
             ((listBox1_clubList.SelectedIndex + 1).ToString()));
         } catch {
            MessageBox.Show("Error: could not get budget proposal");
         }
      }

      /// <summary>
      /// Exit form (and program)
      /// </summary>
      private void but_exit_Click(object sender, EventArgs e) {
         System.Environment.Exit(1);
      }
   }
}