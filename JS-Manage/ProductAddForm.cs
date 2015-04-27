using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class ProductAddForm : Form
    {
        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        public ProductAddForm()
        {
            InitializeComponent();
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            decimal inputPrice = decimal.Parse(txtInputPrice.Text);
            decimal price = decimal.Parse(txtPrice.Text);

            using (TransactionScope tran = new TransactionScope())
            {
                foreach (object item in chkListBoxSize.CheckedItems)
                {
                    productTableAdapter.InsertProductReturnId(productCode, brand, item.ToString(), inputPrice, price, productType, 0, 0, 0, 0);
                }

                tran.Complete();
            }

            DialogResult result = MessageBox.Show("Tạo mã hàng thành công, bạn có muốn tạo mã hàng mới?", "Tạo mã hàng thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ClearData();
            }
            else
            {
                this.Close();
            }
        }

        private void ClearData()
        {            
            txtProductCode.Text = string.Empty;
            cbBoxProductType.Text = string.Empty;
            cbBoxBrand.Text = string.Empty;           
            txtInputPrice.Text = "0";
            txtPrice.Text = string.Empty;
            foreach (int i in chkListBoxSize.CheckedIndices)
            {
                chkListBoxSize.SetItemCheckState(i, CheckState.Unchecked);
            }
            txtProductCode.Focus();
        }

        private bool ValidateData()
        {
            decimal inputPrice = 0;
            decimal price = 0;
            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            bool isProductExisted=false;

            if (string.IsNullOrEmpty(txtProductCode.Text) || string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("Bạn hãy nhập mã hàng!");
                return false;
            }

            if (string.IsNullOrEmpty(cbBoxProductType.Text) || string.IsNullOrWhiteSpace(cbBoxProductType.Text))
            {
                MessageBox.Show("Bạn hãy nhập loại hàng!");
                return false;
            }


            if (string.IsNullOrEmpty(cbBoxBrand.Text) || string.IsNullOrWhiteSpace(cbBoxBrand.Text))
            {
                MessageBox.Show("Bạn hãy nhập nhãn hiệu!");
                return false;
            }

            if (chkListBoxSize.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn hãy nhập size!");
                return false;
            }

            
            if (!decimal.TryParse(txtInputPrice.Text, out inputPrice))
            {
                MessageBox.Show("Giá nhập không hợp lệ");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }

            foreach (object item in chkListBoxSize.CheckedItems)
            {
                if (productTableAdapter.GetProductByCodeBrandSizeType(productCode, brand, item.ToString(), productType).Rows.Count > 0)
                {
                    MessageBox.Show(string.Format("Mã hàng: {0}, Loại hàng: {1}, Nhãn hiệu: {2}, Size: {3} đã có!", productCode, productType, brand, item.ToString()));
                    isProductExisted = true;
                }
            }

            if (isProductExisted)
            {
                return false;
            }

            return true;
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {
            JSManagementDataSetTableAdapters.BrandTableAdapter brandTableAdapter = new JSManagementDataSetTableAdapters.BrandTableAdapter();
            brandTableAdapter.Connection = CommonHelper.GetSQLConnection();
            JSManagementDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter = new JSManagementDataSetTableAdapters.ProductTypeTableAdapter();
            productTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();            

            cbBoxBrand.DataSource = brandTableAdapter.GetDistinctBrand();

            cbBoxProductType.DataSource = productTypeTableAdapter.GetDistinctProductType();
            
        }
    }
}
