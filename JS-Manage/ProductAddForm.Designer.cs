namespace JS_Manage
{
    partial class ProductAddForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxBrand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInputPrice = new System.Windows.Forms.Label();
            this.txtInputPrice = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListBoxSize = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Size";
            // 
            // cbBoxBrand
            // 
            this.cbBoxBrand.DisplayMember = "Brand";
            this.cbBoxBrand.FormattingEnabled = true;
            this.cbBoxBrand.Location = new System.Drawing.Point(202, 102);
            this.cbBoxBrand.Name = "cbBoxBrand";
            this.cbBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.cbBoxBrand.TabIndex = 55;
            this.cbBoxBrand.ValueMember = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nhãn hiệu";
            // 
            // cbBoxProductType
            // 
            this.cbBoxProductType.DisplayMember = "ProductType";
            this.cbBoxProductType.FormattingEnabled = true;
            this.cbBoxProductType.Location = new System.Drawing.Point(202, 75);
            this.cbBoxProductType.Name = "cbBoxProductType";
            this.cbBoxProductType.Size = new System.Drawing.Size(121, 21);
            this.cbBoxProductType.TabIndex = 54;
            this.cbBoxProductType.ValueMember = "ProductType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Loại Hàng";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(203, 50);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 20);
            this.txtProductCode.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Mã sản phẩm";
            // 
            // lbInputPrice
            // 
            this.lbInputPrice.AutoSize = true;
            this.lbInputPrice.Location = new System.Drawing.Point(97, 235);
            this.lbInputPrice.Name = "lbInputPrice";
            this.lbInputPrice.Size = new System.Drawing.Size(52, 13);
            this.lbInputPrice.TabIndex = 64;
            this.lbInputPrice.Text = "Giá Nhập";
            // 
            // txtInputPrice
            // 
            this.txtInputPrice.Location = new System.Drawing.Point(201, 228);
            this.txtInputPrice.Name = "txtInputPrice";
            this.txtInputPrice.Size = new System.Drawing.Size(74, 20);
            this.txtInputPrice.TabIndex = 57;
            this.txtInputPrice.Text = "0";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(200, 279);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 60;
            this.btSave.Text = "&Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(201, 253);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(74, 20);
            this.txtPrice.TabIndex = 58;
            // 
            // txtP
            // 
            this.txtP.AutoSize = true;
            this.txtP.Location = new System.Drawing.Point(97, 260);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(44, 13);
            this.txtP.TabIndex = 65;
            this.txtP.Text = "Giá bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "THÊM MÃ SẢN PHẨM";
            // 
            // chkListBoxSize
            // 
            this.chkListBoxSize.CheckOnClick = true;
            this.chkListBoxSize.ColumnWidth = 45;
            this.chkListBoxSize.FormattingEnabled = true;
            this.chkListBoxSize.Items.AddRange(new object[] {
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.chkListBoxSize.Location = new System.Drawing.Point(201, 129);
            this.chkListBoxSize.MultiColumn = true;
            this.chkListBoxSize.Name = "chkListBoxSize";
            this.chkListBoxSize.Size = new System.Drawing.Size(214, 94);
            this.chkListBoxSize.TabIndex = 56;
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.chkListBoxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBoxBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxProductType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInputPrice);
            this.Controls.Add(this.txtInputPrice);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtP);
            this.Name = "ProductAddForm";
            this.Text = "ProductAddForm";
            this.Load += new System.EventHandler(this.ProductAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBoxBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxProductType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInputPrice;
        private System.Windows.Forms.TextBox txtInputPrice;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListBoxSize;
    }
}