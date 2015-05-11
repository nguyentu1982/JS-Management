namespace JS_Manage
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsAttendRewardPointProgram = new System.Windows.Forms.CheckBox();
            this.cboxIsContact = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCustomerType = new System.Windows.Forms.ComboBox();
            this.lbCustId = new System.Windows.Forms.Label();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btFindCust = new System.Windows.Forms.Button();
            this.txtCustNameSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grvCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxHasNote = new System.Windows.Forms.CheckBox();
            this.cboxIsContactFind = new System.Windows.Forms.CheckBox();
            this.grvTransactionHistory = new System.Windows.Forms.DataGridView();
            this.grvRewardPointHistory = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePickerDemand = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDemandDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustIdFind = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRewardPointHistory)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên kh&ách hàng (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Đi&ện Thoại (*)";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(120, 80);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(161, 20);
            this.txtCustName.TabIndex = 40;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(120, 103);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(356, 20);
            this.txtCustAddress.TabIndex = 50;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(161, 20);
            this.txtPhone.TabIndex = 60;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(107, 241);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(50, 23);
            this.btSave.TabIndex = 80;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsAttendRewardPointProgram);
            this.groupBox1.Controls.Add(this.cboxIsContact);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxCustomerType);
            this.groupBox1.Controls.Add(this.lbCustId);
            this.groupBox1.Controls.Add(this.btAddNew);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.lbHeader);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 272);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // checkBoxIsAttendRewardPointProgram
            // 
            this.checkBoxIsAttendRewardPointProgram.AutoSize = true;
            this.checkBoxIsAttendRewardPointProgram.Checked = true;
            this.checkBoxIsAttendRewardPointProgram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIsAttendRewardPointProgram.Location = new System.Drawing.Point(295, 218);
            this.checkBoxIsAttendRewardPointProgram.Name = "checkBoxIsAttendRewardPointProgram";
            this.checkBoxIsAttendRewardPointProgram.Size = new System.Drawing.Size(75, 17);
            this.checkBoxIsAttendRewardPointProgram.TabIndex = 78;
            this.checkBoxIsAttendRewardPointProgram.Text = "Tích điểm";
            this.checkBoxIsAttendRewardPointProgram.UseVisualStyleBackColor = true;
            // 
            // cboxIsContact
            // 
            this.cboxIsContact.AutoSize = true;
            this.cboxIsContact.Location = new System.Drawing.Point(109, 218);
            this.cboxIsContact.Name = "cboxIsContact";
            this.cboxIsContact.Size = new System.Drawing.Size(123, 17);
            this.cboxIsContact.TabIndex = 75;
            this.cboxIsContact.Text = "Có liên hệ với khách";
            this.cboxIsContact.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mã số KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Loại KH";
            // 
            // comboBoxCustomerType
            // 
            this.comboBoxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerType.FormattingEnabled = true;
            this.comboBoxCustomerType.Location = new System.Drawing.Point(342, 113);
            this.comboBoxCustomerType.Name = "comboBoxCustomerType";
            this.comboBoxCustomerType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCustomerType.TabIndex = 65;
            // 
            // lbCustId
            // 
            this.lbCustId.AutoSize = true;
            this.lbCustId.Location = new System.Drawing.Point(96, 48);
            this.lbCustId.Name = "lbCustId";
            this.lbCustId.Size = new System.Drawing.Size(13, 13);
            this.lbCustId.TabIndex = 27;
            this.lbCustId.Text = "0";
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(219, 241);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(100, 23);
            this.btAddNew.TabIndex = 100;
            this.btAddNew.Text = "&Thêm KH mới";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(163, 241);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(50, 23);
            this.btDelete.TabIndex = 90;
            this.btDelete.Text = "&Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.Location = new System.Drawing.Point(105, 15);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(151, 20);
            this.lbHeader.TabIndex = 24;
            this.lbHeader.Text = "Thêm khách hàng";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(109, 138);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(356, 73);
            this.txtNote.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "&Ghi chú";
            // 
            // btFindCust
            // 
            this.btFindCust.Location = new System.Drawing.Point(500, 21);
            this.btFindCust.Name = "btFindCust";
            this.btFindCust.Size = new System.Drawing.Size(49, 23);
            this.btFindCust.TabIndex = 30;
            this.btFindCust.Text = "Tìm";
            this.btFindCust.UseVisualStyleBackColor = true;
            this.btFindCust.Click += new System.EventHandler(this.btFindCust_Click);
            // 
            // txtCustNameSearch
            // 
            this.txtCustNameSearch.Location = new System.Drawing.Point(232, 24);
            this.txtCustNameSearch.Name = "txtCustNameSearch";
            this.txtCustNameSearch.Size = new System.Drawing.Size(133, 20);
            this.txtCustNameSearch.TabIndex = 20;
            this.txtCustNameSearch.TextChanged += new System.EventHandler(this.txtCustNameSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên KH / SĐT";
            // 
            // grvCustomer
            // 
            this.grvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomer.Location = new System.Drawing.Point(19, 342);
            this.grvCustomer.Name = "grvCustomer";
            this.grvCustomer.Size = new System.Drawing.Size(650, 337);
            this.grvCustomer.TabIndex = 35;
            this.grvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCustomer_CellClick);
            this.grvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCustomer_CellDoubleClick);
            this.grvCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvCustomer_KeyDown);
            this.grvCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grvCustomer_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtCustIdFind);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboxHasNote);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCustNameSearch);
            this.groupBox2.Controls.Add(this.cboxIsContactFind);
            this.groupBox2.Controls.Add(this.btFindCust);
            this.groupBox2.Location = new System.Drawing.Point(13, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 401);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm &khách hàng";
            // 
            // cboxHasNote
            // 
            this.cboxHasNote.AutoSize = true;
            this.cboxHasNote.Location = new System.Drawing.Point(370, 26);
            this.cboxHasNote.Name = "cboxHasNote";
            this.cboxHasNote.Size = new System.Drawing.Size(63, 17);
            this.cboxHasNote.TabIndex = 22;
            this.cboxHasNote.Text = "Ghi chú";
            this.cboxHasNote.UseVisualStyleBackColor = true;
            this.cboxHasNote.CheckedChanged += new System.EventHandler(this.cboxHasNote_CheckedChanged);
            // 
            // cboxIsContactFind
            // 
            this.cboxIsContactFind.AutoSize = true;
            this.cboxIsContactFind.Location = new System.Drawing.Point(436, 25);
            this.cboxIsContactFind.Name = "cboxIsContactFind";
            this.cboxIsContactFind.Size = new System.Drawing.Size(61, 17);
            this.cboxIsContactFind.TabIndex = 25;
            this.cboxIsContactFind.Text = "Liên hệ";
            this.cboxIsContactFind.UseVisualStyleBackColor = true;
            this.cboxIsContactFind.CheckedChanged += new System.EventHandler(this.cboxContact_CheckedChanged);
            // 
            // grvTransactionHistory
            // 
            this.grvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTransactionHistory.Location = new System.Drawing.Point(3, 3);
            this.grvTransactionHistory.Name = "grvTransactionHistory";
            this.grvTransactionHistory.Size = new System.Drawing.Size(477, 629);
            this.grvTransactionHistory.TabIndex = 100;
            // 
            // grvRewardPointHistory
            // 
            this.grvRewardPointHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRewardPointHistory.Location = new System.Drawing.Point(6, 6);
            this.grvRewardPointHistory.Name = "grvRewardPointHistory";
            this.grvRewardPointHistory.Size = new System.Drawing.Size(580, 282);
            this.grvRewardPointHistory.TabIndex = 150;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(681, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 661);
            this.tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grvTransactionHistory);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lịch sử mua hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grvRewardPointHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Điểm tích lũy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePickerDemand);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtDemandDescription);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(590, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhu cầu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDemand
            // 
            this.dateTimePickerDemand.Location = new System.Drawing.Point(89, 10);
            this.dateTimePickerDemand.Name = "dateTimePickerDemand";
            this.dateTimePickerDemand.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDemand.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ngày";
            // 
            // txtDemandDescription
            // 
            this.txtDemandDescription.Location = new System.Drawing.Point(89, 38);
            this.txtDemandDescription.Multiline = true;
            this.txtDemandDescription.Name = "txtDemandDescription";
            this.txtDemandDescription.Size = new System.Drawing.Size(490, 50);
            this.txtDemandDescription.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mô tả nhu cầu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "MSKH";
            // 
            // txtCustIdFind
            // 
            this.txtCustIdFind.Location = new System.Drawing.Point(59, 23);
            this.txtCustIdFind.Name = "txtCustIdFind";
            this.txtCustIdFind.Size = new System.Drawing.Size(83, 20);
            this.txtCustIdFind.TabIndex = 10;
            this.txtCustIdFind.TextChanged += new System.EventHandler(this.txtCustIdFind_TextChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grvCustomer);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CustomerForm";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvRewardPointHistory)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox groupBox1;        
        private System.Windows.Forms.Button btFindCust;
        private System.Windows.Forms.TextBox txtCustNameSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grvCustomer;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbCustId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCustomerType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grvTransactionHistory;
        private System.Windows.Forms.DataGridView grvRewardPointHistory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDemand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDemandDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cboxIsContactFind;
        private System.Windows.Forms.CheckBox cboxIsContact;
        private System.Windows.Forms.CheckBox cboxHasNote;
        private System.Windows.Forms.CheckBox checkBoxIsAttendRewardPointProgram;
        private System.Windows.Forms.TextBox txtCustIdFind;
        private System.Windows.Forms.Label label10;
    }
}