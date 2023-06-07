namespace SoftTeam.Boundary
{
    partial class ShowPaymentPage
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
            this.DeptCB = new System.Windows.Forms.ComboBox();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.결제상태 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.비고,
            this.결제상태});
            this.PaymentLV.FullRowSelect = true;
            this.PaymentLV.HideSelection = false;
            this.PaymentLV.Location = new System.Drawing.Point(12, 42);
            this.PaymentLV.MultiSelect = false;
            this.PaymentLV.Name = "PaymentLV";
            this.PaymentLV.Size = new System.Drawing.Size(658, 362);
            this.PaymentLV.TabIndex = 1;
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
            // DeptCB
            // 
            this.DeptCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptCB.FormattingEnabled = true;
            this.DeptCB.Items.AddRange(new object[] {
            "전체",
            "기획팀",
            "인사팀",
            "총무팀",
            "회계팀",
            "전산팀"});
            this.DeptCB.Location = new System.Drawing.Point(12, 15);
            this.DeptCB.Name = "DeptCB";
            this.DeptCB.Size = new System.Drawing.Size(228, 20);
            this.DeptCB.TabIndex = 9;
            // 
            // StatusCB
            // 
            this.StatusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Items.AddRange(new object[] {
            "전체",
            "결제 대기",
            "승인",
            "반려"});
            this.StatusCB.Location = new System.Drawing.Point(578, 15);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(92, 20);
            this.StatusCB.TabIndex = 10;
            // 
            // 결제상태
            // 
            this.결제상태.Text = "결제상태";
            this.결제상태.Width = 80;
            // 
            // ShowPaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 420);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.DeptCB);
            this.Controls.Add(this.PaymentLV);
            this.Name = "ShowPaymentPage";
            this.Text = "ShowPaymentPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PaymentLV;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader 부서;
        private System.Windows.Forms.ColumnHeader 카테고리;
        private System.Windows.Forms.ColumnHeader 품목명;
        private System.Windows.Forms.ColumnHeader 수량;
        private System.Windows.Forms.ColumnHeader 단가;
        private System.Windows.Forms.ColumnHeader 비고;
        private System.Windows.Forms.ComboBox DeptCB;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.ColumnHeader 결제상태;
    }
}