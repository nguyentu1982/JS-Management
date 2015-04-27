namespace JS_Manage
{
    partial class CashManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashManagementForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerCashFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCashTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btView = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvCashSumary = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCashOpeningBallance = new System.Windows.Forms.Label();
            this.groupBoxIncome = new System.Windows.Forms.GroupBox();
            this.gridViewCashDetail = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelCreateIncome = new System.Windows.Forms.LinkLabel();
            this.linkLabelCreateCost = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCashSumary)).BeginInit();
            this.groupBoxIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCashDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // dateTimePickerCashFrom
            // 
            this.dateTimePickerCashFrom.Location = new System.Drawing.Point(43, 12);
            this.dateTimePickerCashFrom.Name = "dateTimePickerCashFrom";
            this.dateTimePickerCashFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCashFrom.TabIndex = 1;
            // 
            // dateTimePickerCashTo
            // 
            this.dateTimePickerCashTo.Location = new System.Drawing.Point(292, 12);
            this.dateTimePickerCashTo.Name = "dateTimePickerCashTo";
            this.dateTimePickerCashTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCashTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // btView
            // 
            this.btView.Location = new System.Drawing.Point(499, 9);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(75, 23);
            this.btView.TabIndex = 4;
            this.btView.Text = "Xem";
            this.btView.UseVisualStyleBackColor = true;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerCashFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btView);
            this.groupBox1.Controls.Add(this.dateTimePickerCashTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(181, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 39);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // grvCashSumary
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grvCashSumary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvCashSumary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCashSumary.Location = new System.Drawing.Point(181, 96);
            this.grvCashSumary.Name = "grvCashSumary";
            this.grvCashSumary.Size = new System.Drawing.Size(450, 454);
            this.grvCashSumary.TabIndex = 6;
            this.grvCashSumary.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCashSumary_CellEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số dư đầu kỳ";
            this.label3.Visible = false;
            // 
            // lbCashOpeningBallance
            // 
            this.lbCashOpeningBallance.AutoSize = true;
            this.lbCashOpeningBallance.Location = new System.Drawing.Point(258, 75);
            this.lbCashOpeningBallance.Name = "lbCashOpeningBallance";
            this.lbCashOpeningBallance.Size = new System.Drawing.Size(13, 13);
            this.lbCashOpeningBallance.TabIndex = 8;
            this.lbCashOpeningBallance.Text = "0";
            this.lbCashOpeningBallance.Visible = false;
            // 
            // groupBoxIncome
            // 
            this.groupBoxIncome.Controls.Add(this.gridViewCashDetail);
            this.groupBoxIncome.Location = new System.Drawing.Point(639, 77);
            this.groupBoxIncome.Name = "groupBoxIncome";
            this.groupBoxIncome.Size = new System.Drawing.Size(470, 473);
            this.groupBoxIncome.TabIndex = 9;
            this.groupBoxIncome.TabStop = false;
            this.groupBoxIncome.Text = "Chi tiết giao dịch theo ngày";
            // 
            // gridViewCashDetail
            // 
            this.gridViewCashDetail.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridViewCashDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewCashDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewCashDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCashDetail.Location = new System.Drawing.Point(10, 19);
            this.gridViewCashDetail.Name = "gridViewCashDetail";
            this.gridViewCashDetail.Size = new System.Drawing.Size(450, 450);
            this.gridViewCashDetail.TabIndex = 0;
            this.gridViewCashDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCashDetail_CellDoubleClick);
            this.gridViewCashDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridViewCashDetail_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "QUẢN LÝ TIỀN MĂT";
            // 
            // linkLabelCreateIncome
            // 
            this.linkLabelCreateIncome.AutoSize = true;
            this.linkLabelCreateIncome.Location = new System.Drawing.Point(17, 98);
            this.linkLabelCreateIncome.Name = "linkLabelCreateIncome";
            this.linkLabelCreateIncome.Size = new System.Drawing.Size(121, 13);
            this.linkLabelCreateIncome.TabIndex = 12;
            this.linkLabelCreateIncome.TabStop = true;
            this.linkLabelCreateIncome.Text = "Tạo phiếu THU tiền mặt";
            this.linkLabelCreateIncome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateIncome_LinkClicked);
            // 
            // linkLabelCreateCost
            // 
            this.linkLabelCreateCost.AutoSize = true;
            this.linkLabelCreateCost.Location = new System.Drawing.Point(17, 122);
            this.linkLabelCreateCost.Name = "linkLabelCreateCost";
            this.linkLabelCreateCost.Size = new System.Drawing.Size(116, 13);
            this.linkLabelCreateCost.TabIndex = 13;
            this.linkLabelCreateCost.TabStop = true;
            this.linkLabelCreateCost.Text = "Tạo phiếu CHI tiền mặt";
            this.linkLabelCreateCost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateCost_LinkClicked);
            // 
            // CashManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1164, 562);
            this.Controls.Add(this.linkLabelCreateCost);
            this.Controls.Add(this.linkLabelCreateIncome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxIncome);
            this.Controls.Add(this.lbCashOpeningBallance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grvCashSumary);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CashManagementForm";
            this.Text = "CashManagementForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashManagementForm_KeyDown);
            this.Resize += new System.EventHandler(this.CashManagementForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCashSumary)).EndInit();
            this.groupBoxIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCashDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCashFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerCashTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvCashSumary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCashOpeningBallance;
        private System.Windows.Forms.GroupBox groupBoxIncome;
        private System.Windows.Forms.DataGridView gridViewCashDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelCreateIncome;
        private System.Windows.Forms.LinkLabel linkLabelCreateCost;
    }
}