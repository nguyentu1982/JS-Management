using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class CashManagementForm : Form
    {
        JSManagementDataSetTableAdapters.CashDetailTableAdapter cashDetailTableAdapter;
        JSManagementDataSetTableAdapters.IncomeTableAdapter incomeTableAdapter;
        JSManagementDataSetTableAdapters.CostTableAdapter costTableAdapter;
        JSManagementDataSetTableAdapters.CashSumaryTableAdapter cashSumaryTableAdapter;
        CultureInfo cul;

        private const string DATE_COLUMN_NAME = "Date";
        private const string INCOME_COLUMN_NAME = "Income";
        private const string COST_COLUMN_NAME ="Cost";
        private const string CLOSING_BALANCE_COLUMN_NAME ="ClosingBallance";
        private const string REASON_COLUMN_NAME = "Reason";
        private const string ACTION_COLUMN_NAME = "Action";
        private const string ID_COLUMN_NAME = "ID";

        private const string DATE_COLUMN_HEADER = "Ngày";
        private const string INCOME_COLUMN_HEADER = "Thu";
        private const string COST_COLUMN_HEADER = "Chi";
        private const string CLOSING_BALANCE_COLUMN_HEADER = "Số dư";
        private const string REASON_COLUMN_HEADER = "Diễn giải";

        private const string BILL_OF_COST = "phiếu chi";
        private const string BILL_OF_INCOME = "phiếu thu";
        private const string BILL_OF_ORDER = "hóa đơn bán hàng";
        int gridviewCashDetailCurrentMouseOverRow = 0;

        public CashManagementForm()
        {
            InitializeComponent();
            cashDetailTableAdapter = new JSManagementDataSetTableAdapters.CashDetailTableAdapter();
            cashDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();

            incomeTableAdapter = new JSManagementDataSetTableAdapters.IncomeTableAdapter();
            incomeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            costTableAdapter = new JSManagementDataSetTableAdapters.CostTableAdapter();
            costTableAdapter.Connection = CommonHelper.GetSQLConnection();

            cashSumaryTableAdapter = new JSManagementDataSetTableAdapters.CashSumaryTableAdapter();
            cashSumaryTableAdapter.Connection = CommonHelper.GetSQLConnection();

            cul = CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btView_Click(object sender, EventArgs e)
        {            
            grvCashSumary.DataSource = cashSumaryTableAdapter.GetCashSumary(DateTime.Parse(dateTimePickerCashFrom.Value.ToShortDateString()),DateTime.Parse( dateTimePickerCashTo.Value.ToShortDateString()));
            grvCashSumary.Columns[DATE_COLUMN_NAME].HeaderText = DATE_COLUMN_HEADER;
            grvCashSumary.Columns[INCOME_COLUMN_NAME].HeaderText = INCOME_COLUMN_HEADER;
            grvCashSumary.Columns[COST_COLUMN_NAME].HeaderText = COST_COLUMN_HEADER;
            grvCashSumary.Columns[CLOSING_BALANCE_COLUMN_NAME].HeaderText = CLOSING_BALANCE_COLUMN_HEADER;

            grvCashSumary.Columns[INCOME_COLUMN_NAME].DefaultCellStyle.Format = "N0";
            grvCashSumary.Columns[COST_COLUMN_NAME].DefaultCellStyle.Format = "N0";
            grvCashSumary.Columns[CLOSING_BALANCE_COLUMN_NAME].DefaultCellStyle.Format = "N0";
        }

        private void CashManagementForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void CashManagementForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;
            Point p = grvCashSumary.Location;
            Point p1 = groupBoxIncome.Location;
            Point p2 = groupBoxIncome.PointToScreen( gridViewCashDetail.Location);
            

            grvCashSumary.Height = this.Height - p.Y - 50;

            groupBoxIncome.Width = this.Width - p1.X - 20;
            groupBoxIncome.Height = this.Height - p1.Y - 50;
            gridViewCashDetail.Width = this.Width - p2.X - 20;
            gridViewCashDetail.Height = this.Height - p2.Y - 50;
           
            
        }

        private void grvCashSumary_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvCashSumary.Rows[e.RowIndex];
            if (row.IsNewRow)
            {
                
                gridViewCashDetail.DataSource = null;
                return; 
            }
            
            DateTime date = DateTime.Parse(row.Cells[Constant.Cash.DATE_COLUMN_NAME].Value.ToString());
            gridViewCashDetail.DataSource = cashDetailTableAdapter.GetCashDetail(date, date);
            RenameCashDetailGridHeaderText();            
            
        }

        private void RenameCashDetailGridHeaderText()
        {
            gridViewCashDetail.Columns[DATE_COLUMN_NAME].HeaderText = DATE_COLUMN_HEADER;
            gridViewCashDetail.Columns[INCOME_COLUMN_NAME].HeaderText = INCOME_COLUMN_HEADER;
            gridViewCashDetail.Columns[COST_COLUMN_NAME].HeaderText = COST_COLUMN_HEADER;
            gridViewCashDetail.Columns[CLOSING_BALANCE_COLUMN_NAME].HeaderText = CLOSING_BALANCE_COLUMN_HEADER;
            gridViewCashDetail.Columns[REASON_COLUMN_NAME].HeaderText = REASON_COLUMN_HEADER;
            gridViewCashDetail.Columns[REASON_COLUMN_NAME].DisplayIndex = 1;
            gridViewCashDetail.Columns[ACTION_COLUMN_NAME].Visible = false;
            gridViewCashDetail.Columns[ID_COLUMN_NAME].Visible = false;

            gridViewCashDetail.Columns[INCOME_COLUMN_NAME].DefaultCellStyle.Format = "N0";
            gridViewCashDetail.Columns[COST_COLUMN_NAME].DefaultCellStyle.Format = "N0";
            gridViewCashDetail.Columns[CLOSING_BALANCE_COLUMN_NAME].DefaultCellStyle.Format = "N0";
        }

        private void RenameIncomeGridHeaderText()
        {
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.INCOME_ID_COLUMN_NAME].HeaderText = "ID";
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.INCOME_DATE_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.INCOME_DATE_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.INCOME_NUMBER_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.INCOME_NUMBER_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.PAYER_NAME_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.PAYER_NAME_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.REASON_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.REASON_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.AMOUNT_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.AMOUNT_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.AMOUNT_COLUMN_NAME].DefaultCellStyle.Format = string.Format("#,###", cul.NumberFormat);
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.CREATED_BY_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.CREATED_BY_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.CREATED_DATE_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.CREATED_DATE_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.LAST_EDITED_BY_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.LAST_EDITED_BY_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.LAST_EDITED_DATE_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.LAST_EDITED_DATE_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.ORDER_ID_COLUMN_NAME].Visible = false;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.PURCHASE_ORDER_ID_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.PURCHASE_ORDER_ID_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.FROM_BANK_ACCOUNT_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.FROM_BANK_ACCOUNT_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.TO_BANK_ACCOUNT_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.TO_BANK_ACCOUNT_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.COST_ID_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.COST_ID_COLUMN_HEADER;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.TO_BANK_ACCOUNT_ID_COLUMN_NAME].Visible = false;
            //gridViewCashDetail.Columns[Constant.Income.IncomeGrid.FROM_BANK_ACCOUNT_ID_COLUMN_NAME].Visible = false;

        }

        private void RenameCostGridHeaderText()
        {
            //gridViewCost.Columns[Constant.Cost.COST_ID_COLUMN_NAME].HeaderText = Constant.Cost.COST_ID_COLUMN_HEADER;
            //gridViewCost.Columns[Constant.Cost.COST_DATE_COLUMN_NAME].HeaderText = Constant.Cost.COST_DATE_COLUMN_HEADER;
            //gridViewCost.Columns[Constant.Cost.COST_NAME_COLUMN_NAME].HeaderText = Constant.Cost.COST_NAME_COLUMN_HEADER;
            //gridViewCost.Columns[Constant.Cost.AMOUNT_COLUMN_NAME].HeaderText = Constant.Cost.AMOUNT_COLUMN_HEADER;
            //gridViewCost.Columns[Constant.Cost.AMOUNT_COLUMN_NAME].DefaultCellStyle.Format = string.Format("#,###", cul);
            //gridViewCost.Columns[Constant.Cost.COST_TYPE_COLUMN_NAME].HeaderText = Constant.Cost.COST_TYPE_COLUMN_HEADER;
            //gridViewCost.Columns[Constant.Cost.USER_NAME_COLUMN_NAME].HeaderText = Constant.Cost.USER_NAME_COLUMN_HEADER;
            //gridViewCost.Columns[Constant.Cost.COST_TYPE_ID_COLUMN_NAME].Visible = false;
        }

        private void linkLabelCreateIncome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.isOpenedByCashManagementForm = true;
            incomeForm.paymentMethodName = Constant.PaymentMethod.CASH;
            ComboBox cboxPaymentMethod = (incomeForm.Controls.Find(Constant.Income.PAYMENT_METHOD_COMBOBOX_CONTROL_NAME, true)[0] as ComboBox);            
            cboxPaymentMethod.Enabled = false;
            incomeForm.StartPosition = FormStartPosition.CenterScreen;
            incomeForm.Show();

        }

        private void linkLabelCreateCost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CostsForm costForm = new CostsForm();
            costForm.StartPosition = FormStartPosition.CenterScreen;
            costForm.Show();
        }

        private void gridViewCashDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridViewCashDetail.Rows[e.RowIndex];
            if(row.IsNewRow) return;

            string action = row.Cells[ACTION_COLUMN_NAME].Value.ToString();
            int id = int.Parse( row.Cells[ID_COLUMN_NAME].Value.ToString());
            switch (action)
            {
                case BILL_OF_COST:
                    CostsForm costForm = new CostsForm();
                    costForm.costId = id;
                    costForm.StartPosition = FormStartPosition.CenterScreen;
                    costForm.ShowDialog();
                    return;
                case BILL_OF_INCOME:
                    IncomeForm incomeForm = new IncomeForm();
                    incomeForm.incomeId = id;
                    incomeForm.StartPosition = FormStartPosition.CenterScreen;
                    incomeForm.ShowDialog();
                    return;
                case BILL_OF_ORDER:
                    PurchaseReceiptOrderForm proForm = new PurchaseReceiptOrderForm();
                    proForm.PurchaseReceiveOrderId = id;
                    proForm.StartPosition = FormStartPosition.CenterScreen;
                    proForm.ShowDialog();
                    return;

            }
        }

        private void gridViewCashDetail_MouseClick(object sender, MouseEventArgs e)
        {
            
            string action = string.Empty;
            if (e.Button == MouseButtons.Right)
            {
                gridviewCashDetailCurrentMouseOverRow = gridViewCashDetail.HitTest(e.X, e.Y).RowIndex;
                DataGridViewRow row = gridViewCashDetail.Rows[gridviewCashDetailCurrentMouseOverRow];
                action = row.Cells[ACTION_COLUMN_NAME].Value.ToString();
                ContextMenu m = new ContextMenu();                
                m.MenuItems.Add(new MenuItem(string.Format("Xem {0}", action), new EventHandler(gridViewCashDetail_ViewDetail)));

                if (gridviewCashDetailCurrentMouseOverRow >= 0)
                {

                }

                m.Show(gridViewCashDetail, new Point(e.X, e.Y));

            }
        }

        private void gridViewCashDetail_ViewDetail(object sender, EventArgs e)
        {
            gridViewCashDetail_CellDoubleClick(new object(),  new DataGridViewCellEventArgs(0, gridviewCashDetailCurrentMouseOverRow));
        }
    }
}
