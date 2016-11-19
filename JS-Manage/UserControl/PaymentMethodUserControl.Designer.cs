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
            this.cboxBankAccount = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboxBankAccount
            // 
            this.cboxBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBankAccount.FormattingEnabled = true;
            this.cboxBankAccount.Location = new System.Drawing.Point(206, 4);
            this.cboxBankAccount.Name = "cboxBankAccount";
            this.cboxBankAccount.Size = new System.Drawing.Size(145, 21);
            this.cboxBankAccount.TabIndex = 1019;
            this.cboxBankAccount.Visible = false;
            this.cboxBankAccount.SelectedIndexChanged += new System.EventHandler(this.cboxBankAccount_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 11);
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
            "Tiền mặt",
            "Chuyển khoản"});
            this.cboxPaymentMethod.Location = new System.Drawing.Point(100, 5);
            this.cboxPaymentMethod.Name = "cboxPaymentMethod";
            this.cboxPaymentMethod.Size = new System.Drawing.Size(100, 21);
            this.cboxPaymentMethod.TabIndex = 1018;
            this.cboxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cboxPaymentMethod_SelectedIndexChanged);
            // 
            // PaymentMethodUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboxBankAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboxPaymentMethod);
            this.Name = "PaymentMethodUserControl";
            this.Size = new System.Drawing.Size(358, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxBankAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxPaymentMethod;
    }
}
