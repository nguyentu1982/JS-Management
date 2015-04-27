namespace JS_Manage
{
    partial class AdminTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminTaskForm));
            this.btOpeningBalance = new System.Windows.Forms.Button();
            this.btActiveDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRewardPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpeningBalance
            // 
            this.btOpeningBalance.Location = new System.Drawing.Point(47, 103);
            this.btOpeningBalance.Name = "btOpeningBalance";
            this.btOpeningBalance.Size = new System.Drawing.Size(146, 27);
            this.btOpeningBalance.TabIndex = 4;
            this.btOpeningBalance.Text = "Nhập số dư đầu kỳ";
            this.btOpeningBalance.UseVisualStyleBackColor = true;
            this.btOpeningBalance.Click += new System.EventHandler(this.btOpeningBalance_Click);
            // 
            // btActiveDate
            // 
            this.btActiveDate.Location = new System.Drawing.Point(47, 73);
            this.btActiveDate.Name = "btActiveDate";
            this.btActiveDate.Size = new System.Drawing.Size(146, 28);
            this.btActiveDate.TabIndex = 2;
            this.btActiveDate.Text = "Kích hoạt ngày nhập liệu";
            this.btActiveDate.UseVisualStyleBackColor = true;
            this.btActiveDate.Click += new System.EventHandler(this.btActiveDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CẤU HÌNH HỆ THỐNG";
            // 
            // btRewardPoint
            // 
            this.btRewardPoint.Location = new System.Drawing.Point(47, 132);
            this.btRewardPoint.Name = "btRewardPoint";
            this.btRewardPoint.Size = new System.Drawing.Size(146, 26);
            this.btRewardPoint.TabIndex = 5;
            this.btRewardPoint.Text = "Điểm thưởng";
            this.btRewardPoint.UseVisualStyleBackColor = true;
            this.btRewardPoint.Click += new System.EventHandler(this.btRewardPoint_Click);
            // 
            // AdminTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(632, 262);
            this.Controls.Add(this.btRewardPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btActiveDate);
            this.Controls.Add(this.btOpeningBalance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AdminTaskForm";
            this.Text = "Cấu hình hệ thống";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminTaskForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpeningBalance;
        private System.Windows.Forms.Button btActiveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRewardPoint;
    }
}