﻿namespace SoftTeam.Boundary
{
    partial class Loginpage
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
            this.UserBT = new System.Windows.Forms.Button();
            this.AdminBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserBT
            // 
            this.UserBT.Location = new System.Drawing.Point(12, 12);
            this.UserBT.Name = "UserBT";
            this.UserBT.Size = new System.Drawing.Size(120, 40);
            this.UserBT.TabIndex = 0;
            this.UserBT.Text = "사용자";
            this.UserBT.UseVisualStyleBackColor = true;
            this.UserBT.Click += new System.EventHandler(this.UserBT_Click);
            // 
            // AdminBT
            // 
            this.AdminBT.Location = new System.Drawing.Point(152, 12);
            this.AdminBT.Name = "AdminBT";
            this.AdminBT.Size = new System.Drawing.Size(120, 40);
            this.AdminBT.TabIndex = 1;
            this.AdminBT.Text = "관리자";
            this.AdminBT.UseVisualStyleBackColor = true;
            this.AdminBT.Click += new System.EventHandler(this.AdminBT_Click);
            // 
            // Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.AdminBT);
            this.Controls.Add(this.UserBT);
            this.Name = "Loginpage";
            this.Text = "Loginpage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserBT;
        private System.Windows.Forms.Button AdminBT;
    }
}