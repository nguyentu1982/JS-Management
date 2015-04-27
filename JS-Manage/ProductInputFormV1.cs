using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using System.Transactions;


namespace JS_Manage
{
    public partial class productInputFormV1 : Form
    {
        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        JSManagementDataSetTableAdapters.ProductInputTableAdapter productInputTableAdapter;
        JSManagementDataSetTableAdapters.ProductInput_ProductTableAdapter productInputProductTableAdapter;
        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;
        public bool isAdmin = false;
        int rowIndex=0;
        public productInputFormV1()
        {
            InitializeComponent();
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();
            productInputTableAdapter = new JSManagementDataSetTableAdapters.ProductInputTableAdapter();
            productInputTableAdapter.Connection = CommonHelper.GetSQLConnection();
            productInputProductTableAdapter = new JSManagementDataSetTableAdapters.ProductInput_ProductTableAdapter();
            productInputProductTableAdapter.Connection = CommonHelper.GetSQLConnection();
            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void ProductInputForm_Load(object sender, EventArgs e)
        {            
            LoadDefaultData();
            lbInputHeader.Text = "Nhập hàng".ToUpper();
            lbProductInputId.Text = string.Empty;            
            txtInputPrice.Visible = isAdmin;
            lbInputPrice.Visible = isAdmin;
            dateTimePicker1_ValueChanged(new object(), new EventArgs());
            if (LoginInfor.IsAdmin == false)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePicker1.Value.ToShortDateString()))
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

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string inputDate = dateTimePicker1.Text;
                string supplierId = txtCustomerCode.Text;
                string productCode = txtProductCode.Text;
                string productType = cbBoxProductType.Text;
                string brand = cbBoxBrand.Text;
                string size = cbBoxSize.Text;
                decimal quantity = numericUpDownQuantity.Value;
                string inputPrice = txtInputPrice.Text;
                string price = txtPrice.Text;
                int productId = 0;

                if (lbProductInputId.Text == "0")
                {
                    //if exists product
                    if (productTableAdapter.GetProductByCodeBrandSizeType(productCode, brand, size, productType).Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Mã hàng này đã có, bạn có muốn tiếp tục nhập", "Nhập hàng đã có", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            using (TransactionScope tran = new TransactionScope())
                            {
                                productId = productTableAdapter.GetProductByCodeBrandSizeType(productCode, brand, size, productType)[0].ProductId;
                                productInputTableAdapter.Insert(DateTime.Parse(inputDate), int.Parse(supplierId), productId, int.Parse(quantity.ToString()), decimal.Parse(inputPrice),null);
                                productTableAdapter.UpdateProductCommonInfoById(productCode, brand, size, decimal.Parse(inputPrice), productType, decimal.Parse(price), productId);
                                tran.Complete();
                            }                            
                            ClearData();
                            ReloadInputProductGrid();
                            MessageBox.Show("Nhập hàng thành công!");
                        }
                    }

                    //insert into product table
                    if (productTableAdapter.GetProductByCodeBrandSizeType(productCode, brand, size, productType).Rows.Count == 0)
                    {
                        using (TransactionScope tran = new TransactionScope())
                        {
                            productId = int.Parse(productTableAdapter.InsertProductReturnId(productCode, brand, size, decimal.Parse(inputPrice), decimal.Parse(price), productType, 0, 0, 0, 0).ToString());
                            productInputTableAdapter.Insert(DateTime.Parse(inputDate), int.Parse(supplierId), productId, int.Parse(quantity.ToString()), decimal.Parse(inputPrice),null);
                            tran.Complete();
                        }
                        ReloadInputProductGrid();
                        ClearData();                        
                        MessageBox.Show("Nhập hàng thành công!");
                    }
                }
                else
                {
                    productId = int.Parse(lbProductID.Text);
                    using (TransactionScope tran = new TransactionScope())
                    {
                        if (productInputTableAdapter.UpdateProductInputById(inputDate, int.Parse(supplierId), productId, int.Parse(quantity.ToString()), decimal.Parse(txtInputPrice.Text), int.Parse(lbProductInputId.Text)) > 0)
                        {
                            productTableAdapter.UpdateProductCommonInfoById(productCode, brand, size, decimal.Parse(inputPrice), productType, decimal.Parse(price), productId);
                            tran.Complete();
                            UpdateGridView();
                            ClearData();
                            MessageBox.Show("Sửa thành công!");
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập không thành công! Kiểm tra dữ liệu nhập");
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btFindSupplier_Click(object sender, EventArgs e)
        {
            CustomerForm customerList = new CustomerForm();            
            customerList.ShowDialog();
        }

        private void btFindProduct_Click(object sender, EventArgs e)
        {
            ProductSearchForm productSearchForm = new ProductSearchForm();
            productSearchForm.Text = "Tìm hàng nhập";
            productSearchForm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            grvInputProduct.DataSource = productInputProductTableAdapter.GetDataByInputDate(dateTimePicker1.Text);
            DisableColumnGridViewUserRole(grvInputProduct, "Cost");
            if (grvInputProduct.RowCount == 1)
                ClearData();
            if (LoginInfor.IsAdmin == false)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePicker1.Value.ToShortDateString()))
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

        private void ReloadInputProductGrid()
        {
            grvInputProduct.DataSource = productInputProductTableAdapter.GetDataByInputDateNewestFirst(dateTimePicker1.Text);            
            DisableColumnGridViewUserRole(grvInputProduct, "Cost");           

            if (grvInputProduct.RowCount == 1)
                ClearData();
            if (LoginInfor.IsAdmin == false)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePicker1.Value.ToShortDateString()))
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

        private void lbProductID_TextChanged(object sender, EventArgs e)
        {
            if (lbProductID.Text == "0")
            {
                cbBoxProductType.Enabled = true;
                cbBoxBrand.Enabled = true;
                cbBoxSize.Enabled = true;
            }
            else
            {
                cbBoxProductType.Text = productTableAdapter.GetDataByProductId(int.Parse(lbProductID.Text))[0].ProductType;
                cbBoxProductType.Enabled = false;
                cbBoxBrand.Text = productTableAdapter.GetDataByProductId(int.Parse(lbProductID.Text))[0].Brand;
                cbBoxBrand.Enabled = false;
                cbBoxSize.Text = productTableAdapter.GetDataByProductId(int.Parse(lbProductID.Text))[0].Size;
                cbBoxSize.Enabled = false;
            }
        }

        private void DisableColumnGridViewUserRole(DataGridView gridView, string dataPropertyName)
        {
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].DataPropertyName == dataPropertyName)
                {
                    gridView.Columns[i].Visible = isAdmin;
                }
            }
        }

        private void grvInputProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        private void BindDataToEdit(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == grvInputProduct.RowCount - 1)
                return;
            lbInputHeader.Text = "Sửa hàng nhập".ToUpper();
            DataGridViewRow row = grvInputProduct.Rows[e.RowIndex];
            string productInputId = row.Cells[0].Value.ToString();
            string inputDate = row.Cells[1].Value.ToString();
            string supplierId = row.Cells[2].Value.ToString();
            string productId = row.Cells[3].Value.ToString();


            string quantity = row.Cells[4].Value.ToString();
            string productCost = row.Cells[5].Value.ToString();
            string productCode = row.Cells[6].Value.ToString();
            string productType = row.Cells[7].Value.ToString();
            string brand = row.Cells[8].Value.ToString();
            string size = row.Cells[9].Value.ToString();
            string price = row.Cells[10].Value.ToString();

            lbProductInputId.Text = productInputId;
            txtCustomerCode.Text = supplierId;
            txtProductCode.Text = productCode;
            lbProductID.Text = productId;
            cbBoxSize.Text = size;
            cbBoxBrand.Text = brand;
            cbBoxProductType.Text = productType;
            numericUpDownQuantity.Value = decimal.Parse(quantity == string.Empty ? "0" : quantity);
            txtInputPrice.Text = productCost;
            txtPrice.Text = price;
            lbProductID_TextChanged(new object(), new EventArgs());
            btDelete.Visible = true;
            btAddNew.Visible = true;
            btCopyProduct.Visible = true;
            rowIndex = e.RowIndex;
        }

        private void UpdateGridView()
        {
            DataGridViewRow row = grvInputProduct.Rows[rowIndex];
                        
            grvInputProduct.Rows[rowIndex].Cells[2].Value = txtCustomerCode.Text;
            grvInputProduct.Rows[rowIndex].Cells[3].Value = lbProductID.Text;
            grvInputProduct.Rows[rowIndex].Cells[4].Value = numericUpDownQuantity.Value;
            grvInputProduct.Rows[rowIndex].Cells[5].Value = txtInputPrice.Text;
            grvInputProduct.Rows[rowIndex].Cells[6].Value = txtProductCode.Text;
            grvInputProduct.Rows[rowIndex].Cells[7].Value = cbBoxProductType.Text;
            grvInputProduct.Rows[rowIndex].Cells[8].Value = cbBoxBrand.Text;
            grvInputProduct.Rows[rowIndex].Cells[9].Value = cbBoxSize.Text;
            grvInputProduct.Rows[rowIndex].Cells[10].Value = txtPrice.Text;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa hàng nhập này?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (productInputTableAdapter.DeleteProductInputById(int.Parse(lbProductInputId.Text)) > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        dateTimePicker1_ValueChanged(new object(), new EventArgs());
                        ClearData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            
            LoadDefaultData();
            ClearData();
        }

        private void ClearData()
        {
            lbInputHeader.Text = "Nhập hàng".ToUpper();
            lbProductInputId.Text = "0";
            txtCustomerCode.Text = string.Empty;
            lbCustomerInfo.Text = string.Empty;
            txtProductCode.Text = string.Empty;
            lbProductID.Text = "0";
            cbBoxProductType.Text = string.Empty;
            cbBoxBrand.Text = string.Empty;
            cbBoxSize.Text = string.Empty;
            numericUpDownQuantity.Value = 1;
            txtInputPrice.Text = "0";
            txtPrice.Text = string.Empty;
            
        }

        private void LoadDefaultData()
        {
            JSManagementDataSetTableAdapters.BrandTableAdapter brandTableAdapter = new JSManagementDataSetTableAdapters.BrandTableAdapter();
            brandTableAdapter.Connection = CommonHelper.GetSQLConnection();
            JSManagementDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter = new JSManagementDataSetTableAdapters.ProductTypeTableAdapter();
            productTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();
            JSManagementDataSetTableAdapters.SizeTableAdapter sizeTableAdapter = new JSManagementDataSetTableAdapters.SizeTableAdapter();            
            sizeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            cbBoxBrand.DataSource = brandTableAdapter.GetDistinctBrand();

            cbBoxProductType.DataSource = productTypeTableAdapter.GetDistinctProductType();

            cbBoxSize.DataSource = sizeTableAdapter.GetDistinctSize();
        }

        private void grvInputProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
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

        private void btCopyProduct_Click(object sender, EventArgs e)
        {
            lbInputHeader.Text = "Nhập Hàng".ToUpper();
            lbProductInputId.Text = "0";
            cbBoxBrand.Enabled = true;
            cbBoxProductType.Enabled = true;
            cbBoxSize.Enabled = true;
            lbProductID.Text = "0";
        }

        private void lbInputPrice_Click(object sender, EventArgs e)
        {
            txtInputPrice.Visible = !txtInputPrice.Visible;
            grvInputProduct.Columns[5].Visible = txtInputPrice.Visible;
        }

        private void productInputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }       
        
    }
}
