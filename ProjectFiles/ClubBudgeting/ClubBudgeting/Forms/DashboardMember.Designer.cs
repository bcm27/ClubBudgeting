namespace ClubBudgeting.Forms
{
   partial class DashboardMember
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
         this.lab1_accountName = new System.Windows.Forms.Label();
         this.lab3_budget = new System.Windows.Forms.Label();
         this.but1_upload_budget_prop = new System.Windows.Forms.Button();
         this.but6_logout = new System.Windows.Forms.Button();
         this.but4_upload_receipt = new System.Windows.Forms.Button();
         this.openFileD_budget_prop = new System.Windows.Forms.OpenFileDialog();
         this.openFileD_receipt = new System.Windows.Forms.OpenFileDialog();
         this.lab4_debt = new System.Windows.Forms.Label();
         this.listView_trans = new System.Windows.Forms.ListView();
         this.but1_view_transactions = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lab1_accountName
         // 
         this.lab1_accountName.AutoSize = true;
         this.lab1_accountName.Location = new System.Drawing.Point(12, 9);
         this.lab1_accountName.Name = "lab1_accountName";
         this.lab1_accountName.Size = new System.Drawing.Size(179, 13);
         this.lab1_accountName.TabIndex = 0;
         this.lab1_accountName.Text = "Account Name: Example Club Name";
         // 
         // lab3_budget
         // 
         this.lab3_budget.AutoSize = true;
         this.lab3_budget.Location = new System.Drawing.Point(12, 32);
         this.lab3_budget.Name = "lab3_budget";
         this.lab3_budget.Size = new System.Drawing.Size(113, 13);
         this.lab3_budget.TabIndex = 2;
         this.lab3_budget.Text = "Budget Total: $928.37";
         // 
         // but1_upload_budget_prop
         // 
         this.but1_upload_budget_prop.Location = new System.Drawing.Point(15, 140);
         this.but1_upload_budget_prop.Name = "but1_upload_budget_prop";
         this.but1_upload_budget_prop.Size = new System.Drawing.Size(140, 23);
         this.but1_upload_budget_prop.TabIndex = 5;
         this.but1_upload_budget_prop.Text = "Upload Budget Proposal";
         this.but1_upload_budget_prop.UseVisualStyleBackColor = true;
         this.but1_upload_budget_prop.Click += new System.EventHandler(this.button1_Click);
         // 
         // but6_logout
         // 
         this.but6_logout.Location = new System.Drawing.Point(15, 387);
         this.but6_logout.Name = "but6_logout";
         this.but6_logout.Size = new System.Drawing.Size(140, 23);
         this.but6_logout.TabIndex = 9;
         this.but6_logout.Text = "Logout";
         this.but6_logout.UseVisualStyleBackColor = true;
         // 
         // but4_upload_receipt
         // 
         this.but4_upload_receipt.Location = new System.Drawing.Point(15, 111);
         this.but4_upload_receipt.Name = "but4_upload_receipt";
         this.but4_upload_receipt.Size = new System.Drawing.Size(140, 23);
         this.but4_upload_receipt.TabIndex = 10;
         this.but4_upload_receipt.Text = "Upload Receipt";
         this.but4_upload_receipt.UseVisualStyleBackColor = true;
         // 
         // openFileD_budget_prop
         // 
         this.openFileD_budget_prop.FileName = "openFileD_budget_prop";
         // 
         // openFileD_receipt
         // 
         this.openFileD_receipt.FileName = "openFileDialog2";
         // 
         // lab4_debt
         // 
         this.lab4_debt.AutoSize = true;
         this.lab4_debt.Location = new System.Drawing.Point(12, 55);
         this.lab4_debt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab4_debt.Name = "lab4_debt";
         this.lab4_debt.Size = new System.Drawing.Size(60, 13);
         this.lab4_debt.TabIndex = 27;
         this.lab4_debt.Text = "Total Debt:";
         // 
         // listView_trans
         // 
         this.listView_trans.Location = new System.Drawing.Point(200, 12);
         this.listView_trans.Name = "listView_trans";
         this.listView_trans.Size = new System.Drawing.Size(480, 398);
         this.listView_trans.TabIndex = 28;
         this.listView_trans.UseCompatibleStateImageBehavior = false;
         this.listView_trans.SelectedIndexChanged += new System.EventHandler(this.listView_trans_SelectedIndexChanged);
         // 
         // but1_view_transactions
         // 
         this.but1_view_transactions.Location = new System.Drawing.Point(15, 82);
         this.but1_view_transactions.Name = "but1_view_transactions";
         this.but1_view_transactions.Size = new System.Drawing.Size(140, 23);
         this.but1_view_transactions.TabIndex = 3;
         this.but1_view_transactions.Text = "View Transactions";
         this.but1_view_transactions.UseVisualStyleBackColor = true;
         this.but1_view_transactions.Click += new System.EventHandler(this.but1_view_transactions_Click);
         // 
         // DashboardMember
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(692, 423);
         this.Controls.Add(this.listView_trans);
         this.Controls.Add(this.lab4_debt);
         this.Controls.Add(this.but4_upload_receipt);
         this.Controls.Add(this.but6_logout);
         this.Controls.Add(this.but1_upload_budget_prop);
         this.Controls.Add(this.but1_view_transactions);
         this.Controls.Add(this.lab3_budget);
         this.Controls.Add(this.lab1_accountName);
         this.Name = "DashboardMember";
         this.Text = "DashboardMember";
         this.Load += new System.EventHandler(this.DashboardMember_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_accountName;
      private System.Windows.Forms.Label lab3_budget;
      private System.Windows.Forms.Button but1_upload_budget_prop;
      private System.Windows.Forms.Button but6_logout;
      private System.Windows.Forms.Button but4_upload_receipt;
      private System.Windows.Forms.OpenFileDialog openFileD_budget_prop;
      private System.Windows.Forms.OpenFileDialog openFileD_receipt;
      private System.Windows.Forms.Label lab4_debt;
      private System.Windows.Forms.ListView listView_trans;
      private System.Windows.Forms.Button but1_view_transactions;
   }
}