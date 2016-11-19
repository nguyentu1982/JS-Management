using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class PaymentMethodUserControl : UserControl
    {
        private string _paymentMethod;
        private int _bankAccountId;
        private string _cboxBankAccountDisplayMember;
        private string _cboxBankAccountValueMember;
        private JSManagementDataSet.BankAccountDataTable _bankAccountDataTable;
        public PaymentMethodUserControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(PaymentMethodUserControl_Load);
        }

        private void PaymentMethodUserControl_Load(object sender, EventArgs e)
        {
            cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.CASH;
        }        

        private void cboxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                cboxBankAccount.Visible = true;
                cboxBankAccount.DataSource = _bankAccountDataTable;
                cboxBankAccount.DisplayMember = _cboxBankAccountDisplayMember;
                cboxBankAccount.ValueMember = _cboxBankAccountValueMember;
            }
            else
            {
                cboxBankAccount.Visible = false;
            }

            _paymentMethod = cboxPaymentMethod.SelectedItem.ToString();
        }

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        public int BankAccountId
        {
            get { return _bankAccountId; }
            set { _bankAccountId = value; }
        }

        public string CboxBankAccountDisplayMember
        {
            set { _cboxBankAccountDisplayMember = value; }
        }

        public string CboxBankAccountValueMember
        {
            set { _cboxBankAccountValueMember = value; }
        }

        public JSManagementDataSet.BankAccountDataTable BankAccountDataTable
        {
            set { _bankAccountDataTable = value; }
        }

        private void cboxBankAccount_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (cboxBankAccount.Visible)
            {
                int.TryParse(cboxBankAccount.SelectedValue.ToString(), out _bankAccountId);
            }
         
        }
    }
}
