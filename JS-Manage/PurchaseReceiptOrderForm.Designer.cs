namespace JS_Manage
{
    partial class PurchaseReceiptOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseReceiptOrderForm));
            this.lbPerchaseReceiptOrderHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerPerchaseReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.grvProducts = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClosingBallance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncomeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldBy = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.lbPurchaseReceiptOrderId = new System.Windows.Forms.Label();
            this.grvPurchaseReceiptOrderSumary = new System.Windows.Forms.DataGridView();
            this.txtBillNumberFind = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerPurchaseReceiptFromFind = new System.Windows.Forms.DateTimePicker();
            this.Từ = new System.Windows.Forms.Label();
            this.dateTimePickerPurchaseReceiptToFind = new System.Windows.Forms.DateTimePicker();
            this.Đến = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxOutputTypeFind = new System.Windows.Forms.ComboBox();
            this.ucCustomerSelectFind = new JS_Manage.CustomerSelectUserControl();
            this.paymentMethodUserControl2 = new JS_Manage.PaymentMethodUserControl();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSoldBy = new System.Windows.Forms.ComboBox();
            this.chkListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btPrintPostOfficeLetter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAvaiableRewardPoint = new System.Windows.Forms.Label();
            this.lbPointsBalanceAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRewardPointUsedAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxBankAccount = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucTxtCurrencyDeliveryCost = new JS_Manage.UCTextBoxCurrency();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboxPrePaid = new System.Windows.Forms.CheckBox();
            this.txtRemainPaid = new System.Windows.Forms.TextBox();
            this.lbRemainPaid = new System.Windows.Forms.Label();
            this.txtPrePaid = new System.Windows.Forms.TextBox();
            this.lbprePaid = new System.Windows.Forms.Label();
            this.txtOrderNote = new System.Windows.Forms.TextBox();
            this.cboxIsCod = new System.Windows.Forms.CheckBox();
            this.cboxIsRewardPointUse = new System.Windows.Forms.CheckBox();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.ucCustomerSelect = new JS_Manage.CustomerSelectUserControl();
            this.ucOutputStore = new JS_Manage.StoreSelectedUserControl();
            this.cboxOutPutType = new System.Windows.Forms.ComboBox();
            this.ucInputStore = new JS_Manage.StoreSelectedUserControl();
            this.cboxIsRewardPointPrint = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPurchaseReceiptOrderSumary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPerchaseReceiptOrderHeader
            // 
            this.lbPerchaseReceiptOrderHeader.AutoSize = true;
            this.lbPerchaseReceiptOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerchaseReceiptOrderHeader.Location = new System.Drawing.Point(104, 3);
            this.lbPerchaseReceiptOrderHeader.Name = "lbPerchaseReceiptOrderHeader";
            this.lbPerchaseReceiptOrderHeader.Size = new System.Drawing.Size(267, 24);
            this.lbPerchaseReceiptOrderHeader.TabIndex = 0;
            this.lbPerchaseReceiptOrderHeader.Text = "LẬP PHIẾU XUẤT HÀNG BÁN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ng&ày";
            // 
            // dateTimePickerPerchaseReceiptDate
            // 
            this.dateTimePickerPerchaseReceiptDate.Checked = false;
            this.dateTimePickerPerchaseReceiptDate.CustomFormat = "";
            this.dateTimePickerPerchaseReceiptDate.Location = new System.Drawing.Point(111, 44);
            this.dateTimePickerPerchaseReceiptDate.Name = "dateTimePickerPerchaseReceiptDate";
            this.dateTimePickerPerchaseReceiptDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerPerchaseReceiptDate.TabIndex = 20;
            this.dateTimePickerPerchaseReceiptDate.ValueChanged += new System.EventHandler(this.dateTimePickerPerchaseReceiptDate_ValueChanged);
            // 
            // grvProducts
            // 
            this.grvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductType,
            this.Brand,
            this.Size,
            this.Price,
            this.Quantity,
            this.SoldPrice,
            this.Amount,
            this.ProductId,
            this.ClosingBallance,
            this.OrderId,
            this.IncomeId,
            this.SoldBy});
            this.grvProducts.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.grvProducts.Location = new System.Drawing.Point(14, 191);
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.Size = new System.Drawing.Size(672, 247);
            this.grvProducts.TabIndex = 140;
            this.grvProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProducts_CellEndEdit);
            this.grvProducts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grvProducts_DataError);
            this.grvProducts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grvProducts_EditingControlShowing);
            this.grvProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvProducts_KeyDown);
            this.grvProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grvProducts_MouseClick);
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Mã hàng";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.Width = 80;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Loại Hàng";
            this.ProductType.Name = "ProductType";
            this.ProductType.Width = 80;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Hiệu";
            this.Brand.Name = "Brand";
            this.Brand.Width = 80;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.Width = 30;
            // 
            // Price
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 30;
            // 
            // SoldPrice
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.SoldPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.SoldPrice.HeaderText = "Giá bán";
            this.SoldPrice.Name = "SoldPrice";
            this.SoldPrice.Width = 70;
            // 
            // Amount
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Amount.HeaderText = "Thành Tiền";
            this.Amount.Name = "Amount";
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // ClosingBallance
            // 
            this.ClosingBallance.HeaderText = "ClosingBallance";
            this.ClosingBallance.Name = "ClosingBallance";
            this.ClosingBallance.ReadOnly = true;
            this.ClosingBallance.Visible = false;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "OrderId";
            this.OrderId.Name = "OrderId";
            this.OrderId.Visible = false;
            // 
            // IncomeId
            // 
            this.IncomeId.HeaderText = "IncomeId";
            this.IncomeId.Name = "IncomeId";
            this.IncomeId.Visible = false;
            // 
            // SoldBy
            // 
            this.SoldBy.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.SoldBy.HeaderText = "Người bán";
            this.SoldBy.Name = "SoldBy";
            this.SoldBy.Width = 80;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(6, 598);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 23);
            this.btSave.TabIndex = 150;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(106, 598);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 23);
            this.btDelete.TabIndex = 160;
            this.btDelete.Text = "&Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(206, 598);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(115, 23);
            this.btAddNew.TabIndex = 170;
            this.btAddNew.Text = "&Tiếp tục xuất hàng";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Mã số bư&u gửi";
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(327, 598);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(94, 23);
            this.btPrint.TabIndex = 180;
            this.btPrint.Text = "&In hóa đơn";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // lbPurchaseReceiptOrderId
            // 
            this.lbPurchaseReceiptOrderId.AutoSize = true;
            this.lbPurchaseReceiptOrderId.Location = new System.Drawing.Point(8, 4);
            this.lbPurchaseReceiptOrderId.Name = "lbPurchaseReceiptOrderId";
            this.lbPurchaseReceiptOrderId.Size = new System.Drawing.Size(13, 13);
            this.lbPurchaseReceiptOrderId.TabIndex = 58;
            this.lbPurchaseReceiptOrderId.Text = "0";
            // 
            // grvPurchaseReceiptOrderSumary
            // 
            this.grvPurchaseReceiptOrderSumary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPurchaseReceiptOrderSumary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPurchaseReceiptOrderSumary.Location = new System.Drawing.Point(6, 157);
            this.grvPurchaseReceiptOrderSumary.Name = "grvPurchaseReceiptOrderSumary";
            this.grvPurchaseReceiptOrderSumary.Size = new System.Drawing.Size(631, 555);
            this.grvPurchaseReceiptOrderSumary.TabIndex = 59;
            this.grvPurchaseReceiptOrderSumary.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvPurchaseReceiptOrderDetail_CellEnter);
            // 
            // txtBillNumberFind
            // 
            this.txtBillNumberFind.Location = new System.Drawing.Point(74, 105);
            this.txtBillNumberFind.Name = "txtBillNumberFind";
            this.txtBillNumberFind.Size = new System.Drawing.Size(122, 20);
            this.txtBillNumberFind.TabIndex = 210;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Mã bưu gửi";
            // 
            // dateTimePickerPurchaseReceiptFromFind
            // 
            this.dateTimePickerPurchaseReceiptFromFind.Checked = false;
            this.dateTimePickerPurchaseReceiptFromFind.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerPurchaseReceiptFromFind.Location = new System.Drawing.Point(38, 27);
            this.dateTimePickerPurchaseReceiptFromFind.Name = "dateTimePickerPurchaseReceiptFromFind";
            this.dateTimePickerPurchaseReceiptFromFind.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerPurchaseReceiptFromFind.TabIndex = 150;
            // 
            // Từ
            // 
            this.Từ.AutoSize = true;
            this.Từ.Location = new System.Drawing.Point(7, 32);
            this.Từ.Name = "Từ";
            this.Từ.Size = new System.Drawing.Size(20, 13);
            this.Từ.TabIndex = 60;
            this.Từ.Text = "Từ";
            // 
            // dateTimePickerPurchaseReceiptToFind
            // 
            this.dateTimePickerPurchaseReceiptToFind.Checked = false;
            this.dateTimePickerPurchaseReceiptToFind.CustomFormat = "dd-mm-yyyy";
            this.dateTimePickerPurchaseReceiptToFind.Location = new System.Drawing.Point(38, 53);
            this.dateTimePickerPurchaseReceiptToFind.Name = "dateTimePickerPurchaseReceiptToFind";
            this.dateTimePickerPurchaseReceiptToFind.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerPurchaseReceiptToFind.TabIndex = 160;
            // 
            // Đến
            // 
            this.Đến.AutoSize = true;
            this.Đến.Location = new System.Drawing.Point(6, 56);
            this.Đến.Name = "Đến";
            this.Đến.Size = new System.Drawing.Size(27, 13);
            this.Đến.TabIndex = 69;
            this.Đến.Text = "Đến";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(201, 128);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(66, 23);
            this.btFind.TabIndex = 230;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxOutputTypeFind);
            this.groupBox1.Controls.Add(this.ucCustomerSelectFind);
            this.groupBox1.Controls.Add(this.paymentMethodUserControl2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxSoldBy);
            this.groupBox1.Controls.Add(this.chkListBox);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Controls.Add(this.grvPurchaseReceiptOrderSumary);
            this.groupBox1.Controls.Add(this.Từ);
            this.groupBox1.Controls.Add(this.Đến);
            this.groupBox1.Controls.Add(this.dateTimePickerPurchaseReceiptFromFind);
            this.groupBox1.Controls.Add(this.dateTimePickerPurchaseReceiptToFind);
            this.groupBox1.Controls.Add(this.txtBillNumberFind);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(705, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 723);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1020;
            this.label2.Text = "Loại Xuất";
            // 
            // cboxOutputTypeFind
            // 
            this.cboxOutputTypeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOutputTypeFind.FormattingEnabled = true;
            this.cboxOutputTypeFind.Location = new System.Drawing.Point(74, 78);
            this.cboxOutputTypeFind.Name = "cboxOutputTypeFind";
            this.cboxOutputTypeFind.Size = new System.Drawing.Size(121, 21);
            this.cboxOutputTypeFind.TabIndex = 200;
            // 
            // ucCustomerSelectFind
            // 
            this.ucCustomerSelectFind.CustId = 0;
            this.ucCustomerSelectFind.Location = new System.Drawing.Point(294, 27);
            this.ucCustomerSelectFind.Name = "ucCustomerSelectFind";
            this.ucCustomerSelectFind.Size = new System.Drawing.Size(340, 23);
            this.ucCustomerSelectFind.TabIndex = 180;
            this.ucCustomerSelectFind.TabIndexCustSelect = 1;
            // 
            // paymentMethodUserControl2
            // 
            this.paymentMethodUserControl2.AutoSize = true;
            this.paymentMethodUserControl2.BankAccountIds = ((System.Collections.Generic.List<int>)(resources.GetObject("paymentMethodUserControl2.BankAccountIds")));
            this.paymentMethodUserControl2.Location = new System.Drawing.Point(296, 47);
            this.paymentMethodUserControl2.Name = "paymentMethodUserControl2";
            this.paymentMethodUserControl2.PaymentMethod = "";
            this.paymentMethodUserControl2.Size = new System.Drawing.Size(376, 30);
            this.paymentMethodUserControl2.TabIndex = 190;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 212;
            this.label9.Text = "Người bán";
            // 
            // comboBoxSoldBy
            // 
            this.comboBoxSoldBy.FormattingEnabled = true;
            this.comboBoxSoldBy.Location = new System.Drawing.Point(74, 129);
            this.comboBoxSoldBy.Name = "comboBoxSoldBy";
            this.comboBoxSoldBy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSoldBy.TabIndex = 220;
            // 
            // chkListBox
            // 
            this.chkListBox.CheckOnClick = true;
            this.chkListBox.FormattingEnabled = true;
            this.chkListBox.Items.AddRange(new object[] {
            "Tất cả",
            "Trả trước",
            "Trả sau / COD"});
            this.chkListBox.Location = new System.Drawing.Point(199, 27);
            this.chkListBox.Name = "chkListBox";
            this.chkListBox.Size = new System.Drawing.Size(92, 49);
            this.chkListBox.TabIndex = 170;
            this.chkListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListBox_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tổng tiền";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(527, 451);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(111, 22);
            this.txtTotalAmount.TabIndex = 1000;
            this.txtTotalAmount.Text = "0";
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // btPrintPostOfficeLetter
            // 
            this.btPrintPostOfficeLetter.Location = new System.Drawing.Point(428, 598);
            this.btPrintPostOfficeLetter.Name = "btPrintPostOfficeLetter";
            this.btPrintPostOfficeLetter.Size = new System.Drawing.Size(214, 23);
            this.btPrintPostOfficeLetter.TabIndex = 190;
            this.btPrintPostOfficeLetter.Text = "In &bìa bưu gửi";
            this.btPrintPostOfficeLetter.UseVisualStyleBackColor = true;
            this.btPrintPostOfficeLetter.Click += new System.EventHandler(this.btPrintPostOfficeLetter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Chi tiết &hàng xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "&Ghi chú";
            // 
            // lbAvaiableRewardPoint
            // 
            this.lbAvaiableRewardPoint.AutoSize = true;
            this.lbAvaiableRewardPoint.Location = new System.Drawing.Point(626, 45);
            this.lbAvaiableRewardPoint.Name = "lbAvaiableRewardPoint";
            this.lbAvaiableRewardPoint.Size = new System.Drawing.Size(13, 13);
            this.lbAvaiableRewardPoint.TabIndex = 1002;
            this.lbAvaiableRewardPoint.Text = "0";
            // 
            // lbPointsBalanceAmount
            // 
            this.lbPointsBalanceAmount.AutoSize = true;
            this.lbPointsBalanceAmount.Location = new System.Drawing.Point(641, 32);
            this.lbPointsBalanceAmount.Name = "lbPointsBalanceAmount";
            this.lbPointsBalanceAmount.Size = new System.Drawing.Size(13, 13);
            this.lbPointsBalanceAmount.TabIndex = 1006;
            this.lbPointsBalanceAmount.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(204, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 17);
            this.label13.TabIndex = 1007;
            this.label13.Text = "Điểm thưởng";
            // 
            // txtRewardPointUsedAmount
            // 
            this.txtRewardPointUsedAmount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRewardPointUsedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRewardPointUsedAmount.Location = new System.Drawing.Point(314, 476);
            this.txtRewardPointUsedAmount.Name = "txtRewardPointUsedAmount";
            this.txtRewardPointUsedAmount.ReadOnly = true;
            this.txtRewardPointUsedAmount.Size = new System.Drawing.Size(111, 22);
            this.txtRewardPointUsedAmount.TabIndex = 1008;
            this.txtRewardPointUsedAmount.Text = "0";
            this.txtRewardPointUsedAmount.TextChanged += new System.EventHandler(this.txtRewardPointUsedAmount_TextChanged);
            // 
            // txtTotalAmountPaid
            // 
            this.txtTotalAmountPaid.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalAmountPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmountPaid.Location = new System.Drawing.Point(528, 477);
            this.txtTotalAmountPaid.Name = "txtTotalAmountPaid";
            this.txtTotalAmountPaid.ReadOnly = true;
            this.txtTotalAmountPaid.Size = new System.Drawing.Size(111, 22);
            this.txtTotalAmountPaid.TabIndex = 1010;
            this.txtTotalAmountPaid.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(433, 479);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 1009;
            this.label14.Text = "Thanh toán";
            // 
            // cboxPaymentMethod
            // 
            this.cboxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaymentMethod.FormattingEnabled = true;
            this.cboxPaymentMethod.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboxPaymentMethod.Location = new System.Drawing.Point(436, 81);
            this.cboxPaymentMethod.Name = "cboxPaymentMethod";
            this.cboxPaymentMethod.Size = new System.Drawing.Size(100, 21);
            this.cboxPaymentMethod.TabIndex = 100;
            this.cboxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cboxPaymentMethod_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 1017;
            this.label10.Text = "Phương thức TT";
            // 
            // cboxBankAccount
            // 
            this.cboxBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBankAccount.FormattingEnabled = true;
            this.cboxBankAccount.Location = new System.Drawing.Point(546, 92);
            this.cboxBankAccount.Name = "cboxBankAccount";
            this.cboxBankAccount.Size = new System.Drawing.Size(145, 21);
            this.cboxBankAccount.TabIndex = 120;
            this.cboxBankAccount.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ucTxtCurrencyDeliveryCost);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.cboxPrePaid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtRemainPaid);
            this.panel1.Controls.Add(this.lbPointsBalanceAmount);
            this.panel1.Controls.Add(this.lbRemainPaid);
            this.panel1.Controls.Add(this.cboxPaymentMethod);
            this.panel1.Controls.Add(this.txtPrePaid);
            this.panel1.Controls.Add(this.lbprePaid);
            this.panel1.Controls.Add(this.lbPurchaseReceiptOrderId);
            this.panel1.Controls.Add(this.txtOrderNote);
            this.panel1.Controls.Add(this.cboxIsCod);
            this.panel1.Controls.Add(this.cboxIsRewardPointUse);
            this.panel1.Controls.Add(this.txtBillNumber);
            this.panel1.Controls.Add(this.ucCustomerSelect);
            this.panel1.Controls.Add(this.ucOutputStore);
            this.panel1.Controls.Add(this.cboxOutPutType);
            this.panel1.Controls.Add(this.btPrintPostOfficeLetter);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btAddNew);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.txtTotalAmountPaid);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRewardPointUsedAmount);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.grvProducts);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lbPerchaseReceiptOrderHeader);
            this.panel1.Controls.Add(this.ucInputStore);
            this.panel1.Controls.Add(this.cboxIsRewardPointPrint);
            this.panel1.Location = new System.Drawing.Point(3, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 706);
            this.panel1.TabIndex = 25;
            // 
            // ucTxtCurrencyDeliveryCost
            // 
            this.ucTxtCurrencyDeliveryCost.IsTextBox1Enable = true;
            this.ucTxtCurrencyDeliveryCost.isTextBox1Null = false;
            this.ucTxtCurrencyDeliveryCost.Location = new System.Drawing.Point(106, 105);
            this.ucTxtCurrencyDeliveryCost.Name = "ucTxtCurrencyDeliveryCost";
            this.ucTxtCurrencyDeliveryCost.Size = new System.Drawing.Size(552, 24);
            this.ucTxtCurrencyDeliveryCost.TabIndex = 125;
            this.ucTxtCurrencyDeliveryCost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 1019;
            this.label6.Text = "Số Lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 1018;
            this.label11.Text = "Phí gửi hàng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(314, 450);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(111, 22);
            this.txtQuantity.TabIndex = 1020;
            this.txtQuantity.Text = "0";
            // 
            // cboxPrePaid
            // 
            this.cboxPrePaid.AutoSize = true;
            this.cboxPrePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPrePaid.Location = new System.Drawing.Point(87, 503);
            this.cboxPrePaid.Name = "cboxPrePaid";
            this.cboxPrePaid.Size = new System.Drawing.Size(102, 21);
            this.cboxPrePaid.TabIndex = 142;
            this.cboxPrePaid.Text = "TT 1 phần";
            this.cboxPrePaid.UseVisualStyleBackColor = true;
            this.cboxPrePaid.CheckedChanged += new System.EventHandler(this.cboxPrePaid_CheckedChanged);
            // 
            // txtRemainPaid
            // 
            this.txtRemainPaid.BackColor = System.Drawing.SystemColors.Info;
            this.txtRemainPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemainPaid.Location = new System.Drawing.Point(528, 503);
            this.txtRemainPaid.Name = "txtRemainPaid";
            this.txtRemainPaid.ReadOnly = true;
            this.txtRemainPaid.Size = new System.Drawing.Size(111, 22);
            this.txtRemainPaid.TabIndex = 1018;
            this.txtRemainPaid.Text = "0";
            this.txtRemainPaid.Visible = false;
            // 
            // lbRemainPaid
            // 
            this.lbRemainPaid.AutoSize = true;
            this.lbRemainPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemainPaid.Location = new System.Drawing.Point(439, 505);
            this.lbRemainPaid.Name = "lbRemainPaid";
            this.lbRemainPaid.Size = new System.Drawing.Size(58, 17);
            this.lbRemainPaid.TabIndex = 1017;
            this.lbRemainPaid.Text = "Còn lại";
            this.lbRemainPaid.Visible = false;
            // 
            // txtPrePaid
            // 
            this.txtPrePaid.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrePaid.Location = new System.Drawing.Point(314, 503);
            this.txtPrePaid.Name = "txtPrePaid";
            this.txtPrePaid.Size = new System.Drawing.Size(111, 22);
            this.txtPrePaid.TabIndex = 145;
            this.txtPrePaid.Text = "0";
            this.txtPrePaid.Visible = false;
            this.txtPrePaid.TextChanged += new System.EventHandler(this.txtPrePaid_TextChanged);
            // 
            // lbprePaid
            // 
            this.lbprePaid.AutoSize = true;
            this.lbprePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprePaid.Location = new System.Drawing.Point(204, 504);
            this.lbprePaid.Name = "lbprePaid";
            this.lbprePaid.Size = new System.Drawing.Size(75, 17);
            this.lbprePaid.TabIndex = 1015;
            this.lbprePaid.Text = "TT Trước";
            this.lbprePaid.Visible = false;
            // 
            // txtOrderNote
            // 
            this.txtOrderNote.Location = new System.Drawing.Point(106, 131);
            this.txtOrderNote.Multiline = true;
            this.txtOrderNote.Name = "txtOrderNote";
            this.txtOrderNote.Size = new System.Drawing.Size(580, 52);
            this.txtOrderNote.TabIndex = 130;
            // 
            // cboxIsCod
            // 
            this.cboxIsCod.AutoSize = true;
            this.cboxIsCod.Location = new System.Drawing.Point(245, 85);
            this.cboxIsCod.Name = "cboxIsCod";
            this.cboxIsCod.Size = new System.Drawing.Size(90, 17);
            this.cboxIsCod.TabIndex = 90;
            this.cboxIsCod.Text = "C&OD/Trả sau";
            this.cboxIsCod.UseVisualStyleBackColor = true;
            // 
            // cboxIsRewardPointUse
            // 
            this.cboxIsRewardPointUse.AutoSize = true;
            this.cboxIsRewardPointUse.Location = new System.Drawing.Point(519, 33);
            this.cboxIsRewardPointUse.Name = "cboxIsRewardPointUse";
            this.cboxIsRewardPointUse.Size = new System.Drawing.Size(103, 17);
            this.cboxIsRewardPointUse.TabIndex = 75;
            this.cboxIsRewardPointUse.Text = "SD điểm thưởng";
            this.cboxIsRewardPointUse.UseVisualStyleBackColor = true;
            this.cboxIsRewardPointUse.CheckedChanged += new System.EventHandler(this.cboxIsRewardPointUse_CheckedChanged);
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(106, 82);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(129, 20);
            this.txtBillNumber.TabIndex = 80;
            // 
            // ucCustomerSelect
            // 
            this.ucCustomerSelect.CustId = 0;
            this.ucCustomerSelect.Location = new System.Drawing.Point(14, 55);
            this.ucCustomerSelect.Name = "ucCustomerSelect";
            this.ucCustomerSelect.Size = new System.Drawing.Size(442, 23);
            this.ucCustomerSelect.TabIndex = 70;
            this.ucCustomerSelect.TabIndexCustSelect = 1;
            this.ucCustomerSelect.CustomerIdTextChanged += new System.EventHandler(this.ucCustomerSelect_CustomerIdTextChanged);
            // 
            // ucOutputStore
            // 
            this.ucOutputStore.Location = new System.Drawing.Point(485, 6);
            this.ucOutputStore.Name = "ucOutputStore";
            this.ucOutputStore.Size = new System.Drawing.Size(201, 21);
            this.ucOutputStore.StoreId = 0;
            this.ucOutputStore.TabIndex = 1014;
            // 
            // cboxOutPutType
            // 
            this.cboxOutPutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxOutPutType.FormattingEnabled = true;
            this.cboxOutPutType.Location = new System.Drawing.Point(312, 32);
            this.cboxOutPutType.Name = "cboxOutPutType";
            this.cboxOutPutType.Size = new System.Drawing.Size(100, 21);
            this.cboxOutPutType.TabIndex = 30;
            this.cboxOutPutType.SelectedIndexChanged += new System.EventHandler(this.cboxOutPutType_SelectedIndexChanged);
            // 
            // ucInputStore
            // 
            this.ucInputStore.Location = new System.Drawing.Point(485, 50);
            this.ucInputStore.Name = "ucInputStore";
            this.ucInputStore.Size = new System.Drawing.Size(201, 21);
            this.ucInputStore.StoreId = 0;
            this.ucInputStore.TabIndex = 60;
            this.ucInputStore.Visible = false;
            // 
            // cboxIsRewardPointPrint
            // 
            this.cboxIsRewardPointPrint.AutoSize = true;
            this.cboxIsRewardPointPrint.Checked = true;
            this.cboxIsRewardPointPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxIsRewardPointPrint.Location = new System.Drawing.Point(420, 35);
            this.cboxIsRewardPointPrint.Name = "cboxIsRewardPointPrint";
            this.cboxIsRewardPointPrint.Size = new System.Drawing.Size(97, 17);
            this.cboxIsRewardPointPrint.TabIndex = 40;
            this.cboxIsRewardPointPrint.Text = "In điểm thưởng";
            this.cboxIsRewardPointPrint.UseVisualStyleBackColor = true;
            // 
            // PurchaseReceiptOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1362, 733);
            this.Controls.Add(this.cboxBankAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbAvaiableRewardPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerPerchaseReceiptDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PurchaseReceiptOrderForm";
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.PurchaseReceiptOrderForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchaseReceiptOrderForm_KeyDown);
            this.Resize += new System.EventHandler(this.PurchaseReceiptOrderForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPurchaseReceiptOrderSumary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPerchaseReceiptOrderHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerPerchaseReceiptDate;
        private System.Windows.Forms.DataGridView grvProducts;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label lbPurchaseReceiptOrderId;
        private System.Windows.Forms.DataGridView grvPurchaseReceiptOrderSumary;
        private System.Windows.Forms.TextBox txtBillNumberFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseReceiptFromFind;
        private System.Windows.Forms.Label Từ;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseReceiptToFind;
        private System.Windows.Forms.Label Đến;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btPrintPostOfficeLetter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSoldBy;
        private System.Windows.Forms.Label lbAvaiableRewardPoint;
        private System.Windows.Forms.Label lbPointsBalanceAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRewardPointUsedAmount;
        private System.Windows.Forms.TextBox txtTotalAmountPaid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboxPaymentMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxBankAccount;
        private PaymentMethodUserControl paymentMethodUserControl1;
        private ProductTypeBrandSizeUserControl productTypeBrandSizeUserControl1;
        private System.Windows.Forms.Panel panel1;
        private PaymentMethodUserControl paymentMethodUserControl2;
        private System.Windows.Forms.ComboBox cboxOutPutType;
        private StoreSelectedUserControl ucInputStore;
        private StoreSelectedUserControl ucOutputStore;
        private CustomerSelectUserControl ucCustomerSelect;
        private System.Windows.Forms.CheckBox cboxIsRewardPointPrint;
        private System.Windows.Forms.TextBox txtOrderNote;
        private System.Windows.Forms.CheckBox cboxIsCod;
        private System.Windows.Forms.CheckBox cboxIsRewardPointUse;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.TextBox txtRemainPaid;
        private System.Windows.Forms.Label lbRemainPaid;
        private System.Windows.Forms.TextBox txtPrePaid;
        private System.Windows.Forms.Label lbprePaid;
        private System.Windows.Forms.CheckBox cboxPrePaid;
        private CustomerSelectUserControl ucCustomerSelectFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxOutputTypeFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClosingBallance;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeId;
        private System.Windows.Forms.DataGridViewComboBoxColumn SoldBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private UCTextBoxCurrency ucTxtCurrencyDeliveryCost;
        private System.Windows.Forms.Label label11;
    }
}