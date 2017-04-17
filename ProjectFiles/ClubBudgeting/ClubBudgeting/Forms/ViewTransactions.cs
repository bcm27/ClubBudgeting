﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubBudgeting.Source;
using System.Collections;

namespace ClubBudgeting.Forms
{
   public partial class ViewTransactions : Form
   {
      // static instance methods so we can access this information
      private static SQL sql = SQL.Instance;
      private static User us = User.Instance;
      private ArrayList trans = new ArrayList();

      public ViewTransactions()
      {
         InitializeComponent();
      }

      /// <summary>
      /// When the form is loaded, load the data from the club onto the list
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void ViewTransactions_Load(object sender, EventArgs e)
      { loadList(sql.getTransactions(new Parameters(us.CLUB_ID))); }

      /// <summary>
      /// loads the transactions for the club Id into the viewList.
      /// </summary>
      /// <param name="trans"></param>
      private void loadList(ArrayList trans)
      {
         listView_trans.View = View.Details;

         listView_trans.Columns.Add("ID", 20, HorizontalAlignment.Center);
         listView_trans.Columns.Add("Purchase Date");
         listView_trans.Columns.Add("Cost");
         listView_trans.Columns.Add("Description");
         listView_trans.Columns.Add("Approved");

         foreach (ArrayList dataP in trans)
         {
            string ID = dataP[0].ToString(),
            purDate = dataP[1].ToString(),
            //invoice = dataP[2].ToString(),
            //fileExt = dataP[3].ToString(),
            cost = dataP[4].ToString(),
            desc = dataP[5].ToString(),
            appr = dataP[7].ToString();

            var transRow = new ListViewItem(new[] {ID,
               purDate, cost, desc, appr});

            listView_trans.Items.Add(transRow);
         }
      } // end loadList
   }
}
