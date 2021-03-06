﻿namespace ClubBudgeting.Forms
{
   partial class CreateAccount
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
         this.lab1_account = new System.Windows.Forms.Label();
         this.lab2_password = new System.Windows.Forms.Label();
         this.lab3_password_check = new System.Windows.Forms.Label();
         this.txtbx1_userName = new System.Windows.Forms.TextBox();
         this.txtbx2_password = new System.Windows.Forms.TextBox();
         this.txtbx3_password_check = new System.Windows.Forms.TextBox();
         this.lab4_firstName = new System.Windows.Forms.Label();
         this.lab5_lastName = new System.Windows.Forms.Label();
         this.lab6_clubID = new System.Windows.Forms.Label();
         this.txt4_firstName = new System.Windows.Forms.TextBox();
         this.txtbx5_lastName = new System.Windows.Forms.TextBox();
         this.but1_register = new System.Windows.Forms.Button();
         this.cb_clublist = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // lab1_account
         // 
         this.lab1_account.AutoSize = true;
         this.lab1_account.Location = new System.Drawing.Point(55, 23);
         this.lab1_account.Name = "lab1_account";
         this.lab1_account.Size = new System.Drawing.Size(60, 13);
         this.lab1_account.TabIndex = 0;
         this.lab1_account.Text = "User Name";
         // 
         // lab2_password
         // 
         this.lab2_password.AutoSize = true;
         this.lab2_password.Location = new System.Drawing.Point(29, 58);
         this.lab2_password.Name = "lab2_password";
         this.lab2_password.Size = new System.Drawing.Size(81, 13);
         this.lab2_password.TabIndex = 1;
         this.lab2_password.Text = "Enter Password";
         // 
         // lab3_password_check
         // 
         this.lab3_password_check.AutoSize = true;
         this.lab3_password_check.Location = new System.Drawing.Point(12, 93);
         this.lab3_password_check.Name = "lab3_password_check";
         this.lab3_password_check.Size = new System.Drawing.Size(98, 13);
         this.lab3_password_check.TabIndex = 2;
         this.lab3_password_check.Text = "Re-Enter Password";
         // 
         // txtbx1_userName
         // 
         this.txtbx1_userName.Location = new System.Drawing.Point(116, 20);
         this.txtbx1_userName.Name = "txtbx1_userName";
         this.txtbx1_userName.Size = new System.Drawing.Size(100, 20);
         this.txtbx1_userName.TabIndex = 3;
         // 
         // txtbx2_password
         // 
         this.txtbx2_password.Location = new System.Drawing.Point(116, 55);
         this.txtbx2_password.Name = "txtbx2_password";
         this.txtbx2_password.Size = new System.Drawing.Size(100, 20);
         this.txtbx2_password.TabIndex = 4;
         // 
         // txtbx3_password_check
         // 
         this.txtbx3_password_check.Location = new System.Drawing.Point(116, 90);
         this.txtbx3_password_check.Name = "txtbx3_password_check";
         this.txtbx3_password_check.Size = new System.Drawing.Size(100, 20);
         this.txtbx3_password_check.TabIndex = 5;
         // 
         // lab4_firstName
         // 
         this.lab4_firstName.AutoSize = true;
         this.lab4_firstName.Location = new System.Drawing.Point(239, 23);
         this.lab4_firstName.Name = "lab4_firstName";
         this.lab4_firstName.Size = new System.Drawing.Size(57, 13);
         this.lab4_firstName.TabIndex = 6;
         this.lab4_firstName.Text = "First Name";
         // 
         // lab5_lastName
         // 
         this.lab5_lastName.AutoSize = true;
         this.lab5_lastName.Location = new System.Drawing.Point(239, 58);
         this.lab5_lastName.Name = "lab5_lastName";
         this.lab5_lastName.Size = new System.Drawing.Size(58, 13);
         this.lab5_lastName.TabIndex = 7;
         this.lab5_lastName.Text = "Last Name";
         // 
         // lab6_clubID
         // 
         this.lab6_clubID.AutoSize = true;
         this.lab6_clubID.Location = new System.Drawing.Point(259, 93);
         this.lab6_clubID.Name = "lab6_clubID";
         this.lab6_clubID.Size = new System.Drawing.Size(37, 13);
         this.lab6_clubID.TabIndex = 8;
         this.lab6_clubID.Text = "ClubId";
         // 
         // txt4_firstName
         // 
         this.txt4_firstName.Location = new System.Drawing.Point(302, 20);
         this.txt4_firstName.Name = "txt4_firstName";
         this.txt4_firstName.Size = new System.Drawing.Size(100, 20);
         this.txt4_firstName.TabIndex = 9;
         // 
         // txtbx5_lastName
         // 
         this.txtbx5_lastName.Location = new System.Drawing.Point(302, 55);
         this.txtbx5_lastName.Name = "txtbx5_lastName";
         this.txtbx5_lastName.Size = new System.Drawing.Size(100, 20);
         this.txtbx5_lastName.TabIndex = 10;
         // 
         // but1_register
         // 
         this.but1_register.Location = new System.Drawing.Point(431, 90);
         this.but1_register.Name = "but1_register";
         this.but1_register.Size = new System.Drawing.Size(75, 21);
         this.but1_register.TabIndex = 12;
         this.but1_register.Text = "Register";
         this.but1_register.UseVisualStyleBackColor = true;
         this.but1_register.Click += new System.EventHandler(this.but1_register_Click);
         // 
         // cb_clublist
         // 
         this.cb_clublist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cb_clublist.FormattingEnabled = true;
         this.cb_clublist.Location = new System.Drawing.Point(302, 90);
         this.cb_clublist.Name = "cb_clublist";
         this.cb_clublist.Size = new System.Drawing.Size(100, 21);
         this.cb_clublist.TabIndex = 14;
         this.cb_clublist.SelectedIndexChanged += new System.EventHandler(this.cb_clubList_index);
         // 
         // CreateAccount
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(518, 129);
         this.Controls.Add(this.cb_clublist);
         this.Controls.Add(this.but1_register);
         this.Controls.Add(this.txtbx5_lastName);
         this.Controls.Add(this.txt4_firstName);
         this.Controls.Add(this.lab6_clubID);
         this.Controls.Add(this.lab5_lastName);
         this.Controls.Add(this.lab4_firstName);
         this.Controls.Add(this.txtbx3_password_check);
         this.Controls.Add(this.txtbx2_password);
         this.Controls.Add(this.txtbx1_userName);
         this.Controls.Add(this.lab3_password_check);
         this.Controls.Add(this.lab2_password);
         this.Controls.Add(this.lab1_account);
         this.Name = "CreateAccount";
         this.Text = "createAccount";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_account;
      private System.Windows.Forms.Label lab2_password;
      private System.Windows.Forms.Label lab3_password_check;
      private System.Windows.Forms.TextBox txtbx1_userName;
      private System.Windows.Forms.TextBox txtbx2_password;
      private System.Windows.Forms.TextBox txtbx3_password_check;
      private System.Windows.Forms.Label lab4_firstName;
      private System.Windows.Forms.Label lab5_lastName;
      private System.Windows.Forms.Label lab6_clubID;
      private System.Windows.Forms.TextBox txt4_firstName;
      private System.Windows.Forms.TextBox txtbx5_lastName;
      private System.Windows.Forms.Button but1_register;
      private System.Windows.Forms.ComboBox cb_clublist;
   }
}