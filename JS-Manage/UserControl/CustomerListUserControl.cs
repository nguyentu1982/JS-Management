using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace JS_Manage
{
    public partial class CustomerListUserControl : UserControl
    {        
            
        public CustomerListUserControl()
        {            
            InitializeComponent();                     
            txtCustNameSearch_TextChanged(new object(), new EventArgs());
        }        

        private void grvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = grvCustomer.Rows[e.RowIndex];
            string custID = row.Cells[0].Value.ToString();
            string custName = row.Cells[1].Value.ToString();
            string custAddress = row.Cells[2].Value.ToString();
            string custPhone = row.Cells[3].Value.ToString();

            FormCollection fc = Application.OpenForms;
            Form mainform = new Form();
            
            foreach (Form f in fc)
            {
                if (f.Name == "productOutputForm")
                {
                    mainform = f;
                }
                if (f.Name == "productInputForm")
                {
                    mainform = f;
                }
            }


            if (mainform.Controls.Count > 0)
            {
                TextBox txtCustomerCode = mainform.Controls.Find("txtCustomerCode", true)[0] as TextBox;
                Label lbCustomerInfo = mainform.Controls.Find("lbCustomerInfo", true)[0] as Label;
                lbCustomerInfo.Text = string.Format("{0}, {1}, {2}",custName, custAddress, custPhone);
                txtCustomerCode.Text = custID;
                Form custListForm = (Form)this.Parent;
                custListForm.Close();
            }
            else
            {                
                Form custEditForm = new Form();
                custEditForm.Text = "Sửa thông tin khách hàng";

                CustomerUserControl custUserControl = new CustomerUserControl();
                TextBox txtCustName = custUserControl.Controls.Find("txtCustName", true)[0] as TextBox;
                TextBox txtCustAddress = custUserControl.Controls.Find("txtCustAddress", true)[0] as TextBox;
                TextBox txtPhone = custUserControl.Controls.Find("txtPhone", true)[0] as TextBox;
                Label lbCustId = custUserControl.Controls.Find("lbCustId", true)[0] as Label;
                Label lbHeader = custUserControl.Controls.Find("lbHeader", true)[0] as Label;

                txtCustName.Text = custName;
                txtCustAddress.Text = custAddress;
                txtPhone.Text = custPhone;
                lbCustId.Text = custID;
                lbHeader.Text = string.Format("Sửa thông tin khách hàng").ToUpper();

                custEditForm.Controls.Add(custUserControl);
                custEditForm.Width = custUserControl.Width;
                custEditForm.Height = custUserControl.Height;
                custEditForm.Show();
            }
        }
        
        private void btFindCust_Click(object sender, EventArgs e)
        {            
            grvCustomer.DataSource = this.customerTableAdapter1.GetDataByCustomerNameOrTelephone(string.Format("%{0}%", txtCustNameSearch.Text));
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form custAddForm = new Form();
            custAddForm.Text = "Thêm khách hàng mới";
            CustomerUserControl custUserControl = new CustomerUserControl();
            custAddForm.Controls.Add(custUserControl);
            custAddForm.Width = custUserControl.Width;
            custAddForm.Show();
        }

        private void txtCustNameSearch_TextChanged(object sender, EventArgs e)
        {            
            grvCustomer.DataSource = this.customerTableAdapter1.GetDataByCustomerNameOrTelephone(string.Format("%{0}%", txtCustNameSearch.Text));
        }
        
    }
}
