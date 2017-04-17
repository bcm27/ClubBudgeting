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
         this.txtbx1_transAmt = new System.Windows.Forms.TextBox();
         this.txtbx2_date = new System.Windows.Forms.TextBox();
         this.but3_logout = new System.Windows.Forms.Button();
         this.lab_clubName = new System.Windows.Forms.Label();
         this.lab_budget = new System.Windows.Forms.Label();
         this.but1_submitTransaction = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.but_addClub = new System.Windows.Forms.Button();
         this.txtbx_clubDesc = new System.Windows.Forms.TextBox();
         this.txtbx_clubName = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.lab_ = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.lab_transStatus = new System.Windows.Forms.Label();
         this.lab_clubStatus = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lab1_acctName
         // 
         this.lab1_acctName.AutoSize = true;
         this.lab1_acctName.Location = new System.Drawing.Point(36, 35);
         this.lab1_acctName.Name = "lab1_acctName";
         this.lab1_acctName.Size = new System.Drawing.Size(158, 25);
         this.lab1_acctName.TabIndex = 0;
         this.lab1_acctName.Text = "Account Name:";
         // 
         // lab3_budgetTotal
         // 
         this.lab3_budgetTotal.AutoSize = true;
         this.lab3_budgetTotal.Location = new System.Drawing.Point(36, 89);
         this.lab3_budgetTotal.Name = "lab3_budgetTotal";
         this.lab3_budgetTotal.Size = new System.Drawing.Size(140, 25);
         this.lab3_budgetTotal.TabIndex = 2;
         this.lab3_budgetTotal.Text = "Budget Total:";
         // 
         // lab4_purchaseAmt
         // 
         this.lab4_purchaseAmt.AutoSize = true;
         this.lab4_purchaseAmt.Location = new System.Drawing.Point(39, 221);
         this.lab4_purchaseAmt.Name = "lab4_purchaseAmt";
         this.lab4_purchaseAmt.Size = new System.Drawing.Size(276, 25);
         this.lab4_purchaseAmt.TabIndex = 3;
         this.lab4_purchaseAmt.Text = "Enter a transaction amount:";
         // 
         // lab5_refundAmt
         // 
         this.lab5_refundAmt.AutoSize = true;
         this.lab5_refundAmt.Location = new System.Drawing.Point(39, 291);
         this.lab5_refundAmt.Name = "lab5_refundAmt";
         this.lab5_refundAmt.Size = new System.Drawing.Size(265, 25);
         this.lab5_refundAmt.TabIndex = 4;
         this.lab5_refundAmt.Text = "Enter the transaction date:";
         // 
         // txtbx1_transAmt
         // 
         this.txtbx1_transAmt.Location = new System.Drawing.Point(319, 218);
         this.txtbx1_transAmt.Name = "txtbx1_transAmt";
         this.txtbx1_transAmt.Size = new System.Drawing.Size(192, 31);
         this.txtbx1_transAmt.TabIndex = 6;
         // 
         // txtbx2_date
         // 
         this.txtbx2_date.Location = new System.Drawing.Point(319, 291);
         this.txtbx2_date.Name = "txtbx2_date";
         this.txtbx2_date.Size = new System.Drawing.Size(192, 31);
         this.txtbx2_date.TabIndex = 8;
         // 
         // but3_logout
         // 
         this.but3_logout.Location = new System.Drawing.Point(41, 627);
         this.but3_logout.Name = "but3_logout";
         this.but3_logout.Size = new System.Drawing.Size(209, 48);
         this.but3_logout.TabIndex = 10;
         this.but3_logout.Text = "Logout";
         this.but3_logout.UseVisualStyleBackColor = true;
         // 
         // lab_clubName
         // 
         this.lab_clubName.AutoSize = true;
         this.lab_clubName.Location = new System.Drawing.Point(200, 35);
         this.lab_clubName.Name = "lab_clubName";
         this.lab_clubName.Size = new System.Drawing.Size(115, 25);
         this.lab_clubName.TabIndex = 11;
         this.lab_clubName.Text = "Club name";
         // 
         // lab_budget
         // 
         this.lab_budget.AutoSize = true;
         this.lab_budget.Location = new System.Drawing.Point(182, 89);
         this.lab_budget.Name = "lab_budget";
         this.lab_budget.Size = new System.Drawing.Size(78, 25);
         this.lab_budget.TabIndex = 13;
         this.lab_budget.Text = "budget";
         // 
         // but1_submitTransaction
         // 
         this.but1_submitTransaction.Location = new System.Drawing.Point(575, 218);
         this.but1_submitTransaction.Name = "but1_submitTransaction";
         this.but1_submitTransaction.Size = new System.Drawing.Size(169, 104);
         this.but1_submitTransaction.TabIndex = 14;
         this.but1_submitTransaction.Text = "Submit transaction";
         this.but1_submitTransaction.UseVisualStyleBackColor = true;
         this.but1_submitTransaction.Click += new System.EventHandler(this.but1_submitTransaction_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(336, 335);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(152, 25);
         this.label1.TabIndex = 15;
         this.label1.Text = "YYYY-MM-DD";
         // 
         // but_addClub
         // 
         this.but_addClub.Location = new System.Drawing.Point(575, 440);
         this.but_addClub.Name = "but_addClub";
         this.but_addClub.Size = new System.Drawing.Size(169, 104);
         this.but_addClub.TabIndex = 20;
         this.but_addClub.Text = "Add club";
         this.but_addClub.UseVisualStyleBackColor = true;
         this.but_addClub.Click += new System.EventHandler(this.but_addClub_Click);
         // 
         // txtbx_clubDesc
         // 
         this.txtbx_clubDesc.Location = new System.Drawing.Point(319, 513);
         this.txtbx_clubDesc.Name = "txtbx_clubDesc";
         this.txtbx_clubDesc.Size = new System.Drawing.Size(192, 31);
         this.txtbx_clubDesc.TabIndex = 19;
         // 
         // txtbx_clubName
         // 
         this.txtbx_clubName.Location = new System.Drawing.Point(319, 440);
         this.txtbx_clubName.Name = "txtbx_clubName";
         this.txtbx_clubName.Size = new System.Drawing.Size(192, 31);
         this.txtbx_clubName.TabIndex = 18;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(39, 513);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(244, 25);
         this.label2.TabIndex = 17;
         this.label2.Text = "Enter a club description:";
         // 
         // lab_
         // 
         this.lab_.AutoSize = true;
         this.lab_.Location = new System.Drawing.Point(39, 443);
         this.lab_.Name = "lab_";
         this.lab_.Size = new System.Drawing.Size(192, 25);
         this.lab_.TabIndex = 16;
         this.lab_.Text = "Enter a club name:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(39, 381);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(143, 29);
         this.label3.TabIndex = 21;
         this.label3.Text = "Add a club:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(39, 162);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(221, 29);
         this.label4.TabIndex = 22;
         this.label4.Text = "Add a transaction:";
         // 
         // lab_transStatus
         // 
         this.lab_transStatus.AutoSize = true;
         this.lab_transStatus.Location = new System.Drawing.Point(763, 257);
         this.lab_transStatus.Name = "lab_transStatus";
         this.lab_transStatus.Size = new System.Drawing.Size(73, 25);
         this.lab_transStatus.TabIndex = 23;
         this.lab_transStatus.Text = "Status";
         // 
         // lab_clubStatus
         // 
         this.lab_clubStatus.AutoSize = true;
         this.lab_clubStatus.Location = new System.Drawing.Point(763, 480);
         this.lab_clubStatus.Name = "lab_clubStatus";
         this.lab_clubStatus.Size = new System.Drawing.Size(73, 25);
         this.lab_clubStatus.TabIndex = 24;
         this.lab_clubStatus.Text = "Status";
         // 
         // DashboardAdmin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(988, 719);
         this.Controls.Add(this.lab_clubStatus);
         this.Controls.Add(this.lab_transStatus);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.but_addClub);
         this.Controls.Add(this.txtbx_clubDesc);
         this.Controls.Add(this.txtbx_clubName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.lab_);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.but1_submitTransaction);
         this.Controls.Add(this.lab_budget);
         this.Controls.Add(this.lab_clubName);
         this.Controls.Add(this.but3_logout);
         this.Controls.Add(this.txtbx2_date);
         this.Controls.Add(this.txtbx1_transAmt);
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
      private System.Windows.Forms.TextBox txtbx1_transAmt;
      private System.Windows.Forms.TextBox txtbx2_date;
      private System.Windows.Forms.Button but3_logout;
      private System.Windows.Forms.Label lab_clubName;
      private System.Windows.Forms.Label lab_budget;
      private System.Windows.Forms.Button but1_submitTransaction;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button but_addClub;
      private System.Windows.Forms.TextBox txtbx_clubDesc;
      private System.Windows.Forms.TextBox txtbx_clubName;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lab_;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label lab_transStatus;
      private System.Windows.Forms.Label lab_clubStatus;
   }
}