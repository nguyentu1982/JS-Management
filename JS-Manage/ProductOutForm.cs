using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JS_Manage
{
    public partial class productOutputForm : Form
    {
        JSManagementDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;
        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        public bool isAdmin = false;
        public productOutputForm()
        {
            InitializeComponent();
            ordersTableAdapter = new JSManagementDataSetTableAdapters.OrdersTableAdapter();
            ordersTableAdapter.Connection = CommonHelper.GetSQLConnection();
            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbOrderId.Text == "0")
                {
                    DateTime orderDate = dateTimePickerOrderDate.Value;
                    int custId = 0;
                    custId = int.Parse(txtCustomerCode.Text);
                    int productId = int.Parse(lbProductID.Text);
                    string size = cbBoxSize.Text;
                    int quantity = int.Parse(numericUpDownQuantity.Value.ToString());
                    decimal price = decimal.Parse(txtPrice.Text);
                    string billNumber = txtBillNumber.Text;
                    bool isCOD = chkIsCOD.Checked;

                    if (ordersTableAdapter.Insert(orderDate, custId, productId, size, quantity, price, billNumber, isCOD, null) > 0)
                    {
                        MessageBox.Show("Thành công!");
                        dateTimePickerOrderDate_ValueChanged(new object(), new EventArgs());
                        ClearData();
                    }
                }
                else
                {
                    int orderId = int.Parse(lbOrderId.Text);
                    DateTime orderDate = dateTimePickerOrderDate.Value;
                    int custId = 0;
                    custId = int.Parse(txtCustomerCode.Text);
                    int productId = int.Parse(lbProductID.Text);
                    string size = cbBoxSize.Text;
                    int quantity = int.Parse(numericUpDownQuantity.Value.ToString());
                    decimal price = decimal.Parse(txtPrice.Text);
                    string billNumber = txtBillNumber.Text;
                    bool isCOD = chkIsCOD.Checked;
                    if(ordersTableAdapter.UpdateOrderById(orderDate.ToShortDateString(), custId, productId, size, quantity, price, billNumber, isCOD, orderId) > 0)
                    {
                        MessageBox.Show("Sửa Thành công!");
                        dateTimePickerOrderDate_ValueChanged(new object(), new EventArgs());
                    }
                }                
            }
            catch 
            {
                MessageBox.Show("Kiểm tra các số liệu");
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {           
            if (lbOrderId.Text == "0")
            {
                lbOrderHeader.Text = "Xuất hàng".ToUpper();
            }
            dateTimePickerOrderDate_ValueChanged(new object(), new EventArgs());
        }                

        private void btProductCodeSearch_Click(object sender, EventArgs e)
        {
            ProductSearchForm productSearchForm = new ProductSearchForm();
            productSearchForm.ShowDialog();
        }

        private void dateTimePickerOrderDate_ValueChanged(object sender, EventArgs e)
        {           
            try
            {
                grvOrders.DataSource = ordersTableAdapter.GetDataByOrderDate(dateTimePickerOrderDate.Text);
                if (grvOrders.RowCount == 1)
                {
                    ClearData();
                }
                if (LoginInfor.IsAdmin == false)
                {
                    if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                    {
                        if (!CommonHelper.GetActiveDates().Contains(dateTimePickerOrderDate.Value.ToShortDateString()))
                        {
                            btSave.Enabled = false;
                            btDelete.Enabled = false;
                            btAddNew.Enabled = false;
                            return;
                        }
                    }                    
                    btSave.Enabled = true;
                    btDelete.Enabled = true;
                    btAddNew.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btFindCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm customerList = new CustomerForm();            
            customerList.ShowDialog();
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            ProductSearchForm productSearchForm = new ProductSearchForm();
            productSearchForm.Controls.Find("txtProductCodeSearch", true)[0].Text = txtProductCode.Text;           
            productSearchForm.ShowDialog();
            

        }

        private void grvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerCode.Text))
            {
                lbCustomerInfo.Text = string.Empty;
            }
            else 
            {
                int custId;
                if (int.TryParse(txtCustomerCode.Text, out custId))
                {
                    var custData = custTableAdapter.GetDataByCustomerId(custId);
                    lbCustomerInfo.Text = string.Empty;
                    if (custData.Rows.Count > 0)
                    {
                        lbCustomerInfo.Text = string.Format("{0}/ {1}/ {2}", custData[0].CustomerName, custData[0].Address, custData[0].Telephone);
                    }
                }          
                
            }
        } 

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn XÓA thông tin?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (ordersTableAdapter.DeleteOrderById(int.Parse(lbOrderId.Text)) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    dateTimePickerOrderDate_ValueChanged(new object(), new EventArgs());
                }
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
            btDelete.Visible = false;
        }

        private void cbBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(new object(), new EventArgs());
            }
            if (e.KeyChar == (char)9)
            {
                button1_Click(new object(), new EventArgs());
            }
        }

        private void grvOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        #region Ultility

        private void BindDataToEdit(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == grvOrders.RowCount - 1)
                return;
            DataGridViewRow row = grvOrders.Rows[e.RowIndex];
            string orderId = row.Cells[0].Value.ToString();
            string orderDate = row.Cells[1].Value.ToString();
            string custId = row.Cells[2].Value.ToString();
            string productCode = row.Cells[3].Value.ToString();
            string productId = row.Cells[10].Value.ToString();
            string size = row.Cells[4].Value.ToString();
            string quantity = row.Cells[5].Value.ToString();
            string price = row.Cells[6].Value.ToString();
            string billNumber = row.Cells[8].Value.ToString();
            bool isCOD = bool.Parse(row.Cells[9].Value.ToString());
            string settedPrice = row.Cells[11].Value.ToString();
            lbOrderId.Text = orderId;
            lbOrderHeader.Text = "Sửa hàng xuất".ToUpper();
            
            txtCustomerCode.Text = custId;
            txtProductCode.Text = productCode;
            lbProductID.Text = productId;
            cbBoxSize.Text = size;
            numericUpDownQuantity.Value = decimal.Parse(quantity == string.Empty ? "0" : quantity);
            txtPrice.Text = price;
            txtBillNumber.Text = billNumber;
            chkIsCOD.Checked = isCOD;
            lbPrice.Text = settedPrice;
            cbBoxBrand.Text = productTableAdapter.GetDataByProductId(int.Parse(productId))[0].Brand;
            cbBoxProductType.Text = productTableAdapter.GetDataByProductId(int.Parse(productId))[0].ProductType;
            cbBoxSize.Text = productTableAdapter.GetDataByProductId(int.Parse(productId))[0].Size;
            btDelete.Visible = true;
            btAddNew.Visible = true;
        }

        private void ClearData()
        {
            lbOrderHeader.Text = "Xuất hàng".ToUpper();
            lbOrderId.Text = "0";
            txtCustomerCode.Text = string.Empty;
            txtProductCode.Text = string.Empty;
            cbBoxBrand.DataSource = null;
            cbBoxBrand.Items.Clear();
            cbBoxBrand.Text = string.Empty;
            cbBoxProductType.DataSource = null;
            cbBoxProductType.Items.Clear();
            cbBoxProductType.Text = string.Empty;
            cbBoxSize.DataSource = null;
            cbBoxSize.Items.Clear();
            cbBoxSize.Text = string.Empty;
            numericUpDownQuantity.Value = 1;
            txtPrice.Text = string.Empty;
            chkIsCOD.Checked = false;
            txtBillNumber.Text = string.Empty;
            lbPrice.Text = string.Empty;
            lbProductID.Text = "0";
        }        

        #endregion Ultility
    }
}
