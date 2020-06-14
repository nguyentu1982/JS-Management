namespace JS_Manage
{
    partial class ReceivableFromCustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivableFromCustomersForm));
            this.grvReceivableFromCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCustomerInfo = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grvProductOutput = new System.Windows.Forms.DataGridView();
            this.lbBillNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPurchaseReceiptOrderId = new System.Windows.Forms.Label();
            this.btSaveoNote = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btFindCustomer = new System.Windows.Forms.Button();
            this.chkIsInDebt = new System.Windows.Forms.CheckBox();
            this.btFind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxBankAccount = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCustId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvReceivableFromCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductOutput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvReceivableFromCustomer
            // 
            this.grvReceivableFromCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvReceivableFromCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvReceivableFromCustomer.Location = new System.Drawing.Point(13, 397);
            this.grvReceivableFromCustomer.Name = "grvReceivableFromCustomer";
            this.grvReceivableFromCustomer.Size = new System.Drawing.Size(760, 348);
            this.grvReceivableFromCustomer.TabIndex = 14;
            this.grvReceivableFromCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvReceivableFromCustomer_CellClick);
            this.grvReceivableFromCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvReceivableFromCustomer_CellContentClick);
            this.grvReceivableFromCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvReceivableFromCustomer_CellDoubleClick);
            this.grvReceivableFromCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvReceivableFromCustomer_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÔNG NỢ PHẢI THU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách hàng";
            // 
            // lbCustomerInfo
            // 
            this.lbCustomerInfo.AutoSize = true;
            this.lbCustomerInfo.Location = new System.Drawing.Point(116, 45);
            this.lbCustomerInfo.Name = "lbCustomerInfo";
            this.lbCustomerInfo.Size = new System.Drawing.Size(0, 13);
            this.lbCustomerInfo.TabIndex = 3;
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Location = new System.Drawing.Point(116, 61);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(0, 13);
            this.lbOrder.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn hàng";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(117, 78);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(0, 13);
            this.lbOrderDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày mua";
            // 
            // grvProductOutput
            // 
            this.grvProductOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProductOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProductOutput.Location = new System.Drawing.Point(23, 160);
            this.grvProductOutput.Name = "grvProductOutput";
            this.grvProductOutput.Size = new System.Drawing.Size(740, 163);
            this.grvProductOutput.TabIndex = 18;
            // 
            // lbBillNumber
            // 
            this.lbBillNumber.AutoSize = true;
            this.lbBillNumber.Location = new System.Drawing.Point(117, 97);
            this.lbBillNumber.Name = "lbBillNumber";
            this.lbBillNumber.Size = new System.Drawing.Size(0, 13);
            this.lbBillNumber.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã số bưu điện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPurchaseReceiptOrderId);
            this.groupBox1.Controls.Add(this.btSaveoNote);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 334);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lbPurchaseReceiptOrderId
            // 
            this.lbPurchaseReceiptOrderId.AutoSize = true;
            this.lbPurchaseReceiptOrderId.Location = new System.Drawing.Point(602, 16);
            this.lbPurchaseReceiptOrderId.Name = "lbPurchaseReceiptOrderId";
            this.lbPurchaseReceiptOrderId.Size = new System.Drawing.Size(13, 13);
            this.lbPurchaseReceiptOrderId.TabIndex = 23;
            this.lbPurchaseReceiptOrderId.Text = "0";
            // 
            // btSaveoNote
            // 
            this.btSaveoNote.Location = new System.Drawing.Point(540, 134);
            this.btSaveoNote.Name = "btSaveoNote";
            this.btSaveoNote.Size = new System.Drawing.Size(75, 23);
            this.btSaveoNote.TabIndex = 22;
            this.btSaveoNote.Text = "Save";
            this.btSaveoNote.UseVisualStyleBackColor = true;
            this.btSaveoNote.Click += new System.EventHandler(this.btSaveoNote_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(97, 119);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(436, 38);
            this.txtNote.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Khách hàng";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(319, 11);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(41, 20);
            this.txtCustomer.TabIndex = 4;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Location = new System.Drawing.Point(319, 37);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(107, 20);
            this.txtBillNumber.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã số bưu gửi";
            // 
            // btFindCustomer
            // 
            this.btFindCustomer.Location = new System.Drawing.Point(366, 9);
            this.btFindCustomer.Name = "btFindCustomer";
            this.btFindCustomer.Size = new System.Drawing.Size(24, 23);
            this.btFindCustomer.TabIndex = 6;
            this.btFindCustomer.Text = ">";
            this.btFindCustomer.UseVisualStyleBackColor = true;
            this.btFindCustomer.Click += new System.EventHandler(this.btFindCustomer_Click);
            // 
            // chkIsInDebt
            // 
            this.chkIsInDebt.AutoSize = true;
            this.chkIsInDebt.Checked = true;
            this.chkIsInDebt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsInDebt.Location = new System.Drawing.Point(432, 40);
            this.chkIsInDebt.Name = "chkIsInDebt";
            this.chkIsInDebt.Size = new System.Drawing.Size(60, 17);
            this.chkIsInDebt.TabIndex = 10;
            this.chkIsInDebt.Text = "Còn nợ";
            this.chkIsInDebt.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(679, 32);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 12;
            this.btFind.Text = "Tì&m";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboxBankAccount);
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btFindCustomer);
            this.groupBox2.Controls.Add(this.btFind);
            this.groupBox2.Controls.Add(this.txtCustomer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbCustId);
            this.groupBox2.Controls.Add(this.chkIsInDebt);
            this.groupBox2.Controls.Add(this.txtBillNumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 62);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(498, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tài Khoản";
            // 
            // cboxBankAccount
            // 
            this.cboxBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBankAccount.FormattingEnabled = true;
            this.cboxBankAccount.Location = new System.Drawing.Point(555, 34);
            this.cboxBankAccount.Name = "cboxBankAccount";
            this.cboxBankAccount.Size = new System.Drawing.Size(121, 21);
            this.cboxBankAccount.TabIndex = 23;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(37, 37);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(37, 14);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Từ";
            // 
            // lbCustId
            // 
            this.lbCustId.AutoSize = true;
            this.lbCustId.Location = new System.Drawing.Point(396, 17);
            this.lbCustId.Name = "lbCustId";
            this.lbCustId.Size = new System.Drawing.Size(13, 13);
            this.lbCustId.TabIndex = 20;
            this.lbCustId.Text = "0";
            this.lbCustId.Visible = false;
            // 
            // ReceivableFromCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.lbBillNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grvProductOutput);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCustomerInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grvReceivableFromCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ReceivableFromCustomersForm";
            this.Text = "Nợ phải thu";
            this.Load += new System.EventHandler(this.ReceivableFromCustomersForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReceivableFromCustomersForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvReceivableFromCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvProductOutput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvReceivableFromCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCustomerInfo;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grvProductOutput;
        private System.Windows.Forms.Label lbBillNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btFindCustomer;
        private System.Windows.Forms.CheckBox chkIsInDebt;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCustId;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSaveoNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbPurchaseReceiptOrderId;
        private System.Windows.Forms.ComboBox cboxBankAccount;
        private System.Windows.Forms.Label label11;
    }
}