namespace ClubBudgeting.Forms
{
   partial class DashboardAdmin
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
         this.lab1_acctName = new System.Windows.Forms.Label();
         this.lab3_budgetTotal = new System.Windows.Forms.Label();
         this.lab4_purchaseAmt = new System.Windows.Forms.Label();
         this.lab5_refundAmt = new System.Windows.Forms.Label();
         this.txtbx1_purchaseAmt = new System.Windows.Forms.TextBox();
         this.but1_submitPurchase = new System.Windows.Forms.Button();
         this.but2_submitRefund = new System.Windows.Forms.Button();
         this.txtbx2_refundAmt = new System.Windows.Forms.TextBox();
         this.but3_logout = new System.Windows.Forms.Button();
         this.lab_clubName = new System.Windows.Forms.Label();
         this.lab_budget = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lab1_acctName
         // 
         this.lab1_acctName.AutoSize = true;
         this.lab1_acctName.Location = new System.Drawing.Point(39, 41);
         this.lab1_acctName.Name = "lab1_acctName";
         this.lab1_acctName.Size = new System.Drawing.Size(158, 25);
         this.lab1_acctName.TabIndex = 0;
         this.lab1_acctName.Text = "Account Name:";
         // 
         // lab3_budgetTotal
         // 
         this.lab3_budgetTotal.AutoSize = true;
         this.lab3_budgetTotal.Location = new System.Drawing.Point(39, 95);
         this.lab3_budgetTotal.Name = "lab3_budgetTotal";
         this.lab3_budgetTotal.Size = new System.Drawing.Size(140, 25);
         this.lab3_budgetTotal.TabIndex = 2;
         this.lab3_budgetTotal.Text = "Budget Total:";
         // 
         // lab4_purchaseAmt
         // 
         this.lab4_purchaseAmt.AutoSize = true;
         this.lab4_purchaseAmt.Location = new System.Drawing.Point(39, 175);
         this.lab4_purchaseAmt.Name = "lab4_purchaseAmt";
         this.lab4_purchaseAmt.Size = new System.Drawing.Size(259, 25);
         this.lab4_purchaseAmt.TabIndex = 3;
         this.lab4_purchaseAmt.Text = "Enter a purchase amount:";
         // 
         // lab5_refundAmt
         // 
         this.lab5_refundAmt.AutoSize = true;
         this.lab5_refundAmt.Location = new System.Drawing.Point(39, 245);
         this.lab5_refundAmt.Name = "lab5_refundAmt";
         this.lab5_refundAmt.Size = new System.Drawing.Size(231, 25);
         this.lab5_refundAmt.TabIndex = 4;
         this.lab5_refundAmt.Text = "Enter a refund amount:";
         // 
         // txtbx1_purchaseAmt
         // 
         this.txtbx1_purchaseAmt.Location = new System.Drawing.Point(319, 172);
         this.txtbx1_purchaseAmt.Name = "txtbx1_purchaseAmt";
         this.txtbx1_purchaseAmt.Size = new System.Drawing.Size(192, 31);
         this.txtbx1_purchaseAmt.TabIndex = 6;
         // 
         // but1_submitPurchase
         // 
         this.but1_submitPurchase.Location = new System.Drawing.Point(571, 172);
         this.but1_submitPurchase.Name = "but1_submitPurchase";
         this.but1_submitPurchase.Size = new System.Drawing.Size(191, 31);
         this.but1_submitPurchase.TabIndex = 7;
         this.but1_submitPurchase.Text = "Submit purchase";
         this.but1_submitPurchase.UseVisualStyleBackColor = true;
         this.but1_submitPurchase.Click += new System.EventHandler(this.but1_submitPurchase_Click);
         // 
         // but2_submitRefund
         // 
         this.but2_submitRefund.Location = new System.Drawing.Point(571, 245);
         this.but2_submitRefund.Name = "but2_submitRefund";
         this.but2_submitRefund.Size = new System.Drawing.Size(191, 31);
         this.but2_submitRefund.TabIndex = 9;
         this.but2_submitRefund.Text = "Submit refund";
         this.but2_submitRefund.UseVisualStyleBackColor = true;
         this.but2_submitRefund.Click += new System.EventHandler(this.but2_submitRefund_Click);
         // 
         // txtbx2_refundAmt
         // 
         this.txtbx2_refundAmt.Location = new System.Drawing.Point(319, 245);
         this.txtbx2_refundAmt.Name = "txtbx2_refundAmt";
         this.txtbx2_refundAmt.Size = new System.Drawing.Size(192, 31);
         this.txtbx2_refundAmt.TabIndex = 8;
         // 
         // but3_logout
         // 
         this.but3_logout.Location = new System.Drawing.Point(44, 357);
         this.but3_logout.Name = "but3_logout";
         this.but3_logout.Size = new System.Drawing.Size(209, 48);
         this.but3_logout.TabIndex = 10;
         this.but3_logout.Text = "Logout";
         this.but3_logout.UseVisualStyleBackColor = true;
         // 
         // lab_clubName
         // 
         this.lab_clubName.AutoSize = true;
         this.lab_clubName.Location = new System.Drawing.Point(203, 41);
         this.lab_clubName.Name = "lab_clubName";
         this.lab_clubName.Size = new System.Drawing.Size(115, 25);
         this.lab_clubName.TabIndex = 11;
         this.lab_clubName.Text = "Club name";
         // 
         // lab_budget
         // 
         this.lab_budget.AutoSize = true;
         this.lab_budget.Location = new System.Drawing.Point(185, 95);
         this.lab_budget.Name = "lab_budget";
         this.lab_budget.Size = new System.Drawing.Size(78, 25);
         this.lab_budget.TabIndex = 13;
         this.lab_budget.Text = "budget";
         // 
         // DashboardAdmin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(864, 435);
         this.Controls.Add(this.lab_budget);
         this.Controls.Add(this.lab_clubName);
         this.Controls.Add(this.but3_logout);
         this.Controls.Add(this.but2_submitRefund);
         this.Controls.Add(this.txtbx2_refundAmt);
         this.Controls.Add(this.but1_submitPurchase);
         this.Controls.Add(this.txtbx1_purchaseAmt);
         this.Controls.Add(this.lab5_refundAmt);
         this.Controls.Add(this.lab4_purchaseAmt);
         this.Controls.Add(this.lab3_budgetTotal);
         this.Controls.Add(this.lab1_acctName);
         this.Name = "DashboardAdmin";
         this.Text = "Dashboard Admin";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_acctName;
      private System.Windows.Forms.Label lab3_budgetTotal;
      private System.Windows.Forms.Label lab4_purchaseAmt;
      private System.Windows.Forms.Label lab5_refundAmt;
      private System.Windows.Forms.TextBox txtbx1_purchaseAmt;
      private System.Windows.Forms.Button but1_submitPurchase;
      private System.Windows.Forms.Button but2_submitRefund;
      private System.Windows.Forms.TextBox txtbx2_refundAmt;
      private System.Windows.Forms.Button but3_logout;
      private System.Windows.Forms.Label lab_clubName;
      private System.Windows.Forms.Label lab_budget;
   }
}