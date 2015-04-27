using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class OperatingResultsForm : Form
    {
        private const string ORDER_DATE_COLUMN_NAME = "OrderDate";
		private const string TOTAL_COST_COLUMN_NAME = "TotalCost";
		private const string OPERATION_COST_COLUMN_NAME = "OperationCost";
		private const string TOTAL_AMOUNT_COLUMN_NAME  = "TotalAmount";
		private const string REVENUE_COLUMN_NAME = "Revenue";
        private const string RUNNING_TOTAL_COLUMN_NAME = "RunningTotal";

        private const string ORDER_DATE_COLUMN_HEADER_TEXT = "Ngày";
        private const string TOTAL_COST_COLUMN_HEADER_TEXT = "Giá vốn (1)";
        private const string OPERATION_COST_COLUMN_HEADER_TEXT = "CP HĐKD (2)";
        private const string TOTAL_AMOUNT_COLUMN_HEADER_TEXT = "Doanh Thu (3)";
        private const string REVENUE_COLUMN_HEADER_TEXT = "Lợi nhuận (4) = (3) - (2) - (1)";
        private const string RUNNING_TOTAL_COLUMN_HEADER_TEXT = "Lũy kế";

        private const string NUMBER_FORMAT = "N0";

        public OperatingResultsForm()
        {
            InitializeComponent();
            customerTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            string size = cbBoxSize.Text;
            int supplierId = supplierSelectUserControl1.CustId ;
            int custId = customerSelectUserControl1.CustId;
            
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            JSManagementDataSetTableAdapters.RevenueDetailTableAdapter revenueDetailTableAdapter = new JSManagementDataSetTableAdapters.RevenueDetailTableAdapter();
            revenueDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();
            grvOperationResult.DataSource = revenueDetailTableAdapter.GetRevenueDetail(productCode, productType, brand, size, supplierId, custId, startDate, endDate);

            grvOperationResult.Columns[ORDER_DATE_COLUMN_NAME].HeaderText = ORDER_DATE_COLUMN_HEADER_TEXT;
            grvOperationResult.Columns[TOTAL_COST_COLUMN_NAME].HeaderText = TOTAL_COST_COLUMN_HEADER_TEXT;
            grvOperationResult.Columns[OPERATION_COST_COLUMN_NAME].HeaderText = OPERATION_COST_COLUMN_HEADER_TEXT;
            grvOperationResult.Columns[TOTAL_AMOUNT_COLUMN_NAME].HeaderText = TOTAL_AMOUNT_COLUMN_HEADER_TEXT;
            grvOperationResult.Columns[REVENUE_COLUMN_NAME].HeaderText = REVENUE_COLUMN_HEADER_TEXT;
            grvOperationResult.Columns[RUNNING_TOTAL_COLUMN_NAME].HeaderText = RUNNING_TOTAL_COLUMN_HEADER_TEXT;

            grvOperationResult.Columns[TOTAL_COST_COLUMN_NAME].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvOperationResult.Columns[OPERATION_COST_COLUMN_NAME].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvOperationResult.Columns[TOTAL_AMOUNT_COLUMN_NAME].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvOperationResult.Columns[REVENUE_COLUMN_NAME].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvOperationResult.Columns[RUNNING_TOTAL_COLUMN_NAME].DefaultCellStyle.Format = NUMBER_FORMAT;
        }

        private void OperatingResultsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jSManagementDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.jSManagementDataSet.Customer);
            LoadDefaultData();
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

        private void OperatingResultsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
