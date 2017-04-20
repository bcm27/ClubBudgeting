using ClubBudgeting.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubBudgeting {
   public partial class Form1 : Form {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      public Form1() {
         InitializeComponent();
      }

      /// <summary>
      /// Login the user - load either the user or admin dashboard depending 
      /// on permission levels
      /// </summary>
      private void but1_login_Click(object sender, EventArgs e) {
         try {
            string check = sql.logIn(txtbx1_userName.Text, txtbx2_password.Text);
            us.LogIn(txtbx1_userName.Text, txtbx2_password.Text);

            // check user privileges - if admin, launch admin window
            if (check == "0")
               openAdminForm();
            else {
               us.CLUB_ID = check;
               openUserForm();
            }
         } catch (MySql.Data.MySqlClient.MySqlException) {
            MessageBox.Show("Incorrect username/password combination",
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      /// <summary>
      /// Open the user dashboard
      /// </summary>
      private void openUserForm() {
         this.Hide();

         DashboardMember dashboardMember = new DashboardMember();

         dashboardMember.StartPosition = FormStartPosition.CenterParent;
         dashboardMember.Show(ParentForm);
      }

      /// <summary>
      /// Open the club list form
      /// </summary>
      private void openAdminForm() {
         this.Hide();

         ClubList clubList = new ClubList();

         clubList.StartPosition = FormStartPosition.CenterParent;
         clubList.Show(ParentForm);
      }

      /// <summary>
      /// Hitting enter to login performs button click action
      /// </summary>
      private void txtbx2_password_KeyDown(object sender, KeyEventArgs e) {
         if (e.KeyCode == Keys.Enter) {
            but1_login_Click(this, new EventArgs());
         }
      }
   }
}