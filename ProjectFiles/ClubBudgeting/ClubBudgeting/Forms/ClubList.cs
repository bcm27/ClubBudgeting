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
         DashboardAdmin adminForm = new DashboardAdmin();
         adminForm.StartPosition = FormStartPosition.CenterParent;
         adminForm.Show(ParentForm);
      }

      public ListBox listBox
      {
         get
         {
            return listBox1_clubList;
         }
      }

   }
}