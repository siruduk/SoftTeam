namespace SoftTeam.Boundary
{
    partial class ItemAddPage
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
            this.SaveBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.RemarkTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.AddCategoryBT = new System.Windows.Forms.Button();
            this.CheckBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveBT
            // 
            this.SaveBT.Enabled = false;
            this.SaveBT.Location = new System.Drawing.Point(245, 235);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(77, 26);
            this.SaveBT.TabIndex = 6;
            this.SaveBT.Text = "저장";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "소모품 정보 입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "카테고리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "물품명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "비고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "수량";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(97, 86);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(225, 21);
            this.NameTB.TabIndex = 2;
            this.NameTB.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // RemarkTB
            // 
            this.RemarkTB.Location = new System.Drawing.Point(97, 206);
            this.RemarkTB.Name = "RemarkTB";
            this.RemarkTB.Size = new System.Drawing.Size(225, 21);
            this.RemarkTB.TabIndex = 3;
            this.RemarkTB.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(97, 125);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(225, 21);
            this.PriceTB.TabIndex = 4;
            this.PriceTB.TextChanged += new System.EventHandler(this.TextChanged);
            this.PriceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(97, 165);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(225, 21);
            this.AmountTB.TabIndex = 5;
            this.AmountTB.TextChanged += new System.EventHandler(this.TextChanged);
            this.AmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // CategoryCB
            // 
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(97, 49);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(225, 20);
            this.CategoryCB.Sorted = true;
            this.CategoryCB.TabIndex = 1;
            this.CategoryCB.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // AddCategoryBT
            // 
            this.AddCategoryBT.Location = new System.Drawing.Point(223, 12);
            this.AddCategoryBT.Name = "AddCategoryBT";
            this.AddCategoryBT.Size = new System.Drawing.Size(99, 26);
            this.AddCategoryBT.TabIndex = 0;
            this.AddCategoryBT.Text = "카테고리 추가";
            this.AddCategoryBT.UseVisualStyleBackColor = true;
            this.AddCategoryBT.Click += new System.EventHandler(this.AddCategoryBT_Click);
            // 
            // CheckBT
            // 
            this.CheckBT.Location = new System.Drawing.Point(162, 235);
            this.CheckBT.Name = "CheckBT";
            this.CheckBT.Size = new System.Drawing.Size(77, 26);
            this.CheckBT.TabIndex = 7;
            this.CheckBT.Text = "중복 확인";
            this.CheckBT.UseVisualStyleBackColor = true;
            this.CheckBT.Click += new System.EventHandler(this.CheckBT_Click);
            // 
            // ItemAddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 271);
            this.Controls.Add(this.CheckBT);
            this.Controls.Add(this.AddCategoryBT);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.RemarkTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveBT);
            this.Name = "ItemAddPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "소모품 목록 추가";
            this.Load += new System.EventHandler(this.ItemAddPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddCategoryBT;
        public System.Windows.Forms.TextBox NameTB;
        public System.Windows.Forms.TextBox RemarkTB;
        public System.Windows.Forms.TextBox PriceTB;
        public System.Windows.Forms.TextBox AmountTB;
        public System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Button CheckBT;
    }
}