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
    public partial class ProductCheckingForm : Form
    {
        private System.Windows.Forms.PrintDialog prnDialog;
        private System.Windows.Forms.PrintPreviewDialog prnPreview;
        private System.Drawing.Printing.PrintDocument prnDocument;

        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        
        public int purchaseReceiptOrderProductGridRowIndex;
        public bool isOpenedByPurchaseReceiptOrder = false;
        public int inputProductGridRowIndex;
        public bool isOpenedByInputProduct=false;

        private const string PRODUCT_ID = "ProductId";
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
        private const string REAL_CLOSING_BALANCE_COLUMN_NAME = "RealClosingBallance";
        private const string REAL_CLOSING_BALANCE_HEADER_TEXT = "Số tồn thực tế";

        public ProductCheckingForm()
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

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            if (isOpenedByInputProduct || isOpenedByPurchaseReceiptOrder)
            {
                chkIsInStock.Checked = false;
            }

            string productCode = txtProductCodeSearch.Text;
            productCode = string.Format("%{0}%", productCode);
            if (chkIsInStock.Checked)
            {
                grvProductList.DataSource = productTableAdapter.GetProductsByProductCodeInStock(productCode);
                DisableColumnGridViewUserRole(grvProductList, "ProductCost");

            }
            else
            {               
                grvProductList.DataSource = productTableAdapter.GetProductsByProductCode(productCode);
                DisableColumnGridViewUserRole(grvProductList, "ProductCost");
            }
            grvProductList.CellEnter += dataGridView1_CellEnter;
            grvProductList.Columns.Add(REAL_CLOSING_BALANCE_COLUMN_NAME, REAL_CLOSING_BALANCE_HEADER_TEXT);
            UpdateRealClosingBallance(dateTimePickerProductChecking.Value);
        }

        private void UpdateRealClosingBallance(DateTime dateTime)
        {
            int productId;
            foreach (DataGridViewRow row in grvProductList.Rows)
            {
                if (!row.IsNewRow)
                {
                    productId = int.Parse(row.Cells[PRODUCT_ID].Value.ToString());

                }
            }
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            string productCode = txtProductCodeSearch.Text;
            bool isInStock = chkIsInStock.Checked;
            if (!isInStock)
            {
                if (string.IsNullOrEmpty(productCode))
                {
                    grvProductList.DataSource = productTableAdapter.GetProducts();                    
                    DisableColumnGridViewUserRole(grvProductList, "ProductCost");
                }
                else
                {
                    productCode = string.Format("%{0}%", productCode);
                    grvProductList.DataSource = productTableAdapter.GetProductsByProductCode(productCode);
                    DisableColumnGridViewUserRole(grvProductList, "ProductCost");
                }
            }
            else
           {
                if (string.IsNullOrEmpty(productCode))
                {
                    grvProductList.DataSource = productTableAdapter.GetProductsInStock();
                    DisableColumnGridViewUserRole(grvProductList, "ProductCost");
                }
                else
                {
                    productCode = string.Format("%{0}%", productCode);
                    grvProductList.DataSource = productTableAdapter.GetProductsByProductCodeInStock(productCode);
                    DisableColumnGridViewUserRole(grvProductList, "ProductCost");
                }
            }            
        }               

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvProductList.RowCount)
                return;            
           BindData(e);            
        }      
        
        private void DisableColumnGridViewUserRole(DataGridView gridView, string dataPropertyName)
        {
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].DataPropertyName == dataPropertyName)
                {
                    gridView.Columns[i].Visible = false;
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {            
            BindData(e);
        }

        private void BindData(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvProductList.RowCount-1)
                return;           
            
            DataGridViewRow row = grvProductList.Rows[e.RowIndex];
            string productId = row.Cells[PRODUCT_ID].Value.ToString();
            grvProductInOutDetail.DataSource = getProductInOutDetailTableAdapter.GetProductInOutDetailByProductId(int.Parse(productId));            
        }        

        private void chkIsInStock_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbInstocked = (CheckBox)sender;
            string productCode = txtProductCodeSearch.Text;
            productCode = string.Format("%{0}%", productCode);
            if (cbInstocked.Checked)
            {
                productCode = string.Format("%{0}%", productCode);
                grvProductList.DataSource = productTableAdapter.GetProductsByProductCodeInStock(productCode);
                DisableColumnGridViewUserRole(grvProductList, "ProductCost");
            }
            else
            {
                grvProductList.DataSource = productTableAdapter.GetProductsByProductCode(productCode);
                DisableColumnGridViewUserRole(grvProductList, "ProductCost");
            }
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
                dataGridView1_CellClick(new object(), new DataGridViewCellEventArgs(grvProductList.CurrentCell.ColumnIndex, grvProductList.CurrentCell.RowIndex));
        }  

        

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

            CultureInfo cul = CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);   

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

        private void dateTimePickerProductChecking_ValueChanged(object sender, EventArgs e)
        {

        }

           
    }
}
