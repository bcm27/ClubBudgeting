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
         this.but1_view_transactions = new System.Windows.Forms.Button();
         this.but2_budget_prop_submit = new System.Windows.Forms.Button();
         this.but1_upload_budget_prop = new System.Windows.Forms.Button();
         this.txtbx_1_budget_file_path = new System.Windows.Forms.TextBox();
         this.lab4_budget_prop_filePath = new System.Windows.Forms.Label();
         this.but6_logout = new System.Windows.Forms.Button();
         this.but4_upload_receipt = new System.Windows.Forms.Button();
         this.but5_receipt_submit = new System.Windows.Forms.Button();
         this.lab5_receipt_filePath = new System.Windows.Forms.Label();
         this.txtbx2_receipt_file_path = new System.Windows.Forms.TextBox();
         this.openFileD_budget_prop = new System.Windows.Forms.OpenFileDialog();
         this.openFileD_receipt = new System.Windows.Forms.OpenFileDialog();
         this.lab4_debt = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lab1_accountName
         // 
         this.lab1_accountName.AutoSize = true;
         this.lab1_accountName.Location = new System.Drawing.Point(24, 17);
         this.lab1_accountName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.lab1_accountName.Name = "lab1_accountName";
         this.lab1_accountName.Size = new System.Drawing.Size(359, 25);
         this.lab1_accountName.TabIndex = 0;
         this.lab1_accountName.Text = "Account Name: Example Club Name";
         // 
         // lab3_budget
         // 
         this.lab3_budget.AutoSize = true;
         this.lab3_budget.Location = new System.Drawing.Point(24, 62);
         this.lab3_budget.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.lab3_budget.Name = "lab3_budget";
         this.lab3_budget.Size = new System.Drawing.Size(224, 25);
         this.lab3_budget.TabIndex = 2;
         this.lab3_budget.Text = "Budget Total: $928.37";
         // 
         // but1_view_transactions
         // 
         this.but1_view_transactions.Location = new System.Drawing.Point(30, 158);
         this.but1_view_transactions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.but1_view_transactions.Name = "but1_view_transactions";
         this.but1_view_transactions.Size = new System.Drawing.Size(280, 44);
         this.but1_view_transactions.TabIndex = 3;
         this.but1_view_transactions.Text = "View Transactions";
         this.but1_view_transactions.UseVisualStyleBackColor = true;
         this.but1_view_transactions.Click += new System.EventHandler(this.but1_view_transactions_Click);
         // 
         // but2_budget_prop_submit
         // 
         this.but2_budget_prop_submit.Location = new System.Drawing.Point(340, 212);
         this.but2_budget_prop_submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.but2_budget_prop_submit.Name = "but2_budget_prop_submit";
         this.but2_budget_prop_submit.Size = new System.Drawing.Size(280, 44);
         this.but2_budget_prop_submit.TabIndex = 4;
         this.but2_budget_prop_submit.Text = "Budget Proposal Submit";
         this.but2_budget_prop_submit.UseVisualStyleBackColor = true;
         // 
         // but1_upload_budget_prop
         // 
         this.but1_upload_budget_prop.Location = new System.Drawing.Point(340, 156);
         this.but1_upload_budget_prop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.but1_upload_budget_prop.Name = "but1_upload_budget_prop";
         this.but1_upload_budget_prop.Size = new System.Drawing.Size(280, 44);
         this.but1_upload_budget_prop.TabIndex = 5;
         this.but1_upload_budget_prop.Text = "Upload Budget Proposal";
         this.but1_upload_budget_prop.UseVisualStyleBackColor = true;
         this.but1_upload_budget_prop.Click += new System.EventHandler(this.button1_Click);
         // 
         // txtbx_1_budget_file_path
         // 
         this.txtbx_1_budget_file_path.Enabled = false;
         this.txtbx_1_budget_file_path.Location = new System.Drawing.Point(736, 162);
         this.txtbx_1_budget_file_path.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.txtbx_1_budget_file_path.Name = "txtbx_1_budget_file_path";
         this.txtbx_1_budget_file_path.Size = new System.Drawing.Size(620, 31);
         this.txtbx_1_budget_file_path.TabIndex = 7;
         // 
         // lab4_budget_prop_filePath
         // 
         this.lab4_budget_prop_filePath.AutoSize = true;
         this.lab4_budget_prop_filePath.Location = new System.Drawing.Point(634, 167);
         this.lab4_budget_prop_filePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.lab4_budget_prop_filePath.Name = "lab4_budget_prop_filePath";
         this.lab4_budget_prop_filePath.Size = new System.Drawing.Size(97, 25);
         this.lab4_budget_prop_filePath.TabIndex = 8;
         this.lab4_budget_prop_filePath.Text = "File Path";
         // 
         // but6_logout
         // 
         this.but6_logout.Location = new System.Drawing.Point(30, 475);
         this.but6_logout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.but6_logout.Name = "but6_logout";
         this.but6_logout.Size = new System.Drawing.Size(280, 44);
         this.but6_logout.TabIndex = 9;
         this.but6_logout.Text = "Logout";
         this.but6_logout.UseVisualStyleBackColor = true;
         // 
         // but4_upload_receipt
         // 
         this.but4_upload_receipt.Location = new System.Drawing.Point(334, 302);
         this.but4_upload_receipt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.but4_upload_receipt.Name = "but4_upload_receipt";
         this.but4_upload_receipt.Size = new System.Drawing.Size(286, 44);
         this.but4_upload_receipt.TabIndex = 10;
         this.but4_upload_receipt.Text = "Upload Receipt";
         this.but4_upload_receipt.UseVisualStyleBackColor = true;
         // 
         // but5_receipt_submit
         // 
         this.but5_receipt_submit.Location = new System.Drawing.Point(334, 358);
         this.but5_receipt_submit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.but5_receipt_submit.Name = "but5_receipt_submit";
         this.but5_receipt_submit.Size = new System.Drawing.Size(286, 44);
         this.but5_receipt_submit.TabIndex = 11;
         this.but5_receipt_submit.Text = "Submit Receipt";
         this.but5_receipt_submit.UseVisualStyleBackColor = true;
         // 
         // lab5_receipt_filePath
         // 
         this.lab5_receipt_filePath.AutoSize = true;
         this.lab5_receipt_filePath.Location = new System.Drawing.Point(634, 312);
         this.lab5_receipt_filePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.lab5_receipt_filePath.Name = "lab5_receipt_filePath";
         this.lab5_receipt_filePath.Size = new System.Drawing.Size(97, 25);
         this.lab5_receipt_filePath.TabIndex = 12;
         this.lab5_receipt_filePath.Text = "File Path";
         // 
         // txtbx2_receipt_file_path
         // 
         this.txtbx2_receipt_file_path.Enabled = false;
         this.txtbx2_receipt_file_path.Location = new System.Drawing.Point(742, 312);
         this.txtbx2_receipt_file_path.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.txtbx2_receipt_file_path.Name = "txtbx2_receipt_file_path";
         this.txtbx2_receipt_file_path.Size = new System.Drawing.Size(620, 31);
         this.txtbx2_receipt_file_path.TabIndex = 13;
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
         this.lab4_debt.Location = new System.Drawing.Point(25, 105);
         this.lab4_debt.Name = "lab4_debt";
         this.lab4_debt.Size = new System.Drawing.Size(117, 25);
         this.lab4_debt.TabIndex = 27;
         this.lab4_debt.Text = "Total Debt:";
         // 
         // DashboardMember
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1384, 542);
         this.Controls.Add(this.lab4_debt);
         this.Controls.Add(this.txtbx2_receipt_file_path);
         this.Controls.Add(this.lab5_receipt_filePath);
         this.Controls.Add(this.but5_receipt_submit);
         this.Controls.Add(this.but4_upload_receipt);
         this.Controls.Add(this.but6_logout);
         this.Controls.Add(this.lab4_budget_prop_filePath);
         this.Controls.Add(this.txtbx_1_budget_file_path);
         this.Controls.Add(this.but1_upload_budget_prop);
         this.Controls.Add(this.but2_budget_prop_submit);
         this.Controls.Add(this.but1_view_transactions);
         this.Controls.Add(this.lab3_budget);
         this.Controls.Add(this.lab1_accountName);
         this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
         this.Name = "DashboardMember";
         this.Text = "DashboardMember";
         this.Load += new System.EventHandler(this.DashboardMember_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_accountName;
      private System.Windows.Forms.Label lab3_budget;
      private System.Windows.Forms.Button but1_view_transactions;
      private System.Windows.Forms.Button but2_budget_prop_submit;
      private System.Windows.Forms.Button but1_upload_budget_prop;
      private System.Windows.Forms.TextBox txtbx_1_budget_file_path;
      private System.Windows.Forms.Label lab4_budget_prop_filePath;
      private System.Windows.Forms.Button but6_logout;
      private System.Windows.Forms.Button but4_upload_receipt;
      private System.Windows.Forms.Button but5_receipt_submit;
      private System.Windows.Forms.Label lab5_receipt_filePath;
      private System.Windows.Forms.TextBox txtbx2_receipt_file_path;
      private System.Windows.Forms.OpenFileDialog openFileD_budget_prop;
      private System.Windows.Forms.OpenFileDialog openFileD_receipt;
      private System.Windows.Forms.Label lab4_debt;
   }
}