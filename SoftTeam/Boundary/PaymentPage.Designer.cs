namespace SoftTeam.Boundary
{
    partial class PaymentPage
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
            this.PaymentLV = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.부서 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.카테고리 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.품목명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.수량 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.단가 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.비고 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calcPriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeptTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemarkTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryTB = new System.Windows.Forms.TextBox();
            this.AcceptBT = new System.Windows.Forms.Button();
            this.ReturnBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaymentLV
            // 
            this.PaymentLV.AllowColumnReorder = true;
            this.PaymentLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.부서,
            this.카테고리,
            this.품목명,
            this.수량,
            this.단가,
            this.비고});
            this.PaymentLV.FullRowSelect = true;
            this.PaymentLV.HideSelection = false;
            this.PaymentLV.Location = new System.Drawing.Point(12, 76);
            this.PaymentLV.MultiSelect = false;
            this.PaymentLV.Name = "PaymentLV";
            this.PaymentLV.Size = new System.Drawing.Size(565, 362);
            this.PaymentLV.TabIndex = 0;
            this.PaymentLV.UseCompatibleStateImageBehavior = false;
            this.PaymentLV.SelectedIndexChanged += new System.EventHandler(this.PaymentLV_SelectedIndexChanged);
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 30;
            // 
            // 부서
            // 
            this.부서.Text = "부서";
            // 
            // 카테고리
            // 
            this.카테고리.Text = "카테고리";
            this.카테고리.Width = 65;
            // 
            // 품목명
            // 
            this.품목명.Text = "품목명";
            this.품목명.Width = 250;
            // 
            // 수량
            // 
            this.수량.Text = "수량";
            this.수량.Width = 40;
            // 
            // 단가
            // 
            this.단가.Text = "단가";
            this.단가.Width = 50;
            // 
            // 비고
            // 
            this.비고.Text = "비고";
            this.비고.Width = 70;
            // 
            // ItemTB
            // 
            this.ItemTB.Location = new System.Drawing.Point(653, 117);
            this.ItemTB.Multiline = true;
            this.ItemTB.Name = "ItemTB";
            this.ItemTB.Size = new System.Drawing.Size(135, 40);
            this.ItemTB.TabIndex = 1;
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(653, 180);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(135, 21);
            this.AmountTB.TabIndex = 2;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(653, 228);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(135, 21);
            this.PriceTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "수량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "단가";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "총액";
            // 
            // calcPriceTB
            // 
            this.calcPriceTB.Location = new System.Drawing.Point(653, 275);
            this.calcPriceTB.Name = "calcPriceTB";
            this.calcPriceTB.Size = new System.Drawing.Size(135, 21);
            this.calcPriceTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "요청부서";
            // 
            // DeptTB
            // 
            this.DeptTB.Location = new System.Drawing.Point(653, 320);
            this.DeptTB.Name = "DeptTB";
            this.DeptTB.Size = new System.Drawing.Size(135, 21);
            this.DeptTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "비고";
            // 
            // RemarkTB
            // 
            this.RemarkTB.Location = new System.Drawing.Point(653, 370);
            this.RemarkTB.Name = "RemarkTB";
            this.RemarkTB.Size = new System.Drawing.Size(135, 21);
            this.RemarkTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "카테고리";
            // 
            // categoryTB
            // 
            this.categoryTB.Location = new System.Drawing.Point(653, 76);
            this.categoryTB.Name = "categoryTB";
            this.categoryTB.Size = new System.Drawing.Size(135, 21);
            this.categoryTB.TabIndex = 13;
            // 
            // AcceptBT
            // 
            this.AcceptBT.Location = new System.Drawing.Point(611, 410);
            this.AcceptBT.Name = "AcceptBT";
            this.AcceptBT.Size = new System.Drawing.Size(77, 28);
            this.AcceptBT.TabIndex = 15;
            this.AcceptBT.Text = "승인";
            this.AcceptBT.UseVisualStyleBackColor = true;
            this.AcceptBT.Click += new System.EventHandler(this.AcceptBT_Click);
            // 
            // ReturnBT
            // 
            this.ReturnBT.Location = new System.Drawing.Point(711, 410);
            this.ReturnBT.Name = "ReturnBT";
            this.ReturnBT.Size = new System.Drawing.Size(77, 28);
            this.ReturnBT.TabIndex = 16;
            this.ReturnBT.Text = "반려";
            this.ReturnBT.UseVisualStyleBackColor = true;
            this.ReturnBT.Click += new System.EventHandler(this.ReturnBT_Click);
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 451);
            this.Controls.Add(this.ReturnBT);
            this.Controls.Add(this.AcceptBT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categoryTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RemarkTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeptTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calcPriceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.ItemTB);
            this.Controls.Add(this.PaymentLV);
            this.Name = "PaymentPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PaymentLV;
        private System.Windows.Forms.TextBox ItemTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox calcPriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DeptTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RemarkTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categoryTB;
        private System.Windows.Forms.Button AcceptBT;
        private System.Windows.Forms.Button ReturnBT;
        private System.Windows.Forms.ColumnHeader 부서;
        private System.Windows.Forms.ColumnHeader 카테고리;
        private System.Windows.Forms.ColumnHeader 품목명;
        private System.Windows.Forms.ColumnHeader 수량;
        private System.Windows.Forms.ColumnHeader 단가;
        private System.Windows.Forms.ColumnHeader 비고;
        private System.Windows.Forms.ColumnHeader No;
    }
}