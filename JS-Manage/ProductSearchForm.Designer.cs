namespace JS_Manage
{
    partial class ProductSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSearchForm));
            this.txtProductCodeSearch = new System.Windows.Forms.TextBox();
            this.grvProductList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIsInStock = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lbProductId = new System.Windows.Forms.Label();
            this.cbBoxSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputPrice = new System.Windows.Forms.TextBox();
            this.lbInputPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownOpeningBalance = new System.Windows.Forms.NumericUpDown();
            this.btSave = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.numericUpDownInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownOutput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownClosingBalance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvProductInOutDetail = new System.Windows.Forms.DataGridView();
            this.lbProductHeader = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLowStockReport = new System.Windows.Forms.Button();
            this.btCopyProduct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxStoreFind = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxProductTypeFind = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.comboBoxBrandFind = new System.Windows.Forms.ComboBox();
            this.btPrintPreview = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSizeFind = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet = new JS_Manage.JSManagementDataSet();
            this.getProductInOutDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet1 = new JS_Manage.JSManagementDataSet();
            this.productTableAdapter1 = new JS_Manage.JSManagementDataSetTableAdapters.ProductTableAdapter();
            this.getProductInOutDetailTableAdapter = new JS_Manage.JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpeningBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClosingBalance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductInOutDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductInOutDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductCodeSearch
            // 
            this.txtProductCodeSearch.Location = new System.Drawing.Point(92, 275);
            this.txtProductCodeSearch.Name = "txtProductCodeSearch";
            this.txtProductCodeSearch.Size = new System.Drawing.Size(89, 20);
            this.txtProductCodeSearch.TabIndex = 0;
            this.txtProductCodeSearch.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // grvProductList
            // 
            this.grvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductList.Location = new System.Drawing.Point(13, 311);
            this.grvProductList.Name = "grvProductList";
            this.grvProductList.Size = new System.Drawing.Size(1146, 367);
            this.grvProductList.TabIndex = 3;
            this.grvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProductList_CellDoubleClick);
            this.grvProductList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.grvProductList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 278);
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
            this.chkIsInStock.Location = new System.Drawing.Point(614, 17);
            this.chkIsInStock.Name = "chkIsInStock";
            this.chkIsInStock.Size = new System.Drawing.Size(72, 17);
            this.chkIsInStock.TabIndex = 1;
            this.chkIsInStock.Text = "Còn hàng";
            this.chkIsInStock.UseVisualStyleBackColor = true;
            this.chkIsInStock.CheckedChanged += new System.EventHandler(this.chkIsInStock_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã sản phẩm";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(115, 46);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 4;
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(621, 16);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(13, 13);
            this.lbProductId.TabIndex = 8;
            this.lbProductId.Text = "0";
            // 
            // cbBoxSize
            // 
            this.cbBoxSize.DisplayMember = "Size";
            this.cbBoxSize.FormattingEnabled = true;
            this.cbBoxSize.Location = new System.Drawing.Point(423, 69);
            this.cbBoxSize.Name = "cbBoxSize";
            this.cbBoxSize.Size = new System.Drawing.Size(54, 21);
            this.cbBoxSize.TabIndex = 7;
            this.cbBoxSize.ValueMember = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Size";
            // 
            // cbBoxBrand
            // 
            this.cbBoxBrand.DisplayMember = "Brand";
            this.cbBoxBrand.FormattingEnabled = true;
            this.cbBoxBrand.Location = new System.Drawing.Point(275, 70);
            this.cbBoxBrand.Name = "cbBoxBrand";
            this.cbBoxBrand.Size = new System.Drawing.Size(100, 21);
            this.cbBoxBrand.TabIndex = 6;
            this.cbBoxBrand.ValueMember = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nhãn hiệu";
            // 
            // cbBoxProductType
            // 
            this.cbBoxProductType.DisplayMember = "ProductType";
            this.cbBoxProductType.FormattingEnabled = true;
            this.cbBoxProductType.Location = new System.Drawing.Point(115, 70);
            this.cbBoxProductType.Name = "cbBoxProductType";
            this.cbBoxProductType.Size = new System.Drawing.Size(100, 21);
            this.cbBoxProductType.TabIndex = 5;
            this.cbBoxProductType.ValueMember = "ProductType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Loại Hàng";
            // 
            // txtInputPrice
            // 
            this.txtInputPrice.Location = new System.Drawing.Point(560, 69);
            this.txtInputPrice.Name = "txtInputPrice";
            this.txtInputPrice.Size = new System.Drawing.Size(74, 20);
            this.txtInputPrice.TabIndex = 8;
            this.txtInputPrice.Text = "0";
            // 
            // lbInputPrice
            // 
            this.lbInputPrice.AutoSize = true;
            this.lbInputPrice.Location = new System.Drawing.Point(490, 73);
            this.lbInputPrice.Name = "lbInputPrice";
            this.lbInputPrice.Size = new System.Drawing.Size(52, 13);
            this.lbInputPrice.TabIndex = 48;
            this.lbInputPrice.Text = "Giá Nhập";
            this.lbInputPrice.Click += new System.EventHandler(this.lbInputPrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(103, 93);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(101, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtP
            // 
            this.txtP.AutoSize = true;
            this.txtP.Location = new System.Drawing.Point(26, 102);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(44, 13);
            this.txtP.TabIndex = 50;
            this.txtP.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Số dư đầu kỳ";
            // 
            // numericUpDownOpeningBalance
            // 
            this.numericUpDownOpeningBalance.Enabled = false;
            this.numericUpDownOpeningBalance.Location = new System.Drawing.Point(103, 118);
            this.numericUpDownOpeningBalance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOpeningBalance.Name = "numericUpDownOpeningBalance";
            this.numericUpDownOpeningBalance.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownOpeningBalance.TabIndex = 10;
            this.numericUpDownOpeningBalance.Enter += new System.EventHandler(this.numericUpDownOpeningBalance_Enter);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(25, 228);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(188, 228);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(117, 23);
            this.btAddNew.TabIndex = 13;
            this.btAddNew.Text = "&Thêm mã mới";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(106, 228);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "&Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(895, 15);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(82, 23);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Tìm sản phẩm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownInput
            // 
            this.numericUpDownInput.Enabled = false;
            this.numericUpDownInput.Location = new System.Drawing.Point(103, 168);
            this.numericUpDownInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownInput.Name = "numericUpDownInput";
            this.numericUpDownInput.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownInput.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Nhập trong kỳ";
            // 
            // numericUpDownOutput
            // 
            this.numericUpDownOutput.Enabled = false;
            this.numericUpDownOutput.Location = new System.Drawing.Point(103, 144);
            this.numericUpDownOutput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOutput.Name = "numericUpDownOutput";
            this.numericUpDownOutput.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownOutput.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Xuất trong kỳ";
            // 
            // numericUpDownClosingBalance
            // 
            this.numericUpDownClosingBalance.Enabled = false;
            this.numericUpDownClosingBalance.Location = new System.Drawing.Point(103, 192);
            this.numericUpDownClosingBalance.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownClosingBalance.Name = "numericUpDownClosingBalance";
            this.numericUpDownClosingBalance.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownClosingBalance.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 61;
            this.label9.Text = "Tồn cuối kỳ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvProductInOutDetail);
            this.groupBox1.Location = new System.Drawing.Point(667, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 258);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch sử giao dịch";
            // 
            // grvProductInOutDetail
            // 
            this.grvProductInOutDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductInOutDetail.Location = new System.Drawing.Point(14, 19);
            this.grvProductInOutDetail.Name = "grvProductInOutDetail";
            this.grvProductInOutDetail.Size = new System.Drawing.Size(462, 230);
            this.grvProductInOutDetail.TabIndex = 100;
            this.grvProductInOutDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProductInOutDetail_CellDoubleClick);
            // 
            // lbProductHeader
            // 
            this.lbProductHeader.AutoSize = true;
            this.lbProductHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductHeader.Location = new System.Drawing.Point(202, 11);
            this.lbProductHeader.Name = "lbProductHeader";
            this.lbProductHeader.Size = new System.Drawing.Size(51, 20);
            this.lbProductHeader.TabIndex = 5;
            this.lbProductHeader.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLowStockReport);
            this.groupBox2.Controls.Add(this.btCopyProduct);
            this.groupBox2.Controls.Add(this.numericUpDownClosingBalance);
            this.groupBox2.Controls.Add(this.lbProductHeader);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbInputPrice);
            this.groupBox2.Controls.Add(this.numericUpDownOutput);
            this.groupBox2.Controls.Add(this.txtInputPrice);
            this.groupBox2.Controls.Add(this.lbProductId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbBoxBrand);
            this.groupBox2.Controls.Add(this.numericUpDownInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbBoxSize);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownOpeningBalance);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 258);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // btLowStockReport
            // 
            this.btLowStockReport.Location = new System.Drawing.Point(425, 226);
            this.btLowStockReport.Name = "btLowStockReport";
            this.btLowStockReport.Size = new System.Drawing.Size(154, 23);
            this.btLowStockReport.TabIndex = 67;
            this.btLowStockReport.Text = "Báo cáo hàng cần nhập";
            this.btLowStockReport.UseVisualStyleBackColor = true;
            this.btLowStockReport.Visible = false;
            this.btLowStockReport.Click += new System.EventHandler(this.btLowStockReport_Click);
            // 
            // btCopyProduct
            // 
            this.btCopyProduct.Location = new System.Drawing.Point(302, 226);
            this.btCopyProduct.Name = "btCopyProduct";
            this.btCopyProduct.Size = new System.Drawing.Size(117, 23);
            this.btCopyProduct.TabIndex = 66;
            this.btCopyProduct.Text = "&Copy sản phẩm";
            this.btCopyProduct.UseVisualStyleBackColor = true;
            this.btCopyProduct.Click += new System.EventHandler(this.btCopyProduct_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxStoreFind);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBoxProductTypeFind);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btPrint);
            this.groupBox3.Controls.Add(this.comboBoxBrandFind);
            this.groupBox3.Controls.Add(this.btPrintPreview);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btSearch);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBoxSizeFind);
            this.groupBox3.Controls.Add(this.chkIsInStock);
            this.groupBox3.Location = new System.Drawing.Point(12, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1147, 45);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // cboxStoreFind
            // 
            this.cboxStoreFind.FormattingEnabled = true;
            this.cboxStoreFind.Location = new System.Drawing.Point(768, 16);
            this.cboxStoreFind.Name = "cboxStoreFind";
            this.cboxStoreFind.Size = new System.Drawing.Size(121, 21);
            this.cboxStoreFind.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(733, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Kho ";
            // 
            // comboBoxProductTypeFind
            // 
            this.comboBoxProductTypeFind.DisplayMember = "ProductType";
            this.comboBoxProductTypeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductTypeFind.FormattingEnabled = true;
            this.comboBoxProductTypeFind.Location = new System.Drawing.Point(236, 15);
            this.comboBoxProductTypeFind.Name = "comboBoxProductTypeFind";
            this.comboBoxProductTypeFind.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProductTypeFind.TabIndex = 66;
            this.comboBoxProductTypeFind.ValueMember = "ProductType";
            this.comboBoxProductTypeFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductTypeFind_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Loại Hàng";
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(1068, 14);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(72, 23);
            this.btPrint.TabIndex = 1;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // comboBoxBrandFind
            // 
            this.comboBoxBrandFind.DisplayMember = "Brand";
            this.comboBoxBrandFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrandFind.FormattingEnabled = true;
            this.comboBoxBrandFind.Location = new System.Drawing.Point(396, 15);
            this.comboBoxBrandFind.Name = "comboBoxBrandFind";
            this.comboBoxBrandFind.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBrandFind.TabIndex = 67;
            this.comboBoxBrandFind.ValueMember = "Brand";
            this.comboBoxBrandFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrandFind_SelectedIndexChanged);
            // 
            // btPrintPreview
            // 
            this.btPrintPreview.Location = new System.Drawing.Point(983, 14);
            this.btPrintPreview.Name = "btPrintPreview";
            this.btPrintPreview.Size = new System.Drawing.Size(79, 23);
            this.btPrintPreview.TabIndex = 0;
            this.btPrintPreview.Text = "Print Preview";
            this.btPrintPreview.UseVisualStyleBackColor = true;
            this.btPrintPreview.Click += new System.EventHandler(this.btPrintPreview_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Nhãn hiệu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(505, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Size";
            // 
            // comboBoxSizeFind
            // 
            this.comboBoxSizeFind.DisplayMember = "Size";
            this.comboBoxSizeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSizeFind.FormattingEnabled = true;
            this.comboBoxSizeFind.Location = new System.Drawing.Point(542, 14);
            this.comboBoxSizeFind.Name = "comboBoxSizeFind";
            this.comboBoxSizeFind.Size = new System.Drawing.Size(54, 21);
            this.comboBoxSizeFind.TabIndex = 68;
            this.comboBoxSizeFind.ValueMember = "Size";
            this.comboBoxSizeFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeFind_SelectedIndexChanged);
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
            // ProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1164, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.cbBoxProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvProductList);
            this.Controls.Add(this.txtProductCodeSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ProductSearchForm";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductSearchForm_KeyDown);
            this.Resize += new System.EventHandler(this.ProductSearchForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpeningBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClosingBalance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvProductInOutDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductInOutDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCodeSearch;
        private System.Windows.Forms.DataGridView grvProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsInStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.ComboBox cbBoxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputPrice;
        private System.Windows.Forms.Label lbInputPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label txtP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownOpeningBalance;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSearch;
        private JSManagementDataSet jSManagementDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.NumericUpDown numericUpDownInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownClosingBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvProductInOutDetail;
        private System.Windows.Forms.BindingSource getProductInOutDetailBindingSource;
        private JSManagementDataSet jSManagementDataSet1;
        private JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter getProductInOutDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingBallanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbProductHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btCopyProduct;
        private System.Windows.Forms.Button btPrintPreview;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.ComboBox comboBoxProductTypeFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxBrandFind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSizeFind;
        private System.Windows.Forms.Button btLowStockReport;
        private System.Windows.Forms.ComboBox cboxStoreFind;
        private System.Windows.Forms.Label label13;
    }
}

