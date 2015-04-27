namespace JS_Manage
{
    partial class productOutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productOutputForm));
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFindCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBoxProductType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.chkIsCOD = new System.Windows.Forms.CheckBox();
            this.grvOrders = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCODDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet = new JS_Manage.JSManagementDataSet();
            this.btSave = new System.Windows.Forms.Button();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.lbOrderHeader = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCustomerInfo = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.ordersTableAdapter1 = new JS_Manage.JSManagementDataSetTableAdapters.OrdersTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(417, 56);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrderDate.TabIndex = 0;
            this.dateTimePickerOrderDate.ValueChanged += new System.EventHandler(this.dateTimePickerOrderDate_ValueChanged);
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(417, 82);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCode.TabIndex = 1;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách hàng";
            // 
            // btFindCustomer
            // 
            this.btFindCustomer.Location = new System.Drawing.Point(524, 79);
            this.btFindCustomer.Name = "btFindCustomer";
            this.btFindCustomer.Size = new System.Drawing.Size(22, 23);
            this.btFindCustomer.TabIndex = 2;
            this.btFindCustomer.Text = ">";
            this.btFindCustomer.UseVisualStyleBackColor = true;
            this.btFindCustomer.Click += new System.EventHandler(this.btFindCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Hàng";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(417, 106);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 3;
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại Hàng";
            // 
            // cbBoxProductType
            // 
            this.cbBoxProductType.DisplayMember = "ProductType";
            this.cbBoxProductType.Enabled = false;
            this.cbBoxProductType.FormattingEnabled = true;
            this.cbBoxProductType.Location = new System.Drawing.Point(417, 132);
            this.cbBoxProductType.Name = "cbBoxProductType";
            this.cbBoxProductType.Size = new System.Drawing.Size(121, 21);
            this.cbBoxProductType.TabIndex = 5;
            this.cbBoxProductType.ValueMember = "ProductType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhãn hiệu";
            // 
            // cbBoxBrand
            // 
            this.cbBoxBrand.DisplayMember = "Brand";
            this.cbBoxBrand.Enabled = false;
            this.cbBoxBrand.FormattingEnabled = true;
            this.cbBoxBrand.Location = new System.Drawing.Point(417, 159);
            this.cbBoxBrand.Name = "cbBoxBrand";
            this.cbBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.cbBoxBrand.TabIndex = 6;
            this.cbBoxBrand.ValueMember = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Size";
            // 
            // cbBoxSize
            // 
            this.cbBoxSize.DisplayMember = "Size";
            this.cbBoxSize.Enabled = false;
            this.cbBoxSize.FormattingEnabled = true;
            this.cbBoxSize.Location = new System.Drawing.Point(417, 186);
            this.cbBoxSize.Name = "cbBoxSize";
            this.cbBoxSize.Size = new System.Drawing.Size(54, 21);
            this.cbBoxSize.TabIndex = 7;
            this.cbBoxSize.ValueMember = "Size";
            this.cbBoxSize.SelectedIndexChanged += new System.EventHandler(this.cbBoxSize_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(518, 188);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 13);
            this.lbPrice.TabIndex = 16;
            this.lbPrice.Text = "Giá bán";
            // 
            // txtP
            // 
            this.txtP.AutoSize = true;
            this.txtP.Location = new System.Drawing.Point(317, 247);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(44, 13);
            this.txtP.TabIndex = 17;
            this.txtP.Text = "Giá bán";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(417, 240);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(64, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã vận đơn";
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(417, 266);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(129, 20);
            this.txtBillNumber.TabIndex = 10;
            // 
            // chkIsCOD
            // 
            this.chkIsCOD.AutoSize = true;
            this.chkIsCOD.Location = new System.Drawing.Point(569, 268);
            this.chkIsCOD.Name = "chkIsCOD";
            this.chkIsCOD.Size = new System.Drawing.Size(113, 17);
            this.chkIsCOD.TabIndex = 11;
            this.chkIsCOD.Text = "Thu tiền sau/COD";
            this.chkIsCOD.UseVisualStyleBackColor = true;
            // 
            // grvOrders
            // 
            this.grvOrders.AutoGenerateColumns = false;
            this.grvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Amount,
            this.billNumberDataGridViewTextBoxColumn,
            this.isCODDataGridViewCheckBoxColumn,
            this.productIDDataGridViewTextBoxColumn});
            this.grvOrders.DataSource = this.ordersBindingSource;
            this.grvOrders.Location = new System.Drawing.Point(12, 331);
            this.grvOrders.Name = "grvOrders";
            this.grvOrders.Size = new System.Drawing.Size(1025, 418);
            this.grvOrders.TabIndex = 15;
            this.grvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOrders_CellClick);
            this.grvOrders.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOrders_CellEnter);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Ngày xuất";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Width = 50;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 70;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Thành Tiền";
            this.Amount.Name = "Amount";
            // 
            // billNumberDataGridViewTextBoxColumn
            // 
            this.billNumberDataGridViewTextBoxColumn.DataPropertyName = "BillNumber";
            this.billNumberDataGridViewTextBoxColumn.HeaderText = "Mã vận đơn";
            this.billNumberDataGridViewTextBoxColumn.Name = "billNumberDataGridViewTextBoxColumn";
            // 
            // isCODDataGridViewCheckBoxColumn
            // 
            this.isCODDataGridViewCheckBoxColumn.DataPropertyName = "IsCOD";
            this.isCODDataGridViewCheckBoxColumn.HeaderText = "Thu Tiền sau/COD";
            this.isCODDataGridViewCheckBoxColumn.Name = "isCODDataGridViewCheckBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.jSManagementDataSet;
            // 
            // jSManagementDataSet
            // 
            this.jSManagementDataSet.DataSetName = "JSManagementDataSet";
            this.jSManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Location = new System.Drawing.Point(415, 293);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(693, 52);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(13, 13);
            this.lbOrderId.TabIndex = 25;
            this.lbOrderId.Text = "0";
            // 
            // lbOrderHeader
            // 
            this.lbOrderHeader.AutoSize = true;
            this.lbOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderHeader.Location = new System.Drawing.Point(482, 20);
            this.lbOrderHeader.Name = "lbOrderHeader";
            this.lbOrderHeader.Size = new System.Drawing.Size(64, 25);
            this.lbOrderHeader.TabIndex = 26;
            this.lbOrderHeader.Text = "label9";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(417, 212);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownQuantity.TabIndex = 8;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCustomerInfo
            // 
            this.lbCustomerInfo.AutoSize = true;
            this.lbCustomerInfo.Location = new System.Drawing.Point(553, 89);
            this.lbCustomerInfo.Name = "lbCustomerInfo";
            this.lbCustomerInfo.Size = new System.Drawing.Size(112, 13);
            this.lbCustomerInfo.TabIndex = 29;
            this.lbCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(553, 112);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(13, 13);
            this.lbProductID.TabIndex = 30;
            this.lbProductID.Text = "0";
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(487, 292);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Enabled = false;
            this.btAddNew.Location = new System.Drawing.Point(569, 291);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(117, 23);
            this.btAddNew.TabIndex = 14;
            this.btAddNew.Text = "Tiếp tục xuất hàng";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Visible = false;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ngày xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(268, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 325);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JS_Manage.Properties.Resources.jeans_style_flying;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // productOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1039, 774);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.lbCustomerInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.lbOrderHeader);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.grvOrders);
            this.Controls.Add(this.chkIsCOD);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBoxSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBoxBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btFindCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerCode);
            this.Controls.Add(this.dateTimePickerOrderDate);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productOutputForm";
            this.Text = "Xuất Hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFindCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBoxProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label txtP;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.CheckBox chkIsCOD;

        private System.Windows.Forms.DataGridView grvOrders;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Label lbOrderHeader;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCustomerInfo;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddNew;
        private JSManagementDataSet jSManagementDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private JSManagementDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCODDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn settedPriceDataGridViewTextBoxColumn;       
        
    }
}