namespace SoftTeam.Boundary
{
    partial class UserMainPage
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
            this.UsedLogBT = new System.Windows.Forms.Button();
            this.PaymentManagementBT = new System.Windows.Forms.Button();
            this.EquipmentManagementBT = new System.Windows.Forms.Button();
            this.ItemManagementBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsedLogBT
            // 
            this.UsedLogBT.Location = new System.Drawing.Point(305, 202);
            this.UsedLogBT.Name = "UsedLogBT";
            this.UsedLogBT.Size = new System.Drawing.Size(137, 73);
            this.UsedLogBT.TabIndex = 12;
            this.UsedLogBT.Text = "소모 기록 확인";
            this.UsedLogBT.UseVisualStyleBackColor = true;
            this.UsedLogBT.Click += new System.EventHandler(this.UsedLogBT_Click);
            // 
            // PaymentManagementBT
            // 
            this.PaymentManagementBT.Location = new System.Drawing.Point(450, 202);
            this.PaymentManagementBT.Name = "PaymentManagementBT";
            this.PaymentManagementBT.Size = new System.Drawing.Size(137, 73);
            this.PaymentManagementBT.TabIndex = 10;
            this.PaymentManagementBT.Text = "결제 기록 확인";
            this.PaymentManagementBT.UseVisualStyleBackColor = true;
            // 
            // EquipmentManagementBT
            // 
            this.EquipmentManagementBT.Enabled = false;
            this.EquipmentManagementBT.Location = new System.Drawing.Point(450, 111);
            this.EquipmentManagementBT.Name = "EquipmentManagementBT";
            this.EquipmentManagementBT.Size = new System.Drawing.Size(137, 73);
            this.EquipmentManagementBT.TabIndex = 9;
            this.EquipmentManagementBT.Text = "기자재 관리";
            this.EquipmentManagementBT.UseVisualStyleBackColor = true;
            // 
            // ItemManagementBT
            // 
            this.ItemManagementBT.Location = new System.Drawing.Point(305, 111);
            this.ItemManagementBT.Name = "ItemManagementBT";
            this.ItemManagementBT.Size = new System.Drawing.Size(137, 73);
            this.ItemManagementBT.TabIndex = 8;
            this.ItemManagementBT.Text = "소모품 관리";
            this.ItemManagementBT.UseVisualStyleBackColor = true;
            this.ItemManagementBT.Click += new System.EventHandler(this.ItemManagementBT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 275);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "사용자";
            // 
            // UserMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsedLogBT);
            this.Controls.Add(this.PaymentManagementBT);
            this.Controls.Add(this.EquipmentManagementBT);
            this.Controls.Add(this.ItemManagementBT);
            this.Name = "UserMainPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UsedLogBT;
        private System.Windows.Forms.Button PaymentManagementBT;
        private System.Windows.Forms.Button EquipmentManagementBT;
        private System.Windows.Forms.Button ItemManagementBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}