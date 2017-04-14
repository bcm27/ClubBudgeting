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
         this.lab2_defundNum = new System.Windows.Forms.Label();
         this.lab3_budgetTotal = new System.Windows.Forms.Label();
         this.lab4_purchaseAmt = new System.Windows.Forms.Label();
         this.lab5_refundAmt = new System.Windows.Forms.Label();
         this.txtbx1_purchaseAmt = new System.Windows.Forms.TextBox();
         this.but1_submitPurchase = new System.Windows.Forms.Button();
         this.but2_submitRefund = new System.Windows.Forms.Button();
         this.txtbx2_refundAmt = new System.Windows.Forms.TextBox();
         this.but3_logout = new System.Windows.Forms.Button();
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
         // lab2_defundNum
         // 
         this.lab2_defundNum.AutoSize = true;
         this.lab2_defundNum.Location = new System.Drawing.Point(39, 91);
         this.lab2_defundNum.Name = "lab2_defundNum";
         this.lab2_defundNum.Size = new System.Drawing.Size(168, 25);
         this.lab2_defundNum.TabIndex = 1;
         this.lab2_defundNum.Text = "Defund Number:";
         // 
         // lab3_budgetTotal
         // 
         this.lab3_budgetTotal.AutoSize = true;
         this.lab3_budgetTotal.Location = new System.Drawing.Point(39, 139);
         this.lab3_budgetTotal.Name = "lab3_budgetTotal";
         this.lab3_budgetTotal.Size = new System.Drawing.Size(140, 25);
         this.lab3_budgetTotal.TabIndex = 2;
         this.lab3_budgetTotal.Text = "Budget Total:";
         // 
         // lab4_purchaseAmt
         // 
         this.lab4_purchaseAmt.AutoSize = true;
         this.lab4_purchaseAmt.Location = new System.Drawing.Point(39, 219);
         this.lab4_purchaseAmt.Name = "lab4_purchaseAmt";
         this.lab4_purchaseAmt.Size = new System.Drawing.Size(259, 25);
         this.lab4_purchaseAmt.TabIndex = 3;
         this.lab4_purchaseAmt.Text = "Enter a purchase amount:";
         // 
         // lab5_refundAmt
         // 
         this.lab5_refundAmt.AutoSize = true;
         this.lab5_refundAmt.Location = new System.Drawing.Point(39, 289);
         this.lab5_refundAmt.Name = "lab5_refundAmt";
         this.lab5_refundAmt.Size = new System.Drawing.Size(231, 25);
         this.lab5_refundAmt.TabIndex = 4;
         this.lab5_refundAmt.Text = "Enter a refund amount:";
         // 
         // txtbx1_purchaseAmt
         // 
         this.txtbx1_purchaseAmt.Location = new System.Drawing.Point(319, 216);
         this.txtbx1_purchaseAmt.Name = "txtbx1_purchaseAmt";
         this.txtbx1_purchaseAmt.Size = new System.Drawing.Size(192, 31);
         this.txtbx1_purchaseAmt.TabIndex = 6;
         // 
         // but1_submitPurchase
         // 
         this.but1_submitPurchase.Location = new System.Drawing.Point(571, 216);
         this.but1_submitPurchase.Name = "but1_submitPurchase";
         this.but1_submitPurchase.Size = new System.Drawing.Size(191, 31);
         this.but1_submitPurchase.TabIndex = 7;
         this.but1_submitPurchase.Text = "Submit purchase";
         this.but1_submitPurchase.UseVisualStyleBackColor = true;
         // 
         // but2_submitRefund
         // 
         this.but2_submitRefund.Location = new System.Drawing.Point(571, 289);
         this.but2_submitRefund.Name = "but2_submitRefund";
         this.but2_submitRefund.Size = new System.Drawing.Size(191, 31);
         this.but2_submitRefund.TabIndex = 9;
         this.but2_submitRefund.Text = "Submit refund";
         this.but2_submitRefund.UseVisualStyleBackColor = true;
         // 
         // txtbx2_refundAmt
         // 
         this.txtbx2_refundAmt.Location = new System.Drawing.Point(319, 289);
         this.txtbx2_refundAmt.Name = "txtbx2_refundAmt";
         this.txtbx2_refundAmt.Size = new System.Drawing.Size(192, 31);
         this.txtbx2_refundAmt.TabIndex = 8;
         // 
         // but3_logout
         // 
         this.but3_logout.Location = new System.Drawing.Point(44, 401);
         this.but3_logout.Name = "but3_logout";
         this.but3_logout.Size = new System.Drawing.Size(209, 48);
         this.but3_logout.TabIndex = 10;
         this.but3_logout.Text = "Logout";
         this.but3_logout.UseVisualStyleBackColor = true;
         // 
         // DashboardAdmin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(864, 477);
         this.Controls.Add(this.but3_logout);
         this.Controls.Add(this.but2_submitRefund);
         this.Controls.Add(this.txtbx2_refundAmt);
         this.Controls.Add(this.but1_submitPurchase);
         this.Controls.Add(this.txtbx1_purchaseAmt);
         this.Controls.Add(this.lab5_refundAmt);
         this.Controls.Add(this.lab4_purchaseAmt);
         this.Controls.Add(this.lab3_budgetTotal);
         this.Controls.Add(this.lab2_defundNum);
         this.Controls.Add(this.lab1_acctName);
         this.Name = "DashboardAdmin";
         this.Text = "DashboardAdmin";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_acctName;
      private System.Windows.Forms.Label lab2_defundNum;
      private System.Windows.Forms.Label lab3_budgetTotal;
      private System.Windows.Forms.Label lab4_purchaseAmt;
      private System.Windows.Forms.Label lab5_refundAmt;
      private System.Windows.Forms.TextBox txtbx1_purchaseAmt;
      private System.Windows.Forms.Button but1_submitPurchase;
      private System.Windows.Forms.Button but2_submitRefund;
      private System.Windows.Forms.TextBox txtbx2_refundAmt;
      private System.Windows.Forms.Button but3_logout;
   }
}