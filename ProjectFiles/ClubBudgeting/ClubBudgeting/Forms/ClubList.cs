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

namespace ClubBudgeting.Forms
{
   public partial class ClubList : Form
   {
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;
      
      private static ArrayList clubNames = new ArrayList();
      private static string clubName;
      private static string clubIndex;

      public ClubList()
      {
         InitializeComponent();

         loadClubNames();
      }

      /// <summary>
      /// Load club names into the listbox
      /// </summary>
      private void loadClubNames()
      {
         clubNames = sql.CLUB_LIST;

         foreach (ArrayList club in clubNames)
         {
            listBox1_clubList.Items.Add(club[1]); // add club name to listbox
         }
      }

      /// <summary>
      /// Save the selected club's info and create new admin form
      /// </summary>
      private void but1_clubInfo_Click(object sender, EventArgs e)
      {
<<<<<<< HEAD
         clubIndex = (listBox1_clubList.SelectedIndex + 1).ToString();
         clubName = listBox1_clubList.SelectedItem.ToString();

         DashboardAdmin adminForm = new DashboardAdmin();
         adminForm.StartPosition = FormStartPosition.CenterParent;
         adminForm.Show(ParentForm);
=======
         try
         {
            clubIndex = (listBox1_clubList.SelectedIndex + 1).ToString();
            clubName = listBox1_clubList.SelectedItem.ToString();

            DashboardAdmin adminForm = new DashboardAdmin();
            adminForm.StartPosition = FormStartPosition.CenterParent;
            adminForm.Show(ParentForm);
         }
         catch
         {
            MessageBox.Show("Error: please select a club");
         }
>>>>>>> bcaf68c6596f8d0d013f4b91371514ab8737c303
      }

      /// <summary>
      /// Get function for club index
      /// </summary>
      public string getClubIndex
      {
         get
         {
            return clubIndex;
         }
      }

      /// <summary>
      /// Get function for club name
      /// </summary>
      public string getClubName
      {
         get
         {
            return clubName;
         }
      }

   }
}