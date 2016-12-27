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
        JSDataSet2TableAdapters.GetLiabilitySumaryBySupplierIdTableAdapter liatilitySumaryTalbeAdapter;
        CultureInfo cul;
        int ID;
        public LiabilitiesForm()
        {
            InitializeComponent();
            liabilitiesDetailTableAdapter = new JSManagementDataSetTableAdapters.LiabilitiesDetailTableAdapter();
            liabilitiesDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();
            cul =  CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);

            liatilitySumaryTalbeAdapter= new JSDataSet2TableAdapters.GetLiabilitySumaryBySupplierIdTableAdapter();
            liatilitySumaryTalbeAdapter.Connection = CommonHelper.GetSQLConnection();
            
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            int supplierId =0;
            DateTime startDate = dateTimePickerFrom.Value;
            DateTime endDate = dateTimePickerTo.Value;
            supplierId = customerSelectUserControl1.CustId;
            dataGridViewLiabilities.DataSource = liatilitySumaryTalbeAdapter.GetData(supplierId, startDate, endDate);
            dataGridViewLiabilities.Dock = DockStyle.Fill;

            //dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.ProInOutDetailId].Visible = false;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.DATE].HeaderText = Constant.Liabilities.ColumnHeader.DATE;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.ACTION].HeaderText = Constant.Liabilities.ColumnHeader.ACTION;
           
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.QUANTITY].HeaderText = Constant.Liabilities.ColumnHeader.QUANTITY;
            
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.AMOUNT].HeaderText = Constant.Liabilities.ColumnHeader.AMOUNT;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.AMOUNT].DefaultCellStyle.Format = string.Format("#,###", cul);
            
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.CLOSING_BALANCE].Visible = false;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.CLOSING_BALANCE_AMOUNT].HeaderText = Constant.Liabilities.ColumnHeader.CLOSING_BALANCE_AMOUNT;
            dataGridViewLiabilities.Columns[Constant.Liabilities.ColumnName.CLOSING_BALANCE_AMOUNT].DefaultCellStyle.Format = string.Format("#,###", cul);

        }

        private void dataGridViewLiabilities_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dataGridViewLiabilities.HitTest(e.X, e.Y).RowIndex;
                ContextMenu m = new ContextMenu();
                DataGridViewRow r = dataGridViewLiabilities.Rows[currentMouseOverRow];
                string action = r.Cells["Action"].Value.ToString();
                ID = int.Parse(r.Cells["Id"].Value.ToString());
                switch (action.ToLower())
                {
                    case "thu": 
                        //display income 
                        m.MenuItems.Add(new MenuItem("Xem phiếu thu", new EventHandler(viewIncome)));
                        break;
                    case "chi":
                        //display cost
                        m.MenuItems.Add(new MenuItem("Xem phiếu chi", new EventHandler(viewCost)));
                        break;
                    case "nhập":
                        m.MenuItems.Add(new MenuItem("Xem phiếu nhập", new EventHandler(viewInputOrder)));
                        //display input
                        break;
                    case "xuất":
                        //display order
                        m.MenuItems.Add(new MenuItem("Xem phiếu xuất", new EventHandler(viewPurchaseOrder)));
                        break;
                }

                if (currentMouseOverRow >= 0)
                {
                    m.Show(dataGridViewLiabilities, new Point(e.X, e.Y));
                }
            }
        }

        private void viewPurchaseOrder(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                PurchaseReceiptOrderForm purchaseOrderForm = new PurchaseReceiptOrderForm();
                purchaseOrderForm.PurchaseOrderId = ID;
                purchaseOrderForm.ShowDialog();
            }
        }

        private void viewInputOrder(object sender, EventArgs e)
        {
            if(ID!=0)
            {
                productInputForm productInputForm = new productInputForm();
                productInputForm.ProductInputOrderId = ID;
                productInputForm.ShowDialog();
            }
        }

        private void viewCost(object sender, EventArgs e)
        {
            if(ID!=0)
            {
                CostsForm costForm = new CostsForm();
                costForm.costId = ID;
                costForm.ShowDialog();
            }
        }

        private void viewIncome(object sender, EventArgs e)
        {
            if(ID != 0)
            {
                IncomeForm incomeForm = new IncomeForm();
                incomeForm.Show(ID);
                incomeForm.ShowDialog();
            }
        }
    }
}
