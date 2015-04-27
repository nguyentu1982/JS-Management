namespace JS_Manage
{
    partial class CostsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostName = new System.Windows.Forms.TextBox();
            this.dateTimePickerCostDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCostType = new System.Windows.Forms.ComboBox();
            this.costTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet = new JS_Manage.JSManagementDataSet();
            this.btSave = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbCostHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerSelectUserControl = new JS_Manage.CustomerSelectUserControl();
            this.cboxBankAccount = new System.Windows.Forms.ComboBox();
            this.lbCostId = new System.Windows.Forms.Label();
            this.grvCost = new System.Windows.Forms.DataGridView();
            this.CostId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costTypeTableAdapter = new JS_Manage.JSManagementDataSetTableAdapters.CostTypeTableAdapter();
            this.dateTimePickerCostFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerCostTo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCostTypeFind = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxBankAccountFind = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.costTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội d&ung chi";
            // 
            // txtCostName
            // 
            this.txtCostName.Location = new System.Drawing.Point(224, 72);
            this.txtCostName.Name = "txtCostName";
            this.txtCostName.Size = new System.Drawing.Size(200, 20);
            this.txtCostName.TabIndex = 40;
            // 
            // dateTimePickerCostDate
            // 
            this.dateTimePickerCostDate.Location = new System.Drawing.Point(224, 50);
            this.dateTimePickerCostDate.Name = "dateTimePickerCostDate";
            this.dateTimePickerCostDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCostDate.TabIndex = 20;
            this.dateTimePickerCostDate.ValueChanged += new System.EventHandler(this.dateTimePickerCostDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ng&ày chi";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(224, 98);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Số tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Loại chi";
            // 
            // cbCostType
            // 
            this.cbCostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostType.FormattingEnabled = true;
            this.cbCostType.Location = new System.Drawing.Point(224, 124);
            this.cbCostType.Name = "cbCostType";
            this.cbCostType.Size = new System.Drawing.Size(121, 21);
            this.cbCostType.TabIndex = 70;
            this.cbCostType.SelectedIndexChanged += new System.EventHandler(this.cbCostType_SelectedIndexChanged);
            // 
            // costTypeBindingSource
            // 
            this.costTypeBindingSource.DataMember = "CostType";
            this.costTypeBindingSource.DataSource = this.jSManagementDataSet;
            // 
            // jSManagementDataSet
            // 
            this.jSManagementDataSet.DataSetName = "JSManagementDataSet";
            this.jSManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(224, 176);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 90;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(382, 176);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.TabIndex = 120;
            this.btAddNew.Text = "&Tiếp tục chi";
            this.btAddNew.UseVisualStyleBackColor = true;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(303, 176);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 100;
            this.btDelete.Text = "&Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbCostHeader
            // 
            this.lbCostHeader.AutoSize = true;
            this.lbCostHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostHeader.Location = new System.Drawing.Point(229, 18);
            this.lbCostHeader.Name = "lbCostHeader";
            this.lbCostHeader.Size = new System.Drawing.Size(186, 20);
            this.lbCostHeader.TabIndex = 11;
            this.lbCostHeader.Text = "PHIẾU CHI TIỀN MẶT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerSelectUserControl);
            this.groupBox1.Controls.Add(this.cboxBankAccount);
            this.groupBox1.Controls.Add(this.lbCostId);
            this.groupBox1.Controls.Add(this.lbCostHeader);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.txtCostName);
            this.groupBox1.Controls.Add(this.btAddNew);
            this.groupBox1.Controls.Add(this.dateTimePickerCostDate);
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCostType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // customerSelectUserControl
            // 
            this.customerSelectUserControl.Location = new System.Drawing.Point(121, 150);
            this.customerSelectUserControl.Name = "customerSelectUserControl";
            this.customerSelectUserControl.Size = new System.Drawing.Size(536, 23);
            this.customerSelectUserControl.TabIndex = 121;
            this.customerSelectUserControl.Visible = false;
            // 
            // cboxBankAccount
            // 
            this.cboxBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBankAccount.FormattingEnabled = true;
            this.cboxBankAccount.Location = new System.Drawing.Point(351, 124);
            this.cboxBankAccount.Name = "cboxBankAccount";
            this.cboxBankAccount.Size = new System.Drawing.Size(121, 21);
            this.cboxBankAccount.TabIndex = 80;
            this.cboxBankAccount.Visible = false;
            // 
            // lbCostId
            // 
            this.lbCostId.AutoSize = true;
            this.lbCostId.Location = new System.Drawing.Point(644, 16);
            this.lbCostId.Name = "lbCostId";
            this.lbCostId.Size = new System.Drawing.Size(13, 13);
            this.lbCostId.TabIndex = 0;
            this.lbCostId.Text = "0";
            // 
            // grvCost
            // 
            this.grvCost.AutoGenerateColumns = false;
            this.grvCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostId,
            this.costDateDataGridViewTextBoxColumn,
            this.costNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.costTypeDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.grvCost.DataSource = this.costBindingSource;
            this.grvCost.Location = new System.Drawing.Point(12, 292);
            this.grvCost.Name = "grvCost";
            this.grvCost.Size = new System.Drawing.Size(651, 373);
            this.grvCost.TabIndex = 22;
            this.grvCost.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCost_CellClick);
            this.grvCost.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCost_CellEnter);
            // 
            // CostId
            // 
            this.CostId.DataPropertyName = "CostId";
            this.CostId.HeaderText = "CostId";
            this.CostId.Name = "CostId";
            this.CostId.ReadOnly = true;
            // 
            // costDateDataGridViewTextBoxColumn
            // 
            this.costDateDataGridViewTextBoxColumn.DataPropertyName = "CostDate";
            this.costDateDataGridViewTextBoxColumn.HeaderText = "Ngày chi";
            this.costDateDataGridViewTextBoxColumn.Name = "costDateDataGridViewTextBoxColumn";
            // 
            // costNameDataGridViewTextBoxColumn
            // 
            this.costNameDataGridViewTextBoxColumn.DataPropertyName = "CostName";
            this.costNameDataGridViewTextBoxColumn.HeaderText = "Nội dung";
            this.costNameDataGridViewTextBoxColumn.Name = "costNameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "Số tiền";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // costTypeDataGridViewTextBoxColumn
            // 
            this.costTypeDataGridViewTextBoxColumn.DataPropertyName = "CostType";
            this.costTypeDataGridViewTextBoxColumn.HeaderText = "Loại chi";
            this.costTypeDataGridViewTextBoxColumn.Name = "costTypeDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Người nhập";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // costBindingSource
            // 
            this.costBindingSource.DataMember = "Cost";
            this.costBindingSource.DataSource = this.jSManagementDataSet;
            // 
            // costTypeTableAdapter
            // 
            this.costTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerCostFrom
            // 
            this.dateTimePickerCostFrom.Location = new System.Drawing.Point(46, 240);
            this.dateTimePickerCostFrom.Name = "dateTimePickerCostFrom";
            this.dateTimePickerCostFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCostFrom.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Từ";
            // 
            // dateTimePickerCostTo
            // 
            this.dateTimePickerCostTo.Location = new System.Drawing.Point(46, 266);
            this.dateTimePickerCostTo.Name = "dateTimePickerCostTo";
            this.dateTimePickerCostTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCostTo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Đến";
            // 
            // cbCostTypeFind
            // 
            this.cbCostTypeFind.DataSource = this.costTypeBindingSource;
            this.cbCostTypeFind.DisplayMember = "CostType";
            this.cbCostTypeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostTypeFind.FormattingEnabled = true;
            this.cbCostTypeFind.Location = new System.Drawing.Point(319, 237);
            this.cbCostTypeFind.Name = "cbCostTypeFind";
            this.cbCostTypeFind.Size = new System.Drawing.Size(121, 21);
            this.cbCostTypeFind.TabIndex = 18;
            this.cbCostTypeFind.ValueMember = "CostTypeId";
            this.cbCostTypeFind.SelectedIndexChanged += new System.EventHandler(this.cbCostTypeFind_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Loại chi";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(319, 263);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(121, 23);
            this.btFind.TabIndex = 20;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxBankAccountFind);
            this.groupBox2.Location = new System.Drawing.Point(6, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 459);
            this.groupBox2.TabIndex = 140;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm &phiếu chi";
            // 
            // cboxBankAccountFind
            // 
            this.cboxBankAccountFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBankAccountFind.FormattingEnabled = true;
            this.cboxBankAccountFind.Location = new System.Drawing.Point(441, 22);
            this.cboxBankAccountFind.Name = "cboxBankAccountFind";
            this.cboxBankAccountFind.Size = new System.Drawing.Size(121, 21);
            this.cboxBankAccountFind.TabIndex = 0;
            // 
            // CostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(675, 677);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCostTypeFind);
            this.Controls.Add(this.dateTimePickerCostTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerCostFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grvCost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CostsForm";
            this.Text = "Chi";
            this.Load += new System.EventHandler(this.CostsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CostsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.costTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostName;
        private System.Windows.Forms.DateTimePicker dateTimePickerCostDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCostType;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbCostHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvCost;
        private JSManagementDataSet jSManagementDataSet;
        private System.Windows.Forms.BindingSource costTypeBindingSource;
        private JSManagementDataSetTableAdapters.CostTypeTableAdapter costTypeTableAdapter;
        private System.Windows.Forms.Label lbCostId;
        private System.Windows.Forms.BindingSource costBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerCostFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerCostTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCostTypeFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostId;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboxBankAccount;
        private System.Windows.Forms.ComboBox cboxBankAccountFind;
        private CustomerSelectUserControl customerSelectUserControl;
    }
}