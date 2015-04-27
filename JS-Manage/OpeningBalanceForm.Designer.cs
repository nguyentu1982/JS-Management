namespace JS_Manage
{
    partial class OpeningBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningBalanceForm));
            this.grvOpeningBalance = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvOpeningBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // grvOpeningBalance
            // 
            this.grvOpeningBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvOpeningBalance.Location = new System.Drawing.Point(13, 57);
            this.grvOpeningBalance.Name = "grvOpeningBalance";
            this.grvOpeningBalance.Size = new System.Drawing.Size(832, 452);
            this.grvOpeningBalance.TabIndex = 0;
            this.grvOpeningBalance.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOpeningBalance_CellValueChanged);
            this.grvOpeningBalance.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grvOpeningBalance_DataError);
            this.grvOpeningBalance.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grvOpeningBalance_EditingControlShowing);
            this.grvOpeningBalance.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvOpeningBalance_RowLeave);
            this.grvOpeningBalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grvOpeningBalance_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SỐ DƯ ĐẦU KỲ";
            // 
            // OpeningBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(857, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvOpeningBalance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "OpeningBalanceForm";
            this.Text = "Số dư đầu kỳ";
            this.Load += new System.EventHandler(this.OpeningBalanceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpeningBalanceForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grvOpeningBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvOpeningBalance;
        private System.Windows.Forms.Label label1;
    }
}