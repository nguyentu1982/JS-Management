namespace JS_Manage
{
    partial class productInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productInputForm));
            this.lbInputHeader = new System.Windows.Forms.Label();
            this.grvInputProduct = new System.Windows.Forms.DataGridView();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplierSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.grvProducts = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductInputId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbProductInputOrderId = new System.Windows.Forms.Label();
            this.lbCustomerInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btFindSupplier = new System.Windows.Forms.Button();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerProductInput = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxBankAccount = new System.Windows.Forms.ComboBox();
            this.cboxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cboxIsPaidLater = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btProductInforPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvInputProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInputHeader
            // 
            this.lbInputHeader.AutoSize = true;
            this.lbInputHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputHeader.Location = new System.Drawing.Point(355, 16);
            this.lbInputHeader.Name = "lbInputHeader";
            this.lbInputHeader.Size = new System.Drawing.Size(119, 25);
            this.lbInputHeader.TabIndex = 0;
            this.lbInputHeader.Text = "InputHeader";
            // 
            // grvInputProduct
            // 
            this.grvInputProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvInputProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvInputProduct.Location = new System.Drawing.Point(9, 438);
            this.grvInputProduct.Name = "grvInputProduct";
            this.grvInputProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvInputProduct.Size = new System.Drawing.Size(886, 314);
            this.grvInputProduct.TabIndex = 22;
            this.grvInputProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInputProduct_CellClick);
            this.grvInputProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInputProduct_CellEnter);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(227, 340);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(117, 23);
            this.btAddNew.TabIndex = 8;
            this.btAddNew.Text = "&Tiếp tục nhập hàng";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(145, 341);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "&Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(73, 342);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(43, 408);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 12;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(295, 408);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Đến";
            // 
            // txtSupplierSearch
            // 
            this.txtSupplierSearch.Location = new System.Drawing.Point(582, 408);
            this.txtSupplierSearch.Name = "txtSupplierSearch";
            this.txtSupplierSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierSearch.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nhà Cung cấp";
            // 
            // button1
            // 
            this.button1.Image = global::JS_Manage.Properties.Resources.cute_ball_search1;
            this.button1.Location = new System.Drawing.Point(688, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 28);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(739, 406);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 20;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // grvProducts
            // 
            this.grvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductType,
            this.Brand,
            this.Size,
            this.Quantity,
            this.Cost,
            this.Amount,
            this.ProductId,
            this.ProductInputId});
            this.grvProducts.Location = new System.Drawing.Point(73, 114);
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.Size = new System.Drawing.Size(744, 220);
            this.grvProducts.TabIndex = 3;
            this.grvProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProducts_CellEndEdit);
            this.grvProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grvProducts_EditingControlShowing);
            this.grvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvProducts_KeyDown);
            this.grvProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grvProducts_MouseClick);
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Mã hàng";
            this.ProductCode.Name = "ProductCode";
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Loại Hàng";
            this.ProductType.Name = "ProductType";
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Hiệu";
            this.Brand.Name = "Brand";
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.Name = "Quantity";
            // 
            // Cost
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Cost.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cost.HeaderText = "Đơn giá";
            this.Cost.Name = "Cost";
            // 
            // Amount
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle2;
            this.Amount.HeaderText = "Thành tiền";
            this.Amount.Name = "Amount";
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // ProductInputId
            // 
            this.ProductInputId.HeaderText = "ProductInputId";
            this.ProductInputId.Name = "ProductInputId";
            this.ProductInputId.Visible = false;
            // 
            // lbProductInputOrderId
            // 
            this.lbProductInputOrderId.AutoSize = true;
            this.lbProductInputOrderId.Location = new System.Drawing.Point(693, 16);
            this.lbProductInputOrderId.Name = "lbProductInputOrderId";
            this.lbProductInputOrderId.Size = new System.Drawing.Size(13, 13);
            this.lbProductInputOrderId.TabIndex = 55;
            this.lbProductInputOrderId.Text = "0";
            // 
            // lbCustomerInfo
            // 
            this.lbCustomerInfo.AutoSize = true;
            this.lbCustomerInfo.Location = new System.Drawing.Point(286, 71);
            this.lbCustomerInfo.Name = "lbCustomerInfo";
            this.lbCustomerInfo.Size = new System.Drawing.Size(13, 13);
            this.lbCustomerInfo.TabIndex = 6;
            this.lbCustomerInfo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ng&ày nhập";
            // 
            // btFindSupplier
            // 
            this.btFindSupplier.Location = new System.Drawing.Point(257, 65);
            this.btFindSupplier.Name = "btFindSupplier";
            this.btFindSupplier.Size = new System.Drawing.Size(23, 23);
            this.btFindSupplier.TabIndex = 2;
            this.btFindSupplier.Text = ">";
            this.btFindSupplier.UseVisualStyleBackColor = true;
            this.btFindSupplier.Click += new System.EventHandler(this.btFindSupplier_Click);
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(152, 68);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCode.TabIndex = 1;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà c&ung cấp";
            // 
            // dateTimePickerProductInput
            // 
            this.dateTimePickerProductInput.Location = new System.Drawing.Point(152, 45);
            this.dateTimePickerProductInput.Name = "dateTimePickerProductInput";
            this.dateTimePickerProductInput.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerProductInput.TabIndex = 0;
            this.dateTimePickerProductInput.ValueChanged += new System.EventHandler(this.dateTimePickerProductInput_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JS_Manage.Properties.Resources.jeans_style_flying;
            this.pictureBox1.Location = new System.Drawing.Point(823, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btProductInforPrint);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTotalQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboxBankAccount);
            this.groupBox1.Controls.Add(this.cboxPaymentMethod);
            this.groupBox1.Controls.Add(this.cboxIsPaidLater);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dateTimePickerProductInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustomerCode);
            this.groupBox1.Controls.Add(this.btFindSupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbCustomerInfo);
            this.groupBox1.Controls.Add(this.lbProductInputOrderId);
            this.groupBox1.Controls.Add(this.grvProducts);
            this.groupBox1.Controls.Add(this.lbInputHeader);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btAddNew);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalAmount.Location = new System.Drawing.Point(715, 339);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAmount.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Tổng tiền";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQuantity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalQuantity.Location = new System.Drawing.Point(523, 339);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.ReadOnly = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(68, 21);
            this.txtTotalQuantity.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tổng SL";
            // 
            // cboxBankAccount
            // 
            this.cboxBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBankAccount.FormattingEnabled = true;
            this.cboxBankAccount.Location = new System.Drawing.Point(585, 89);
            this.cboxBankAccount.Name = "cboxBankAccount";
            this.cboxBankAccount.Size = new System.Drawing.Size(121, 21);
            this.cboxBankAccount.TabIndex = 59;
            this.cboxBankAccount.Visible = false;
            // 
            // cboxPaymentMethod
            // 
            this.cboxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaymentMethod.FormattingEnabled = true;
            this.cboxPaymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboxPaymentMethod.Location = new System.Drawing.Point(458, 89);
            this.cboxPaymentMethod.Name = "cboxPaymentMethod";
            this.cboxPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cboxPaymentMethod.TabIndex = 58;
            this.cboxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cboxPaymentMethod_SelectedIndexChanged);
            // 
            // cboxIsPaidLater
            // 
            this.cboxIsPaidLater.AutoSize = true;
            this.cboxIsPaidLater.Location = new System.Drawing.Point(358, 91);
            this.cboxIsPaidLater.Name = "cboxIsPaidLater";
            this.cboxIsPaidLater.Size = new System.Drawing.Size(94, 17);
            this.cboxIsPaidLater.TabIndex = 57;
            this.cboxIsPaidLater.Text = "Nhập công nợ";
            this.cboxIsPaidLater.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Chi tiết &hàng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 381);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 381);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm hàn&g nhập";
            // 
            // btProductInforPrint
            // 
            this.btProductInforPrint.Location = new System.Drawing.Point(349, 341);
            this.btProductInforPrint.Name = "btProductInforPrint";
            this.btProductInforPrint.Size = new System.Drawing.Size(103, 23);
            this.btProductInforPrint.TabIndex = 64;
            this.btProductInforPrint.Text = "In Thông tin SP";
            this.btProductInforPrint.UseVisualStyleBackColor = true;
            this.btProductInforPrint.Click += new System.EventHandler(this.btProductInforPrint_Click);
            // 
            // productInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(909, 764);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSupplierSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.grvInputProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "productInputForm";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.ProductInputForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productInputForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvInputProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInputHeader;
        private System.Windows.Forms.DataGridView grvInputProduct;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupplierSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView grvProducts;
        private System.Windows.Forms.Label lbProductInputOrderId;
        private System.Windows.Forms.Label lbCustomerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFindSupplier;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerProductInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInputId;
        private System.Windows.Forms.CheckBox cboxIsPaidLater;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxBankAccount;
        private System.Windows.Forms.ComboBox cboxPaymentMethod;
        private System.Windows.Forms.Button btProductInforPrint;
    }
}