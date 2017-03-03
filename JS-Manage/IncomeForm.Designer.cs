﻿namespace JS_Manage
{
    partial class IncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeForm));
            this.lbIncomeHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grvIncome = new System.Windows.Forms.DataGridView();
            this.txtIncomeNumberFind = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPurchaseReceiptOrderIdFind = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboxFromBankAccountFind = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxToBankAccountFind = new System.Windows.Forms.ComboBox();
            this.cboxPaymentMethodFind = new System.Windows.Forms.ComboBox();
            this.lableToBankAccountFind = new System.Windows.Forms.Label();
            this.dateTimePickerIncomeFindTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIncomeId = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.lbCostId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbToAccount = new System.Windows.Forms.Label();
            this.lableFromBankAccount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxToBankAccount = new System.Windows.Forms.ComboBox();
            this.cboxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cboxReceivableFromCustomer = new System.Windows.Forms.CheckBox();
            this.txtIncomeNumber = new System.Windows.Forms.TextBox();
            this.txtPayerName = new System.Windows.Forms.TextBox();
            this.dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.cboxFromBankAccount = new System.Windows.Forms.ComboBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.customerSelectUserControl1 = new JS_Manage.CustomerSelectUserControl();
            this.ucTextBoxCurrency1 = new JS_Manage.UCTextBoxCurrency();
            this.dateTimePickerIncomeFindFrom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grvIncome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIncomeHeader
            // 
            this.lbIncomeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncomeHeader.Location = new System.Drawing.Point(200, 12);
            this.lbIncomeHeader.Name = "lbIncomeHeader";
            this.lbIncomeHeader.Size = new System.Drawing.Size(349, 27);
            this.lbIncomeHeader.TabIndex = 0;
            this.lbIncomeHeader.Text = "PHIẾU THU";
            this.lbIncomeHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ng&ày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Người nộp tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Lý do nộp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số ti&ền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "S&ố phiếu";
            // 
            // grvIncome
            // 
            this.grvIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvIncome.Location = new System.Drawing.Point(13, 306);
            this.grvIncome.Name = "grvIncome";
            this.grvIncome.Size = new System.Drawing.Size(1160, 432);
            this.grvIncome.TabIndex = 200;
            // 
            // txtIncomeNumberFind
            // 
            this.txtIncomeNumberFind.Location = new System.Drawing.Point(307, 19);
            this.txtIncomeNumberFind.Name = "txtIncomeNumberFind";
            this.txtIncomeNumberFind.Size = new System.Drawing.Size(103, 20);
            this.txtIncomeNumberFind.TabIndex = 160;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số phiếu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Từ";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(601, 40);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(127, 23);
            this.btFind.TabIndex = 210;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerIncomeFindFrom);
            this.groupBox1.Controls.Add(this.txtPurchaseReceiptOrderIdFind);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboxFromBankAccountFind);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboxToBankAccountFind);
            this.groupBox1.Controls.Add(this.cboxPaymentMethodFind);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lableToBankAccountFind);
            this.groupBox1.Controls.Add(this.dateTimePickerIncomeFindTo);
            this.groupBox1.Controls.Add(this.txtIncomeNumberFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 75);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm &phiếu thu";
            // 
            // txtPurchaseReceiptOrderIdFind
            // 
            this.txtPurchaseReceiptOrderIdFind.Location = new System.Drawing.Point(674, 15);
            this.txtPurchaseReceiptOrderIdFind.Name = "txtPurchaseReceiptOrderIdFind";
            this.txtPurchaseReceiptOrderIdFind.Size = new System.Drawing.Size(54, 20);
            this.txtPurchaseReceiptOrderIdFind.TabIndex = 180;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "MS Đơn hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Loại thu";
            // 
            // cboxFromBankAccountFind
            // 
            this.cboxFromBankAccountFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFromBankAccountFind.FormattingEnabled = true;
            this.cboxFromBankAccountFind.Location = new System.Drawing.Point(467, 18);
            this.cboxFromBankAccountFind.Name = "cboxFromBankAccountFind";
            this.cboxFromBankAccountFind.Size = new System.Drawing.Size(121, 21);
            this.cboxFromBankAccountFind.TabIndex = 170;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Từ TK";
            // 
            // cboxToBankAccountFind
            // 
            this.cboxToBankAccountFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxToBankAccountFind.FormattingEnabled = true;
            this.cboxToBankAccountFind.Location = new System.Drawing.Point(467, 41);
            this.cboxToBankAccountFind.Name = "cboxToBankAccountFind";
            this.cboxToBankAccountFind.Size = new System.Drawing.Size(121, 21);
            this.cboxToBankAccountFind.TabIndex = 200;
            this.cboxToBankAccountFind.Visible = false;
            // 
            // cboxPaymentMethodFind
            // 
            this.cboxPaymentMethodFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaymentMethodFind.FormattingEnabled = true;
            this.cboxPaymentMethodFind.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboxPaymentMethodFind.Location = new System.Drawing.Point(307, 41);
            this.cboxPaymentMethodFind.Name = "cboxPaymentMethodFind";
            this.cboxPaymentMethodFind.Size = new System.Drawing.Size(103, 21);
            this.cboxPaymentMethodFind.TabIndex = 190;
            this.cboxPaymentMethodFind.SelectedIndexChanged += new System.EventHandler(this.cboxPaymentMethodFind_SelectedIndexChanged);
            // 
            // lableToBankAccountFind
            // 
            this.lableToBankAccountFind.AutoSize = true;
            this.lableToBankAccountFind.Location = new System.Drawing.Point(417, 43);
            this.lableToBankAccountFind.Name = "lableToBankAccountFind";
            this.lableToBankAccountFind.Size = new System.Drawing.Size(44, 13);
            this.lableToBankAccountFind.TabIndex = 26;
            this.lableToBankAccountFind.Text = "Đến TK";
            this.lableToBankAccountFind.Visible = false;
            // 
            // dateTimePickerIncomeFindTo
            // 
            this.dateTimePickerIncomeFindTo.Location = new System.Drawing.Point(43, 40);
            this.dateTimePickerIncomeFindTo.Name = "dateTimePickerIncomeFindTo";
            this.dateTimePickerIncomeFindTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIncomeFindTo.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Đến";
            // 
            // lbIncomeId
            // 
            this.lbIncomeId.AutoSize = true;
            this.lbIncomeId.Location = new System.Drawing.Point(627, 13);
            this.lbIncomeId.Name = "lbIncomeId";
            this.lbIncomeId.Size = new System.Drawing.Size(13, 13);
            this.lbIncomeId.TabIndex = 19;
            this.lbIncomeId.Text = "0";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(852, 50);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(13, 13);
            this.lbOrderId.TabIndex = 21;
            this.lbOrderId.Text = "0";
            // 
            // lbCostId
            // 
            this.lbCostId.AutoSize = true;
            this.lbCostId.Location = new System.Drawing.Point(852, 73);
            this.lbCostId.Name = "lbCostId";
            this.lbCostId.Size = new System.Drawing.Size(13, 13);
            this.lbCostId.TabIndex = 23;
            this.lbCostId.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(363, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Loại thu";
            // 
            // lbToAccount
            // 
            this.lbToAccount.AutoSize = true;
            this.lbToAccount.Location = new System.Drawing.Point(564, 49);
            this.lbToAccount.Name = "lbToAccount";
            this.lbToAccount.Size = new System.Drawing.Size(44, 13);
            this.lbToAccount.TabIndex = 31;
            this.lbToAccount.Text = "Đến TK";
            this.lbToAccount.Visible = false;
            // 
            // lableFromBankAccount
            // 
            this.lableFromBankAccount.AutoSize = true;
            this.lableFromBankAccount.Location = new System.Drawing.Point(340, 99);
            this.lableFromBankAccount.Name = "lableFromBankAccount";
            this.lableFromBankAccount.Size = new System.Drawing.Size(37, 13);
            this.lableFromBankAccount.TabIndex = 30;
            this.lableFromBankAccount.Text = "Từ TK";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cboxToBankAccount);
            this.panel1.Controls.Add(this.lableFromBankAccount);
            this.panel1.Controls.Add(this.cboxPaymentMethod);
            this.panel1.Controls.Add(this.txtIncomeNumber);
            this.panel1.Controls.Add(this.cboxReceivableFromCustomer);
            this.panel1.Controls.Add(this.customerSelectUserControl1);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.txtPayerName);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.dateTimePickerIncome);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.cboxFromBankAccount);
            this.panel1.Controls.Add(this.btAddNew);
            this.panel1.Controls.Add(this.ucTextBoxCurrency1);
            this.panel1.Location = new System.Drawing.Point(13, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 214);
            this.panel1.TabIndex = 1;
            // 
            // cboxToBankAccount
            // 
            this.cboxToBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxToBankAccount.FormattingEnabled = true;
            this.cboxToBankAccount.Location = new System.Drawing.Point(603, 39);
            this.cboxToBankAccount.Name = "cboxToBankAccount";
            this.cboxToBankAccount.Size = new System.Drawing.Size(121, 21);
            this.cboxToBankAccount.TabIndex = 204;
            this.cboxToBankAccount.Visible = false;
            // 
            // cboxPaymentMethod
            // 
            this.cboxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaymentMethod.FormattingEnabled = true;
            this.cboxPaymentMethod.Items.AddRange(new object[] {
            "",
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboxPaymentMethod.Location = new System.Drawing.Point(436, 41);
            this.cboxPaymentMethod.Name = "cboxPaymentMethod";
            this.cboxPaymentMethod.Size = new System.Drawing.Size(103, 21);
            this.cboxPaymentMethod.TabIndex = 203;
            // 
            // cboxReceivableFromCustomer
            // 
            this.cboxReceivableFromCustomer.AutoSize = true;
            this.cboxReceivableFromCustomer.Location = new System.Drawing.Point(753, 43);
            this.cboxReceivableFromCustomer.Name = "cboxReceivableFromCustomer";
            this.cboxReceivableFromCustomer.Size = new System.Drawing.Size(87, 17);
            this.cboxReceivableFromCustomer.TabIndex = 205;
            this.cboxReceivableFromCustomer.Text = "Th&u công nợ";
            this.cboxReceivableFromCustomer.UseVisualStyleBackColor = true;
            // 
            // txtIncomeNumber
            // 
            this.txtIncomeNumber.Location = new System.Drawing.Point(191, 69);
            this.txtIncomeNumber.Name = "txtIncomeNumber";
            this.txtIncomeNumber.Size = new System.Drawing.Size(143, 20);
            this.txtIncomeNumber.TabIndex = 202;
            // 
            // txtPayerName
            // 
            this.txtPayerName.Location = new System.Drawing.Point(190, 95);
            this.txtPayerName.Name = "txtPayerName";
            this.txtPayerName.Size = new System.Drawing.Size(144, 20);
            this.txtPayerName.TabIndex = 207;
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.Location = new System.Drawing.Point(191, 42);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerIncome.TabIndex = 201;
            // 
            // cboxFromBankAccount
            // 
            this.cboxFromBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFromBankAccount.FormattingEnabled = true;
            this.cboxFromBankAccount.Location = new System.Drawing.Point(436, 94);
            this.cboxFromBankAccount.Name = "cboxFromBankAccount";
            this.cboxFromBankAccount.Size = new System.Drawing.Size(121, 21);
            this.cboxFromBankAccount.TabIndex = 208;
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(352, 179);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.TabIndex = 213;
            this.btAddNew.Text = "&Tiếp tục thu";
            this.btAddNew.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(271, 179);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 212;
            this.btDelete.Text = "&Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(190, 179);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 211;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(190, 122);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(475, 20);
            this.txtReason.TabIndex = 209;
            // 
            // customerSelectUserControl1
            // 
            this.customerSelectUserControl1.CustId = 0;
            this.customerSelectUserControl1.Location = new System.Drawing.Point(349, 66);
            this.customerSelectUserControl1.Name = "customerSelectUserControl1";
            this.customerSelectUserControl1.Size = new System.Drawing.Size(488, 23);
            this.customerSelectUserControl1.TabIndex = 206;
            this.customerSelectUserControl1.TabIndexCustSelect = 1;
            // 
            // ucTextBoxCurrency1
            // 
            this.ucTextBoxCurrency1.IsTextBox1Enable = true;
            this.ucTextBoxCurrency1.isTextBox1Null = false;
            this.ucTextBoxCurrency1.Location = new System.Drawing.Point(190, 150);
            this.ucTextBoxCurrency1.Name = "ucTextBoxCurrency1";
            this.ucTextBoxCurrency1.Size = new System.Drawing.Size(552, 24);
            this.ucTextBoxCurrency1.TabIndex = 210;
            this.ucTextBoxCurrency1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dateTimePickerIncomeFindFrom
            // 
            this.dateTimePickerIncomeFindFrom.Location = new System.Drawing.Point(43, 16);
            this.dateTimePickerIncomeFindFrom.Name = "dateTimePickerIncomeFindFrom";
            this.dateTimePickerIncomeFindFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIncomeFindFrom.TabIndex = 140;
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1184, 741);
            this.Controls.Add(this.lbToAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbCostId);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.lbIncomeId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grvIncome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbIncomeHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "IncomeForm";
            this.Text = "Thu";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IncomeForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvIncome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIncomeHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grvIncome;
        private System.Windows.Forms.TextBox txtIncomeNumberFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbIncomeId;
        private System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Label lbCostId;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeFindTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxToBankAccountFind;
        private System.Windows.Forms.Label lableToBankAccountFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbToAccount;
        private System.Windows.Forms.ComboBox cboxFromBankAccountFind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboxPaymentMethodFind;
        private System.Windows.Forms.TextBox txtPurchaseReceiptOrderIdFind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lableFromBankAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxToBankAccount;
        private System.Windows.Forms.ComboBox cboxPaymentMethod;
        private System.Windows.Forms.TextBox txtIncomeNumber;
        private System.Windows.Forms.CheckBox cboxReceivableFromCustomer;
        private CustomerSelectUserControl customerSelectUserControl1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtPayerName;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox cboxFromBankAccount;
        private System.Windows.Forms.Button btAddNew;
        private UCTextBoxCurrency ucTextBoxCurrency1;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncomeFindFrom;
    }
}