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

      public CreateAccount()
      {
         InitializeComponent();
      }

      private void populateDropDown()
      {
         ArrayList clubNames = new ArrayList();
         clubNames = sql.CLUB_LIST;
         comboBox_clublist.Items.AddRange(clubNames.ToArray());

      }// end populateDropDown

      private void comboBox_clublist_SelectedIndexChanged(object sender, EventArgs e)
      {
         clubSelected = this.comboBox_clublist.GetItemText(this.comboBox_clublist.SelectedItem);
      }

      private void but1_register_Click(object sender, EventArgs e)
      {
         //sql.addMember(new Parameters("",));

         //{ "@club", "@admin", "@user", "@first",
         //"@last", "@pass" };
   }
   }
}
