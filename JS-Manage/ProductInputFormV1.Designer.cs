namespace JS_Manage
{
    partial class productInputFormV1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productInputForm));
            this.lbInputHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.btFindSupplier = new System.Windows.Forms.Button();
            this.lbCustomerInfo = new System.Windows.Forms.Label();
            this.btFindProduct = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.Label();
            this.cbBoxSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBoxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grvInputProduct = new System.Windows.Forms.DataGridView();
            this.productInputIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInputProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet = new JS_Manage.JSManagementDataSet();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtInputPrice = new System.Windows.Forms.TextBox();
            this.lbInputPrice = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbProductInputId = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.productInput_ProductTableAdapter = new JS_Manage.JSManagementDataSetTableAdapters.ProductInput_ProductTableAdapter();
            this.btCopyProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvInputProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInputProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInputHeader
            // 
            this.lbInputHeader.AutoSize = true;
            this.lbInputHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputHeader.Location = new System.Drawing.Point(436, 23);
            this.lbInputHeader.Name = "lbInputHeader";
            this.lbInputHeader.Size = new System.Drawing.Size(119, 25);
            this.lbInputHeader.TabIndex = 0;
            this.lbInputHeader.Text = "InputHeader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(445, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà Cung cấp";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(445, 86);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCode.TabIndex = 1;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // btFindSupplier
            // 
            this.btFindSupplier.Location = new System.Drawing.Point(552, 83);
            this.btFindSupplier.Name = "btFindSupplier";
            this.btFindSupplier.Size = new System.Drawing.Size(23, 23);
            this.btFindSupplier.TabIndex = 2;
            this.btFindSupplier.Text = ">";
            this.btFindSupplier.UseVisualStyleBackColor = true;
            this.btFindSupplier.Click += new System.EventHandler(this.btFindSupplier_Click);
            // 
            // lbCustomerInfo
            // 
            this.lbCustomerInfo.AutoSize = true;
            this.lbCustomerInfo.Location = new System.Drawing.Point(304, 89);
            this.lbCustomerInfo.Name = "lbCustomerInfo";
            this.lbCustomerInfo.Size = new System.Drawing.Size(63, 13);
            this.lbCustomerInfo.TabIndex = 6;
            this.lbCustomerInfo.Text = "SupplierInfo";
            // 
            // btFindProduct
            // 
            this.btFindProduct.Location = new System.Drawing.Point(552, 108);
            this.btFindProduct.Name = "btFindProduct";
            this.btFindProduct.Size = new System.Drawing.Size(22, 23);
            this.btFindProduct.TabIndex = 4;
            this.btFindProduct.Text = ">";
            this.btFindProduct.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(445, 218);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownQuantity.TabIndex = 8;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(445, 246);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(64, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // txtP
            // 
            this.txtP.AutoSize = true;
            this.txtP.Location = new System.Drawing.Point(342, 253);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(44, 13);
            this.txtP.TabIndex = 38;
            this.txtP.Text = "Giá bán";
            // 
            // cbBoxSize
            // 
            this.cbBoxSize.DisplayMember = "Size";
            this.cbBoxSize.FormattingEnabled = true;
            this.cbBoxSize.Location = new System.Drawing.Point(445, 192);
            this.cbBoxSize.Name = "cbBoxSize";
            this.cbBoxSize.Size = new System.Drawing.Size(54, 21);
            this.cbBoxSize.TabIndex = 7;
            this.cbBoxSize.ValueMember = "Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Số lượng";
            // 
            // cbBoxBrand
            // 
            this.cbBoxBrand.DisplayMember = "Brand";
            this.cbBoxBrand.FormattingEnabled = true;
            this.cbBoxBrand.Location = new System.Drawing.Point(445, 165);
            this.cbBoxBrand.Name = "cbBoxBrand";
            this.cbBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.cbBoxBrand.TabIndex = 6;
            this.cbBoxBrand.ValueMember = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nhãn hiệu";
            // 
            // cbBoxProductType
            // 
            this.cbBoxProductType.DisplayMember = "ProductType";
            this.cbBoxProductType.FormattingEnabled = true;
            this.cbBoxProductType.Location = new System.Drawing.Point(445, 138);
            this.cbBoxProductType.Name = "cbBoxProductType";
            this.cbBoxProductType.Size = new System.Drawing.Size(121, 21);
            this.cbBoxProductType.TabIndex = 5;
            this.cbBoxProductType.ValueMember = "ProductType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Loại Hàng";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(445, 112);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Mã Hàng";
            // 
            // grvInputProduct
            // 
            this.grvInputProduct.AutoGenerateColumns = false;
            this.grvInputProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvInputProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productInputIdDataGridViewTextBoxColumn,
            this.inputDateDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.grvInputProduct.DataSource = this.productInputProductBindingSource;
            this.grvInputProduct.Location = new System.Drawing.Point(15, 312);
            this.grvInputProduct.Name = "grvInputProduct";
            this.grvInputProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvInputProduct.Size = new System.Drawing.Size(1130, 432);
            this.grvInputProduct.TabIndex = 14;
            this.grvInputProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInputProduct_CellClick);
            this.grvInputProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInputProduct_CellEnter);
            // 
            // productInputIdDataGridViewTextBoxColumn
            // 
            this.productInputIdDataGridViewTextBoxColumn.DataPropertyName = "ProductInputId";
            this.productInputIdDataGridViewTextBoxColumn.HeaderText = "ProductInputId";
            this.productInputIdDataGridViewTextBoxColumn.Name = "productInputIdDataGridViewTextBoxColumn";
            this.productInputIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputDateDataGridViewTextBoxColumn
            // 
            this.inputDateDataGridViewTextBoxColumn.DataPropertyName = "InputDate";
            this.inputDateDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.inputDateDataGridViewTextBoxColumn.Name = "inputDateDataGridViewTextBoxColumn";
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "NCC";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Loại SP";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Hiệu";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productInputProductBindingSource
            // 
            this.productInputProductBindingSource.DataMember = "ProductInput_Product";
            this.productInputProductBindingSource.DataSource = this.jSManagementDataSet;
            // 
            // jSManagementDataSet
            // 
            this.jSManagementDataSet.DataSetName = "JSManagementDataSet";
            this.jSManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(598, 272);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(117, 23);
            this.btAddNew.TabIndex = 13;
            this.btAddNew.Text = "Tiếp tục nhập hàng";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Visible = false;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(516, 273);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 12;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(444, 274);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 23);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtInputPrice
            // 
            this.txtInputPrice.Location = new System.Drawing.Point(581, 219);
            this.txtInputPrice.Name = "txtInputPrice";
            this.txtInputPrice.Size = new System.Drawing.Size(74, 20);
            this.txtInputPrice.TabIndex = 9;
            this.txtInputPrice.Text = "0";
            // 
            // lbInputPrice
            // 
            this.lbInputPrice.AutoSize = true;
            this.lbInputPrice.Location = new System.Drawing.Point(522, 225);
            this.lbInputPrice.Name = "lbInputPrice";
            this.lbInputPrice.Size = new System.Drawing.Size(52, 13);
            this.lbInputPrice.TabIndex = 46;
            this.lbInputPrice.Text = "Giá Nhập";
            this.lbInputPrice.Click += new System.EventHandler(this.lbInputPrice_Click);
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(581, 117);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(35, 13);
            this.lbProductID.TabIndex = 48;
            this.lbProductID.Text = "label9";
            this.lbProductID.TextChanged += new System.EventHandler(this.lbProductID_TextChanged);
            // 
            // lbProductInputId
            // 
            this.lbProductInputId.AutoSize = true;
            this.lbProductInputId.Location = new System.Drawing.Point(609, 22);
            this.lbProductInputId.Name = "lbProductInputId";
            this.lbProductInputId.Size = new System.Drawing.Size(13, 13);
            this.lbProductInputId.TabIndex = 50;
            this.lbProductInputId.Text = "0";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(522, 249);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(35, 13);
            this.lbPrice.TabIndex = 51;
            this.lbPrice.Text = "label8";
            this.lbPrice.Visible = false;
            // 
            // productInput_ProductTableAdapter
            // 
            this.productInput_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // btCopyProduct
            // 
            this.btCopyProduct.Location = new System.Drawing.Point(721, 272);
            this.btCopyProduct.Name = "btCopyProduct";
            this.btCopyProduct.Size = new System.Drawing.Size(117, 23);
            this.btCopyProduct.TabIndex = 52;
            this.btCopyProduct.Text = "Copy SP";
            this.btCopyProduct.UseVisualStyleBackColor = true;
            this.btCopyProduct.Visible = false;
            this.btCopyProduct.Click += new System.EventHandler(this.btCopyProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCustomerInfo);
            this.groupBox1.Location = new System.Drawing.Point(305, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 302);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JS_Manage.Properties.Resources.jeans_style_flying;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // productInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1157, 764);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCopyProduct);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbProductInputId);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.txtInputPrice);
            this.Controls.Add(this.lbInputPrice);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.grvInputProduct);
            this.Controls.Add(this.btFindProduct);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.cbBoxSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBoxBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btFindSupplier);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbInputHeader);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "productInputForm";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.ProductInputForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productInputForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvInputProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInputProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInputHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Button btFindSupplier;
        private System.Windows.Forms.Label lbCustomerInfo;
        private System.Windows.Forms.Button btFindProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label txtP;
        private System.Windows.Forms.ComboBox cbBoxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grvInputProduct;
        
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txtInputPrice;
        private System.Windows.Forms.Label lbInputPrice;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbProductInputId;
        private System.Windows.Forms.Label lbPrice;
        private JSManagementDataSet jSManagementDataSet;
        private System.Windows.Forms.BindingSource productInputProductBindingSource;
        private JSManagementDataSetTableAdapters.ProductInput_ProductTableAdapter productInput_ProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInputIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btCopyProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}