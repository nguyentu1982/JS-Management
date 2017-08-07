namespace JS_Manage
{
    partial class StoreSelectedUserControl
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
            this.cboxStore = new System.Windows.Forms.ComboBox();
            this.labelInOrOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxStore
            // 
            this.cboxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStore.FormattingEnabled = true;
            this.cboxStore.Location = new System.Drawing.Point(84, 0);
            this.cboxStore.Name = "cboxStore";
            this.cboxStore.Size = new System.Drawing.Size(114, 21);
            this.cboxStore.TabIndex = 0;
            // 
            // labelInOrOut
            // 
            this.labelInOrOut.AutoSize = true;
            this.labelInOrOut.Location = new System.Drawing.Point(3, 4);
            this.labelInOrOut.Name = "labelInOrOut";
            this.labelInOrOut.Size = new System.Drawing.Size(35, 13);
            this.labelInOrOut.TabIndex = 1;
            this.labelInOrOut.Text = "label1";
            // 
            // StoreSelectedUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInOrOut);
            this.Controls.Add(this.cboxStore);
            this.Name = "StoreSelectedUserControl";
            this.Size = new System.Drawing.Size(201, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxStore;
        private System.Windows.Forms.Label labelInOrOut;
    }
}
