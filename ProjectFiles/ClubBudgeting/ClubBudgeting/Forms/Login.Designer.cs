namespace ClubBudgeting
{
   partial class Form1
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
         this.lab1_login = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtbx1_userName = new System.Windows.Forms.TextBox();
         this.txtbx2_password = new System.Windows.Forms.TextBox();
         this.but1_login = new System.Windows.Forms.Button();
         this.but2_createAccount = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lab1_login
         // 
         this.lab1_login.AutoSize = true;
         this.lab1_login.Location = new System.Drawing.Point(292, 179);
         this.lab1_login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.lab1_login.Name = "lab1_login";
         this.lab1_login.Size = new System.Drawing.Size(125, 25);
         this.lab1_login.TabIndex = 0;
         this.lab1_login.Text = "User Name:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(306, 242);
         this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(112, 25);
         this.label1.TabIndex = 1;
         this.label1.Text = "Password:";
         // 
         // txtbx1_userName
         // 
         this.txtbx1_userName.Location = new System.Drawing.Point(430, 173);
         this.txtbx1_userName.Margin = new System.Windows.Forms.Padding(6);
         this.txtbx1_userName.Name = "txtbx1_userName";
         this.txtbx1_userName.Size = new System.Drawing.Size(282, 31);
         this.txtbx1_userName.TabIndex = 2;
         // 
         // txtbx2_password
         // 
         this.txtbx2_password.Location = new System.Drawing.Point(430, 237);
         this.txtbx2_password.Margin = new System.Windows.Forms.Padding(6);
         this.txtbx2_password.Name = "txtbx2_password";
         this.txtbx2_password.PasswordChar = '●';
         this.txtbx2_password.Size = new System.Drawing.Size(282, 31);
         this.txtbx2_password.TabIndex = 3;
         // 
         // but1_login
         // 
         this.but1_login.Location = new System.Drawing.Point(510, 287);
         this.but1_login.Margin = new System.Windows.Forms.Padding(6);
         this.but1_login.Name = "but1_login";
         this.but1_login.Size = new System.Drawing.Size(206, 44);
         this.but1_login.TabIndex = 4;
         this.but1_login.Text = "Login";
         this.but1_login.UseVisualStyleBackColor = true;
         this.but1_login.Click += new System.EventHandler(this.but1_login_Click);
         // 
         // but2_createAccount
         // 
         this.but2_createAccount.Location = new System.Drawing.Point(510, 342);
         this.but2_createAccount.Margin = new System.Windows.Forms.Padding(6);
         this.but2_createAccount.Name = "but2_createAccount";
         this.but2_createAccount.Size = new System.Drawing.Size(206, 44);
         this.but2_createAccount.TabIndex = 5;
         this.but2_createAccount.Text = "Create Account";
         this.but2_createAccount.UseVisualStyleBackColor = true;
         this.but2_createAccount.Click += new System.EventHandler(this.but2_createAccount_Click);
         // 
         // Form1
         // 
         this.AcceptButton = this.but1_login;
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1100, 502);
         this.Controls.Add(this.but2_createAccount);
         this.Controls.Add(this.but1_login);
         this.Controls.Add(this.txtbx2_password);
         this.Controls.Add(this.txtbx1_userName);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lab1_login);
         this.Margin = new System.Windows.Forms.Padding(6);
         this.Name = "Form1";
         this.Text = "Login";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab1_login;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtbx1_userName;
      private System.Windows.Forms.TextBox txtbx2_password;
      private System.Windows.Forms.Button but1_login;
      private System.Windows.Forms.Button but2_createAccount;
   }
}

