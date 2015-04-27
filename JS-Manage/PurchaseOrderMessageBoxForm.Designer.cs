namespace JS_Manage
{
    partial class PurchaseOrderMessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderMessageBoxForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btPrintBill = new System.Windows.Forms.Button();
            this.btPrintPostOfficeLetter = new System.Windows.Forms.Button();
            this.btCreateOtherPurchaseOrder = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo phiếu xuất hàng thành công! Bạn muốn tiếp tục?";
            // 
            // btPrintBill
            // 
            this.btPrintBill.Location = new System.Drawing.Point(15, 40);
            this.btPrintBill.Name = "btPrintBill";
            this.btPrintBill.Size = new System.Drawing.Size(75, 23);
            this.btPrintBill.TabIndex = 1;
            this.btPrintBill.Text = "&In hóa đơn";
            this.btPrintBill.UseVisualStyleBackColor = true;
            this.btPrintBill.Click += new System.EventHandler(this.btPrintBill_Click);
            // 
            // btPrintPostOfficeLetter
            // 
            this.btPrintPostOfficeLetter.Location = new System.Drawing.Point(96, 40);
            this.btPrintPostOfficeLetter.Name = "btPrintPostOfficeLetter";
            this.btPrintPostOfficeLetter.Size = new System.Drawing.Size(114, 23);
            this.btPrintPostOfficeLetter.TabIndex = 2;
            this.btPrintPostOfficeLetter.Text = "In &bìa bưu gửi";
            this.btPrintPostOfficeLetter.UseVisualStyleBackColor = true;
            this.btPrintPostOfficeLetter.Click += new System.EventHandler(this.btPrintPostOfficeLetter_Click);
            // 
            // btCreateOtherPurchaseOrder
            // 
            this.btCreateOtherPurchaseOrder.Location = new System.Drawing.Point(216, 40);
            this.btCreateOtherPurchaseOrder.Name = "btCreateOtherPurchaseOrder";
            this.btCreateOtherPurchaseOrder.Size = new System.Drawing.Size(114, 23);
            this.btCreateOtherPurchaseOrder.TabIndex = 3;
            this.btCreateOtherPurchaseOrder.Text = "&Tiếp tục xuất hàng";
            this.btCreateOtherPurchaseOrder.UseVisualStyleBackColor = true;
            this.btCreateOtherPurchaseOrder.Click += new System.EventHandler(this.btCreateOtherPurchaseOrder_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(336, 40);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(114, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // PurchaseOrderMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 73);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreateOtherPurchaseOrder);
            this.Controls.Add(this.btPrintPostOfficeLetter);
            this.Controls.Add(this.btPrintBill);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseOrderMessageBoxForm";
            this.Text = "Tạo phiếu xuất hàng thành công!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPrintBill;
        private System.Windows.Forms.Button btPrintPostOfficeLetter;
        private System.Windows.Forms.Button btCreateOtherPurchaseOrder;
        private System.Windows.Forms.Button btCancel;
    }
}