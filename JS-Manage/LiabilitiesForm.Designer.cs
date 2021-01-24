namespace JS_Manage
{
    partial class LiabilitiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLiabilities = new System.Windows.Forms.DataGridView();
            this.lbLiabilitiesClosing = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLiabilitiesOpening = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerSelectUserControl1 = new JS_Manage.CustomerSelectUserControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiabilities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÔNG NỢ PHẢI TRẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.customerSelectUserControl1);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Location = new System.Drawing.Point(163, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ --> Đến";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(527, 15);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 2;
            this.btFind.Text = "Xem";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(318, 19);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(110, 19);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewLiabilities);
            this.groupBox2.Location = new System.Drawing.Point(163, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1018, 600);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewLiabilities
            // 
            this.dataGridViewLiabilities.AllowUserToAddRows = false;
            this.dataGridViewLiabilities.AllowUserToDeleteRows = false;
            this.dataGridViewLiabilities.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewLiabilities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLiabilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLiabilities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewLiabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLiabilities.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLiabilities.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.dataGridViewLiabilities.Name = "dataGridViewLiabilities";
            this.dataGridViewLiabilities.Size = new System.Drawing.Size(1012, 581);
            this.dataGridViewLiabilities.TabIndex = 0;
            this.dataGridViewLiabilities.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewLiabilities_MouseClick);
            // 
            // lbLiabilitiesClosing
            // 
            this.lbLiabilitiesClosing.AutoSize = true;
            this.lbLiabilitiesClosing.Location = new System.Drawing.Point(541, 115);
            this.lbLiabilitiesClosing.Name = "lbLiabilitiesClosing";
            this.lbLiabilitiesClosing.Size = new System.Drawing.Size(13, 13);
            this.lbLiabilitiesClosing.TabIndex = 4;
            this.lbLiabilitiesClosing.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số dư đầu kỳ";
            // 
            // lbLiabilitiesOpening
            // 
            this.lbLiabilitiesOpening.AutoSize = true;
            this.lbLiabilitiesOpening.Location = new System.Drawing.Point(245, 115);
            this.lbLiabilitiesOpening.Name = "lbLiabilitiesOpening";
            this.lbLiabilitiesOpening.Size = new System.Drawing.Size(13, 13);
            this.lbLiabilitiesOpening.TabIndex = 2;
            this.lbLiabilitiesOpening.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số dư đầu kỳ";
            // 
            // customerSelectUserControl1
            // 
            this.customerSelectUserControl1.CustId = 0;
            this.customerSelectUserControl1.Location = new System.Drawing.Point(7, 45);
            this.customerSelectUserControl1.Name = "customerSelectUserControl1";
            this.customerSelectUserControl1.Size = new System.Drawing.Size(511, 23);
            this.customerSelectUserControl1.TabIndex = 3;
            this.customerSelectUserControl1.TabIndexCustSelect = 1;
            // 
            // LiabilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 741);
            this.Controls.Add(this.lbLiabilitiesClosing);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbLiabilitiesOpening);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LiabilitiesForm";
            this.Text = "LiabilitiesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiabilities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewLiabilities;
        private System.Windows.Forms.Label label3;
        private CustomerSelectUserControl customerSelectUserControl1;
        private System.Windows.Forms.Label lbLiabilitiesClosing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbLiabilitiesOpening;
        private System.Windows.Forms.Label label2;
    }
}