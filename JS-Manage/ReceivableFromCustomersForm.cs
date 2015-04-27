﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class ReceivableFromCustomersForm : Form
    {
        JSManagementDataSetTableAdapters.OrdersTableAdapter orderTableAdapter;
        JSManagementDataSetTableAdapters.ReceivableFromCustomersTableAdapter receivableCustomerAdapter;
        JSManagementDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        public bool isOpenByIncome = false;
        public int bankAccountIdPassFromOtherControl = 0;
        public ReceivableFromCustomersForm()
        {
            InitializeComponent();
            orderTableAdapter = new JSManagementDataSetTableAdapters.OrdersTableAdapter();
            orderTableAdapter.Connection = CommonHelper.GetSQLConnection();

            receivableCustomerAdapter = new JSManagementDataSetTableAdapters.ReceivableFromCustomersTableAdapter();
            receivableCustomerAdapter.Connection = CommonHelper.GetSQLConnection();

            bankAccountTableAdapter = new JSManagementDataSetTableAdapters.BankAccountTableAdapter();
            bankAccountTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void ReceivableFromCustomersForm_Load(object sender, EventArgs e)
        {
            cboxBankAccount.DataSource = bankAccountTableAdapter.GetBankAccountFillToComboBox();
            cboxBankAccount.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
            cboxBankAccount.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;
            cboxBankAccount.SelectedValue = bankAccountIdPassFromOtherControl;
            int bankAccountId = 0;
            bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());  
            grvReceivableFromCustomer.DataSource = receivableCustomerAdapter.GetReceivableFromCustomersByCustIdBillNumberIsInDebt(int.Parse(lbCustId.Text), txtBillNumber.Text, chkIsInDebt.Checked, dateTimePickerFrom.Value, dateTimePickerTo.Value, bankAccountId);
            grvReceivableFromCustomer.CellEnter +=grvReceivableFromCustomer_CellEnter;

            
        }

        private void grvReceivableFromCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GetCostIdToIncomeForm(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvReceivableFromCustomer.Rows.Count - 1)
                return;
            DataGridViewRow row = grvReceivableFromCustomer.Rows[e.RowIndex];
            string amount = row.Cells[3].Value.ToString();
            string incomeAmount = row.Cells[4].Value.ToString();
            if (decimal.Parse(amount) - decimal.Parse(incomeAmount) == 0)
            {
                MessageBox.Show("Công nợ này đã thanh toán hết!");
                return;
            }

            FormCollection activeForms = Application.OpenForms;
            Form incomeForm = new Form();
            foreach (Form f in activeForms)
            {
                if (f.Name == "IncomeForm")
                    incomeForm = f;
            }

            Label lbCostId = incomeForm.Controls.Find("lbCostId", true)[0] as Label;
            lbCostId.Text = row.Cells[0].Value.ToString();
            Label lbOrderId = incomeForm.Controls.Find("lbOrderId", true)[0] as Label;
            lbOrderId.Text = "0";
            TextBox txtreason = incomeForm.Controls.Find("txtReason", true)[0] as TextBox;
            txtreason.Text = string.Format("Thu nợ/tạm ứng ngày {0} / {1}", DateTime.Parse(row.Cells[2].Value.ToString()).ToShortDateString(), row.Cells[1].Value.ToString());
            TextBox txtAmount = incomeForm.Controls.Find("txtAmount", true)[0] as TextBox;
            txtAmount.Text = (decimal.Parse(amount) - decimal.Parse(incomeAmount)).ToString();
            this.Close();
        }

        private void GetOrderIdToIncomeForm(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvReceivableFromCustomer.Rows.Count - 1)
                return;
            DataGridViewRow row = grvReceivableFromCustomer.Rows[e.RowIndex];
            string amount = row.Cells["Amount"].Value.ToString();
            string incomeAmount = row.Cells["IncomeAmount"].Value.ToString();
            int purchaseOrderId = int.Parse(row.Cells["PurchaseReceiptOrderId"].Value.ToString());

            if (decimal.Parse(amount) - decimal.Parse(incomeAmount) == 0)
            {
                MessageBox.Show("Công nợ này đã thanh toán hết!");
                return;
            }

            FormCollection activeForms = Application.OpenForms;
            Form incomeForm = new Form();
            foreach (Form f in activeForms)
            {
                if (f.Name == "IncomeForm")
                    incomeForm = f;            
            }
            Label lbCostId = incomeForm.Controls.Find("lbCostId", true)[0] as Label;
            lbCostId.Text = "0";

            Label lbOrderId = incomeForm.Controls.Find("lbOrderId", true)[0] as Label;
            
            JSManagementDataSet.ReceivableFromCustomersDataTable receivableFromCustDataTable = receivableCustomerAdapter.GetReceivableFromCustomersByPurchaseOrderId(purchaseOrderId);
                
            decimal totalAmount = 0;
            decimal totalIncome = 0;
            foreach (DataRow r in receivableFromCustDataTable.Rows)
            {                    
                totalAmount += decimal.Parse(r.ItemArray[3].ToString());
                totalIncome += decimal.Parse(r.ItemArray[4].ToString());
            }

            lbOrderId.Text = purchaseOrderId.ToString();
            TextBox txtreason = incomeForm.Controls.Find("txtReason", true)[0] as TextBox;
            txtreason.Text = string.Format("Thu nợ tiền hàng ngày {0} / Mã số bưu gửi: {1} / Đơn hàng: {2}", DateTime.Parse(row.Cells["OrderDate"].Value.ToString()).ToShortDateString(), row.Cells["BillNumber"].Value.ToString(), row.Cells["PurchaseReceiptOrderId"].Value.ToString());
            TextBox txtAmount = incomeForm.Controls.Find("txtAmount", true)[0] as TextBox;
            txtAmount.Text = (totalAmount - totalIncome).ToString();                    
            
            this.Close();
        }

        private void btFindCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm custForm = new CustomerForm();
            custForm.isOpenByReceivableFromCustomer = true;
            custForm.ShowDialog();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            int bankAccountId = 0;           
            bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());           

            grvReceivableFromCustomer.DataSource = receivableCustomerAdapter.GetReceivableFromCustomersByCustIdBillNumberIsInDebt(int.Parse(lbCustId.Text), txtBillNumber.Text, chkIsInDebt.Checked, dateTimePickerFrom.Value, dateTimePickerTo.Value, bankAccountId);
            grvReceivableFromCustomer.Columns["OrderId"].Visible = false;
            grvReceivableFromCustomer.Columns["BillNumber"].HeaderText = "Mã số bưu gửi";
            grvReceivableFromCustomer.Columns["OrderDate"].HeaderText = "Ngày đặt hàng";
            grvReceivableFromCustomer.Columns["Amount"].HeaderText = "Tổng tiền";
            grvReceivableFromCustomer.Columns["IncomeAmount"].HeaderText = "Đã thanh toán";
            grvReceivableFromCustomer.Columns["PurchaseReceiptOrderId"].Visible = false;
        }

        private void grvReceivableFromCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvReceivableFromCustomer.Rows.Count - 1)
                return;
            DataGridViewRow row = grvReceivableFromCustomer.Rows[e.RowIndex];
            string billNumber = row.Cells[1].Value.ToString();
            if (!billNumber.Contains("Nội dung:"))
            {
                ViewDetailReceivableFromCustomer(e);
                return;
            }
            if (billNumber.Contains("Nội dung:") && !isOpenByIncome)
            {
                ViewDetailReceiableFromOther(e);
                return;
            }
        }

        private void ViewDetailReceiableFromOther(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvReceivableFromCustomer.Rows.Count - 1)
                return;
            DataGridViewRow row = grvReceivableFromCustomer.Rows[e.RowIndex];
            int costId = int.Parse(row.Cells[0].Value.ToString());

            JSManagementDataSetTableAdapters.CostTableAdapter costTableAdapter = new JSManagementDataSetTableAdapters.CostTableAdapter();
            costTableAdapter.Connection = CommonHelper.GetSQLConnection();

            DataRow[] costDataRows = costTableAdapter.GetData().Select(string.Format("CostId ={0}", costId.ToString()));
            if (costDataRows.Length > 0)
            {
                string costDate = DateTime.Parse(costDataRows[0].ItemArray[1].ToString()).ToShortDateString();
                string costName = costDataRows[0].ItemArray[2].ToString();
                string amount = costDataRows[0].ItemArray[3].ToString();
                MessageBox.Show(string.Format("Ngày: {0} Nội dung chi: {1} Số tiền: {2}", costDate, costName, amount));
            }
        }

        private void ViewDetailReceivableFromCustomer(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvReceivableFromCustomer.Rows.Count - 1)
                return;
            DataGridViewRow row = grvReceivableFromCustomer.Rows[e.RowIndex];

            int purchaseOrderId = int.Parse(row.Cells["PurchaseReceiptOrderId"].Value.ToString());
            int orderId = row.Cells[0].Value==DBNull.Value?0: int.Parse(row.Cells[0].Value.ToString());
            string billNumber = row.Cells[1].Value.ToString();
            string orderDate =  DateTime.Parse(row.Cells[2].Value.ToString()).ToShortDateString();


            lbOrderDate.Text = orderDate;
            lbBillNumber.Text = billNumber;
            lbOrder.Text = purchaseOrderId.ToString();

            JSManagementDataSetTableAdapters.PurchaseReceiptOrderTableAdapter purchaseReceiptOrderTableAdapter = new JSManagementDataSetTableAdapters.PurchaseReceiptOrderTableAdapter();
            purchaseReceiptOrderTableAdapter.Connection = CommonHelper.GetSQLConnection();
            
            JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();

            JSManagementDataSetTableAdapters.Orders_ProductTableAdapter order_ProductTableAdapter = new JSManagementDataSetTableAdapters.Orders_ProductTableAdapter();
            order_ProductTableAdapter.Connection = CommonHelper.GetSQLConnection();

            JSManagementDataSet.PurchaseReceiptOrderDataTable purchaseOrderDataTable = purchaseReceiptOrderTableAdapter.GetById(purchaseOrderId);
            if (purchaseOrderDataTable.Rows.Count > 0)
            {
                int custId = purchaseOrderDataTable[0].CustId;
                lbPurchaseReceiptOrderId.Text = purchaseOrderId.ToString();
                //int custId = int.Parse(orderRow.ItemArray[2].ToString());
                lbCustomerInfo.Text = string.Format("{0} / {1} / {2}", custTableAdapter.GetDataByCustomerId(custId)[0].CustomerName, custTableAdapter.GetDataByCustomerId(custId)[0].Address, custTableAdapter.GetDataByCustomerId(custId)[0].Telephone);
                txtNote.Text = purchaseOrderDataTable[0].OrderNote;
                if (purchaseOrderId > 0)
                {
                    grvProductOutput.DataSource = order_ProductTableAdapter.GetOrdersByPurchaserReceivableOrderId(purchaseOrderId);
                }
                else
                {
                    grvProductOutput.DataSource = order_ProductTableAdapter.GetOrderById(orderId);
                }
            }
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

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomer.Text == string.Empty)
                lbCustId.Text = "0";
        }

        private void ReceivableFromCustomersForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void btSaveoNote_Click(object sender, EventArgs e)
        {
            if (txtNote.Text.Trim() == string.Empty) return;
            var result = MessageBox.Show("Bạn có chắc chắn sửa ghi chú", "Sửa ghi chú cho đơn hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Cancel) return;

            JSManagementDataSetTableAdapters.PurchaseReceiptOrderTableAdapter purchaseReceiptOrderTableAdapter = new JSManagementDataSetTableAdapters.PurchaseReceiptOrderTableAdapter();
            purchaseReceiptOrderTableAdapter.Connection = CommonHelper.GetSQLConnection();
            if (purchaseReceiptOrderTableAdapter.UpdateOrderNoteById(txtNote.Text, int.Parse(lbPurchaseReceiptOrderId.Text)) > 0)
            {
                MessageBox.Show("Sửa ghi chú thành công!");
            }
        }

        private void grvReceivableFromCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvReceivableFromCustomer.Rows.Count - 1)
                return;
            DataGridViewRow row = grvReceivableFromCustomer.Rows[e.RowIndex];
            string billNumber = row.Cells[1].Value.ToString();

            if (isOpenByIncome && !billNumber.Contains("Nội dung:"))
            {
                GetOrderIdToIncomeForm(e);
                return;
            }

            if (isOpenByIncome && billNumber.Contains("Nội dung:"))
            {
                GetCostIdToIncomeForm(e);
                return;
            }

            if (!billNumber.Contains("Nội dung:"))
            {
                ViewDetailReceivableFromCustomer(e);
                return;
            }
            if (billNumber.Contains("Nội dung:"))
            {
                ViewDetailReceiableFromOther(e);
                return;
            }
        }

        private void grvReceivableFromCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                grvReceivableFromCustomer_CellDoubleClick(new object(), new DataGridViewCellEventArgs(grvReceivableFromCustomer.CurrentCell.ColumnIndex, grvReceivableFromCustomer.CurrentCell.RowIndex));
        }
    }
}
