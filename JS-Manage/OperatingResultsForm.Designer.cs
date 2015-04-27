namespace JS_Manage
{
    partial class OperatingResultsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatingResultsForm));
            this.btFind = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet = new JS_Manage.JSManagementDataSet();
            this.cbBoxSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grvOperationResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerTableAdapter = new JS_Manage.JSManagementDataSetTableAdapters.CustomerTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.supplierSelectUserControl1 = new JS_Manage.SupplierSelectUserControl();
            this.customerSelectUserControl1 = new JS_Manage.CustomerSelectUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOperationResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(106, 233);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(121, 23);
            this.btFind.TabIndex = 90;
            this.btFind.Text = "Search";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.jSManagementDataSet;
            // 
            // jSManagementDataSet
            // 
            this.jSManagementDataSet.DataSetName = "JSManagementDataSet";
            this.jSManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbBoxSize
            // 
            this.cbBoxSize.DisplayMember = "Size";
            this.cbBoxSize.FormattingEnabled = true;
            this.cbBoxSize.Location = new System.Drawing.Point(106, 154);
            this.cbBoxSize.Name = "cbBoxSize";
            this.cbBoxSize.Size = new System.Drawing.Size(54, 21);
            this.cbBoxSize.TabIndex = 60;
            this.cbBoxSize.ValueMember = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Size";
            // 
            // cbBoxBrand
            // 
            this.cbBoxBrand.DisplayMember = "Brand";
            this.cbBoxBrand.FormattingEnabled = true;
            this.cbBoxBrand.Location = new System.Drawing.Point(106, 129);
            this.cbBoxBrand.Name = "cbBoxBrand";
            this.cbBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.cbBoxBrand.TabIndex = 50;
            this.cbBoxBrand.ValueMember = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nhãn hiệu";
            // 
            // cbBoxProductType
            // 
            this.cbBoxProductType.DisplayMember = "ProductType";
            this.cbBoxProductType.FormattingEnabled = true;
            this.cbBoxProductType.ItemHeight = 13;
            this.cbBoxProductType.Location = new System.Drawing.Point(106, 102);
            this.cbBoxProductType.Name = "cbBoxProductType";
            this.cbBoxProductType.Size = new System.Drawing.Size(121, 21);
            this.cbBoxProductType.TabIndex = 40;
            this.cbBoxProductType.ValueMember = "ProductType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Loại Hàng";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(106, 78);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(121, 20);
            this.txtProductCode.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã sản phẩm";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(106, 27);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 10;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(106, 53);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Từ ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Đến ngày";
            // 
            // grvOperationResult
            // 
            this.grvOperationResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvOperationResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOperationResult.Location = new System.Drawing.Point(13, 317);
            this.grvOperationResult.Name = "grvOperationResult";
            this.grvOperationResult.Size = new System.Drawing.Size(1122, 446);
            this.grvOperationResult.TabIndex = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerSelectUserControl1);
            this.groupBox1.Controls.Add(this.supplierSelectUserControl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 256);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo KQHĐKD";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(364, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 256);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo cáo chi tiết";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1122, 49);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            // 
            // supplierSelectUserControl1
            // 
            this.supplierSelectUserControl1.CustId = 0;
            this.supplierSelectUserControl1.Location = new System.Drawing.Point(12, 175);
            this.supplierSelectUserControl1.Name = "supplierSelectUserControl1";
            this.supplierSelectUserControl1.Size = new System.Drawing.Size(545, 23);
            this.supplierSelectUserControl1.TabIndex = 0;
            // 
            // customerSelectUserControl1
            // 
            this.customerSelectUserControl1.CustId = 0;
            this.customerSelectUserControl1.Location = new System.Drawing.Point(12, 198);
            this.customerSelectUserControl1.Name = "customerSelectUserControl1";
            this.customerSelectUserControl1.Size = new System.Drawing.Size(545, 23);
            this.customerSelectUserControl1.TabIndex = 1;
            // 
            // OperatingResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1147, 775);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grvOperationResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.btFind);
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
            this.Name = "OperatingResultsForm";
            this.Text = "Báo cáo kết quả hoạt động kinh doanh";
            this.Load += new System.EventHandler(this.OperatingResultsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OperatingResultsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvOperationResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.ComboBox cbBoxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grvOperationResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private JSManagementDataSet jSManagementDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private JSManagementDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private CustomerSelectUserControl customerSelectUserControl1;
        private SupplierSelectUserControl supplierSelectUserControl1;
    }
}