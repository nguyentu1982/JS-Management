namespace JS_Manage
{
    partial class BankAccountManagementForm
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
            this.cboxBankAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbClosingBalanceFind = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOpeningBalanceFind = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvBankAccountTransactionDetail = new System.Windows.Forms.DataGridView();
            this.btFind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCurrentClosingBalance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAvaiableClosingBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabelFromOther = new System.Windows.Forms.LinkLabel();
            this.linkLabelFromReceivableCustomer = new System.Windows.Forms.LinkLabel();
            this.linkLabelFormCash = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelBankTransfer = new System.Windows.Forms.LinkLabel();
            this.lableFromBankToCash = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBankAccountTransactionDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxBankAccount
            // 
            this.cboxBankAccount.FormattingEnabled = true;
            this.cboxBankAccount.Location = new System.Drawing.Point(222, 65);
            this.cboxBankAccount.Name = "cboxBankAccount";
            this.cboxBankAccount.Size = new System.Drawing.Size(121, 21);
            this.cboxBankAccount.TabIndex = 0;
            this.cboxBankAccount.SelectedIndexChanged += new System.EventHandler(this.cboxBankAccount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số dư cuối kỳ";
            // 
            // lbClosingBalanceFind
            // 
            this.lbClosingBalanceFind.AutoSize = true;
            this.lbClosingBalanceFind.Location = new System.Drawing.Point(280, 55);
            this.lbClosingBalanceFind.Name = "lbClosingBalanceFind";
            this.lbClosingBalanceFind.Size = new System.Drawing.Size(13, 13);
            this.lbClosingBalanceFind.TabIndex = 3;
            this.lbClosingBalanceFind.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số dư đầu kỳ";
            // 
            // lbOpeningBalanceFind
            // 
            this.lbOpeningBalanceFind.AutoSize = true;
            this.lbOpeningBalanceFind.Location = new System.Drawing.Point(99, 56);
            this.lbOpeningBalanceFind.Name = "lbOpeningBalanceFind";
            this.lbOpeningBalanceFind.Size = new System.Drawing.Size(13, 13);
            this.lbOpeningBalanceFind.TabIndex = 5;
            this.lbOpeningBalanceFind.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvBankAccountTransactionDetail);
            this.groupBox1.Controls.Add(this.btFind);
            this.groupBox1.Controls.Add(this.lbOpeningBalanceFind);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.lbClosingBalanceFind);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(154, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 550);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết giao dịch";
            // 
            // grvBankAccountTransactionDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grvBankAccountTransactionDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvBankAccountTransactionDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBankAccountTransactionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBankAccountTransactionDetail.Location = new System.Drawing.Point(9, 84);
            this.grvBankAccountTransactionDetail.Name = "grvBankAccountTransactionDetail";
            this.grvBankAccountTransactionDetail.Size = new System.Drawing.Size(983, 450);
            this.grvBankAccountTransactionDetail.TabIndex = 6;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(636, 15);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 4;
            this.btFind.Text = "Xem";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Từ";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(430, 17);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(190, 17);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số dư hiện tại";
            // 
            // lbCurrentClosingBalance
            // 
            this.lbCurrentClosingBalance.AutoSize = true;
            this.lbCurrentClosingBalance.Location = new System.Drawing.Point(430, 71);
            this.lbCurrentClosingBalance.Name = "lbCurrentClosingBalance";
            this.lbCurrentClosingBalance.Size = new System.Drawing.Size(13, 13);
            this.lbCurrentClosingBalance.TabIndex = 8;
            this.lbCurrentClosingBalance.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(397, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // lbAvaiableClosingBalance
            // 
            this.lbAvaiableClosingBalance.AutoSize = true;
            this.lbAvaiableClosingBalance.Location = new System.Drawing.Point(643, 73);
            this.lbAvaiableClosingBalance.Name = "lbAvaiableClosingBalance";
            this.lbAvaiableClosingBalance.Size = new System.Drawing.Size(13, 13);
            this.lbAvaiableClosingBalance.TabIndex = 11;
            this.lbAvaiableClosingBalance.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số dư khả dụng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabelFromOther);
            this.groupBox2.Controls.Add(this.linkLabelFromReceivableCustomer);
            this.groupBox2.Controls.Add(this.linkLabelFormCash);
            this.groupBox2.Location = new System.Drawing.Point(5, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 183);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nộp tiền";
            // 
            // linkLabelFromOther
            // 
            this.linkLabelFromOther.AutoSize = true;
            this.linkLabelFromOther.Location = new System.Drawing.Point(21, 75);
            this.linkLabelFromOther.Name = "linkLabelFromOther";
            this.linkLabelFromOther.Size = new System.Drawing.Size(53, 13);
            this.linkLabelFromOther.TabIndex = 2;
            this.linkLabelFromOther.TabStop = true;
            this.linkLabelFromOther.Text = "Thu khác";
            this.linkLabelFromOther.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFromOther_LinkClicked);
            // 
            // linkLabelFromReceivableCustomer
            // 
            this.linkLabelFromReceivableCustomer.AutoSize = true;
            this.linkLabelFromReceivableCustomer.Location = new System.Drawing.Point(21, 50);
            this.linkLabelFromReceivableCustomer.Name = "linkLabelFromReceivableCustomer";
            this.linkLabelFromReceivableCustomer.Size = new System.Drawing.Size(80, 13);
            this.linkLabelFromReceivableCustomer.TabIndex = 1;
            this.linkLabelFromReceivableCustomer.TabStop = true;
            this.linkLabelFromReceivableCustomer.Text = "Từ công nợ KH";
            this.linkLabelFromReceivableCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFromReceivableCustomer_LinkClicked);
            // 
            // linkLabelFormCash
            // 
            this.linkLabelFormCash.AutoSize = true;
            this.linkLabelFormCash.Location = new System.Drawing.Point(20, 25);
            this.linkLabelFormCash.Name = "linkLabelFormCash";
            this.linkLabelFormCash.Size = new System.Drawing.Size(81, 13);
            this.linkLabelFormCash.TabIndex = 0;
            this.linkLabelFormCash.TabStop = true;
            this.linkLabelFormCash.Text = "Từ TK Tiền mặt";
            this.linkLabelFormCash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFormCash_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelBankTransfer);
            this.groupBox3.Controls.Add(this.lableFromBankToCash);
            this.groupBox3.Location = new System.Drawing.Point(5, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 183);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rút tiền";
            // 
            // labelBankTransfer
            // 
            this.labelBankTransfer.AutoSize = true;
            this.labelBankTransfer.Location = new System.Drawing.Point(21, 50);
            this.labelBankTransfer.Name = "labelBankTransfer";
            this.labelBankTransfer.Size = new System.Drawing.Size(77, 13);
            this.labelBankTransfer.TabIndex = 4;
            this.labelBankTransfer.TabStop = true;
            this.labelBankTransfer.Text = "Chuyển Khoản";
            this.labelBankTransfer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelBankTransfer_LinkClicked);
            // 
            // lableFromBankToCash
            // 
            this.lableFromBankToCash.AutoSize = true;
            this.lableFromBankToCash.Location = new System.Drawing.Point(21, 25);
            this.lableFromBankToCash.Name = "lableFromBankToCash";
            this.lableFromBankToCash.Size = new System.Drawing.Size(105, 13);
            this.lableFromBankToCash.TabIndex = 3;
            this.lableFromBankToCash.TabStop = true;
            this.lableFromBankToCash.Text = "Nộp vào TK tiền mặt";
            this.lableFromBankToCash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lableFromBankToCash_LinkClicked);
            // 
            // BankAccountManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbAvaiableClosingBalance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCurrentClosingBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxBankAccount);
            this.Name = "BankAccountManagementForm";
            this.Text = "BankAccountManagementForm";
            this.Load += new System.EventHandler(this.BankAccountManagementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBankAccountTransactionDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxBankAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbClosingBalanceFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOpeningBalanceFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvBankAccountTransactionDetail;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCurrentClosingBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbAvaiableClosingBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabelFromOther;
        private System.Windows.Forms.LinkLabel linkLabelFromReceivableCustomer;
        private System.Windows.Forms.LinkLabel linkLabelFormCash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel labelBankTransfer;
        private System.Windows.Forms.LinkLabel lableFromBankToCash;
    }
}