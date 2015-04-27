namespace JS_Manage
{
    partial class ProductReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductReportForm));
            this.cbBoxSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.grvProductReport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxSize
            // 
            this.cbBoxSize.DisplayMember = "Size";
            this.cbBoxSize.FormattingEnabled = true;
            this.cbBoxSize.Location = new System.Drawing.Point(132, 161);
            this.cbBoxSize.Name = "cbBoxSize";
            this.cbBoxSize.Size = new System.Drawing.Size(54, 21);
            this.cbBoxSize.TabIndex = 9;
            this.cbBoxSize.ValueMember = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Size";
            // 
            // cbBoxBrand
            // 
            this.cbBoxBrand.DisplayMember = "Brand";
            this.cbBoxBrand.FormattingEnabled = true;
            this.cbBoxBrand.Location = new System.Drawing.Point(132, 136);
            this.cbBoxBrand.Name = "cbBoxBrand";
            this.cbBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.cbBoxBrand.TabIndex = 7;
            this.cbBoxBrand.ValueMember = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nhãn hiệu";
            // 
            // cbBoxProductType
            // 
            this.cbBoxProductType.DisplayMember = "ProductType";
            this.cbBoxProductType.FormattingEnabled = true;
            this.cbBoxProductType.Location = new System.Drawing.Point(132, 109);
            this.cbBoxProductType.Name = "cbBoxProductType";
            this.cbBoxProductType.Size = new System.Drawing.Size(121, 21);
            this.cbBoxProductType.TabIndex = 5;
            this.cbBoxProductType.ValueMember = "ProductType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Loại Hàng";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(132, 85);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(121, 20);
            this.txtProductCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mã sản phẩm";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DisplayMember = "Size";
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(132, 187);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbSupplier.TabIndex = 11;
            this.cbSupplier.ValueMember = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "NCC";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(132, 227);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(121, 23);
            this.btFind.TabIndex = 13;
            this.btFind.Text = "Search";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // grvProductReport
            // 
            this.grvProductReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductReport.Location = new System.Drawing.Point(12, 269);
            this.grvProductReport.Name = "grvProductReport";
            this.grvProductReport.Size = new System.Drawing.Size(829, 438);
            this.grvProductReport.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePickerEndDate);
            this.groupBox1.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 257);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo NXT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Từ ngày";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(120, 53);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 1;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(120, 26);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            // 
            // ProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(850, 731);
            this.Controls.Add(this.grvProductReport);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBoxSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBoxBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ProductReportForm";
            this.Text = "Báo cáo NXT";
            this.Load += new System.EventHandler(this.ProductReportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductReportForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.DataGridView grvProductReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
    }
}