namespace SoftTeam.Boundary
{
    partial class ItemManagementPage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsedBT = new System.Windows.Forms.Button();
            this.RequireBT = new System.Windows.Forms.Button();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.RemarkTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DelBT = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.ItemLV = new System.Windows.Forms.ListView();
            this.카테고리 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.품목명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.수량 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.비고 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReloadBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsedBT
            // 
            this.UsedBT.Location = new System.Drawing.Point(432, 14);
            this.UsedBT.Name = "UsedBT";
            this.UsedBT.Size = new System.Drawing.Size(77, 19);
            this.UsedBT.TabIndex = 6;
            this.UsedBT.Text = "소모처리";
            this.UsedBT.UseVisualStyleBackColor = true;
            this.UsedBT.Click += new System.EventHandler(this.UsedBT_Click);
            // 
            // RequireBT
            // 
            this.RequireBT.Location = new System.Drawing.Point(515, 14);
            this.RequireBT.Name = "RequireBT";
            this.RequireBT.Size = new System.Drawing.Size(77, 19);
            this.RequireBT.TabIndex = 7;
            this.RequireBT.Text = "추가 주문";
            this.RequireBT.UseVisualStyleBackColor = true;
            this.RequireBT.Click += new System.EventHandler(this.RequireBT_Click);
            // 
            // CategoryCB
            // 
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(32, 13);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(228, 20);
            this.CategoryCB.TabIndex = 8;
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(59, 338);
            this.NameTB.Name = "NameTB";
            this.NameTB.ReadOnly = true;
            this.NameTB.Size = new System.Drawing.Size(228, 21);
            this.NameTB.TabIndex = 9;
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(355, 338);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(69, 21);
            this.AmountTB.TabIndex = 10;
            this.AmountTB.TextChanged += new System.EventHandler(this.AmountTB_TextChanged);
            this.AmountTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTB_KeyPress);
            // 
            // RemarkTB
            // 
            this.RemarkTB.Location = new System.Drawing.Point(464, 338);
            this.RemarkTB.Name = "RemarkTB";
            this.RemarkTB.Size = new System.Drawing.Size(124, 21);
            this.RemarkTB.TabIndex = 11;
            this.RemarkTB.TextChanged += new System.EventHandler(this.RemarkTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "수량";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "품목명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "비고";
            // 
            // DelBT
            // 
            this.DelBT.Location = new System.Drawing.Point(349, 14);
            this.DelBT.Name = "DelBT";
            this.DelBT.Size = new System.Drawing.Size(77, 19);
            this.DelBT.TabIndex = 15;
            this.DelBT.Text = "삭제";
            this.DelBT.UseVisualStyleBackColor = true;
            this.DelBT.Click += new System.EventHandler(this.DelBT_Click);
            // 
            // AddBT
            // 
            this.AddBT.Location = new System.Drawing.Point(266, 14);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(77, 19);
            this.AddBT.TabIndex = 16;
            this.AddBT.Text = "추가";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // ItemLV
            // 
            this.ItemLV.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ItemLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.카테고리,
            this.품목명,
            this.가격,
            this.수량,
            this.비고});
            this.ItemLV.FullRowSelect = true;
            this.ItemLV.HideSelection = false;
            this.ItemLV.LabelWrap = false;
            this.ItemLV.Location = new System.Drawing.Point(-1, 39);
            this.ItemLV.MultiSelect = false;
            this.ItemLV.Name = "ItemLV";
            this.ItemLV.Size = new System.Drawing.Size(602, 293);
            this.ItemLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ItemLV.TabIndex = 17;
            this.ItemLV.UseCompatibleStateImageBehavior = false;
            this.ItemLV.SelectedIndexChanged += new System.EventHandler(this.ItemLV_SelectedIndexChanged);
            // 
            // 카테고리
            // 
            this.카테고리.Text = "카테고리";
            this.카테고리.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.카테고리.Width = 90;
            // 
            // 품목명
            // 
            this.품목명.Text = "품목명";
            this.품목명.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.품목명.Width = 260;
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            this.가격.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 수량
            // 
            this.수량.Text = "수량";
            this.수량.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 비고
            // 
            this.비고.Text = "비고";
            this.비고.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.비고.Width = 70;
            // 
            // ReloadBT
            // 
            this.ReloadBT.Image = global::SoftTeam.Properties.Resources.reload;
            this.ReloadBT.Location = new System.Drawing.Point(6, 12);
            this.ReloadBT.Name = "ReloadBT";
            this.ReloadBT.Size = new System.Drawing.Size(23, 23);
            this.ReloadBT.TabIndex = 18;
            this.ReloadBT.UseVisualStyleBackColor = true;
            this.ReloadBT.Click += new System.EventHandler(this.ReloadBT_Click);
            // 
            // ItemManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 371);
            this.Controls.Add(this.ReloadBT);
            this.Controls.Add(this.ItemLV);
            this.Controls.Add(this.AddBT);
            this.Controls.Add(this.DelBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemarkTB);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.RequireBT);
            this.Controls.Add(this.UsedBT);
            this.Name = "ItemManagementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "소모품 관리";
            this.Load += new System.EventHandler(this.ItemManagementPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UsedBT;
        private System.Windows.Forms.Button RequireBT;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.TextBox RemarkTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DelBT;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.ColumnHeader 품목명;
        private System.Windows.Forms.ColumnHeader 비고;
        private System.Windows.Forms.ColumnHeader 가격;
        private System.Windows.Forms.ColumnHeader 수량;
        public System.Windows.Forms.ListView ItemLV;
        private System.Windows.Forms.ColumnHeader 카테고리;
        private System.Windows.Forms.Button ReloadBT;
    }
}

