namespace JS_Manage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btProductInput = new System.Windows.Forms.Button();
            this.btLiabilities = new System.Windows.Forms.Button();
            this.btProductSearch = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btAdminTask = new System.Windows.Forms.Button();
            this.btCosts = new System.Windows.Forms.Button();
            this.btReport = new System.Windows.Forms.Button();
            this.btOperationResult = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btIncome = new System.Windows.Forms.Button();
            this.btRecievableFromCustomer = new System.Windows.Forms.Button();
            this.btPurchaseReceiptOrder = new System.Windows.Forms.Button();
            this.btManageCash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btBankAccountManagement = new System.Windows.Forms.Button();
            this.btProductChecking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btProductInput
            // 
            this.btProductInput.Location = new System.Drawing.Point(300, 157);
            this.btProductInput.Name = "btProductInput";
            this.btProductInput.Size = new System.Drawing.Size(75, 75);
            this.btProductInput.TabIndex = 6;
            this.btProductInput.Text = "Nhập Hàng";
            this.btProductInput.UseVisualStyleBackColor = true;
            this.btProductInput.Click += new System.EventHandler(this.btProductInput_Click);
            // 
            // btLiabilities
            // 
            this.btLiabilities.Location = new System.Drawing.Point(457, 94);
            this.btLiabilities.Name = "btLiabilities";
            this.btLiabilities.Size = new System.Drawing.Size(75, 75);
            this.btLiabilities.TabIndex = 22;
            this.btLiabilities.Text = "Nợ phải trả";
            this.btLiabilities.UseVisualStyleBackColor = true;
            this.btLiabilities.Click += new System.EventHandler(this.btLiabilities_Click);
            // 
            // btProductSearch
            // 
            this.btProductSearch.Location = new System.Drawing.Point(138, 157);
            this.btProductSearch.Name = "btProductSearch";
            this.btProductSearch.Size = new System.Drawing.Size(75, 75);
            this.btProductSearch.TabIndex = 2;
            this.btProductSearch.Text = "Kho hàng";
            this.btProductSearch.UseVisualStyleBackColor = true;
            this.btProductSearch.Click += new System.EventHandler(this.btProductSearch_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Location = new System.Drawing.Point(138, 238);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(75, 75);
            this.btCustomer.TabIndex = 10;
            this.btCustomer.Text = "Khách hàng";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btAdminTask
            // 
            this.btAdminTask.Location = new System.Drawing.Point(381, 317);
            this.btAdminTask.Name = "btAdminTask";
            this.btAdminTask.Size = new System.Drawing.Size(75, 75);
            this.btAdminTask.TabIndex = 24;
            this.btAdminTask.Text = "Admin Task";
            this.btAdminTask.UseVisualStyleBackColor = true;
            this.btAdminTask.Click += new System.EventHandler(this.btAdminTask_Click);
            // 
            // btCosts
            // 
            this.btCosts.Location = new System.Drawing.Point(381, 238);
            this.btCosts.Name = "btCosts";
            this.btCosts.Size = new System.Drawing.Size(75, 75);
            this.btCosts.TabIndex = 16;
            this.btCosts.Text = "Chi";
            this.btCosts.UseVisualStyleBackColor = true;
            this.btCosts.Click += new System.EventHandler(this.btCosts_Click);
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(219, 157);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(75, 75);
            this.btReport.TabIndex = 4;
            this.btReport.Text = "Báo cáo NXT";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btOperationResult
            // 
            this.btOperationResult.Location = new System.Drawing.Point(138, 319);
            this.btOperationResult.Name = "btOperationResult";
            this.btOperationResult.Size = new System.Drawing.Size(75, 75);
            this.btOperationResult.TabIndex = 18;
            this.btOperationResult.Text = "Báo cáo KQKD";
            this.btOperationResult.UseVisualStyleBackColor = true;
            this.btOperationResult.Visible = false;
            this.btOperationResult.Click += new System.EventHandler(this.btOperationResult_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(488, 12);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(29, 13);
            this.lbUserName.TabIndex = 9;
            this.lbUserName.Text = "User";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(523, 6);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(65, 25);
            this.btLogout.TabIndex = 50;
            this.btLogout.Text = "Đăng xuất";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btIncome
            // 
            this.btIncome.Location = new System.Drawing.Point(300, 238);
            this.btIncome.Name = "btIncome";
            this.btIncome.Size = new System.Drawing.Size(75, 75);
            this.btIncome.TabIndex = 14;
            this.btIncome.Text = "Thu";
            this.btIncome.UseVisualStyleBackColor = true;
            this.btIncome.Click += new System.EventHandler(this.btIncome_Click);
            // 
            // btRecievableFromCustomer
            // 
            this.btRecievableFromCustomer.Location = new System.Drawing.Point(219, 238);
            this.btRecievableFromCustomer.Name = "btRecievableFromCustomer";
            this.btRecievableFromCustomer.Size = new System.Drawing.Size(75, 75);
            this.btRecievableFromCustomer.TabIndex = 12;
            this.btRecievableFromCustomer.Text = "Nợ phải thu";
            this.btRecievableFromCustomer.UseVisualStyleBackColor = true;
            this.btRecievableFromCustomer.Click += new System.EventHandler(this.btRecievableFromCustomer_Click);
            // 
            // btPurchaseReceiptOrder
            // 
            this.btPurchaseReceiptOrder.Location = new System.Drawing.Point(381, 157);
            this.btPurchaseReceiptOrder.Name = "btPurchaseReceiptOrder";
            this.btPurchaseReceiptOrder.Size = new System.Drawing.Size(75, 75);
            this.btPurchaseReceiptOrder.TabIndex = 8;
            this.btPurchaseReceiptOrder.Text = "Xuất hàng / In Hóa Đơn";
            this.btPurchaseReceiptOrder.UseVisualStyleBackColor = true;
            this.btPurchaseReceiptOrder.Click += new System.EventHandler(this.btPurchaseReceiptOrder_Click);
            // 
            // btManageCash
            // 
            this.btManageCash.Location = new System.Drawing.Point(219, 319);
            this.btManageCash.Name = "btManageCash";
            this.btManageCash.Size = new System.Drawing.Size(75, 75);
            this.btManageCash.TabIndex = 20;
            this.btManageCash.Text = "Quản lý tiền mặt";
            this.btManageCash.UseVisualStyleBackColor = true;
            this.btManageCash.Visible = false;
            this.btManageCash.Click += new System.EventHandler(this.btManageCash_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(187, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phát triển bởi Nguyễn Anh Tú Ver 1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 34);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Làm đẹp đôi chân bạn bằng quần jeans!";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 38);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btBankAccountManagement);
            this.groupBox3.Controls.Add(this.btProductChecking);
            this.groupBox3.Controls.Add(this.btLiabilities);
            this.groupBox3.Location = new System.Drawing.Point(5, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 258);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btBankAccountManagement
            // 
            this.btBankAccountManagement.Location = new System.Drawing.Point(295, 175);
            this.btBankAccountManagement.Name = "btBankAccountManagement";
            this.btBankAccountManagement.Size = new System.Drawing.Size(75, 75);
            this.btBankAccountManagement.TabIndex = 52;
            this.btBankAccountManagement.Text = "Quản lý Tài Khoản";
            this.btBankAccountManagement.UseVisualStyleBackColor = true;
            this.btBankAccountManagement.Click += new System.EventHandler(this.btBankAccountManagement_Click);
            // 
            // btProductChecking
            // 
            this.btProductChecking.Location = new System.Drawing.Point(457, 13);
            this.btProductChecking.Name = "btProductChecking";
            this.btProductChecking.Size = new System.Drawing.Size(75, 75);
            this.btProductChecking.TabIndex = 51;
            this.btProductChecking.Text = "Kiểm hàng";
            this.btProductChecking.UseVisualStyleBackColor = true;
            this.btProductChecking.Click += new System.EventHandler(this.btProductChecking_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btManageCash);
            this.Controls.Add(this.btPurchaseReceiptOrder);
            this.Controls.Add(this.btRecievableFromCustomer);
            this.Controls.Add(this.btIncome);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btOperationResult);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.btCosts);
            this.Controls.Add(this.btAdminTask);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.btProductSearch);
            this.Controls.Add(this.btProductInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Jeans Style";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btProductInput;
        private System.Windows.Forms.Button btLiabilities;
        private System.Windows.Forms.Button btProductSearch;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btAdminTask;
        private System.Windows.Forms.Button btCosts;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btOperationResult;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btIncome;
        private System.Windows.Forms.Button btRecievableFromCustomer;
        private System.Windows.Forms.Button btPurchaseReceiptOrder;
        private System.Windows.Forms.Button btManageCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btProductChecking;
        private System.Windows.Forms.Button btBankAccountManagement;
    }
}