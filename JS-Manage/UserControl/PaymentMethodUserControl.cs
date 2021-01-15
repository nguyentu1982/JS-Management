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
        private List<int> _bankAccountIds;
        private string _cboxBankAccountDisplayMember;
        private string _cboxBankAccountValueMember;
        private JSManagementDataSet.BankAccountDataTable _bankAccountDataTable;
        public bool isForSearch;
        public PaymentMethodUserControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(PaymentMethodUserControl_Load);
        }

        private void PaymentMethodUserControl_Load(object sender, EventArgs e)
        {
            
        }        

        private void cboxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            _bankAccountIds = new List<int>();
            if (cboxPaymentMethod.SelectedItem.ToString().ToLower() == Constant.PaymentMethod.BANK_TRANSFER.ToLower())
            {
                checkedListBoxBankAccount.Visible = true;
                btShowHide.Visible = true;
                checkedListBoxBankAccount.DataSource = _bankAccountDataTable;
                checkedListBoxBankAccount.DisplayMember = _cboxBankAccountDisplayMember;
                checkedListBoxBankAccount.ValueMember = _cboxBankAccountValueMember;
                checkedListBoxBankAccount.Height = _bankAccountDataTable.Rows.Count * 20;
            }
            else
            {
                checkedListBoxBankAccount.Visible = false;
                btShowHide.Visible = false;
                checkedListBoxBankAccount.DataSource = null;
            }

            _paymentMethod = cboxPaymentMethod.SelectedItem.ToString();
        }

        public void AddPaymentMethodItemForSearch()
        {            
            cboxPaymentMethod.Items.Add("Tất cả");
            cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.ALL;            
        }

        public string PaymentMethod
        {
            get { if (cboxPaymentMethod.SelectedItem!=null) 
                    return cboxPaymentMethod.SelectedItem.ToString();
            return string.Empty;
            }
            set { cboxPaymentMethod.SelectedItem = value; }
        }

        public List<int> BankAccountIds
        {
            get { return _bankAccountIds; }
            set 
            {
                _bankAccountIds = value;
                
            }
        }

        public string CboxBankAccountDisplayMember
        {
            set { _cboxBankAccountDisplayMember = value; }
        }

        public string CboxBankAccountValueMember
        {
            set { _cboxBankAccountValueMember = value; }
        }

        public JSManagementDataSet.BankAccountDataTable BankAccountDataSource
        {
            set { _bankAccountDataTable = value; }
        }

        private void btShowHide_Click(object sender, EventArgs e)
        {
            if(checkedListBoxBankAccount.Height >20)
            {
                checkedListBoxBankAccount.Height = 20;
            }
            else
            {
                checkedListBoxBankAccount.Height = _bankAccountDataTable.Rows.Count * 20;
            }
        }

        private void checkedListBoxBankAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        private void checkedListBoxBankAccount_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int id;
            CheckedListBox checkedListBoxBankAccount = sender as CheckedListBox;

            DataRowView row =  checkedListBoxBankAccount.Items[e.Index] as DataRowView;
            id = int.Parse(row.Row.ItemArray[0].ToString());
            if(e.NewValue == CheckState.Checked)
            {
                
                if(!_bankAccountIds.Contains(id))
                {
                    _bankAccountIds.Add(id);
                }
            }
            else
            {
                if(_bankAccountIds.Contains(id))
                {
                    _bankAccountIds.Remove(id);
                }
            }

        }


        internal void LoadData(List<int> bankIds, JSManagementDataSet.BankAccountDataTable bankAccountData)
        {
            if (bankIds.Count > 0)
            {
                cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.BANK_TRANSFER;
                checkedListBoxBankAccount.DataSource = bankAccountData;
                int indexToSelect=-1;
                
                for (int j = 0; j < checkedListBoxBankAccount.Items.Count; j++)
                {
                    DataRowView castedItem = checkedListBoxBankAccount.Items[j] as DataRowView;
                    foreach (int i in bankIds)
                    {
                        if (castedItem["BankAccountId"].ToString() == i.ToString())
                        {
                            indexToSelect = j;
                        }
                    }
                }
                if(indexToSelect != -1)
                    checkedListBoxBankAccount.SetItemChecked(indexToSelect, true);
                btShowHide_Click(new object(), new EventArgs());
                
            } 
        }
    }
}
