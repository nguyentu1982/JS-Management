﻿namespace JS_Manage
{
    partial class CustomerSelectUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.btGetCustId = new System.Windows.Forms.Button();
            this.lbCustInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng/NCC";
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(92, 1);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(45, 20);
            this.txtCustId.TabIndex = 1;
            this.txtCustId.TextChanged += new System.EventHandler(this.txtCustId_TextChanged);
            // 
            // btGetCustId
            // 
            this.btGetCustId.Location = new System.Drawing.Point(139, -1);
            this.btGetCustId.Name = "btGetCustId";
            this.btGetCustId.Size = new System.Drawing.Size(23, 23);
            this.btGetCustId.TabIndex = 65;
            this.btGetCustId.Text = ">";
            this.btGetCustId.UseVisualStyleBackColor = true;
            this.btGetCustId.Click += new System.EventHandler(this.btGetCustId_Click);
            // 
            // lbCustInfo
            // 
            this.lbCustInfo.AutoSize = true;
            this.lbCustInfo.Location = new System.Drawing.Point(167, 5);
            this.lbCustInfo.Name = "lbCustInfo";
            this.lbCustInfo.Size = new System.Drawing.Size(49, 13);
            this.lbCustInfo.TabIndex = 3;
            this.lbCustInfo.Text = "CustInfor";
            // 
            // CustomerSelectUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCustInfo);
            this.Controls.Add(this.btGetCustId);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSelectUserControl";
            this.Size = new System.Drawing.Size(479, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Button btGetCustId;
        private System.Windows.Forms.Label lbCustInfo;
    }
}
