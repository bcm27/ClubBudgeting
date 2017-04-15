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
         this.lab2_defnum = new System.Windows.Forms.Label();
         this.lab3_budget = new System.Windows.Forms.Label();
         this.but1_view_transactions = new System.Windows.Forms.Button();
         this.but2_budget_prop = new System.Windows.Forms.Button();
         this.button1 = new System.Windows.Forms.Button();
         this.txtbx_1_budget_file_path = new System.Windows.Forms.TextBox();
         this.lab4_budget_prop_filePath = new System.Windows.Forms.Label();
         this.but6_logout = new System.Windows.Forms.Button();
         this.but4_upload_receipt = new System.Windows.Forms.Button();
         this.but5_receipt_submit = new System.Windows.Forms.Button();
         this.lab5_receipt_filePath = new System.Windows.Forms.Label();
         this.txtbx2_receipt_file_path = new System.Windows.Forms.TextBox();
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
         // lab2_defnum
         // 
         this.lab2_defnum.AutoSize = true;
         this.lab2_defnum.Location = new System.Drawing.Point(12, 31);
         this.lab2_defnum.Name = "lab2_defnum";
         this.lab2_defnum.Size = new System.Drawing.Size(118, 13);
         this.lab2_defnum.TabIndex = 1;
         this.lab2_defnum.Text = "Defund Number: 23d23";
         // 
         // lab3_budget
         // 
         this.lab3_budget.AutoSize = true;
         this.lab3_budget.Location = new System.Drawing.Point(12, 54);
         this.lab3_budget.Name = "lab3_budget";
         this.lab3_budget.Size = new System.Drawing.Size(113, 13);
         this.lab3_budget.TabIndex = 2;
         this.lab3_budget.Text = "Budget Total: $928.37";
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
         // but2_budget_prop
         // 
         this.but2_budget_prop.Location = new System.Drawing.Point(170, 110);
         this.but2_budget_prop.Name = "but2_budget_prop";
         this.but2_budget_prop.Size = new System.Drawing.Size(140, 23);
         this.but2_budget_prop.TabIndex = 4;
         this.but2_budget_prop.Text = "Budget Proposal Submit";
         this.but2_budget_prop.UseVisualStyleBackColor = true;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(170, 81);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(140, 23);
         this.button1.TabIndex = 5;
         this.button1.Text = "Upload Budget Proposal";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // txtbx_1_budget_file_path
         // 
         this.txtbx_1_budget_file_path.Enabled = false;
         this.txtbx_1_budget_file_path.Location = new System.Drawing.Point(368, 84);
         this.txtbx_1_budget_file_path.Name = "txtbx_1_budget_file_path";
         this.txtbx_1_budget_file_path.Size = new System.Drawing.Size(312, 20);
         this.txtbx_1_budget_file_path.TabIndex = 7;
         // 
         // lab4_budget_prop_filePath
         // 
         this.lab4_budget_prop_filePath.AutoSize = true;
         this.lab4_budget_prop_filePath.Location = new System.Drawing.Point(317, 87);
         this.lab4_budget_prop_filePath.Name = "lab4_budget_prop_filePath";
         this.lab4_budget_prop_filePath.Size = new System.Drawing.Size(48, 13);
         this.lab4_budget_prop_filePath.TabIndex = 8;
         this.lab4_budget_prop_filePath.Text = "File Path";
         // 
         // but6_logout
         // 
         this.but6_logout.Location = new System.Drawing.Point(15, 247);
         this.but6_logout.Name = "but6_logout";
         this.but6_logout.Size = new System.Drawing.Size(140, 23);
         this.but6_logout.TabIndex = 9;
         this.but6_logout.Text = "Logout";
         this.but6_logout.UseVisualStyleBackColor = true;
         // 
         // but4_upload_receipt
         // 
         this.but4_upload_receipt.Location = new System.Drawing.Point(167, 157);
         this.but4_upload_receipt.Name = "but4_upload_receipt";
         this.but4_upload_receipt.Size = new System.Drawing.Size(143, 23);
         this.but4_upload_receipt.TabIndex = 10;
         this.but4_upload_receipt.Text = "Upload Receipt";
         this.but4_upload_receipt.UseVisualStyleBackColor = true;
         // 
         // but5_receipt_submit
         // 
         this.but5_receipt_submit.Location = new System.Drawing.Point(167, 186);
         this.but5_receipt_submit.Name = "but5_receipt_submit";
         this.but5_receipt_submit.Size = new System.Drawing.Size(143, 23);
         this.but5_receipt_submit.TabIndex = 11;
         this.but5_receipt_submit.Text = "Submit Receipt";
         this.but5_receipt_submit.UseVisualStyleBackColor = true;
         // 
         // lab5_receipt_filePath
         // 
         this.lab5_receipt_filePath.AutoSize = true;
         this.lab5_receipt_filePath.Location = new System.Drawing.Point(317, 162);
         this.lab5_receipt_filePath.Name = "lab5_receipt_filePath";
         this.lab5_receipt_filePath.Size = new System.Drawing.Size(48, 13);
         this.lab5_receipt_filePath.TabIndex = 12;
         this.lab5_receipt_filePath.Text = "File Path";
         // 
         // txtbx2_receipt_file_path
         // 
         this.txtbx2_receipt_file_path.Enabled = false;
         this.txtbx2_receipt_file_path.Location = new System.Drawing.Point(371, 162);
         this.txtbx2_receipt_file_path.Name = "txtbx2_receipt_file_path";
         this.txtbx2_receipt_file_path.Size = new System.Drawing.Size(312, 20);
         this.txtbx2_receipt_file_path.TabIndex = 13;
         // 
         // DashboardMember
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(692, 282);
         this.Controls.Add(this.txtbx2_receipt_file_path);
         this.Controls.Add(this.lab5_receipt_filePath);
         this.Controls.Add(this.but5_receipt_submit);
         this.Controls.Add(this.but4_upload_receipt);
         this.Controls.Add(this.but6_logout);
         this.Controls.Add(this.lab4_budget_prop_filePath);
         this.Controls.Add(this.txtbx_1_budget_file_path);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.but2_budget_prop);
         this.Controls.Add(this.but1_view_transactions);
         this.Controls.Add(this.lab3_budget);
         this.Controls.Add(this.lab2_defnum);
         this.Controls.Add(this.lab1_accountName);
         this.Name = "DashboardMember";
         this.Text = "DashboardMember";
         this.Load += new System.EventHandler(this.DashboardMember_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_accountName;
      private System.Windows.Forms.Label lab2_defnum;
      private System.Windows.Forms.Label lab3_budget;
      private System.Windows.Forms.Button but1_view_transactions;
      private System.Windows.Forms.Button but2_budget_prop;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox txtbx_1_budget_file_path;
      private System.Windows.Forms.Label lab4_budget_prop_filePath;
      private System.Windows.Forms.Button but6_logout;
      private System.Windows.Forms.Button but4_upload_receipt;
      private System.Windows.Forms.Button but5_receipt_submit;
      private System.Windows.Forms.Label lab5_receipt_filePath;
      private System.Windows.Forms.TextBox txtbx2_receipt_file_path;
   }
}