namespace JS_Manage
{
    partial class PaymentMethodUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.cboxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.checkedListBoxBankAccount = new System.Windows.Forms.CheckedListBox();
            this.btShowHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 1020;
            this.label10.Text = "Phương thức TT";
            // 
            // cboxPaymentMethod
            // 
            this.cboxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaymentMethod.FormattingEnabled = true;
            this.cboxPaymentMethod.Items.AddRange(new object[] {
            "Tất cả",
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboxPaymentMethod.Location = new System.Drawing.Point(100, 5);
            this.cboxPaymentMethod.Name = "cboxPaymentMethod";
            this.cboxPaymentMethod.Size = new System.Drawing.Size(100, 21);
            this.cboxPaymentMethod.TabIndex = 1018;
            this.cboxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cboxPaymentMethod_SelectedIndexChanged);
            // 
            // checkedListBoxBankAccount
            // 
            this.checkedListBoxBankAccount.CheckOnClick = true;
            this.checkedListBoxBankAccount.FormattingEnabled = true;
            this.checkedListBoxBankAccount.Location = new System.Drawing.Point(207, 4);
            this.checkedListBoxBankAccount.Name = "checkedListBoxBankAccount";
            this.checkedListBoxBankAccount.Size = new System.Drawing.Size(172, 19);
            this.checkedListBoxBankAccount.TabIndex = 1021;
            this.checkedListBoxBankAccount.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxBankAccount_ItemCheck);
            this.checkedListBoxBankAccount.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxBankAccount_SelectedIndexChanged);
            // 
            // btShowHide
            // 
            this.btShowHide.Location = new System.Drawing.Point(385, 3);
            this.btShowHide.Name = "btShowHide";
            this.btShowHide.Size = new System.Drawing.Size(20, 23);
            this.btShowHide.TabIndex = 1022;
            this.btShowHide.Text = "v";
            this.btShowHide.UseVisualStyleBackColor = true;
            this.btShowHide.Click += new System.EventHandler(this.btShowHide_Click);
            // 
            // PaymentMethodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btShowHide);
            this.Controls.Add(this.checkedListBoxBankAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboxPaymentMethod);
            this.Name = "PaymentMethodUserControl";
            this.Size = new System.Drawing.Size(414, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxPaymentMethod;
        private System.Windows.Forms.CheckedListBox checkedListBoxBankAccount;
        private System.Windows.Forms.Button btShowHide;
    }
}
