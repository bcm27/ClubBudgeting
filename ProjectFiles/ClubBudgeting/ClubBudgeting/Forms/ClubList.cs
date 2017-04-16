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

      private void loadClubNames()
      {
         clubNames = sql.CLUB_LIST;

         foreach (ArrayList club in clubNames)
         {
            listBox1_clubList.Items.Add(club[1]); // add club name to listbox
         }
      }

      private void but1_clubInfo_Click(object sender, EventArgs e)
      {
         clubIndex = listBox1_clubList.SelectedIndex.ToString();
         clubName = listBox1_clubList.SelectedItem.ToString();

         DashboardAdmin adminForm = new DashboardAdmin();
         adminForm.StartPosition = FormStartPosition.CenterParent;
         adminForm.Show(ParentForm);
      }

      public string getClubIndex
      {
         get
         {
            return clubIndex;
         }
      }

      public string getClubName
      {
         get
         {
            return clubName;
         }
      }

   }
}