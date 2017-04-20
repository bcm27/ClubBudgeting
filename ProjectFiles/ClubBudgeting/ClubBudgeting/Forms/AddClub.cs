using System;
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
   public partial class AddClub : Form
   {
      private static SQL sql = SQL.Instance;

      public AddClub()
      {
         InitializeComponent();
      }

      private void but_addClub_Click(object sender, EventArgs e)
      {
         try
         {
            if (!string.IsNullOrEmpty(txtbx_clubDesc.Text) &&
             !string.IsNullOrEmpty(txtbx_clubName.Text))
            {
               sql.addClub(new Parameters(txtbx_clubName.Text,
                txtbx_clubDesc.Text));
               lab_clubStatus.Text = "Successfully added";
            }
            else
               throw new Exception();
         }
         catch
         {
            lab_clubStatus.Text = "Failed";
            MessageBox.Show("Error: could not add club - make sure"
             + " club name and description are not blank");
         }
      }
   }
}
