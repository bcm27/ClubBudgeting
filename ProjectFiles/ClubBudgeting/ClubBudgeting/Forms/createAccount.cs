using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ClubBudgeting.Forms
{
   public partial class CreateAccount : Form
   {
      private ClubList clubForm = new ClubList();
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;

      private string clubSelected;
      private bool isAdmin = false;

      public CreateAccount()
      {
         InitializeComponent();
         populateDropDown();
      }

      /// <summary>
      /// Populate the drop down menu with all the club names
      /// </summary>
      private void populateDropDown()
      {
         ArrayList clubs = sql.CLUB_LIST;         
         string[] names = new string[clubs.Count - 1];

         for (int i = 1; i < clubs.Count; i++)
            names[i - 1] = ((ArrayList)clubs[i])[1].ToString(); 

         cb_clublist.Items.AddRange(names);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void cb_clubList_index(object sender, EventArgs e)
      {
         clubSelected = 
          this.cb_clublist.GetItemText(this.cb_clublist.SelectedItem);
      }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void but1_register_Click(object sender, EventArgs e)
      {
         if (txtbx2_password.Text == txtbx3_password_check.Text
            || getId() != null)
         {
            sql.addMember(new Parameters(getId(), 0,
            txtbx1_userName.Text, txt4_firstName.Text, txtbx5_lastName.Text,
            txtbx2_password.Text));
         }
         else
         {
            MessageBox.Show("Password Error", 
               "Passwords don't match - try again", MessageBoxButtons.OK);
         }
      }

      /// <summary>
      /// Set admin rights if user is admin
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void button1_Click(object sender, EventArgs e)
      {
         if (!isAdmin)
         {
            isAdmin = true;
            lab7_admin.Text = "User is Admin";
         }
         else
         {
            isAdmin = false;
            lab7_admin.Text = "User is not Admin";
         }
      }

      /// <summary>
      /// Return the id of the currently selected club
      /// </summary>
      /// <returns>string</returns>
      public string getId()
      {
         ArrayList clubs = sql.CLUB_LIST;

         foreach (ArrayList names in clubs)
            if (cb_clublist.Text.Equals(names[1]))
               return names[1].ToString(); 

         return null;
      }
   }
}
