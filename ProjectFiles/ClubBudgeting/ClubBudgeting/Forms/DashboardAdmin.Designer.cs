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
         this.lab_debt = new System.Windows.Forms.Label();
         this.lab_totalDebt = new System.Windows.Forms.Label();
         this.but_viewTransactions = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lab1_acctName
         // 
         this.lab1_acctName.AutoSize = true;
         this.lab1_acctName.Location = new System.Drawing.Point(18, 18);
         this.lab1_acctName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab1_acctName.Name = "lab1_acctName";
         this.lab1_acctName.Size = new System.Drawing.Size(62, 13);
         this.lab1_acctName.TabIndex = 0;
         this.lab1_acctName.Text = "Club Name:";
         // 
         // lab3_budgetTotal
         // 
         this.lab3_budgetTotal.AutoSize = true;
         this.lab3_budgetTotal.Location = new System.Drawing.Point(18, 42);
         this.lab3_budgetTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab3_budgetTotal.Name = "lab3_budgetTotal";
         this.lab3_budgetTotal.Size = new System.Drawing.Size(71, 13);
         this.lab3_budgetTotal.TabIndex = 2;
         this.lab3_budgetTotal.Text = "Budget Total:";
         // 
         // lab4_purchaseAmt
         // 
         this.lab4_purchaseAmt.AutoSize = true;
         this.lab4_purchaseAmt.Location = new System.Drawing.Point(20, 132);
         this.lab4_purchaseAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab4_purchaseAmt.Name = "lab4_purchaseAmt";
         this.lab4_purchaseAmt.Size = new System.Drawing.Size(137, 13);
         this.lab4_purchaseAmt.TabIndex = 3;
         this.lab4_purchaseAmt.Text = "Enter a transaction amount:";
         // 
         // lab5_refundAmt
         // 
         this.lab5_refundAmt.AutoSize = true;
         this.lab5_refundAmt.Location = new System.Drawing.Point(18, 161);
         this.lab5_refundAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab5_refundAmt.Name = "lab5_refundAmt";
         this.lab5_refundAmt.Size = new System.Drawing.Size(132, 13);
         this.lab5_refundAmt.TabIndex = 4;
         this.lab5_refundAmt.Text = "Enter the transaction date:";
         // 
         // txtbx1_transAmt
         // 
         this.txtbx1_transAmt.Location = new System.Drawing.Point(160, 130);
         this.txtbx1_transAmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.txtbx1_transAmt.Name = "txtbx1_transAmt";
         this.txtbx1_transAmt.Size = new System.Drawing.Size(98, 20);
         this.txtbx1_transAmt.TabIndex = 6;
         // 
         // txtbx2_date
         // 
         this.txtbx2_date.Location = new System.Drawing.Point(160, 159);
         this.txtbx2_date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.txtbx2_date.Name = "txtbx2_date";
         this.txtbx2_date.Size = new System.Drawing.Size(98, 20);
         this.txtbx2_date.TabIndex = 8;
         // 
         // lab_clubName
         // 
         this.lab_clubName.AutoSize = true;
         this.lab_clubName.Location = new System.Drawing.Point(83, 18);
         this.lab_clubName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab_clubName.Name = "lab_clubName";
         this.lab_clubName.Size = new System.Drawing.Size(57, 13);
         this.lab_clubName.TabIndex = 11;
         this.lab_clubName.Text = "Club name";
         // 
         // lab_budget
         // 
         this.lab_budget.AutoSize = true;
         this.lab_budget.Location = new System.Drawing.Point(91, 42);
         this.lab_budget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab_budget.Name = "lab_budget";
         this.lab_budget.Size = new System.Drawing.Size(40, 13);
         this.lab_budget.TabIndex = 13;
         this.lab_budget.Text = "budget";
         // 
         // but1_submitTransaction
         // 
         this.but1_submitTransaction.Location = new System.Drawing.Point(288, 130);
         this.but1_submitTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.but1_submitTransaction.Name = "but1_submitTransaction";
         this.but1_submitTransaction.Size = new System.Drawing.Size(84, 45);
         this.but1_submitTransaction.TabIndex = 14;
         this.but1_submitTransaction.Text = "Submit Transaction";
         this.but1_submitTransaction.UseVisualStyleBackColor = true;
         this.but1_submitTransaction.Click += new System.EventHandler(this.but1_submitTransaction_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(166, 184);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(75, 13);
         this.label1.TabIndex = 15;
         this.label1.Text = "YYYY-MM-DD";
         // 
         // but_addClub
         // 
         this.but_addClub.Location = new System.Drawing.Point(288, 245);
         this.but_addClub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.but_addClub.Name = "but_addClub";
         this.but_addClub.Size = new System.Drawing.Size(84, 48);
         this.but_addClub.TabIndex = 20;
         this.but_addClub.Text = "Add Club";
         this.but_addClub.UseVisualStyleBackColor = true;
         this.but_addClub.Click += new System.EventHandler(this.but_addClub_Click);
         // 
         // txtbx_clubDesc
         // 
         this.txtbx_clubDesc.Location = new System.Drawing.Point(160, 277);
         this.txtbx_clubDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.txtbx_clubDesc.Name = "txtbx_clubDesc";
         this.txtbx_clubDesc.Size = new System.Drawing.Size(98, 20);
         this.txtbx_clubDesc.TabIndex = 19;
         // 
         // txtbx_clubName
         // 
         this.txtbx_clubName.Location = new System.Drawing.Point(160, 245);
         this.txtbx_clubName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.txtbx_clubName.Name = "txtbx_clubName";
         this.txtbx_clubName.Size = new System.Drawing.Size(98, 20);
         this.txtbx_clubName.TabIndex = 18;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(20, 277);
         this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(121, 13);
         this.label2.TabIndex = 17;
         this.label2.Text = "Enter a club description:";
         // 
         // lab_
         // 
         this.lab_.AutoSize = true;
         this.lab_.Location = new System.Drawing.Point(20, 247);
         this.lab_.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab_.Name = "lab_";
         this.lab_.Size = new System.Drawing.Size(96, 13);
         this.lab_.TabIndex = 16;
         this.lab_.Text = "Enter a club name:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(20, 215);
         this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(78, 15);
         this.label3.TabIndex = 21;
         this.label3.Text = "Add a club:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(20, 101);
         this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(122, 15);
         this.label4.TabIndex = 22;
         this.label4.Text = "Add a transaction:";
         // 
         // lab_transStatus
         // 
         this.lab_transStatus.AutoSize = true;
         this.lab_transStatus.Location = new System.Drawing.Point(382, 150);
         this.lab_transStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab_transStatus.Name = "lab_transStatus";
         this.lab_transStatus.Size = new System.Drawing.Size(37, 13);
         this.lab_transStatus.TabIndex = 23;
         this.lab_transStatus.Text = "Status";
         // 
         // lab_clubStatus
         // 
         this.lab_clubStatus.AutoSize = true;
         this.lab_clubStatus.Location = new System.Drawing.Point(382, 266);
         this.lab_clubStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab_clubStatus.Name = "lab_clubStatus";
         this.lab_clubStatus.Size = new System.Drawing.Size(37, 13);
         this.lab_clubStatus.TabIndex = 24;
         this.lab_clubStatus.Text = "Status";
         // 
         // lab_debt
         // 
         this.lab_debt.AutoSize = true;
         this.lab_debt.Location = new System.Drawing.Point(18, 66);
         this.lab_debt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab_debt.Name = "lab_debt";
         this.lab_debt.Size = new System.Drawing.Size(60, 13);
         this.lab_debt.TabIndex = 25;
         this.lab_debt.Text = "Total Debt:";
         // 
         // lab_totalDebt
         // 
         this.lab_totalDebt.AutoSize = true;
         this.lab_totalDebt.Location = new System.Drawing.Point(80, 66);
         this.lab_totalDebt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.lab_totalDebt.Name = "lab_totalDebt";
         this.lab_totalDebt.Size = new System.Drawing.Size(28, 13);
         this.lab_totalDebt.TabIndex = 26;
         this.lab_totalDebt.Text = "debt";
         // 
         // but_viewTransactions
         // 
         this.but_viewTransactions.Location = new System.Drawing.Point(377, 26);
         this.but_viewTransactions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.but_viewTransactions.Name = "but_viewTransactions";
         this.but_viewTransactions.Size = new System.Drawing.Size(84, 45);
         this.but_viewTransactions.TabIndex = 27;
         this.but_viewTransactions.Text = "View Transactions";
         this.but_viewTransactions.UseVisualStyleBackColor = true;
         this.but_viewTransactions.Click += new System.EventHandler(this.but_viewTransactions_Click);
         // 
         // DashboardAdmin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(494, 323);
         this.Controls.Add(this.but_viewTransactions);
         this.Controls.Add(this.lab_totalDebt);
         this.Controls.Add(this.lab_debt);
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
         this.Controls.Add(this.txtbx2_date);
         this.Controls.Add(this.txtbx1_transAmt);
         this.Controls.Add(this.lab5_refundAmt);
         this.Controls.Add(this.lab4_purchaseAmt);
         this.Controls.Add(this.lab3_budgetTotal);
         this.Controls.Add(this.lab1_acctName);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.Name = "DashboardAdmin";
         this.Text = "Admin Dashboard";
         this.Load += new System.EventHandler(this.DashboardAdmin_Load);
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
      private System.Windows.Forms.Label lab_debt;
      private System.Windows.Forms.Label lab_totalDebt;
      private System.Windows.Forms.Button but_viewTransactions;
   }
}