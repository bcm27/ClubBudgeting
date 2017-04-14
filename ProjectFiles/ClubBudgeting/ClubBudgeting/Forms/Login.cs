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
         // check user previledges if admin launch admin window

         // do this or
         DashboardMember newForm = new DashboardMember(); // Instantiate a Form3 object.
         newForm.StartPosition = FormStartPosition.CenterParent;
         newForm.Show(ParentForm);
      }
   }
}
