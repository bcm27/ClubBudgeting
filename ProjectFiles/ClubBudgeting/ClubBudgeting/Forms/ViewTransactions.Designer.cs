namespace ClubBudgeting.Forms
{
   partial class ViewTransactions
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.listView_trans = new System.Windows.Forms.ListView();
         this.SuspendLayout();
         // 
         // listView_trans
         // 
         this.listView_trans.Location = new System.Drawing.Point(12, 44);
         this.listView_trans.Name = "listView_trans";
         this.listView_trans.Size = new System.Drawing.Size(480, 475);
         this.listView_trans.TabIndex = 0;
         this.listView_trans.UseCompatibleStateImageBehavior = false;
         // 
         // ViewTransactions
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(502, 531);
         this.Controls.Add(this.listView_trans);
         this.Name = "ViewTransactions";
         this.Text = "ViewTransactions";
         this.Load += new System.EventHandler(this.ViewTransactions_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListView listView_trans;
   }
}