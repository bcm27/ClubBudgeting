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

namespace ClubBudgeting
{
   public partial class Form1 : Form
   {
      private ClubList clubForm = new ClubList();
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      public Form1()
      {
         InitializeComponent();
      }

      //#####################################################################//
      /// <summary>
      /// logsin the user provoding they have a proper username, loads either
      /// the user form or the admin dashboard depending on permission levels
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but1_login_Click(object sender, EventArgs e)
      {
         try
         {
            string check = sql.logIn(txtbx1_userName.Text, txtbx2_password.Text);
            // check user previledges; if admin launch admin window
            if (check == "0")
               openAdminForm();
            
            else if (check.Length > 3)
            {
               us.CLUB_ID = check;
               openUserForm();
            }
            else
            {
               MessageBox.Show("Inproper username or password", "Error!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error with logging in has occurred: " +
              ex.Message,
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      } // end button login press

      private void openUserForm()
      {
         DashboardMember newForm = new DashboardMember(); // Instantiate a Form3 object.
         newForm.StartPosition = FormStartPosition.CenterParent;
         newForm.Show(ParentForm);
      } // end open user dashboard

      private void openAdminForm()
      {
         DashboardAdmin newForm = new DashboardAdmin();
         newForm.StartPosition = FormStartPosition.CenterParent;
         newForm.Show(ParentForm);
      } // end open admin dashboard

      private void but2_createAccount_Click(object sender, EventArgs e)
      {
         CreateAccount newForm = new CreateAccount();
         newForm.StartPosition = FormStartPosition.CenterParent;
         newForm.Show(ParentForm);
      }

   } // end class
}
