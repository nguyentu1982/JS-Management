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
    public partial class ProductsSelectedDialogForm : Form
    {
        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter ;

        public ProductsSelectedDialogForm()
        {
            InitializeComponent();            
        }

        private void ProductsSelectedDialogForm_Load(object sender, EventArgs e)
        {
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();

            JSManagementDataSet.ProductDataTable productData = productTableAdapter.GetDataByProductCodeProductTypeBrand(lbProductCode.Text, lbProductType.Text, lbBrand.Text);
            ((ListBox)this.checkedListBoxSize).DataSource = productData;
            ((ListBox)this.checkedListBoxSize).DisplayMember = "Size";
            ((ListBox)this.checkedListBoxSize).ValueMember = "ProductId";
            //checkedListBoxSize.Items.Clear();
            //for (int i = 0; i < productData.Rows.Count; i++)
            //{
                
            //    checkedListBoxSize.Items.Add(productData[i].Size);
            //}
            
            productTableAdapter.Dispose();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();

            FormCollection fc = Application.OpenForms;
            Form productInputForm = new Form();
            
            foreach (Form f in fc)
            {
                if (f.Name == "productInputForm")
                {
                    productInputForm = f;
                }

                if (f.Name == "ProductSearchForm")
                {
                    Application.OpenForms["ProductSearchForm"].Close();
                }
                
            }

            DataGridView grvProducts = productInputForm.Controls.Find("grvProducts", true)[0] as DataGridView;
            int currentIndex = grvProducts.CurrentCell.RowIndex;

            for (int i = 0; i < checkedListBoxSize.CheckedItems.Count; i++)
            {
                DataRowView castedItem = checkedListBoxSize.CheckedItems[i] as DataRowView;
                decimal cost = 0;
                int quantity = 1;
                if (i == 0)
                {
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.PRODUCT_CODE_COLUMN_NAME].Value = lbProductCode.Text;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.PRODUCT_TYPE_COLUMNNAME].Value = lbProductType.Text;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.PRODUCT_TYPE_COLUMNNAME].ReadOnly = true;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.PRODUCT_BRAND_COLUMN_NAME].Value = lbBrand.Text;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.PRODUCT_BRAND_COLUMN_NAME].ReadOnly = true;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.SIZE_COLUMN_NAME].Value = castedItem["Size"];
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.SIZE_COLUMN_NAME].ReadOnly = true;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value = Setting.GetIntergerSetting("ProductInputQuantity") == 0 ? 1 : Setting.GetIntergerSetting("ProductInputQuantity");
                    quantity = (int)grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.PRODUCT_ID_COLUMN_NAME].Value = castedItem["ProductId"];
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.PRODUCT_ID_COLUMN_NAME].ReadOnly = true;
                    if (Setting.GetBoolSetting(Constant.Setting.ALLOW_USER_VIEW_ALL_COST) || LoginInfor.IsAdmin)
                    {
                        cost = productTableAdapter.GetDataByProductId(int.Parse(castedItem["ProductId"].ToString()))[0].ProductCost;
                    }
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.COST_COLUMN_NAME].Value = cost;
                    grvProducts.Rows[currentIndex].Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = quantity * cost;
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow )grvProducts.Rows[0].Clone();
                    grvProducts.NotifyCurrentCellDirty(true);
                    grvProducts.Rows.Insert(currentIndex + i, row);
                    row.Cells[Constant.ProductInput.PRODUCT_CODE_COLUMN_NAME].Value = lbProductCode.Text;
                    row.Cells[Constant.ProductInput.PRODUCT_TYPE_COLUMNNAME].Value = lbProductType.Text;
                    row.Cells[Constant.ProductInput.PRODUCT_TYPE_COLUMNNAME].ReadOnly = true;
                    row.Cells[Constant.ProductInput.PRODUCT_BRAND_COLUMN_NAME].Value = lbBrand.Text;
                    row.Cells[Constant.ProductInput.PRODUCT_BRAND_COLUMN_NAME].ReadOnly = true;
                    row.Cells[Constant.ProductInput.SIZE_COLUMN_NAME].Value = castedItem["Size"];
                    row.Cells[Constant.ProductInput.SIZE_COLUMN_NAME].ReadOnly = true;
                    row.Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value = Setting.GetIntergerSetting("ProductInputQuantity") == 0 ? 1 : Setting.GetIntergerSetting("ProductInputQuantity");
                    row.Cells[Constant.ProductInput.PRODUCT_ID_COLUMN_NAME].Value = castedItem["ProductId"];
                    row.Cells[Constant.ProductInput.PRODUCT_ID_COLUMN_NAME].ReadOnly = true;
                    if (Setting.GetBoolSetting(Constant.Setting.ALLOW_USER_VIEW_ALL_COST) || LoginInfor.IsAdmin)
                    {
                        cost = productTableAdapter.GetDataByProductId(int.Parse(castedItem["ProductId"].ToString()))[0].ProductCost;
                    }
                    row.Cells[Constant.ProductInput.COST_COLUMN_NAME].Value = cost;
                    row.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = quantity * cost;
                }
                                                         
            }
                
            //grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[10].Value = 0;
            //grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[11].Value = 0;
            this.Close();
        }
    }
}
