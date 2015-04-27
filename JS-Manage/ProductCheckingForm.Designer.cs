namespace JS_Manage
{
    partial class ProductCheckingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCheckingForm));
            this.txtProductCodeSearch = new System.Windows.Forms.TextBox();
            this.grvProductList = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet = new JS_Manage.JSManagementDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsInStock = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvProductInOutDetail = new System.Windows.Forms.DataGridView();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingBallanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getProductInOutDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet1 = new JS_Manage.JSManagementDataSet();
            this.productTableAdapter1 = new JS_Manage.JSManagementDataSetTableAdapters.ProductTableAdapter();
            this.getProductInOutDetailTableAdapter = new JS_Manage.JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btPrint = new System.Windows.Forms.Button();
            this.btPrintPreview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerProductChecking = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductInOutDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductInOutDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductCodeSearch
            // 
            this.txtProductCodeSearch.Location = new System.Drawing.Point(92, 270);
            this.txtProductCodeSearch.Name = "txtProductCodeSearch";
            this.txtProductCodeSearch.Size = new System.Drawing.Size(158, 20);
            this.txtProductCodeSearch.TabIndex = 0;
            this.txtProductCodeSearch.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // grvProductList
            // 
            this.grvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductList.Location = new System.Drawing.Point(13, 305);
            this.grvProductList.Name = "grvProductList";
            this.grvProductList.Size = new System.Drawing.Size(1011, 367);
            this.grvProductList.TabIndex = 3;
            this.grvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grvProductList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.jSManagementDataSet;
            // 
            // jSManagementDataSet
            // 
            this.jSManagementDataSet.DataSetName = "JSManagementDataSet";
            this.jSManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sản phẩm";
            // 
            // chkIsInStock
            // 
            this.chkIsInStock.AutoSize = true;
            this.chkIsInStock.Checked = true;
            this.chkIsInStock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsInStock.Location = new System.Drawing.Point(257, 272);
            this.chkIsInStock.Name = "chkIsInStock";
            this.chkIsInStock.Size = new System.Drawing.Size(72, 17);
            this.chkIsInStock.TabIndex = 1;
            this.chkIsInStock.Text = "Còn hàng";
            this.chkIsInStock.UseVisualStyleBackColor = true;
            this.chkIsInStock.CheckedChanged += new System.EventHandler(this.chkIsInStock_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvProductInOutDetail);
            this.groupBox1.Location = new System.Drawing.Point(564, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 258);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử giao dịch";
            // 
            // grvProductInOutDetail
            // 
            this.grvProductInOutDetail.AutoGenerateColumns = false;
            this.grvProductInOutDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductInOutDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.closingBallanceDataGridViewTextBoxColumn});
            this.grvProductInOutDetail.DataSource = this.getProductInOutDetailBindingSource;
            this.grvProductInOutDetail.Location = new System.Drawing.Point(6, 19);
            this.grvProductInOutDetail.Name = "grvProductInOutDetail";
            this.grvProductInOutDetail.Size = new System.Drawing.Size(445, 230);
            this.grvProductInOutDetail.TabIndex = 100;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Nhập/Xuất";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // closingBallanceDataGridViewTextBoxColumn
            // 
            this.closingBallanceDataGridViewTextBoxColumn.DataPropertyName = "ClosingBallance";
            this.closingBallanceDataGridViewTextBoxColumn.HeaderText = "Tồn";
            this.closingBallanceDataGridViewTextBoxColumn.Name = "closingBallanceDataGridViewTextBoxColumn";
            // 
            // getProductInOutDetailBindingSource
            // 
            this.getProductInOutDetailBindingSource.DataMember = "GetProductInOutDetail";
            this.getProductInOutDetailBindingSource.DataSource = this.jSManagementDataSet1;
            // 
            // jSManagementDataSet1
            // 
            this.jSManagementDataSet1.DataSetName = "JSManagementDataSet";
            this.jSManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // getProductInOutDetailTableAdapter
            // 
            this.getProductInOutDetailTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btPrint);
            this.groupBox3.Controls.Add(this.btPrintPreview);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1012, 36);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(934, 10);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(72, 23);
            this.btPrint.TabIndex = 1;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btPrintPreview
            // 
            this.btPrintPreview.Location = new System.Drawing.Point(810, 9);
            this.btPrintPreview.Name = "btPrintPreview";
            this.btPrintPreview.Size = new System.Drawing.Size(118, 23);
            this.btPrintPreview.TabIndex = 0;
            this.btPrintPreview.Text = "Print Preview";
            this.btPrintPreview.UseVisualStyleBackColor = true;
            this.btPrintPreview.Click += new System.EventHandler(this.btPrintPreview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Kiểm hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ngày";
            // 
            // dateTimePickerProductChecking
            // 
            this.dateTimePickerProductChecking.Location = new System.Drawing.Point(64, 231);
            this.dateTimePickerProductChecking.Name = "dateTimePickerProductChecking";
            this.dateTimePickerProductChecking.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerProductChecking.TabIndex = 68;
            this.dateTimePickerProductChecking.ValueChanged += new System.EventHandler(this.dateTimePickerProductChecking_ValueChanged);
            // 
            // ProductCheckingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1173, 684);
            this.Controls.Add(this.dateTimePickerProductChecking);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkIsInStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvProductList);
            this.Controls.Add(this.txtProductCodeSearch);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ProductCheckingForm";
            this.Text = "Kiểm hàng";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductSearchForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductInOutDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductInOutDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCodeSearch;
        private System.Windows.Forms.DataGridView grvProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsInStock;
        private JSManagementDataSet jSManagementDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvProductInOutDetail;
        private System.Windows.Forms.BindingSource getProductInOutDetailBindingSource;
        private JSManagementDataSet jSManagementDataSet1;
        private JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter getProductInOutDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingBallanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btPrintPreview;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerProductChecking;
    }
}

