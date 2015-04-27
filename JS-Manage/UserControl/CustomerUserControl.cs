using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace JS_Manage
{
    public partial class CustomerUserControl : UserControl
    {
        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;
        public CustomerUserControl()
        {
            InitializeComponent();
            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCustId.Text == "0")
                {
                    lbHeader.Text = string.Format("Thêm khách hàng mới").ToUpper();
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm khách hàng mới?", "Thêm khách hàng mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        //custTableAdapter.Insert(txtCustName.Text, txtCustAddress.Text, txtPhone.Text, txtNote.Text);
                       // MessageBox.Show("Thêm khách hàng mới thành công");
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin?", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {                        
                        //custTableAdapter.UpdateCustomerById(txtCustName.Text, txtCustAddress.Text, txtPhone.Text, txtNote.Text , int.Parse(lbCustId.Text));
                        //MessageBox.Show("Sửa thông tin khách hàng thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kiểm tra dữ liệu nhập!");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn XÓA thông tin?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {                
                custTableAdapter.DeleteCustomerById(int.Parse( lbCustId.Text));
                MessageBox.Show("Xóa thông tin khách hàng thành công!");
            }
        }

        private void ReloadCustomer()
        {
            FormCollection fc = Application.OpenForms;
            Form mainform = new Form();
            foreach (Form f in fc)
            {
                if (f.Name == "CustomerForm")
                {
                    mainform = f;
                }
            }           
            
        }

        private void lbCustId_TextChanged(object sender, EventArgs e)
        {
            int custId;
            if(int.TryParse(lbCustId.Text, out custId))
            {
                getProductInOutDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();
                dataGridView1.DataSource = getProductInOutDetailTableAdapter.GetProductInOutDetailByCustomerId(custId);
                
                if (!Setting.GetBoolSetting("AllowUserViewAllCost") && !LoginInfor.IsAdmin)
                {
                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        if (r.Cells["Action"].Value != null)
                        {
                            if (((bool.Parse(r.Cells["IsReturnSupplier"].Value.ToString())) && r.Cells["Action"].Value.ToString().Trim().ToLower() == "xuất") || r.Cells["Action"].Value.ToString() == "nhập")
                            {
                                r.Cells["Price"].Value = 0;
                                r.Cells["Amount"].Value = 0;
                                r.Cells["ClosingBalanceAmount"].Value = 0;
                                //r.Cells["ClosingBalance"].Value = 0;
                            }
                        }
                    }
                }

                dataGridView1.Columns["Action"].DisplayIndex = 0;
                dataGridView1.Columns["Date"].DisplayIndex = 1;
                dataGridView1.Columns["ProductCode"].DisplayIndex = 2;
                dataGridView1.Columns["ProductType"].DisplayIndex = 3;
                dataGridView1.Columns["Brand"].DisplayIndex = 4;
                dataGridView1.Columns["Size"].DisplayIndex = 5;
                dataGridView1.Columns["Quantity"].DisplayIndex = 6;
                dataGridView1.Columns["Price"].DisplayIndex = 7;
                dataGridView1.Columns["Price"].DefaultCellStyle.Format = string.Format("#,###");
                dataGridView1.Columns["Amount"].DisplayIndex = 8;
                dataGridView1.Columns["Amount"].DefaultCellStyle.Format = string.Format("#,###");
                dataGridView1.Columns["IsReturnSupplier"].DisplayIndex = 9;
                dataGridView1.Columns["ClosingBalanceAmount"].DisplayIndex = 10;
                dataGridView1.Columns["ClosingBalanceAmount"].DefaultCellStyle.Format = string.Format("#,###");
                dataGridView1.Columns["ClosingBalance"].DisplayIndex = 11;
                dataGridView1.Columns["ProInOutDetailId"].DisplayIndex = 12;
            }
            
        }       
    }
}
