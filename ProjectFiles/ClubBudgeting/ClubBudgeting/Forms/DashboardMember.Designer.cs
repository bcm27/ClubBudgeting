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
         this.UploadBudgProp = new System.Windows.Forms.Button();
         this.but6_logout = new System.Windows.Forms.Button();
         this.uploadReceipt = new System.Windows.Forms.Button();
         this.OFD_budget_prop = new System.Windows.Forms.OpenFileDialog();
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
         // UploadBudgProp
         // 
         this.UploadBudgProp.Location = new System.Drawing.Point(15, 110);
         this.UploadBudgProp.Name = "UploadBudgProp";
         this.UploadBudgProp.Size = new System.Drawing.Size(140, 23);
         this.UploadBudgProp.TabIndex = 5;
         this.UploadBudgProp.Text = "Upload Budget Proposal";
         this.UploadBudgProp.UseVisualStyleBackColor = true;
         this.UploadBudgProp.Click += new System.EventHandler(this.button1_Click);
         // 
         // but6_logout
         // 
         this.but6_logout.Location = new System.Drawing.Point(15, 387);
         this.but6_logout.Name = "but6_logout";
         this.but6_logout.Size = new System.Drawing.Size(140, 23);
         this.but6_logout.TabIndex = 9;
         this.but6_logout.Text = "Logout";
         this.but6_logout.UseVisualStyleBackColor = true;
         this.but6_logout.Click += new System.EventHandler(this.but6_logout_Click);
         // 
         // uploadReceipt
         // 
         this.uploadReceipt.AutoEllipsis = true;
         this.uploadReceipt.Location = new System.Drawing.Point(15, 81);
         this.uploadReceipt.Name = "uploadReceipt";
         this.uploadReceipt.Size = new System.Drawing.Size(140, 23);
         this.uploadReceipt.TabIndex = 10;
         this.uploadReceipt.Text = "Upload Receipt";
         this.uploadReceipt.UseVisualStyleBackColor = true;
         this.uploadReceipt.Click += new System.EventHandler(this.uploadReceipt_Click);
         // 
         // OFD_budget_prop
         // 
         this.OFD_budget_prop.FileName = "openFileD_budget_prop";
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
         this.listView_trans.SelectedIndexChanged += new System.EventHandler(this.LV_trans_SelectedIndexChanged);
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
         this.Controls.Add(this.uploadReceipt);
         this.Controls.Add(this.but6_logout);
         this.Controls.Add(this.UploadBudgProp);
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
      private System.Windows.Forms.Button UploadBudgProp;
      private System.Windows.Forms.Button but6_logout;
      private System.Windows.Forms.Button uploadReceipt;
      private System.Windows.Forms.OpenFileDialog OFD_budget_prop;
      private System.Windows.Forms.OpenFileDialog openFileD_receipt;
      private System.Windows.Forms.Label lab4_debt;
      private System.Windows.Forms.ListView listView_trans;
      private System.Windows.Forms.Button but1_view_transactions;
   }
}