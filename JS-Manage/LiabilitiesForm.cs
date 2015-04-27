using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class LiabilitiesForm : Form
    {
        JSManagementDataSetTableAdapters.LiabilitiesDetailTableAdapter liabilitiesDetailTableAdapter;
        CultureInfo cul;
        public LiabilitiesForm()
        {
            InitializeComponent();
            liabilitiesDetailTableAdapter = new JSManagementDataSetTableAdapters.LiabilitiesDetailTableAdapter();
            liabilitiesDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();
            cul = new CultureInfo(Constant.VN_CULTURE_FORMAT);
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            int supplierId =0;
            DateTime startDate = dateTimePickerFrom.Value;
            DateTime endDate = dateTimePickerTo.Value;
            supplierId = customerSelectUserControl1.CustId;
            dataGridViewLiabilities.DataSource = liabilitiesDetailTableAdapter.GetLiabilitiesDetailBySupplierId(supplierId, startDate, endDate);
            dataGridViewLiabilities.Dock = DockStyle.Fill;

            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.ProInOutDetailId].Visible = false;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.DATE].HeaderText = Constant.Liabilities.ColumnHeader.DATE;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.ACTION].HeaderText = Constant.Liabilities.ColumnHeader.ACTION;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.PRODUCT_CODE].HeaderText = Constant.Liabilities.ColumnHeader.PRODUCT_CODE;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.BRAND].HeaderText = Constant.Liabilities.ColumnHeader.BRAND;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.PRODUCT_TYPE].HeaderText = Constant.Liabilities.ColumnHeader.PRODUCT_TYPE;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.SIZE].HeaderText = Constant.Liabilities.ColumnHeader.SIZE;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.QUANTITY].HeaderText = Constant.Liabilities.ColumnHeader.QUANTITY;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.PRICE].HeaderText = Constant.Liabilities.ColumnHeader.PRICE;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.PRICE].DefaultCellStyle.Format = string.Format("#,###", cul);
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.AMOUNT].HeaderText = Constant.Liabilities.ColumnHeader.AMOUNT;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.AMOUNT].DefaultCellStyle.Format = string.Format("#,###", cul);
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.IS_RETURN_SUPPLIER].HeaderText = Constant.Liabilities.ColumnHeader.IS_RETURN_SUPPLIER;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.CLOSING_BALANCE].Visible = false;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.CLOSING_BALANCE_AMOUNT].HeaderText = Constant.Liabilities.ColumnHeader.CLOSING_BALANCE_AMOUNT;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.CLOSING_BALANCE_AMOUNT].DefaultCellStyle.Format = string.Format("#,###", cul);

        }
    }
}
