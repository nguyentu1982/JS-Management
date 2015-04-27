namespace JS_Manage
{
    partial class ActiveDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveDateForm));
            this.grvActiveDate = new System.Windows.Forms.DataGridView();
            this.activeDateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activeDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jSManagementDataSet = new JS_Manage.JSManagementDataSet();
            this.activeDateTableAdapter = new JS_Manage.JSManagementDataSetTableAdapters.ActiveDateTableAdapter();
            this.cboxMonth = new System.Windows.Forms.ComboBox();
            this.cboxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvActiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grvActiveDate
            // 
            this.grvActiveDate.AutoGenerateColumns = false;
            this.grvActiveDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvActiveDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activeDateIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.grvActiveDate.DataSource = this.activeDateBindingSource;
            this.grvActiveDate.Location = new System.Drawing.Point(13, 76);
            this.grvActiveDate.Name = "grvActiveDate";
            this.grvActiveDate.Size = new System.Drawing.Size(356, 627);
            this.grvActiveDate.TabIndex = 3;
            this.grvActiveDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvActiveDate_CellContentClick);
            this.grvActiveDate.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvActiveDate_CellValueChanged);
            this.grvActiveDate.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grvActiveDate_DataError);
            // 
            // activeDateIdDataGridViewTextBoxColumn
            // 
            this.activeDateIdDataGridViewTextBoxColumn.DataPropertyName = "ActiveDateId";
            this.activeDateIdDataGridViewTextBoxColumn.HeaderText = "ActiveDateId";
            this.activeDateIdDataGridViewTextBoxColumn.Name = "activeDateIdDataGridViewTextBoxColumn";
            this.activeDateIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Kích hoạt";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // activeDateBindingSource
            // 
            this.activeDateBindingSource.DataMember = "ActiveDate";
            this.activeDateBindingSource.DataSource = this.jSManagementDataSet;
            // 
            // jSManagementDataSet
            // 
            this.jSManagementDataSet.DataSetName = "JSManagementDataSet";
            this.jSManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activeDateTableAdapter
            // 
            this.activeDateTableAdapter.ClearBeforeFill = true;
            // 
            // cboxMonth
            // 
            this.cboxMonth.FormattingEnabled = true;
            this.cboxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboxMonth.Location = new System.Drawing.Point(75, 47);
            this.cboxMonth.Name = "cboxMonth";
            this.cboxMonth.Size = new System.Drawing.Size(51, 21);
            this.cboxMonth.TabIndex = 0;
            // 
            // cboxYear
            // 
            this.cboxYear.FormattingEnabled = true;
            this.cboxYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            ""});
            this.cboxYear.Location = new System.Drawing.Point(168, 47);
            this.cboxYear.Name = "cboxYear";
            this.cboxYear.Size = new System.Drawing.Size(85, 21);
            this.cboxYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(259, 45);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 2;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "KÍCH HOẠT NGÀY NHẬP LIỆU";
            // 
            // ActiveDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(380, 769);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxYear);
            this.Controls.Add(this.cboxMonth);
            this.Controls.Add(this.grvActiveDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ActiveDateForm";
            this.Text = "ActiveDateForm";
            this.Load += new System.EventHandler(this.ActiveDateForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveDateForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvActiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jSManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvActiveDate;
        private JSManagementDataSet jSManagementDataSet;
        private System.Windows.Forms.BindingSource activeDateBindingSource;
        private JSManagementDataSetTableAdapters.ActiveDateTableAdapter activeDateTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox cboxMonth;
        private System.Windows.Forms.ComboBox cboxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label label3;
    }
}