﻿namespace SoftTeam.Boundary
{
    partial class UsedLogPage
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.UsedLogLV = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.카테고리 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.품목명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.수량 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.소모부서 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.사유 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeptCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CategoryCB
            // 
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Items.AddRange(new object[] {
            "전체"});
            this.CategoryCB.Location = new System.Drawing.Point(12, 23);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(228, 20);
            this.CategoryCB.TabIndex = 9;
            this.CategoryCB.SelectedValueChanged += new System.EventHandler(this.CategoryCB_SelectedValueChanged);
            // 
            // UsedLogLV
            // 
            this.UsedLogLV.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.UsedLogLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.카테고리,
            this.품목명,
            this.수량,
            this.소모부서,
            this.사유,
            this.날짜});
            this.UsedLogLV.FullRowSelect = true;
            this.UsedLogLV.HideSelection = false;
            this.UsedLogLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.UsedLogLV.Location = new System.Drawing.Point(12, 49);
            this.UsedLogLV.Name = "UsedLogLV";
            this.UsedLogLV.Size = new System.Drawing.Size(739, 339);
            this.UsedLogLV.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.UsedLogLV.TabIndex = 18;
            this.UsedLogLV.UseCompatibleStateImageBehavior = false;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 30;
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
            // 수량
            // 
            this.수량.Text = "수량";
            this.수량.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 소모부서
            // 
            this.소모부서.Text = "소모 부서";
            this.소모부서.Width = 65;
            // 
            // 사유
            // 
            this.사유.Text = "사유";
            this.사유.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.사유.Width = 70;
            // 
            // 날짜
            // 
            this.날짜.Text = "날짜";
            this.날짜.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.날짜.Width = 150;
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
            this.DeptCB.Location = new System.Drawing.Point(265, 23);
            this.DeptCB.Name = "DeptCB";
            this.DeptCB.Size = new System.Drawing.Size(160, 20);
            this.DeptCB.TabIndex = 19;
            this.DeptCB.SelectedIndexChanged += new System.EventHandler(this.DeptCB_SelectedIndexChanged);
            // 
            // UsedLogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 408);
            this.Controls.Add(this.DeptCB);
            this.Controls.Add(this.UsedLogLV);
            this.Controls.Add(this.CategoryCB);
            this.Name = "UsedLogPage";
            this.Load += new System.EventHandler(this.UsedLogPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CategoryCB;
        public System.Windows.Forms.ListView UsedLogLV;
        private System.Windows.Forms.ColumnHeader 카테고리;
        private System.Windows.Forms.ColumnHeader 품목명;
        private System.Windows.Forms.ColumnHeader 날짜;
        private System.Windows.Forms.ColumnHeader 수량;
        private System.Windows.Forms.ColumnHeader 사유;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader 소모부서;
        private System.Windows.Forms.ComboBox DeptCB;
    }
}