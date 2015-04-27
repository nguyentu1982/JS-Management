using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class PurchaseOrderMessageBoxForm : Form
    {
        public PurchaseOrderMessageBoxForm()
        {
            InitializeComponent();
            
        }

        public PurchaseOrderDialogResult MessageBoxResult
        {
            get;
            set;
        }

        private void btPrintBill_Click(object sender, EventArgs e)
        {
            MessageBoxResult = PurchaseOrderDialogResult.PrintBill;
            this.Close();
        }

        private void btPrintPostOfficeLetter_Click(object sender, EventArgs e)
        {
            MessageBoxResult = PurchaseOrderDialogResult.PrintPostOfficeLeter;
            this.Close();
        }

        private void btCreateOtherPurchaseOrder_Click(object sender, EventArgs e)
        {
            MessageBoxResult = PurchaseOrderDialogResult.CreateOtherPurchaseOrder;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            MessageBoxResult = PurchaseOrderDialogResult.Cancel;
            this.Close();
        }

        
    }
}
