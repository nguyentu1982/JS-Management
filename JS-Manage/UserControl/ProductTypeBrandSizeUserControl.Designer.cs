namespace JS_Manage
{
    partial class ProductTypeBrandSizeUserControl
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
            this.comboBoxProductTypeFind = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxBrandFind = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxSizeFind = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxProductTypeFind
            // 
            this.comboBoxProductTypeFind.DisplayMember = "ProductType";
            this.comboBoxProductTypeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductTypeFind.FormattingEnabled = true;
            this.comboBoxProductTypeFind.Location = new System.Drawing.Point(64, 3);
            this.comboBoxProductTypeFind.Name = "comboBoxProductTypeFind";
            this.comboBoxProductTypeFind.Size = new System.Drawing.Size(100, 21);
            this.comboBoxProductTypeFind.TabIndex = 72;
            this.comboBoxProductTypeFind.ValueMember = "ProductType";
            this.comboBoxProductTypeFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductTypeFind_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Loại Hàng";
            // 
            // comboBoxBrandFind
            // 
            this.comboBoxBrandFind.DisplayMember = "Brand";
            this.comboBoxBrandFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrandFind.FormattingEnabled = true;
            this.comboBoxBrandFind.Location = new System.Drawing.Point(224, 3);
            this.comboBoxBrandFind.Name = "comboBoxBrandFind";
            this.comboBoxBrandFind.Size = new System.Drawing.Size(100, 21);
            this.comboBoxBrandFind.TabIndex = 73;
            this.comboBoxBrandFind.ValueMember = "Brand";
            this.comboBoxBrandFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrandFind_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Nhãn hiệu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Size";
            // 
            // comboBoxSizeFind
            // 
            this.comboBoxSizeFind.DisplayMember = "Size";
            this.comboBoxSizeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSizeFind.FormattingEnabled = true;
            this.comboBoxSizeFind.Location = new System.Drawing.Point(370, 2);
            this.comboBoxSizeFind.Name = "comboBoxSizeFind";
            this.comboBoxSizeFind.Size = new System.Drawing.Size(54, 21);
            this.comboBoxSizeFind.TabIndex = 74;
            this.comboBoxSizeFind.ValueMember = "Size";
            this.comboBoxSizeFind.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizeFind_SelectedIndexChanged);
            // 
            // ProductTypeBrandSizeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxProductTypeFind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxBrandFind);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxSizeFind);
            this.Name = "ProductTypeBrandSizeUserControl";
            this.Size = new System.Drawing.Size(428, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProductTypeFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxBrandFind;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxSizeFind;
    }
}
