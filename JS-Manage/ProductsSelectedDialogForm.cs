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

        public bool isWorkingOnInputOrder { get; set; }
        public bool isWorkingOnOutputOrder { get; set; }
        public ProductsSelectedDialogForm()
        {
            InitializeComponent();            
        }

        private void ProductsSelectedDialogForm_Load(object sender, EventArgs e)
        {
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();
            int prodId = int.Parse(lbProdId.Text);
            JSManagementDataSet.ProductDataTable productData = productTableAdapter.GetProductByProdId(prodId);
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
            Form purchaseReceiptOrderForm = new Form();
            
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

                if (f.Name == "PurchaseReceiptOrderForm")
                {
                    purchaseReceiptOrderForm = f;
                }
            }
            if(isWorkingOnOutputOrder)
            {                
                DataGridView grvProducts = purchaseReceiptOrderForm.Controls.Find("grvProducts", true)[0] as DataGridView;
                int currentIndex = grvProducts.CurrentCell.RowIndex;

                for (int i = 0; i < checkedListBoxSize.CheckedItems.Count; i++)
                {
                    DataRowView castedItem = checkedListBoxSize.CheckedItems[i] as DataRowView;
                    DataGridViewRow row;
                    object productId = castedItem["ProductId"];
                    JSManagementDataSet.ProductDataTable prodData = productTableAdapter.GetDataByProductId(int.Parse(productId.ToString()));                    
                    
                    if(i != 0)
                    {
                        row = (DataGridViewRow)grvProducts.Rows[0].Clone(); 
                        grvProducts.NotifyCurrentCellDirty(true);
                        grvProducts.Rows.Insert(currentIndex + i, row);    
                    }

                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.PRODUCT_CODE].Value = prodData[0].ProductCode;
                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.PRODUCT_TYPE].Value = prodData[0].ProductType;
                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.PRODUCT_TYPE].ReadOnly = true;
                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.BRAND].Value = prodData[0].Brand;
                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.BRAND].ReadOnly = true;
                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.SIZE].Value = prodData[0].Size;
                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.SIZE].ReadOnly = true;
                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.QUANTITY].Value = Setting.GetIntergerSetting("ProductOutputQuantity") == 0 ? 1 : Setting.GetIntergerSetting("ProductInputQuantity");

                    grvProducts.Rows[currentIndex+i].Cells[Constant.ProductOutputColumnName.PRICE].Value = prodData[0].Price;
                    if (this.OutputTypeCode == Constant.OutputType.XTH)
                    {
                        if (LoginInfor.IsAdmin || Setting.GetBoolSetting(Constant.Setting.ALLOW_USER_VIEW_ALL_COST))
                            grvProducts.Rows[currentIndex + i].Cells[Constant.ProductOutputColumnName.SOLD_PRICE].Value = prodData[0].ProductCost;
                        else
                            grvProducts.Rows[currentIndex + i].Cells[Constant.ProductOutputColumnName.SOLD_PRICE].Value = 0;
                    }

                    grvProducts.Rows[currentIndex + i].Cells[Constant.ProductOutputColumnName.PRODUCT_ID].Value = productId;
                    grvProducts.Rows[currentIndex + i].Cells[Constant.ProductOutputColumnName.PRODUCT_ID].ReadOnly = true;
                   
                }
            }           
                
            if(isWorkingOnInputOrder)
            {
                DataGridView grvProducts = productInputForm.Controls.Find("grvProducts", true)[0] as DataGridView;
                int currentIndex = grvProducts.CurrentCell.RowIndex;

                for (int i = 0; i < checkedListBoxSize.CheckedItems.Count; i++)
                {
                    DataRowView castedItem = checkedListBoxSize.CheckedItems[i] as DataRowView;
                    decimal cost = 0;
                    int quantity = 1;
                    if (i == 0)
                    {
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.PRODUCT_CODE].Value = lbProductCode.Text;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.PRODUCT_TYPE].Value = lbProductType.Text;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.PRODUCT_TYPE].ReadOnly = true;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.BRAND].Value = lbBrand.Text;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.BRAND].ReadOnly = true;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.SIZE].Value = castedItem["Size"];
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.SIZE].ReadOnly = true;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.QUANTITY].Value = Setting.GetIntergerSetting("ProductInputQuantity") == 0 ? 1 : Setting.GetIntergerSetting("ProductInputQuantity");
                        quantity = (int)grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.QUANTITY].Value;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.PRODUCT_ID].Value = castedItem["ProductId"];
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.PRODUCT_ID].ReadOnly = true;
                        if (Setting.GetBoolSetting(Constant.Setting.ALLOW_USER_VIEW_ALL_COST) || LoginInfor.IsAdmin)
                        {
                            cost = productTableAdapter.GetDataByProductId(int.Parse(castedItem["ProductId"].ToString()))[0].ProductCost;
                        }
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.COST].Value = cost;
                        grvProducts.Rows[currentIndex].Cells[Constant.ProductInputColumnName.AMOUNT].Value = quantity * cost;
                    }
                    else
                    {
                        DataGridViewRow row = (DataGridViewRow)grvProducts.Rows[0].Clone();
                        grvProducts.NotifyCurrentCellDirty(true);
                        grvProducts.Rows.Insert(currentIndex + i, row);
                        row.Cells[Constant.ProductInputColumnName.PRODUCT_CODE].Value = lbProductCode.Text;
                        row.Cells[Constant.ProductInputColumnName.PRODUCT_TYPE].Value = lbProductType.Text;
                        row.Cells[Constant.ProductInputColumnName.PRODUCT_TYPE].ReadOnly = true;
                        row.Cells[Constant.ProductInputColumnName.BRAND].Value = lbBrand.Text;
                        row.Cells[Constant.ProductInputColumnName.BRAND].ReadOnly = true;
                        row.Cells[Constant.ProductInputColumnName.SIZE].Value = castedItem["Size"];
                        row.Cells[Constant.ProductInputColumnName.SIZE].ReadOnly = true;
                        row.Cells[Constant.ProductInputColumnName.QUANTITY].Value = Setting.GetIntergerSetting("ProductInputQuantity") == 0 ? 1 : Setting.GetIntergerSetting("ProductInputQuantity");
                        row.Cells[Constant.ProductInputColumnName.PRODUCT_ID].Value = castedItem["ProductId"];
                        row.Cells[Constant.ProductInputColumnName.PRODUCT_ID].ReadOnly = true;
                        if (Setting.GetBoolSetting(Constant.Setting.ALLOW_USER_VIEW_ALL_COST) || LoginInfor.IsAdmin)
                        {
                            cost = productTableAdapter.GetDataByProductId(int.Parse(castedItem["ProductId"].ToString()))[0].ProductCost;
                        }
                        row.Cells[Constant.ProductInputColumnName.COST].Value = cost;
                        row.Cells[Constant.ProductInputColumnName.AMOUNT].Value = quantity * cost;
                    }

                }
            }
            this.Close();
        }

        public string OutputTypeCode { get; set; }
    }
}
