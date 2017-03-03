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
    public partial class CustomerSelectUserControl : UserControl
    {
        public int CustId
        {
            get
            {
                int custId = 0;
                int.TryParse(txtCustId.Text, out custId);
                return custId;
            }
            set
            {
                if(value != 0)
                txtCustId.Text = value.ToString();
                else
                {
                    txtCustId.Text = string.Empty;
                }
            }
        }
        public int TabIndexCustSelect
        {
            get { return txtCustId.TabIndex; }
            set { txtCustId.TabIndex = value; }
        }

        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;

        public CustomerSelectUserControl()
        {
            InitializeComponent();
            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            //custTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btGetCustId_Click(object sender, EventArgs e)
        {
            CustId = 0;
            CustomerForm customerList = new CustomerForm();
            customerList.isOpenByCustomerSelectUserControl = true;
            customerList.ShowDialog();
            CustId = customerList.CustId;
            txtCustId.Text = CustId.ToString();
        }

        private void txtCustId_TextChanged(object sender, EventArgs e)
        {           
            
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
