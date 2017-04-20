namespace ClubBudgeting.Forms
{
   partial class AddClub
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
         this.lab_clubStatus = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.but_addClub = new System.Windows.Forms.Button();
         this.txtbx_clubDesc = new System.Windows.Forms.TextBox();
         this.txtbx_clubName = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.lab_ = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lab_clubStatus
         // 
         this.lab_clubStatus.AutoSize = true;
         this.lab_clubStatus.Location = new System.Drawing.Point(769, 157);
         this.lab_clubStatus.Name = "lab_clubStatus";
         this.lab_clubStatus.Size = new System.Drawing.Size(73, 25);
         this.lab_clubStatus.TabIndex = 31;
         this.lab_clubStatus.Text = "Status";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(45, 58);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(143, 29);
         this.label3.TabIndex = 30;
         this.label3.Text = "Add a club:";
         // 
         // but_addClub
         // 
         this.but_addClub.Location = new System.Drawing.Point(581, 117);
         this.but_addClub.Name = "but_addClub";
         this.but_addClub.Size = new System.Drawing.Size(169, 92);
         this.but_addClub.TabIndex = 29;
         this.but_addClub.Text = "Add Club";
         this.but_addClub.UseVisualStyleBackColor = true;
         this.but_addClub.Click += new System.EventHandler(this.but_addClub_Click);
         // 
         // txtbx_clubDesc
         // 
         this.txtbx_clubDesc.Location = new System.Drawing.Point(325, 178);
         this.txtbx_clubDesc.Name = "txtbx_clubDesc";
         this.txtbx_clubDesc.Size = new System.Drawing.Size(192, 31);
         this.txtbx_clubDesc.TabIndex = 28;
         // 
         // txtbx_clubName
         // 
         this.txtbx_clubName.Location = new System.Drawing.Point(325, 117);
         this.txtbx_clubName.Name = "txtbx_clubName";
         this.txtbx_clubName.Size = new System.Drawing.Size(192, 31);
         this.txtbx_clubName.TabIndex = 27;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(45, 178);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(244, 25);
         this.label2.TabIndex = 26;
         this.label2.Text = "Enter a club description:";
         // 
         // lab_
         // 
         this.lab_.AutoSize = true;
         this.lab_.Location = new System.Drawing.Point(45, 120);
         this.lab_.Name = "lab_";
         this.lab_.Size = new System.Drawing.Size(192, 25);
         this.lab_.TabIndex = 25;
         this.lab_.Text = "Enter a club name:";
         // 
         // AddClub
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(902, 299);
         this.Controls.Add(this.lab_clubStatus);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.but_addClub);
         this.Controls.Add(this.txtbx_clubDesc);
         this.Controls.Add(this.txtbx_clubName);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.lab_);
         this.Name = "AddClub";
         this.Text = "AddClub";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lab_clubStatus;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button but_addClub;
      private System.Windows.Forms.TextBox txtbx_clubDesc;
      private System.Windows.Forms.TextBox txtbx_clubName;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lab_;
   }
}