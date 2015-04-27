using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class ProductReportForm : Form
    {
        JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter productInOutDetailTableAdapter = new JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter();
        public ProductReportForm()
        {
            InitializeComponent();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            string size = cbBoxSize.Text;
            string supplier = cbSupplier.Text;
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            productInOutDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();
            grvProductReport.DataSource = productInOutDetailTableAdapter.GetProductInOutDetail(productCode, productType, brand, size, supplier, startDate, endDate);
            grvProductReport.Columns["Action"].HeaderText = "Xuất/Nhập";
            grvProductReport.Columns["Date"].HeaderText = "Ngày";
            grvProductReport.Columns["Quantity"].HeaderText = "Số lượng";
            grvProductReport.Columns["ClosingBalance"].HeaderText = "Số dư";
            grvProductReport.Columns["ProductCode"].HeaderText = "Mã SP";
            grvProductReport.Columns["Brand"].HeaderText = "Hiệu";
            grvProductReport.Columns["ProductType"].HeaderText = "Loại SP";
            grvProductReport.Columns["Size"].HeaderText = "Size";
            grvProductReport.Columns["Price"].Visible = false;
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

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }

        private void ProductReportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
