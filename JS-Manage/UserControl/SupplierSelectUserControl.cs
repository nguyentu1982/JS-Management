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
    public partial class SupplierSelectUserControl : UserControl
    {
        public int CustId
        {
            get;
            set;
        }
        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;

        public SupplierSelectUserControl()
        {
            InitializeComponent();
            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            //custTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btGetCustId_Click(object sender, EventArgs e)
        {
            CustId = 0;
            CustomerForm customerList = new CustomerForm();
            customerList.isOpenBySupplierSelectUserControl = true;
            customerList.ShowDialog();
            CustId = customerList.CustId;
            txtCustId.Text = CustId.ToString();
        }

        private void txtCustId_TextChanged(object sender, EventArgs e)
        {           
            CustId = 0;
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();
            if (string.IsNullOrEmpty(txtCustId.Text))
            {
                lbCustInfo.Text = string.Empty;
            }
            else
            {
                int custId;
                if (int.TryParse(txtCustId.Text, out custId))
                {
                    var custData = custTableAdapter.GetDataByCustomerId(custId);
                    lbCustInfo.Text = string.Empty;
                    if (custData.Rows.Count > 0)
                    {
                        lbCustInfo.Text = string.Format("{0}/ {1}/ {2}", custData[0].CustomerName, custData[0].Address, custData[0].Telephone);
                        CustId = custId;
                    }
                }

            }
            if (this.CustomerIdTextChanged != null)
                this.CustomerIdTextChanged(this, e);
        }

        public event EventHandler CustomerIdTextChanged;
    }
}
