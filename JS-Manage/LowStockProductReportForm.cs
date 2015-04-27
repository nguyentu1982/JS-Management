using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class LowStockProductReportForm : Form
    {
        private System.Windows.Forms.PrintDialog prnDialog;
        private System.Windows.Forms.PrintPreviewDialog prnPreview;
        private System.Drawing.Printing.PrintDocument prnDocument;

        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        
        public int purchaseReceiptOrderProductGridRowIndex;
        public bool isOpenedByPurchaseReceiptOrder = false;
        public int inputProductGridRowIndex;
        public bool isOpenedByInputProduct=false;
        public LowStockProductReportForm()
        {
            InitializeComponent();
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            this.productTableAdapter.Connection = CommonHelper.GetSQLConnection();
            getProductInOutDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();

            this.prnDialog = new System.Windows.Forms.PrintDialog();
            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            // the Event of 'PrintPage'
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler
                        (prnDocument_PrintPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtProductCode_TextChanged(new object(), new EventArgs());
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            lbProductHeader.Text = "Thêm mã sản phẩm".ToUpper();
            txtInputPrice.Visible = LoginInfor.IsAdmin;
            lbInputPrice.Visible = LoginInfor.IsAdmin;            
            LoadDefaultData();

            if (isOpenedByInputProduct || isOpenedByPurchaseReceiptOrder)
            {
                
            }

            string productCode = txtProductCodeSearch.Text;
            //grvProductList.DataSource = productTableAdapter.SearchProducts(productCode, comboBoxProductTypeFind.Text, comboBoxBrandFind.Text, comboBoxSizeFind.Text, chkIsInStock.Checked);
            //FormatProductListGridview();
            
            grvProductList.CellEnter += dataGridView1_CellEnter;
            customerSelectUserControl1.CustomerIdTextChanged += customerSelectUserControl1_CustomerIdTextChanged;
        }

        void customerSelectUserControl1_CustomerIdTextChanged(object sender, EventArgs e)
        {
            txtProductCode_TextChanged(new object(), new EventArgs());
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            JSManagementDataSetTableAdapters.LowStockProductsTableAdapter lowstockTableAdapter = new JSManagementDataSetTableAdapters.LowStockProductsTableAdapter();
            lowstockTableAdapter.Connection = CommonHelper.GetSQLConnection();
            string productCode = txtProductCodeSearch.Text;
            int lowerQuantity = (int)numericUpDownLowerQuantity.Value;
            grvProductList.DataSource = lowstockTableAdapter.SearchLowStockProducts(productCode, comboBoxProductTypeFind.Text, comboBoxBrandFind.Text, comboBoxSizeFind.Text, customerSelectUserControl1.CustId, lowerQuantity);
            
            FormatProductListGridview();

            
        }

        private void PassProductInforToProductInputForm(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvProductList.Rows[e.RowIndex];

            

            string productId = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_ID].Value.ToString();
            string productCode = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_CODE].Value.ToString();
            string brand = row.Cells[Constant.ProductSearch.ProductGridColumnName.BRAND].Value.ToString();
            string productType = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_TYPE].Value.ToString();
            string productCost = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_COST].Value.ToString();
            string price = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRICE].Value.ToString();
            string size = row.Cells[Constant.ProductSearch.ProductGridColumnName.SIZE].Value.ToString();
            string openingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.OPENING_BALANCE].Value.ToString();
            string input = row.Cells[Constant.ProductSearch.ProductGridColumnName.INPUT].Value.ToString();
            string output = row.Cells[Constant.ProductSearch.ProductGridColumnName.OUTPUT].Value.ToString();
            string closingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.CLOSING_BALANCE].Value.ToString();

            if (Setting.GetBoolSetting(Constant.Setting.Select_Multi_Product_On_Input))
            {
                ProductsSelectedDialogForm proSelectedDialogForm = new ProductsSelectedDialogForm();
                Label lbProductCode = proSelectedDialogForm.Controls.Find(Constant.ProductsSelectedDialog.PRODUCT_CODE_LABEL_CONTROL_NAME,true)[0] as Label;
                Label lbProductType = proSelectedDialogForm.Controls.Find(Constant.ProductsSelectedDialog.PRODUCT_TYPE_LABEL_CONTROL_NAME, true)[0] as Label;
                Label lbProductBrand = proSelectedDialogForm.Controls.Find(Constant.ProductsSelectedDialog.PRODUCT_BRAND_LABEL_CONTROL_NAME, true)[0] as Label;

                lbProductCode.Text = productCode;
                lbProductType.Text = productType;
                lbProductBrand.Text = brand;
                
                proSelectedDialogForm.StartPosition = FormStartPosition.CenterScreen;
                proSelectedDialogForm.ShowDialog();
                
                return;
            }

            FormCollection fc = Application.OpenForms;
            Form productInputForm = new Form();
            foreach (Form f in fc)
            {
                if (f.Name == "productInputForm")
                {
                    productInputForm = f;
                }
            }

            DataGridView grvProducts = productInputForm.Controls.Find("grvProducts", true)[0] as DataGridView;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[0].Value = productCode;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[1].Value = productType;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[1].ReadOnly = true;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[2].Value = brand;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[2].ReadOnly = true;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[3].Value = size;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[3].ReadOnly = true;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[4].Value = Setting.GetIntergerSetting("ProductInputQuantity") == 0 ? 1 : Setting.GetIntergerSetting("ProductInputQuantity");
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[7].Value = productId;
            grvProducts.Rows[grvProducts.CurrentCell.RowIndex].Cells[7].ReadOnly = true;
            //grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[10].Value = 0;
            //grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[11].Value = 0;
            this.Close();
        }

        private void PassProductInforToPurchaseReceiptOrderForm(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvProductList.Rows[e.RowIndex];
            string productId = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_ID].Value.ToString();
            string productCode = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_CODE].Value.ToString();
            string brand = row.Cells[Constant.ProductSearch.ProductGridColumnName.BRAND].Value.ToString();
            string productType = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_TYPE].Value.ToString();
            string productCost = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_COST].Value.ToString();
            string price = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRICE].Value.ToString();
            string size = row.Cells[Constant.ProductSearch.ProductGridColumnName.SIZE].Value.ToString();
            string openingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.OPENING_BALANCE].Value.ToString();
            string input = row.Cells[Constant.ProductSearch.ProductGridColumnName.INPUT].Value.ToString();
            string output = row.Cells[Constant.ProductSearch.ProductGridColumnName.OUTPUT].Value.ToString();
            string closingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.CLOSING_BALANCE].Value.ToString();
            

            FormCollection fc = Application.OpenForms;
            Form PurchaseReceiptOrderForm = new Form();
            foreach (Form f in fc)
            {
                if (f.Name == "PurchaseReceiptOrderForm")
                {
                    PurchaseReceiptOrderForm = f;
                }                
            }

            DataGridView grvProducts = PurchaseReceiptOrderForm.Controls.Find("grvProducts", true)[0] as DataGridView;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[0].Value = productCode;            
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[1].Value = productType;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[1].ReadOnly = true;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[2].Value = brand;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[2].ReadOnly = true;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[3].Value = size;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[3].ReadOnly = true;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[4].Value = price;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[4].ReadOnly = true;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[5].Value = Setting.GetIntergerSetting("DefaultQuantityForOder") == 0 ? 1 : Setting.GetIntergerSetting("DefaultQuantityForOder");
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[8].Value = productId;
            grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[9].Value = closingBalance;
            //grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[10].Value = 0;
            //grvProducts.Rows[purchaseReceiptOrderProductGridRowIndex].Cells[11].Value = 0;
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                

                string productCode = txtProductCode.Text;
                string productType = cbBoxProductType.Text;
                string brand = cbBoxBrand.Text;
                string size = cbBoxSize.Text.Trim();

                if (lbProductId.Text == "0")
                {
                    if (productTableAdapter.GetProductByCodeBrandSizeType(productCode, brand, size, productType).Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Mã hàng này đã có, bạn có muốn sửa mã hàng?", "Sửa mã hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            int productId = productTableAdapter.GetProductByCodeBrandSizeType(productCode, brand, size, productType)[0].ProductId;
                            UpdateProduct(productId);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show(string.Format("Bạn có muốn thêm mã hàng {0} Hiệu: {1} Size: {2}?", productCode, brand, size), "Thêm mã hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            InsertProduct();                            
                        }
                    }
                }
                else
                {
                    
                    DialogResult result = MessageBox.Show(string.Format("Bạn có muốn sửa mã hàng {0} Hiệu: {1} Size: {2}?", productCode, brand, size), "Sửa mã hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        UpdateProduct(int.Parse(lbProductId.Text));                         
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra dữ liệu nhập");
                MessageBox.Show(ex.ToString());
            }
        }

        private void UpdateProduct(int productId)
        {
            if (LoginInfor.IsAdmin == false)
            {
                if (!Setting.GetBoolSetting("AllowUserEditProduct"))
                {
                    MessageBox.Show("Bạn không có quyền sửa mã hàng!");
                    return;
                }
            }

            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            string size = cbBoxSize.Text;
            decimal productCost = decimal.Parse(txtInputPrice.Text == string.Empty ? "0" : txtInputPrice.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int openningBalance = int.Parse(numericUpDownOpeningBalance.Value.ToString());
            int input = int.Parse(numericUpDownInput.Value.ToString());
            int output = int.Parse(numericUpDownOutput.Value.ToString());
            int closingBalance = int.Parse(numericUpDownClosingBalance.Value.ToString());
            
            if (productTableAdapter.UpdateProductById(productCode, brand, size, productCost, price, productType, openningBalance, input, output, closingBalance, productId) > 0)
            {
                MessageBox.Show("Sửa mã hàng thành công!");
                txtProductCode_TextChanged(new object(), new EventArgs());
            }
        }

        private void InsertProduct()
        {
            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            string size = cbBoxSize.Text;
            decimal productCost = decimal.Parse(txtInputPrice.Text == string.Empty ? "0" : txtInputPrice.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            int openningBalance = int.Parse(numericUpDownOpeningBalance.Value.ToString());
            int input = int.Parse(numericUpDownInput.Value.ToString());
            int output = int.Parse(numericUpDownOutput.Value.ToString());
            int closingBalance = int.Parse(numericUpDownClosingBalance.Value.ToString());

            if (int.Parse(productTableAdapter.InsertProductReturnId(productCode, brand, size, productCost, price, productType, openningBalance, input, output, closingBalance).ToString()) > 0)
            {
                MessageBox.Show("Thêm mã hàng thành công");
                ClearData();
                txtProductCode_TextChanged(new object(), new EventArgs());
            }
        }

        private void ClearData()
        {
            lbProductHeader.Text = "Thêm mã hàng mới".ToUpper();
            lbProductId.Text = "0";           
            txtProductCode.Text = string.Empty;            
            cbBoxProductType.Text = string.Empty;
            cbBoxBrand.Text = string.Empty;
            cbBoxSize.Text = string.Empty;
            numericUpDownOpeningBalance.Value = 0;
            txtInputPrice.Text = "0";
            txtPrice.Text = string.Empty;
            numericUpDownClosingBalance.Value = 0;
            numericUpDownInput.Value = 0;
            numericUpDownOutput.Value = 0;
            
        }

        private void FormatProductListGridview()
        {
            grvProductList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            grvProductList.ColumnHeadersHeight = 25;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.PRODUCT_ID].Visible = false;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.PRODUCT_CODE].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.PRODUCT_CODE;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.BRAND].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.BRAND;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.PRODUCT_TYPE].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.PRODUCT_TYPE;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.PRODUCT_COST].Visible = false;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.PRICE].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.PRICE;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.SIZE].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.SIZE;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.OPENING_BALANCE].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.OPENING_BALANCE;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.INPUT].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.INPUT;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.OUTPUT].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.OUTPUT;
            grvProductList.Columns[Constant.ProductSearch.ProductGridColumnName.CLOSING_BALANCE].HeaderText = Constant.ProductSearch.ProductGridColumnHeader.CLOSING_BALANCE;
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginInfor.IsAdmin == false)
                {
                    if (!Setting.GetBoolSetting("AllowUserEditProduct"))
                    {
                        MessageBox.Show("Bạn không có quyền xóa sản phẩm");
                        return;
                    }
                }
                DialogResult result = MessageBox.Show("Bạn có muốn xóa mã hàng này?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {                    
                    if (productTableAdapter.DeleteProductById(int.Parse(lbProductId.Text)) > 0)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công");
                        txtProductCode_TextChanged(new object(), new EventArgs());
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
            ClearData();
            ProductAddForm productAddForm = new ProductAddForm();
            productAddForm.ShowDialog();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {            
            BindData(e);
        }

        private void BindData(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvProductList.RowCount-1)
                return;
            btDelete.Visible = true;
            btAddNew.Visible = true;
            DataGridViewRow row = grvProductList.Rows[e.RowIndex];
            string productId = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_ID].Value.ToString();
            string productCode = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_CODE].Value.ToString();
            string brand = row.Cells[Constant.ProductSearch.ProductGridColumnName.BRAND].Value.ToString();
            string productType = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_TYPE].Value.ToString();
            string productCost = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_COST].Value.ToString();
            string price = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRICE].Value.ToString();
            string size = row.Cells[Constant.ProductSearch.ProductGridColumnName.SIZE].Value.ToString();
            string openingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.OPENING_BALANCE].Value.ToString();
            string input = row.Cells[Constant.ProductSearch.ProductGridColumnName.INPUT].Value.ToString();
            string output = row.Cells[Constant.ProductSearch.ProductGridColumnName.OUTPUT].Value.ToString();
            string closingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.CLOSING_BALANCE].Value.ToString();
            lbProductHeader.Text = string.Format("Sửa mã hàng {0} Hiệu:{1} Size:{2}", productCode, brand, size);
            txtProductCode.Text = productCode;
            cbBoxProductType.Text = productType;
            cbBoxBrand.Text = brand;
            lbProductId.Text = productId;
            txtPrice.Text = price;
            cbBoxSize.Text = size;
            txtInputPrice.Text = productCost;
            numericUpDownOpeningBalance.Value = decimal.Parse(openingBalance == string.Empty ? "0" : openingBalance);
            numericUpDownInput.Value = decimal.Parse(input == string.Empty ? "0" : input);
            numericUpDownOutput.Value = decimal.Parse(output == string.Empty ? "0" : output);
            numericUpDownClosingBalance.Value = decimal.Parse(closingBalance == string.Empty ? "0" : closingBalance);

            grvProductInOutDetail.DataSource = getProductInOutDetailTableAdapter.GetProductInOutDetailByProductId(int.Parse(productId));
            FormatProductInOutDetailGridview();
            
        }

        private void FormatProductInOutDetailGridview()
        {
            grvProductInOutDetail.Columns[Constant.ProductSearch.ProductInOutDetailGridColumnName.ID].Visible = false;
            grvProductInOutDetail.Columns[Constant.ProductSearch.ProductInOutDetailGridColumnName.ACTION].HeaderText = Constant.ProductSearch.ProductInOutDetailGridColumnHeader.ACTION;
            grvProductInOutDetail.Columns[Constant.ProductSearch.ProductInOutDetailGridColumnName.DATE].HeaderText = Constant.ProductSearch.ProductInOutDetailGridColumnHeader.DATE;
            grvProductInOutDetail.Columns[Constant.ProductSearch.ProductInOutDetailGridColumnName.QUANTITY].HeaderText = Constant.ProductSearch.ProductInOutDetailGridColumnHeader.QUANTITY;
            grvProductInOutDetail.Columns[Constant.ProductSearch.ProductInOutDetailGridColumnName.CLOSING_BALANCE].HeaderText = Constant.ProductSearch.ProductInOutDetailGridColumnHeader.CLOSING_BALANCE;
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
            comboBoxBrandFind.DataSource = brandTableAdapter.GetDistinctBrand();

            cbBoxProductType.DataSource = productTypeTableAdapter.GetDistinctProductType();
            comboBoxProductTypeFind.DataSource = productTypeTableAdapter.GetDistinctProductType();

            cbBoxSize.DataSource = sizeTableAdapter.GetDistinctSize();
            comboBoxSizeFind.DataSource = sizeTableAdapter.GetDistinctSize();
        }

        private void chkIsInStock_CheckedChanged(object sender, EventArgs e)
        {
            txtProductCode_TextChanged(new object(), new EventArgs());
        }

        private void lbInputPrice_Click(object sender, EventArgs e)
        {
            txtInputPrice.Visible = !txtInputPrice.Visible;
        }

        private void ProductSearchForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void numericUpDownOpeningBalance_Enter(object sender, EventArgs e)
        {
            (sender as NumericUpDown).Select(0, 10);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                grvProductList_CellDoubleClick(new object(), new DataGridViewCellEventArgs(grvProductList.CurrentCell.ColumnIndex, grvProductList.CurrentCell.RowIndex));
        }

        private void btCopyProduct_Click(object sender, EventArgs e)
        {            
            if (grvProductList.CurrentCell.RowIndex == -1 || grvProductList.CurrentCell.RowIndex == grvProductList.Rows.Count - 1)
                return;

            ClearData();
            DataGridViewRow row = grvProductList.Rows[grvProductList.CurrentCell.RowIndex];
            txtProductCode.Text = row.Cells["ProductCode"].Value.ToString();
            cbBoxProductType.Text = row.Cells["ProductType"].Value.ToString();
            cbBoxBrand.Text = row.Cells["Brand"].Value.ToString();
            cbBoxSize.Text = string.Empty;
            cbBoxSize.Focus();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtInputPrice.Text = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_COST].Value.ToString();
        }

       
        private const string PRODUCT_CODE = "ProductCode";
        private const string BRAND = "Brand";
        private const string SIZE = "sizeDataGridViewTextBoxColumn";
        private const string PRICE = "Price";
        private const string PRODUCT_TYPE = "ProductType";
        private const string OPENING_BALANCE = "openingBalanceDataGridViewTextBoxColumn";
        private const string INPUT = "inputDataGridViewTextBoxColumn";
        private const string OUTPUT = "outputDataGridViewTextBoxColumn";
        private const string CLOSING_BALANCE = "closingBalanceDataGridViewTextBoxColumn";
        private const string NUBER_INCREASE = "STT";
        private const string TOTAL = "Tổng";

        private void btPrint_Click(object sender, EventArgs e)
        {
            rowIndex = 0;
            pageIndex = 1;
            prnDialog.Document = prnDocument;
            prnDialog.ShowDialog();
        }

        private void btPrintPreview_Click(object sender, EventArgs e)
        {
            rowIndex = 0;
            pageIndex = 1;
            prnPreview.Document = prnDocument;
            //prnPreview.PrintPreviewControl.Zoom = 1;
            prnPreview.ShowDialog();
        }

        int rowIndex = 0;
        int pageIndex = 1;
        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int heightPageSize = e.PageSettings.PaperSize.Height;
            int curentX = 10;
            int curentY = 70;
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen p = new Pen(brush);
            Font font = new Font("Arial", 10, FontStyle.Regular);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font boldFontHeader = new Font("Arial", 14, FontStyle.Bold);
            //Print Column Header
            g.DrawString(Setting.GetStringSetting("InvoiceHeader"), boldFontHeader, brush, 10, 10);
            g.DrawString(Setting.GetStringSetting("StockReportHeader").ToUpper(), boldFont, brush, 350, 10);
            g.DrawString(DateTime.Now.ToShortDateString(), font, brush, new PointF(400, 30));
            g.DrawString(string.Format("{0} {1}", Setting.GetStringSetting("PageNumber"), pageIndex), font, brush, 400, 50);            

            g.DrawLine(p, new Point(curentX, curentY), new Point(curentX + 1000, curentY));
            curentY += 5;
            g.DrawString(NUBER_INCREASE, boldFont, brush, new PointF(curentX, curentY));
            curentX += 50;
            g.DrawString(grvProductList.Columns[PRODUCT_CODE].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 100;
            g.DrawString(grvProductList.Columns[BRAND].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 100;
            g.DrawString(grvProductList.Columns[SIZE].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 50;
            g.DrawString(grvProductList.Columns[PRICE].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 100;
            g.DrawString(grvProductList.Columns[PRODUCT_TYPE].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 100;
            g.DrawString(grvProductList.Columns[OPENING_BALANCE].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 100;
            g.DrawString(grvProductList.Columns[INPUT].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 50;
            g.DrawString(grvProductList.Columns[OUTPUT].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentX += 50;
            g.DrawString(grvProductList.Columns[CLOSING_BALANCE].HeaderText, boldFont, brush, new PointF(curentX, curentY));
            curentY += 25;
            g.DrawLine(p, new Point(10, curentY), new Point(1000, curentY));

            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   

            while(rowIndex<grvProductList.Rows.Count)
            {
                DataGridViewRow row = grvProductList.Rows[rowIndex];
                if (row.IsNewRow) return;
                curentX = 10;
                string productCode = row.Cells[PRODUCT_CODE].Value == null ? string.Empty : row.Cells[PRODUCT_CODE].Value.ToString();
                string brand = row.Cells[BRAND].Value == null ? string.Empty : row.Cells[BRAND].Value.ToString();
                string size = row.Cells[SIZE].Value == null ? string.Empty : row.Cells[SIZE].Value.ToString();
                string price = row.Cells[PRICE].Value == null ? string.Empty : decimal.Parse(row.Cells[PRICE].Value.ToString()).ToString("#,###", cul.NumberFormat);
                
                string productType = row.Cells[PRODUCT_TYPE].Value == null ? string.Empty : row.Cells[PRODUCT_TYPE].Value.ToString();
                string openingBallance = row.Cells[OPENING_BALANCE].Value == null ? string.Empty : row.Cells[OPENING_BALANCE].Value.ToString();
                string input = row.Cells[INPUT].Value == null ? string.Empty : row.Cells[INPUT].Value.ToString();
                string output = row.Cells[OUTPUT].Value == null ? string.Empty : row.Cells[OUTPUT].Value.ToString();
                string closingBallance = row.Cells[CLOSING_BALANCE].Value == null ? string.Empty : row.Cells[CLOSING_BALANCE].Value.ToString();

                g.DrawLine(p, new Point(curentX, curentY), new Point(curentX + 1000, curentY));
                curentY += 5;

                g.DrawString((rowIndex+1).ToString(), font, brush, new PointF(curentX, curentY));
                curentX += 50;
                g.DrawString(productCode, font, brush, new PointF(curentX, curentY));
                curentX += 100;
                g.DrawString(brand, font, brush, new PointF(curentX, curentY));
                curentX += 100;
                g.DrawString(size, font, brush, new PointF(curentX, curentY));
                curentX += 50;
                g.DrawString(price, font, brush, new PointF(curentX, curentY));
                curentX += 100;
                g.DrawString(productType, font, brush, new PointF(curentX, curentY));
                curentX += 100;
                g.DrawString(openingBallance, font, brush, new PointF(curentX, curentY));
                curentX += 100;
                g.DrawString(input, font, brush, new PointF(curentX, curentY));
                curentX += 50;
                g.DrawString(output, font, brush, new PointF(curentX, curentY));
                curentX += 50;
                g.DrawString(closingBallance, font, brush, new PointF(curentX, curentY));
                curentY += 20;
                g.DrawLine(p, new Point(10, curentY), new Point(1000, curentY));

                rowIndex++;
                //Print Report Footer
                if (rowIndex == grvProductList.RowCount-1)
                {
                    JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter productInOutDetailTableAdapter = new JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter();
                    productInOutDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();
                    JSManagementDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter = new JSManagementDataSetTableAdapters.ProductTypeTableAdapter();
                    productTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();

                    JSManagementDataSet.ProductTypeDataTable productTypeDataTable = productTypeTableAdapter.GetDistinctProductType();
                    int total = 0;
                    foreach (DataRow r in productTypeDataTable.Rows)
                    {
                        string productTypeName = r[0].ToString();
                        int subTotal = productInOutDetailTableAdapter.GetProductInOutDetail("", productTypeName, "", "", "", null, null)[0].ClosingBalance;
                        total = total + subTotal;
                        curentX = 50;
                        curentY += 20;
                        g.DrawString(productTypeName, boldFont, brush, new PointF(curentX, curentY));
                        curentX += 100;
                        g.DrawString(subTotal.ToString(), boldFont, brush, new PointF(curentX, curentY));

                    }
                    curentY += 20;
                    curentX = 50;
                    g.DrawString(TOTAL, boldFont, brush, new PointF(curentX, curentY));
                    curentX += 100;
                    g.DrawString(total.ToString(), boldFont, brush, new PointF(curentX, curentY));
                }

                if (curentY < heightPageSize - 25)
                {
                    e.HasMorePages = false;
                }
                else
                {
                    e.HasMorePages = true;
                    pageIndex++;
                    curentY = 70;                    
                    return;
                }
            }
            
        }

        private void grvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvProductList.RowCount)
                return;

            if (isOpenedByPurchaseReceiptOrder)
            {
                PassProductInforToPurchaseReceiptOrderForm(e);
                return;
            }

            if (isOpenedByInputProduct)
            {
                PassProductInforToProductInputForm(e);
                return;
            }
            btDelete.Visible = true;
            btAddNew.Visible = true;
            DataGridViewRow row = grvProductList.Rows[e.RowIndex];
            string productId = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_ID].Value.ToString();
            string productCode = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_CODE].Value.ToString();
            string brand = row.Cells[Constant.ProductSearch.ProductGridColumnName.BRAND].Value.ToString();
            string productType = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_TYPE].Value.ToString();
            string productCost = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRODUCT_COST].Value.ToString();
            string price = row.Cells[Constant.ProductSearch.ProductGridColumnName.PRICE].Value.ToString();
            string size = row.Cells[Constant.ProductSearch.ProductGridColumnName.SIZE].Value.ToString();
            string openingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.OPENING_BALANCE].Value.ToString();
            string input = row.Cells[Constant.ProductSearch.ProductGridColumnName.INPUT].Value.ToString();
            string output = row.Cells[Constant.ProductSearch.ProductGridColumnName.OUTPUT].Value.ToString();
            string closingBalance = row.Cells[Constant.ProductSearch.ProductGridColumnName.CLOSING_BALANCE].Value.ToString();
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
            if (mainform.Controls.Count > 1)
            {
                TextBox txtProductCode = mainform.Controls.Find("txtProductCode", true)[0] as TextBox;
                txtProductCode.Text = productCode;
                ComboBox cbBoxProductType = mainform.Controls.Find("cbBoxProductType", true)[0] as ComboBox;
                cbBoxProductType.Text = productType;
                ComboBox cbBoxBrand = mainform.Controls.Find("cbBoxBrand", true)[0] as ComboBox;
                cbBoxBrand.Text = brand;
                Label lbProductID = mainform.Controls.Find("lbProductID", true)[0] as Label;
                lbProductID.Text = productId;
                Label lbPrice = mainform.Controls.Find("lbPrice", true)[0] as Label;
                lbPrice.Text = price;
                ComboBox cbBoxSize = mainform.Controls.Find("cbBoxSize", true)[0] as ComboBox;
                cbBoxSize.Text = size;
                mainform.Show();
                this.Close();
            }
            else
            {
                BindData(e);
            }
        }

        private void grvProductInOutDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = 0;
            if(!int.TryParse( grvProductInOutDetail.CurrentRow.Cells[Constant.ProductSearch.ProductInOutDetailGridColumnName.ID].Value.ToString(), out id))
            {
                return;
            }
            string action = grvProductInOutDetail.CurrentRow.Cells[Constant.ProductSearch.ProductInOutDetailGridColumnName.ACTION].Value.ToString();
            if (action == Constant.ProductSearch.ProductInOutDetailGridColumnName.XUAT)
            {
                PurchaseReceiptOrderForm purchaseOrderForm = new PurchaseReceiptOrderForm();
                purchaseOrderForm.PurchaseOrderId = id;
                purchaseOrderForm.ShowDialog();
                return;
            }

            if (action == Constant.ProductSearch.ProductInOutDetailGridColumnName.NHAP)
            {
                productInputForm productInputForm = new productInputForm();
                productInputForm.ProductInputOrderId = id;
                productInputForm.ShowDialog();
                return;
            }
        }

        private void comboBoxProductTypeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductCode_TextChanged(new object(), new EventArgs());
        }

        private void comboBoxBrandFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductCode_TextChanged(new object(), new EventArgs());
        }

        private void comboBoxSizeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductCode_TextChanged(new object(), new EventArgs());
        }

        private void ProductSearchForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;
            Point p = grvProductList.Location;
            grvProductList.Height = this.Height - p.Y-40;
        }           
    }
}
