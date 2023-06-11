namespace SoftTeam.Boundary
{
    partial class AdminMainPage
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
            this.ItemManagementBT = new System.Windows.Forms.Button();
            this.EquipmentManamentBT = new System.Windows.Forms.Button();
            this.PaymentLogBT = new System.Windows.Forms.Button();
            this.PaymentManagementBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsedLogBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemManagementBT
            // 
            this.ItemManagementBT.Location = new System.Drawing.Point(305, 119);
            this.ItemManagementBT.Name = "ItemManagementBT";
            this.ItemManagementBT.Size = new System.Drawing.Size(137, 73);
            this.ItemManagementBT.TabIndex = 0;
            this.ItemManagementBT.Text = "소모품 관리";
            this.ItemManagementBT.Click += new System.EventHandler(this.ItemManagementBT_Click);
            // 
            // EquipmentManamentBT
            // 
            this.EquipmentManamentBT.Enabled = false;
            this.EquipmentManamentBT.Location = new System.Drawing.Point(450, 119);
            this.EquipmentManamentBT.Name = "EquipmentManamentBT";
            this.EquipmentManamentBT.Size = new System.Drawing.Size(137, 73);
            this.EquipmentManamentBT.TabIndex = 1;
            this.EquipmentManamentBT.Text = "기자재 관리";
            this.EquipmentManamentBT.UseVisualStyleBackColor = true;
            // 
            // PaymentLogBT
            // 
            this.PaymentLogBT.Location = new System.Drawing.Point(450, 198);
            this.PaymentLogBT.Name = "PaymentLogBT";
            this.PaymentLogBT.Size = new System.Drawing.Size(137, 73);
            this.PaymentLogBT.TabIndex = 2;
            this.PaymentLogBT.Text = "결제 기록 확인";
            this.PaymentLogBT.UseVisualStyleBackColor = true;
            this.PaymentLogBT.Click += new System.EventHandler(this.PaymentLogBT_Click);
            // 
            // PaymentManagementBT
            // 
            this.PaymentManagementBT.Location = new System.Drawing.Point(305, 198);
            this.PaymentManagementBT.Name = "PaymentManagementBT";
            this.PaymentManagementBT.Size = new System.Drawing.Size(137, 73);
            this.PaymentManagementBT.TabIndex = 3;
            this.PaymentManagementBT.Text = "결제 처리";
            this.PaymentManagementBT.UseVisualStyleBackColor = true;
            this.PaymentManagementBT.Click += new System.EventHandler(this.PaymentManagementBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "관리자";
            // 
            // UsedLogBT
            // 
            this.UsedLogBT.Location = new System.Drawing.Point(450, 275);
            this.UsedLogBT.Name = "UsedLogBT";
            this.UsedLogBT.Size = new System.Drawing.Size(137, 73);
            this.UsedLogBT.TabIndex = 6;
            this.UsedLogBT.Text = "소모 기록 확인";
            this.UsedLogBT.UseVisualStyleBackColor = true;
            this.UsedLogBT.Click += new System.EventHandler(this.UsedLogBT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 275);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(305, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 73);
            this.button1.TabIndex = 7;
            this.button1.Text = "계정 승인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsedLogBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PaymentManagementBT);
            this.Controls.Add(this.PaymentLogBT);
            this.Controls.Add(this.EquipmentManamentBT);
            this.Controls.Add(this.ItemManagementBT);
            this.Name = "AdminMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ItemManagementBT;
        private System.Windows.Forms.Button EquipmentManamentBT;
        private System.Windows.Forms.Button PaymentLogBT;
        private System.Windows.Forms.Button PaymentManagementBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UsedLogBT;
        private System.Windows.Forms.Button button1;
    }
}