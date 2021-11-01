using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class IncomeForm : Form
    {
        JSManagementDataSetTableAdapters.IncomeTableAdapter incomeTableAdapter;
        JSManagementDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        CultureInfo cul;

        int rowIndex;
        public string paymentMethodName;
        public bool isReceiableBankAccountIncomeMustValidate;
        public bool isOpenedByBankAccountManagementForm;
        public bool isOpenedByCashManagementForm;
        public int selectedFromBankAccountId;
        public int selectedToBankAccountId;
        public int incomeId;
        bool isBind = false;

        public IncomeForm()
        {
            InitializeComponent();

            incomeTableAdapter = new JSManagementDataSetTableAdapters.IncomeTableAdapter();
            incomeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            bankAccountTableAdapter = new JSManagementDataSetTableAdapters.BankAccountTableAdapter();
            bankAccountTableAdapter.Connection = CommonHelper.GetSQLConnection();

            cul = CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);
        }

        #region EventHandler

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateIncome()) return;

            DialogResult result;
            if (lbIncomeId.Text == "0")
            {
                if (!CheckActiveDate(dateTimePickerIncome.Value)) return;

                int incomeId;
                result = MessageBox.Show("Bạn có chắc chắn thêm phiếu thu mới?", "Thêm phiếu thu mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Cancel) return;

                if (!InsertIncome(out incomeId))
                {
                    MessageBox.Show("Thêm phiếu thu KHÔNG thành công!", "Thêm phiếu thu KHÔNG thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                result = MessageBox.Show("Thêm phiếu thu thành công! Bạn có muốn thêm phiếu thu mới", "Thêm phiếu thu mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    ClearData();
                    txtIncomeNumber.Focus();
                    return;
                }

                lbIncomeId.Text = incomeId.ToString();
            }
            else
            {
                var income = incomeTableAdapter.GetDataByIncomeId(int.Parse(lbIncomeId.Text));

                if (income[0] == null)
                {
                    MessageBox.Show("Phiếu thu không tồn tại");
                    return;
                }

                if (!CheckActiveDate(income[0].IncomeDate)) return;

                result = MessageBox.Show("Bạn có chắc chắn " + lbIncomeHeader.Text.ToLower() + "?", lbIncomeHeader.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Cancel) return;

                if (!UpdateIncome())
                {
                    MessageBox.Show(lbIncomeHeader.Text.ToLower() + " KHÔNG thành công!", lbIncomeHeader.Text.ToLower() + " KHÔNG thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                result = MessageBox.Show(lbIncomeHeader.Text.ToLower() + " thành công! Bạn có muốn thêm phiếu mới", "Thêm phiếu mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    ClearData();
                    txtIncomeNumber.Focus();
                    return;
                }

                UpdateIncomeGrid();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var income = incomeTableAdapter.GetDataByIncomeId(int.Parse(lbIncomeId.Text));

            if (income[0] == null)
            {
                MessageBox.Show("Phiếu thu không tồn tại");
                return;
            }

            if (!CheckActiveDate(income[0].IncomeDate)) return;

            int incomeId;

            if (!int.TryParse(lbIncomeId.Text, out incomeId) || lbIncomeId.Text == "0")
            {
                MessageBox.Show("Phiếu thu không tồn tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn muốn xóa phiếu?", "Xóa phiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Cancel) return;

            if (!DeleteIncome(incomeId))
            {
                MessageBox.Show("Xóa phiếu KHÔNG thành công!", "Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa phiếu thu thành công!");
            HideIncomeRowGrid();
            ClearData();
            txtIncomeNumber.Focus();
            return;
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
            txtIncomeNumber.Focus();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string incomeNumber = txtIncomeNumberFind.Text;
            int bankAccountId = cboxToBankAccountFind.SelectedValue == null || !cboxToBankAccountFind.Visible ? 0 : int.Parse(cboxToBankAccountFind.SelectedValue.ToString());

            int fromBankAccountId = 0;
            if (cboxFromBankAccountFind.SelectedValue.ToString() != "0")
            {
                fromBankAccountId = int.Parse(cboxFromBankAccountFind.SelectedValue.ToString());
            }
            int purchaseReceiptOrderId = 0;
            int.TryParse(txtPurchaseReceiptOrderIdFind.Text, out purchaseReceiptOrderId);

            SearchIncome(incomeNumber, dateTimePickerIncomeFindFrom.Value, dateTimePickerIncomeFindTo.Value, bankAccountId, fromBankAccountId, purchaseReceiptOrderId);
            //grvIncome.CellEnter -= grvIncome_CellEnter;
            //grvIncome.CellEnter +=grvIncome_CellEnter;
        }

        private void grvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        private void grvIncome_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        #endregion EventHandler

        #region CRUD

        private void SearchIncome(string incomeNumber, DateTime startDate, DateTime endDate, int bankAccountId, int fromBankAccountId, int purchaseReceiveOrderId)
        {
            grvIncome.ScrollBars = ScrollBars.Both;
            grvIncome.DataSource = incomeTableAdapter.GetIncome(startDate, endDate, incomeNumber, bankAccountId, fromBankAccountId, purchaseReceiveOrderId);
            RenameIncomeGridHeaderText();
            if (grvIncome.Rows.Count == 1)
                ClearData();
        }

        private bool InsertIncome(out int incomeId)
        {
            string incomeNumber = txtIncomeNumber.Text;
            DateTime incomeDate = dateTimePickerIncome.Value;
            string payerName = txtPayerName.Text;
            string reason = txtReason.Text;
            decimal amount = ucTextBoxCurrency1.Value;
            string createdBy = LoginInfor.UserName;
            DateTime createdDate = DateTime.Now;
            int purchaseOrderId = int.Parse(lbOrderId.Text);
            int costId = int.Parse(lbCostId.Text);
            int toBankAccountId = 0;
            int fromBankAccountId = int.Parse(cboxFromBankAccount.SelectedValue.ToString());
            List<int> incomeIds = new List<int>();
            int? custId = customerSelectUserControl1.CustId;
            if (custId == 0)
                custId = null;

            object income = new object();



            //Chuyển tiền vào tài khoản mà không phải thu công nợ
            if (!cboxReceivableFromCustomer.Checked && cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                toBankAccountId = int.Parse(cboxToBankAccount.SelectedValue.ToString());
            }

            //Chuyển tiền vào tài khoản tiền mặt từ tài khoản ngân hàng

            if (cboxFromBankAccount.SelectedValue.ToString() != "0" && cboxFromBankAccount.Visible)
            {
                fromBankAccountId = int.Parse(cboxFromBankAccount.SelectedValue.ToString());
            }

            income = incomeTableAdapter.InsertIncomeReturnId(incomeDate, incomeNumber, payerName, reason, amount, createdBy, createdDate, createdBy, createdDate, null, costId, purchaseOrderId, fromBankAccountId, toBankAccountId, custId);

            int.TryParse(income.ToString(), out incomeId);
            incomeIds.Add(incomeId);

            if (incomeIds.Count > 0)
            {
                return true;
            }

            return false;

        }

        private bool UpdateIncome()
        {
            int incomeId = int.Parse(lbIncomeId.Text);            
            string incomeNumber = txtIncomeNumber.Text;
            DateTime incomeDate = dateTimePickerIncome.Value;
            string payerName = txtPayerName.Text;
            string reason = txtReason.Text;
            decimal amount = 0;
            if(incomeTableAdapter.GetDataByIncomeId(incomeId)[0].Amount<0)
            {
                amount = -ucTextBoxCurrency1.Value;
            }
            else
            {
                amount = ucTextBoxCurrency1.Value;
            }
            
            string editedBy = LoginInfor.UserName;
            DateTime editedDate = DateTime.Now;
            int purchaseOrderId = int.Parse(lbOrderId.Text);
            int costId = int.Parse(lbCostId.Text);
            object income;
            List<int> rowcount = new List<int>();
            int rowEffect;
            int fromBankAccountId = int.Parse(cboxFromBankAccount.SelectedValue.ToString());
            int toBankAccountId = 0;
            int? custId = customerSelectUserControl1.CustId;
            if (custId == 0)
                custId = null;



            //Chuyển tiền vào tài khoản mà không phải thu công nợ
            if (!cboxReceivableFromCustomer.Checked && cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                toBankAccountId = int.Parse(cboxToBankAccount.SelectedValue.ToString());
            }

            //Chuyển tiền vào tài khoản tiền mặt từ tài khoản ngân hàng

            if (cboxFromBankAccount.SelectedValue.ToString() != "0" && cboxFromBankAccount.Visible)
            {
                fromBankAccountId = int.Parse(cboxFromBankAccount.SelectedValue.ToString());
            }

            income = incomeTableAdapter.UpdateIncomeById(incomeDate, incomeNumber, payerName, reason, amount, editedBy, editedDate, null, costId, incomeId, purchaseOrderId, fromBankAccountId, toBankAccountId, custId);
            int.TryParse(income.ToString(), out rowEffect);
            if (rowEffect > 0) rowcount.Add(incomeId);

            if (rowcount.Count > 0)
            {
                return true;
            }

            return false;
        }

        private bool DeleteIncome(int incomeId)
        {
            object income;
            List<int> rowcount = new List<int>();
            int rowEffect;
            income = incomeTableAdapter.DeleteIncomeById(incomeId);
            int.TryParse(income.ToString(), out rowEffect);
            if (rowEffect > 0) rowcount.Add(rowEffect);

            if (rowcount.Count > 0)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Ultility

        private bool CheckActiveDate(DateTime date)
        {
            if (!LoginInfor.IsAdmin)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled"))
                {
                    if (!CommonHelper.GetActiveDates().Contains(date.ToShortDateString()))
                    {
                        MessageBox.Show("Ngày nhập chưa được kích hoạt, liên hệ ADMIN!");
                        return false;
                    }
                }
            }
            return true;
        }

        private void ClearData()
        {
            lbIncomeHeader.Text = "Tạo phiếu thu".ToUpper();
            lbIncomeId.Text = "0";
            txtIncomeNumber.Text = string.Empty;
            ucTextBoxCurrency1.Value = 0;
            txtPayerName.Text = string.Empty;
            txtReason.Text = string.Empty;
            cboxReceivableFromCustomer.Checked = false;
            lbOrderId.Text = "0";
            lbCostId.Text = "0";
            dateTimePickerIncome.Value = DateTime.Now;
            cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.CASH;
            cboxFromBankAccount.SelectedValue = 0;
            customerSelectUserControl1.CustId = 0;
            cboxPaymentMethod.SelectedIndex = 0;
            customerSelectUserControl1.Enabled = true;
            lbType.Text = "Loại thu";
            lbToAccount.Text = "Đến Tài Khoản";
            lbPersonName.Text = "Người nộp tiền";
            lableFromBankAccount.Text = "Từ Tài Khoản";
        }

        private bool ValidateIncome()
        {
            if (!ValidatePaymentMethod())
            {
                return false;
            }

            if (isReceiableBankAccountIncomeMustValidate)
            {
                MessageBox.Show("Công nợ phải thu không hợp lệ!");
                return false;
            }

            if (txtIncomeNumber.Text == string.Empty)
            {
                MessageBox.Show("Bạn hãy nhập số phiếu chứng từ gốc");
                txtIncomeNumber.Focus();
                return false;
            }

            if (txtReason.Text == string.Empty)
            {
                MessageBox.Show("Lý do nộp không được để trống");
                txtReason.Focus();
                return false;
            }

            if (ucTextBoxCurrency1.Value <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                ucTextBoxCurrency1.Focus();
                return false;
            }

            return true;
        }

        private void BindDataToEdit(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvIncome.Rows.Count - 1)
            {
                ClearData();
                return;
            }

            rowIndex = e.RowIndex;
            DataGridViewRow row = grvIncome.Rows[e.RowIndex];
            int incomeId = 0;
            int.TryParse(row.Cells[Constant.Income.IncomeGrid.INCOME_ID_COLUMN_NAME].Value.ToString(), out incomeId);
            if (incomeId == 0) return;

            BindDataToEdit(incomeId);
            // JSManagementDataSet.IncomeDataTable incomeData = incomeTableAdapter.GetDataByIncomeId(incomeId);
            // lbIncomeHeader.Text = "Sửa phiếu thu".ToUpper();

            // lbIncomeId.Text = incomeId.ToString();
            // txtIncomeNumber.Text = incomeData[0].IncomeNumber;
            // dateTimePickerIncome.Value = incomeData[0].IncomeDate;
            // txtPayerName.Text = incomeData[0].PayerName;
            // txtReason.Text = incomeData[0].Reason;
            // ucTextBoxCurrency1.Value = incomeData[0].Amount;

            // lbOrderId.Text = incomeData[0].PurchaseReceiptOrderId.ToString();
            // lbCostId.Text = incomeData[0].CostId.ToString();
            // if (incomeData[0].ToBankAccountId != 0)
            // {
            //     cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.BANK_TRANSFER;
            //     cboxToBankAccount.SelectedValue = incomeData[0].ToBankAccountId;
            // }
            // else
            // {
            //     cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.CASH;
            // }


            //cboxFromBankAccount.SelectedValue = incomeData[0].FromBankAccountId;
            //if (incomeData[0].CustomerId != 0)
            //customerSelectUserControl1.CustId = incomeData[0].CustomerId;

            // rowIndex = e.RowIndex;
        }

        private void RenameIncomeGridHeaderText()
        {
            grvIncome.Columns[Constant.Income.IncomeGrid.INCOME_ID_COLUMN_NAME].HeaderText = "ID";
            grvIncome.Columns[Constant.Income.IncomeGrid.INCOME_DATE_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.INCOME_DATE_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.INCOME_NUMBER_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.INCOME_NUMBER_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.PAYER_NAME_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.PAYER_NAME_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.REASON_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.REASON_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.AMOUNT_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.AMOUNT_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.AMOUNT_COLUMN_NAME].DefaultCellStyle.Format = string.Format("#,###", cul.NumberFormat);
            grvIncome.Columns[Constant.Income.IncomeGrid.CREATED_BY_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.CREATED_BY_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.CREATED_DATE_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.CREATED_DATE_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.LAST_EDITED_BY_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.LAST_EDITED_BY_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.LAST_EDITED_DATE_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.LAST_EDITED_DATE_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.ORDER_ID_COLUMN_NAME].Visible = false;
            grvIncome.Columns[Constant.Income.IncomeGrid.PURCHASE_ORDER_ID_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.PURCHASE_ORDER_ID_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.FROM_BANK_ACCOUNT_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.FROM_BANK_ACCOUNT_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.TO_BANK_ACCOUNT_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.TO_BANK_ACCOUNT_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.COST_ID_COLUMN_NAME].HeaderText = Constant.Income.IncomeGrid.COST_ID_COLUMN_HEADER;
            grvIncome.Columns[Constant.Income.IncomeGrid.TO_BANK_ACCOUNT_ID_COLUMN_NAME].Visible = false;
            grvIncome.Columns[Constant.Income.IncomeGrid.FROM_BANK_ACCOUNT_ID_COLUMN_NAME].Visible = false;

        }

        private void UpdateIncomeGrid()
        {
            grvIncome.Rows[rowIndex].Cells[1].Value = dateTimePickerIncome.Value;
            grvIncome.Rows[rowIndex].Cells[2].Value = txtIncomeNumber.Text;
            grvIncome.Rows[rowIndex].Cells[3].Value = txtPayerName.Text;
            grvIncome.Rows[rowIndex].Cells[4].Value = txtReason.Text;
            grvIncome.Rows[rowIndex].Cells[5].Value = ucTextBoxCurrency1.Value;
            grvIncome.Rows[rowIndex].Cells[10].Value = lbOrderId.Text;
            grvIncome.Rows[rowIndex].Cells[11].Value = lbCostId.Text;
        }

        private void HideIncomeRowGrid()
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[grvIncome.DataSource];
            currencyManager1.SuspendBinding();
            grvIncome.Rows.RemoveAt(rowIndex);
        }

        #endregion Ultility

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            grvIncome.CellEnter += grvIncome_CellEnter;

            cboxFromBankAccountFind.DataSource = bankAccountTableAdapter.GetBankAccountFillToComboBox();
            cboxFromBankAccountFind.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
            cboxFromBankAccountFind.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;

            if (isOpenedByBankAccountManagementForm || isOpenedByCashManagementForm)
            {
                cboxPaymentMethod.SelectedItem = paymentMethodName;
            }

            cboxFromBankAccount.DataSource = bankAccountTableAdapter.GetBankAccountFillToComboBox();
            cboxFromBankAccount.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
            cboxFromBankAccount.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;

            if (isOpenedByBankAccountManagementForm)
            {
                cboxFromBankAccount.SelectedValue = selectedFromBankAccountId;
            }

            this.WindowState = FormWindowState.Maximized;

            if (incomeId != 0)
                BindDataToEdit(incomeId);
        }

        private void BindDataToEdit(int incomeId)
        {
            if (incomeId == 0) return;
            ClearData();
            JSManagementDataSet.IncomeDataTable incomeData = incomeTableAdapter.GetDataByIncomeId(incomeId);
            if(incomeData[0].Amount<0)
            {
                lbIncomeHeader.Text = "Sửa phiếu chi".ToUpper();
                lbType.Text = "Loại chi";
                lbToAccount.Text = "Từ Tài Khoản";             
                lbPersonName.Text = "Người trả tiền";
                lableFromBankAccount.Text = "Đến Tài Khoản";
            }
            else
            {
                lbIncomeHeader.Text = "Sửa phiếu thu".ToUpper();
                lbType.Text = "Loại thu";
                lbToAccount.Text = "Đến Tài Khoản";
                lbPersonName.Text = "Người nộp tiền";
                lableFromBankAccount.Text = "Từ Tài Khoản";
            }            

            if (incomeData[0].ToBankAccountId != 0)
            {
                cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.BANK_TRANSFER;
                cboxToBankAccount.SelectedValue = incomeData[0].ToBankAccountId;
            }
            else
            {
                cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.CASH;
            }
            lbIncomeId.Text = incomeId.ToString();
            txtIncomeNumber.Text = incomeData[0].IncomeNumber;
            dateTimePickerIncome.Value = incomeData[0].IncomeDate;
            txtPayerName.Text = incomeData[0].PayerName;
            txtReason.Text = incomeData[0].Reason;
            CultureInfo cul = CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);
            ucTextBoxCurrency1.Value = incomeData[0].Amount>0?incomeData[0].Amount : -incomeData[0].Amount;

            if(incomeData[0].PurchaseReceiptOrderId >= 0)
                lbOrderId.Text =  incomeData[0].PurchaseReceiptOrderId.ToString();
            if (lbOrderId.Text != "0")
            {
                cboxReceivableFromCustomer.CheckedChanged -= cboxReceivableFromCustomer_CheckedChanged;
                cboxReceivableFromCustomer.Checked = true;
                customerSelectUserControl1.Enabled = false;
                customerSelectUserControl1.CustId = incomeData[0].CustomerId;
                customerSelectUserControl1.Enabled = false;
                cboxReceivableFromCustomer.CheckedChanged += cboxReceivableFromCustomer_CheckedChanged;
            }

            lbCostId.Text = incomeData[0].CostId.ToString();


            cboxFromBankAccount.SelectedValue = incomeData[0].FromBankAccountId;

            customerSelectUserControl1.CustId = incomeData[0].CustomerId;
        }

        private void cboxReceivableFromCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidatePaymentMethod())
            {
                return;
            }

            CheckBox cboxReceivableFromCustomer = (CheckBox)sender;

            if (!cboxReceivableFromCustomer.Checked)
            {
                customerSelectUserControl1.Enabled = true;
            }

            if (cboxReceivableFromCustomer.Checked)
            {
                ReceivableFromCustomersForm receivableFromCustForm = new ReceivableFromCustomersForm();
                receivableFromCustForm.isOpenByIncome = true;
                receivableFromCustForm.bankAccountIdPassFromOtherControl = (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER && cboxToBankAccount.Visible == true) ? int.Parse(cboxToBankAccount.SelectedValue.ToString()) : 0;
                (receivableFromCustForm.Controls.Find(Constant.ReceiveableFromCustomer.BANK_ACCOUNT_COMBOBOX_CONTROL_NAME, true)[0] as ComboBox).Enabled = false;
                receivableFromCustForm.ShowDialog();

                return;
            }
        }

        private void IncomeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

            if (e.Control && e.KeyCode == Keys.O) txtIncomeNumber.Focus();

            if (e.Control && e.KeyCode == Keys.A) dateTimePickerIncome.Focus();

            if (e.Control && e.KeyCode == Keys.N) txtPayerName.Focus();

            if (e.Control && e.KeyCode == Keys.L) txtReason.Focus();

            if (e.Control && e.KeyCode == Keys.E) ucTextBoxCurrency1.Focus();

            if (e.Control && e.KeyCode == Keys.U) cboxReceivableFromCustomer.Focus();

            if (e.Control && e.KeyCode == Keys.S) btSave_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.X) btDelete_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.T) btAddNew_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.P) dateTimePickerIncomeFindFrom.Focus();
        }

        private void dateTimePickerIncome_ValueChanged(object sender, EventArgs e)
        {
            if (!LoginInfor.IsAdmin)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePickerIncome.Value.ToShortDateString()))
                    {
                        btSave.Enabled = false;
                        btDelete.Enabled = false;
                        return;
                    }
                }
                btSave.Enabled = true;
                btDelete.Enabled = true;
            }
        }

        private void cboxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPaymentMethod.SelectedItem == null) return;
            if (cboxPaymentMethod.SelectedItem.ToString() != Constant.PaymentMethod.BANK_TRANSFER)
            {
                cboxToBankAccount.Visible = false;
                lbToAccount.Visible = false;
                return;
            }

            if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                cboxToBankAccount.Visible = true;
                lbToAccount.Visible = true;
                cboxToBankAccount.DataSource = bankAccountTableAdapter.GetData();
                cboxToBankAccount.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
                cboxToBankAccount.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;

                if (isOpenedByBankAccountManagementForm)
                {
                    cboxToBankAccount.SelectedValue = selectedToBankAccountId;
                }
            }
        }

        private void cboxPaymentMethodFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPaymentMethodFind.SelectedItem.ToString() != Constant.PaymentMethod.BANK_TRANSFER)
            {
                cboxToBankAccountFind.Visible = false;
                lableToBankAccountFind.Visible = false;
                return;
            }

            if (cboxPaymentMethodFind.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                cboxToBankAccountFind.Visible = true;
                lableToBankAccountFind.Visible = true;
                cboxToBankAccountFind.DataSource = bankAccountTableAdapter.GetData();
                cboxToBankAccountFind.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
                cboxToBankAccountFind.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;

            }
        }

        public void Show(int incomeId)
        {
            BindDataToEdit(incomeId);
        }

        #region Utils

        private bool ValidatePaymentMethod()
        {
            if (cboxPaymentMethod.SelectedItem == null || cboxPaymentMethod.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show("Bạn hãy chọn loại thu!");
                cboxPaymentMethod.Focus();
                return false;
            }
            return true;
        }

        #endregion

    }
}
