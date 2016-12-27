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
    public partial class BankAccountManagementForm : Form
    {
        JSManagementDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        JSManagementDataSetTableAdapters.CostTypeTableAdapter costTypeTableAdapter;
        JSManagementDataSetTableAdapters.BankAccountDetailTableAdapter bankAccountDetailTableAdapter;
        CultureInfo cul;

        public BankAccountManagementForm()
        {
            InitializeComponent();

            bankAccountTableAdapter = new JSManagementDataSetTableAdapters.BankAccountTableAdapter();
            bankAccountTableAdapter.Connection = CommonHelper.GetSQLConnection();

            costTypeTableAdapter = new JSManagementDataSetTableAdapters.CostTypeTableAdapter();
            costTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            bankAccountDetailTableAdapter = new JSManagementDataSetTableAdapters.BankAccountDetailTableAdapter();
            bankAccountDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();

            cul = CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);
        }

        private void BankAccountManagementForm_Load(object sender, EventArgs e)
        {
            cboxBankAccount.DataSource = bankAccountTableAdapter.GetBankAccountFillToComboBox();
            cboxBankAccount.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
            cboxBankAccount.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;
        }

        private void cboxBankAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bankAccountId = 0;
            int.TryParse(cboxBankAccount.SelectedValue.ToString(), out bankAccountId);
            if (bankAccountId == 0) return;

            decimal closingBalance=0;
            DateTime date = DateTime.Now;
            date.AddDays(1);
            JSManagementDataSet.BankAccountDetailDataTable bankAccountDetailData = bankAccountDetailTableAdapter.GetBankAccountOpeningBalanceByDateAndBankAccountId(date, bankAccountId);
            if (bankAccountDetailData.Rows.Count > 0)
            {
                closingBalance = bankAccountDetailData[0].RuningTotal;
            }
            lbAvaiableClosingBalance.Text = closingBalance.ToString("#,###");

            btFind_Click(new object(), new EventArgs());
        }

        private void linkLabelFormCash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CostsForm costForm = new CostsForm();
            costForm.selectedCostTypeId = costTypeTableAdapter.GetDataByName(Constant.PaymentMethod.BANK_TRANSFER)[0].CostTypeId;
            (costForm.Controls.Find(Constant.CostType.COST_TYPE_COMBOBOX_CONTROL_NAME, true)[0] as ComboBox).Enabled = false;

            if (cboxBankAccount.SelectedValue.ToString() != "0")
            {
                costForm.isOpenedByBankAccountManagement = true;
                costForm.selectedBankAccountId = int.Parse( cboxBankAccount.SelectedValue.ToString());
            }

            costForm.Show();
        }

        private void linkLabelFromReceivableCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            ComboBox cboxPaymentMethod = (incomeForm.Controls.Find(Constant.Income.PAYMENT_METHOD_COMBOBOX_CONTROL_NAME, true)[0] as ComboBox);
            incomeForm.paymentMethodName = Constant.PaymentMethod.BANK_TRANSFER;
            incomeForm.isOpenedByBankAccountManagementForm = true;
            cboxPaymentMethod.Enabled = false;
            incomeForm.isReceiableBankAccountIncomeMustValidate = true;

            if (cboxBankAccount.SelectedValue.ToString() != "0")
            {
                incomeForm.isOpenedByBankAccountManagementForm = true;
                incomeForm.selectedToBankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }
            incomeForm.Show(); 
        }

        private void linkLabelFromOther_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            ComboBox cboxPaymentMethod = (incomeForm.Controls.Find(Constant.Income.PAYMENT_METHOD_COMBOBOX_CONTROL_NAME, true)[0] as ComboBox);
            incomeForm.paymentMethodName = Constant.PaymentMethod.BANK_TRANSFER;
            cboxPaymentMethod.Enabled = false;
            incomeForm.isReceiableBankAccountIncomeMustValidate = false;
            incomeForm.isOpenedByBankAccountManagementForm = true;

            if (cboxBankAccount.SelectedValue.ToString() != "0")
            {
                incomeForm.isOpenedByBankAccountManagementForm = true;
                incomeForm.selectedToBankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }
            incomeForm.Show();
        }

        private void lableFromBankToCash_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.isOpenedByBankAccountManagementForm = true;
            ComboBox cboxPaymentMethod = (incomeForm.Controls.Find(Constant.Income.PAYMENT_METHOD_COMBOBOX_CONTROL_NAME, true)[0] as ComboBox);
            incomeForm.paymentMethodName = Constant.PaymentMethod.CASH;
            cboxPaymentMethod.Enabled = false;

            CheckBox checBoxIsReceiveAbleFromCustomer = (incomeForm.Controls.Find(Constant.Income.RECEIVABLE_FROM_CUSTOMER_CHECKBOX_CONTROL_NAME, true)[0] as CheckBox);
            checBoxIsReceiveAbleFromCustomer.Visible = false;

            Label labelFromBankAccount = incomeForm.Controls.Find(Constant.Income.LABEL_FROM_BANK_ACCOUNT_CONTROL_NAME, true)[0] as Label;
            labelFromBankAccount.Visible = true;

            ComboBox comboBoxFromBankAccount = incomeForm.Controls.Find(Constant.Income.COMBOBOX_FROM_BANK_ACCOUNT_CONTROL_NAME, true)[0] as ComboBox;
            comboBoxFromBankAccount.Visible = true;

            if (cboxBankAccount.SelectedValue.ToString() != "0")
            {
                incomeForm.isOpenedByBankAccountManagementForm = true;
                incomeForm.selectedFromBankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }

            incomeForm.Show();
        }

        private void labelBankTransfer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IncomeForm incomeForm = new IncomeForm();
            incomeForm.isOpenedByBankAccountManagementForm = true;
            ComboBox cboxPaymentMethod = (incomeForm.Controls.Find(Constant.Income.PAYMENT_METHOD_COMBOBOX_CONTROL_NAME, true)[0] as ComboBox);
            incomeForm.paymentMethodName = Constant.PaymentMethod.BANK_TRANSFER;
            cboxPaymentMethod.Enabled = false;

            CheckBox checBoxIsReceiveAbleFromCustomer = (incomeForm.Controls.Find(Constant.Income.RECEIVABLE_FROM_CUSTOMER_CHECKBOX_CONTROL_NAME, true)[0] as CheckBox);
            checBoxIsReceiveAbleFromCustomer.Visible = false;

            Label labelFromBankAccount = incomeForm.Controls.Find(Constant.Income.LABEL_FROM_BANK_ACCOUNT_CONTROL_NAME, true)[0] as Label;
            labelFromBankAccount.Visible = true;

            ComboBox comboBoxFromBankAccount = incomeForm.Controls.Find(Constant.Income.COMBOBOX_FROM_BANK_ACCOUNT_CONTROL_NAME, true)[0] as ComboBox;
            comboBoxFromBankAccount.Visible = true;

            Label lbIncomeHeader = incomeForm.Controls.Find(Constant.Income.LABEL_INCOME_HEADER_CONTROL_NAME, true)[0] as Label;
            lbIncomeHeader.Text = Constant.Income.BANK_TRANSFER_BILL;

            if (cboxBankAccount.SelectedValue.ToString() != "0")
            {
                incomeForm.isOpenedByBankAccountManagementForm = true;
                incomeForm.selectedToBankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }

            incomeForm.Show();

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            if (cboxBankAccount.SelectedValue.ToString() == "0")
            {
                grvBankAccountTransactionDetail.DataSource = null;
                return;
            }

            int bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            JSManagementDataSet.BankAccountDetailDataTable bankAccountDetailData = bankAccountDetailTableAdapter.GetBankAccountDetail(dateTimePickerFrom.Value, dateTimePickerTo.Value, bankAccountId);
            grvBankAccountTransactionDetail.DataSource = bankAccountDetailData;

            
            JSManagementDataSet.BankAccountDetailDataTable bankAccountOpeningData = bankAccountDetailTableAdapter.GetBankAccountOpeningBalanceByDateAndBankAccountId(dateTimePickerFrom.Value, bankAccountId);
            lbOpeningBalanceFind.Text = bankAccountOpeningData.Rows.Count > 0 ? bankAccountOpeningData[0].RuningTotal.ToString("#,###", cul) : "0";
            lbClosingBalanceFind.Text = bankAccountDetailData.Rows.Count > 0 ? bankAccountDetailData[bankAccountDetailData.Rows.Count - 1].RuningTotal.ToString("#,###") : lbOpeningBalanceFind.Text;

            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.INCOME_ID].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.INCOME_DATE].HeaderText = Constant.BankAccountDetail.ColumnHeaderText.INCOME_DATE;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.INCOME_NUMBER].HeaderText = Constant.BankAccountDetail.ColumnHeaderText.INCOME_NUMBER;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.PAYER_NAME].HeaderText = Constant.BankAccountDetail.ColumnHeaderText.PAYER_NAME;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.REASON].HeaderText = Constant.BankAccountDetail.ColumnHeaderText.REASON;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.AMOUNT].HeaderText = Constant.BankAccountDetail.ColumnHeaderText.AMOUNT;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.AMOUNT1].HeaderText = Constant.BankAccountDetail.ColumnHeaderText.AMOUNT1;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.RUNING_TOTAL].HeaderText = Constant.BankAccountDetail.ColumnHeaderText.RUNING_TOTAL;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.CREATED_BY].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.CREATED_DATE].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.LAST_EDITED_BY].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.LAST_EDITED_DATE].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.ORDER_ID].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.COST_ID].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.PURCHASE_RECEIPT_ORDER_ID].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.TO_BANK_ACCOUNT_ID].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.FROM_BANK_ACCOUNT_ID].Visible = false;
            grvBankAccountTransactionDetail.Columns[Constant.BankAccountDetail.ColumnName.PURCHASE_ORDER_BANK_ACCOUNT_ID].Visible = false;
        }
    }
}
