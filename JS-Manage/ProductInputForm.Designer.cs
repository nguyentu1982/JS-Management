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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerProductInput = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxApprove = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.ucPaymentMethod = new JS_Manage.PaymentMethodUserControl();
            this.ucSupplierSelect = new JS_Manage.CustomerSelectUserControl();
            this.cboxInputType = new System.Windows.Forms.ComboBox();
            this.ucOutputStore = new JS_Manage.StoreSelectedUserControl();
            this.ucInputStore = new JS_Manage.StoreSelectedUserControl();
            this.btProductInforPrint = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxIsPaidLater = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cklFindTransStatus = new System.Windows.Forms.CheckedListBox();
            this.cboxFindInputType = new System.Windows.Forms.ComboBox();
            this.ucFindCustSelect = new JS_Manage.CustomerSelectUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.grvInputProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInputHeader
            // 
            this.lbInputHeader.AutoSize = true;
            this.lbInputHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputHeader.Location = new System.Drawing.Point(94, 10);
            this.lbInputHeader.Name = "lbInputHeader";
            this.lbInputHeader.Size = new System.Drawing.Size(119, 25);
            this.lbInputHeader.TabIndex = 0;
            this.lbInputHeader.Text = "InputHeader";
            // 
            // grvInputProduct
            // 
            this.grvInputProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvInputProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvInputProduct.Location = new System.Drawing.Point(6, 143);
            this.grvInputProduct.Name = "grvInputProduct";
            this.grvInputProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvInputProduct.Size = new System.Drawing.Size(643, 314);
            this.grvInputProduct.TabIndex = 22;
            this.grvInputProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInputProduct_CellClick);
            this.grvInputProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvInputProduct_CellEnter);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(159, 447);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(117, 23);
            this.btAddNew.TabIndex = 8;
            this.btAddNew.Text = "&Tiếp tục nhập hàng";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(77, 448);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "&Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(5, 449);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(65, 23);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(41, 19);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerFrom.TabIndex = 12;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(41, 42);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerTo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Đến";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(41, 64);
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
            this.grvProducts.Location = new System.Drawing.Point(7, 163);
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.Size = new System.Drawing.Size(678, 253);
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
            this.Size.Width = 35;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
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
            this.lbProductInputOrderId.Location = new System.Drawing.Point(6, 16);
            this.lbProductInputOrderId.Name = "lbProductInputOrderId";
            this.lbProductInputOrderId.Size = new System.Drawing.Size(13, 13);
            this.lbProductInputOrderId.TabIndex = 55;
            this.lbProductInputOrderId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ng&ày nhập";
            // 
            // dateTimePickerProductInput
            // 
            this.dateTimePickerProductInput.Location = new System.Drawing.Point(99, 40);
            this.dateTimePickerProductInput.Name = "dateTimePickerProductInput";
            this.dateTimePickerProductInput.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerProductInput.TabIndex = 0;
            this.dateTimePickerProductInput.ValueChanged += new System.EventHandler(this.dateTimePickerProductInput_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxApprove);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.ucPaymentMethod);
            this.groupBox1.Controls.Add(this.ucSupplierSelect);
            this.groupBox1.Controls.Add(this.cboxInputType);
            this.groupBox1.Controls.Add(this.ucOutputStore);
            this.groupBox1.Controls.Add(this.ucInputStore);
            this.groupBox1.Controls.Add(this.btProductInforPrint);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTotalQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboxIsPaidLater);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePickerProductInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbProductInputOrderId);
            this.groupBox1.Controls.Add(this.grvProducts);
            this.groupBox1.Controls.Add(this.lbInputHeader);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btAddNew);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboxApprove
            // 
            this.cboxApprove.AutoSize = true;
            this.cboxApprove.Location = new System.Drawing.Point(394, 42);
            this.cboxApprove.Name = "cboxApprove";
            this.cboxApprove.Size = new System.Drawing.Size(80, 17);
            this.cboxApprove.TabIndex = 67;
            this.cboxApprove.Text = "checkBox1";
            this.cboxApprove.UseVisualStyleBackColor = true;
            this.cboxApprove.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(99, 120);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(379, 20);
            this.txtNote.TabIndex = 60;
            // 
            // ucPaymentMethod
            // 
            this.ucPaymentMethod.AutoSize = true;
            this.ucPaymentMethod.BankAccountIds = ((System.Collections.Generic.List<int>)(resources.GetObject("ucPaymentMethod.BankAccountIds")));
            this.ucPaymentMethod.Location = new System.Drawing.Point(12, 86);
            this.ucPaymentMethod.Name = "ucPaymentMethod";
            this.ucPaymentMethod.PaymentMethod = "";
            this.ucPaymentMethod.Size = new System.Drawing.Size(376, 30);
            this.ucPaymentMethod.TabIndex = 40;
            // 
            // ucSupplierSelect
            // 
            this.ucSupplierSelect.CustId = 0;
            this.ucSupplierSelect.Location = new System.Drawing.Point(7, 64);
            this.ucSupplierSelect.Name = "ucSupplierSelect";
            this.ucSupplierSelect.Size = new System.Drawing.Size(405, 23);
            this.ucSupplierSelect.TabIndex = 30;
            this.ucSupplierSelect.TabIndexCustSelect = 1;
            // 
            // cboxInputType
            // 
            this.cboxInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxInputType.Enabled = false;
            this.cboxInputType.FormattingEnabled = true;
            this.cboxInputType.Location = new System.Drawing.Point(263, 39);
            this.cboxInputType.Name = "cboxInputType";
            this.cboxInputType.Size = new System.Drawing.Size(121, 21);
            this.cboxInputType.TabIndex = 10;
            this.cboxInputType.SelectedIndexChanged += new System.EventHandler(this.cboxInputType_SelectedIndexChanged);
            // 
            // ucOutputStore
            // 
            this.ucOutputStore.Location = new System.Drawing.Point(484, 39);
            this.ucOutputStore.Name = "ucOutputStore";
            this.ucOutputStore.Size = new System.Drawing.Size(201, 21);
            this.ucOutputStore.StoreId = 0;
            this.ucOutputStore.TabIndex = 20;
            this.ucOutputStore.Visible = false;
            // 
            // ucInputStore
            // 
            this.ucInputStore.Location = new System.Drawing.Point(484, 14);
            this.ucInputStore.Name = "ucInputStore";
            this.ucInputStore.Size = new System.Drawing.Size(201, 21);
            this.ucInputStore.StoreId = 0;
            this.ucInputStore.TabIndex = 65;
            // 
            // btProductInforPrint
            // 
            this.btProductInforPrint.Location = new System.Drawing.Point(281, 448);
            this.btProductInforPrint.Name = "btProductInforPrint";
            this.btProductInforPrint.Size = new System.Drawing.Size(103, 23);
            this.btProductInforPrint.TabIndex = 64;
            this.btProductInforPrint.Text = "In Thông tin SP";
            this.btProductInforPrint.UseVisualStyleBackColor = true;
            this.btProductInforPrint.Click += new System.EventHandler(this.btProductInforPrint_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalAmount.Location = new System.Drawing.Point(282, 425);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAmount.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(224, 430);
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
            this.txtTotalQuantity.Location = new System.Drawing.Point(77, 424);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.ReadOnly = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(68, 21);
            this.txtTotalQuantity.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Tổng SL";
            // 
            // cboxIsPaidLater
            // 
            this.cboxIsPaidLater.AutoSize = true;
            this.cboxIsPaidLater.Location = new System.Drawing.Point(394, 93);
            this.cboxIsPaidLater.Name = "cboxIsPaidLater";
            this.cboxIsPaidLater.Size = new System.Drawing.Size(94, 17);
            this.cboxIsPaidLater.TabIndex = 50;
            this.cboxIsPaidLater.Text = "Nhập công nợ";
            this.cboxIsPaidLater.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Chi tiết &hàng nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cklFindTransStatus);
            this.groupBox2.Controls.Add(this.cboxFindInputType);
            this.groupBox2.Controls.Add(this.ucFindCustSelect);
            this.groupBox2.Controls.Add(this.grvInputProduct);
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(701, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 729);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm hàn&g nhập";
            // 
            // cklFindTransStatus
            // 
            this.cklFindTransStatus.CheckOnClick = true;
            this.cklFindTransStatus.FormattingEnabled = true;
            this.cklFindTransStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Đã duyệt",
            "Chưa duyệt"});
            this.cklFindTransStatus.Location = new System.Drawing.Point(346, 39);
            this.cklFindTransStatus.Name = "cklFindTransStatus";
            this.cklFindTransStatus.Size = new System.Drawing.Size(87, 49);
            this.cklFindTransStatus.TabIndex = 69;
            this.cklFindTransStatus.Visible = false;
            this.cklFindTransStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklFindTransStatus_ItemCheck);
            // 
            // cboxFindInputType
            // 
            this.cboxFindInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFindInputType.FormattingEnabled = true;
            this.cboxFindInputType.Location = new System.Drawing.Point(207, 40);
            this.cboxFindInputType.Name = "cboxFindInputType";
            this.cboxFindInputType.Size = new System.Drawing.Size(136, 21);
            this.cboxFindInputType.TabIndex = 68;
            this.cboxFindInputType.SelectedIndexChanged += new System.EventHandler(this.cboxFindInputType_SelectedIndexChanged);
            // 
            // ucFindCustSelect
            // 
            this.ucFindCustSelect.CustId = 0;
            this.ucFindCustSelect.Location = new System.Drawing.Point(207, 16);
            this.ucFindCustSelect.Name = "ucFindCustSelect";
            this.ucFindCustSelect.Size = new System.Drawing.Size(451, 23);
            this.ucFindCustSelect.TabIndex = 58;
            this.ucFindCustSelect.TabIndexCustSelect = 1;
            // 
            // productInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1354, 733);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView grvProducts;
        private System.Windows.Forms.Label lbProductInputOrderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerProductInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cboxIsPaidLater;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btProductInforPrint;
        private StoreSelectedUserControl ucOutputStore;
        private StoreSelectedUserControl ucInputStore;
        private System.Windows.Forms.ComboBox cboxInputType;
        private CustomerSelectUserControl ucSupplierSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductInputId;
        private PaymentMethodUserControl ucPaymentMethod;
        private CustomerSelectUserControl ucFindCustSelect;
        private System.Windows.Forms.ComboBox cboxFindInputType;
        private System.Windows.Forms.CheckedListBox cklFindTransStatus;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cboxApprove;
    }
}