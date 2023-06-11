namespace SoftTeam.Boundary
{
    partial class AddCategoryPage
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
            this.CategoryTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBT = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryTB
            // 
            this.CategoryTB.Location = new System.Drawing.Point(71, 31);
            this.CategoryTB.Name = "CategoryTB";
            this.CategoryTB.Size = new System.Drawing.Size(160, 21);
            this.CategoryTB.TabIndex = 0;
            this.CategoryTB.TextChanged += new System.EventHandler(this.CategoryTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "카테고리";
            // 
            // CheckBT
            // 
            this.CheckBT.Location = new System.Drawing.Point(14, 66);
            this.CheckBT.Name = "CheckBT";
            this.CheckBT.Size = new System.Drawing.Size(76, 30);
            this.CheckBT.TabIndex = 2;
            this.CheckBT.Text = "중복 확인";
            this.CheckBT.UseVisualStyleBackColor = true;
            this.CheckBT.Click += new System.EventHandler(this.CheckBT_Click);
            // 
            // AddBT
            // 
            this.AddBT.Enabled = false;
            this.AddBT.Location = new System.Drawing.Point(155, 66);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(76, 30);
            this.AddBT.TabIndex = 3;
            this.AddBT.Text = "추가";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 108);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.CheckBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryTB);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckBT;
        private System.Windows.Forms.Button AddBT;
    }
}