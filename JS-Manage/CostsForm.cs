using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class CostsForm : Form
    {
       
        JSManagementDataSetTableAdapters.CostTableAdapter costTableAdapter;
        JSManagementDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private const string COST_ID = "CostId";
        public int selectedCostTypeId;
        public int selectedBankAccountId;
        public bool isOpenedByBankAccountManagement;
        public int costId;

        public CostsForm()
        {
            InitializeComponent();
            costTableAdapter = new JSManagementDataSetTableAdapters.CostTableAdapter();
            costTableAdapter.Connection = CommonHelper.GetSQLConnection();
            costTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            bankAccountTableAdapter = new JSManagementDataSetTableAdapters.BankAccountTableAdapter();
            bankAccountTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void CostsForm_Load(object sender, EventArgs e)
        {
            cbCostType.DataSource = costTypeTableAdapter.GetDataFillToComboBox();
            cbCostType.DisplayMember = Constant.CostType.COST_TYPE_NAME;
            cbCostType.ValueMember = Constant.CostType.COST_TYPE_ID;
            cbCostType.SelectedValue = selectedCostTypeId;
            
            cbCostTypeFind.DataSource = costTypeTableAdapter.GetDataFillToComboBox();
            cbCostTypeFind.DisplayMember = Constant.CostType.COST_TYPE_NAME;
            cbCostTypeFind.ValueMember = Constant.CostType.COST_TYPE_ID;

            if (costId != 0) BindDataToEdit(costId);
        }

        

        #region EventHandler

        private void dateTimePickerCostDate_ValueChanged(object sender, EventArgs e)
        {
            if (LoginInfor.IsAdmin == false)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePickerCostDate.Value.ToShortDateString()))
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

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;                       

            if (lbCostId.Text == "0")
            {
                if (!CheckActiveDate(dateTimePickerCostDate.Value)) return;

                int costId;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn tạo phiếu chi?","Tạo phiếu chi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Cancel) return;

                if (!InsertCost(out costId))
                {
                    MessageBox.Show("Tạo phiếu chi KHÔNG thành công!","Tạo phiếu chi KHÔNG thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult measageResult = MessageBox.Show("Thêm phiếu chi thành công! Bạn có muốn thêm phiếu chi mới", "Tạo phiếu chi mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (measageResult == System.Windows.Forms.DialogResult.OK)
                {
                    ClearData();
                    txtCostName.Focus();
                    return;
                }

                lbCostId.Text = costId.ToString();
            }
            else
            {
                var cost = costTableAdapter.GetById(int.Parse(lbCostId.Text));

                if (cost[0] == null)
                {
                    MessageBox.Show("Phiếu thu không tồn tại!");
                    return;
                }

                if (!CheckActiveDate(cost[0].CostDate)) return;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa phiếu chi?", "Sửa phiếu chi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Cancel) return;

                if (!UpdateCost(lbCostId.Text))
                {
                    MessageBox.Show("Sửa phiếu chi KHÔNG thành công!","Sửa phiếu chi không thành công",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult measageResult = MessageBox.Show("Sửa phiếu chi thành công! Bạn có muốn tạo phiếu chi mới", "Tạo phiếu chi mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (measageResult == System.Windows.Forms.DialogResult.OK)
                {
                    ClearData();
                    txtCostName.Focus();
                    return;
                }
            }            
        }

        private void ClearData()
        {
            lbCostHeader.Text = "Nhập chi phí".ToUpper();
            lbCostId.Text = "0";
            txtAmount.Text = string.Empty;
            txtCostName.Text = string.Empty;
            dateTimePickerCostDate.Value = DateTime.Now;
            cbCostType.SelectedIndex = 0;
        }

        private void grvCost_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        private void grvCost_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var cost = costTableAdapter.GetById(int.Parse(lbCostId.Text));

            if (cost[0] == null)
            {
                MessageBox.Show("Phiếu thu không tồn tại!");
                return;
            }

            if (!CheckActiveDate(cost[0].CostDate)) return;           

            int costId;
            if (!int.TryParse(lbCostId.Text, out costId)|| lbCostId.Text == "0")
            {
                MessageBox.Show("Phiếu chi không tồn tại!");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn muốn xóa phiếu chi?", "Xóa phiếu chi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Cancel) return;

            if (!DeleteCost(costId))
            {
                MessageBox.Show("Xóa phiếu chi KHÔNG thành công!","Xóa không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa phiếu chi thành công!");            
            ClearData();
            return;
            
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            int costTypeId = -1;
            int bankAccountId = cboxBankAccountFind.SelectedValue == null ? 0 : int.Parse(cboxBankAccountFind.SelectedValue.ToString());


            if (cbCostTypeFind.SelectedValue != null)
            {
                costTypeId = int.Parse(cbCostTypeFind.SelectedValue.ToString());
            }
            if (LoginInfor.IsAdmin || Setting.GetBoolSetting("AllowUserViewAllCost"))
            {
                grvCost.DataSource = costTableAdapter.GetCost(dateTimePickerCostFrom.Value, dateTimePickerCostTo.Value, costTypeId, bankAccountId);
            }
            else
            {
                if (costTypeId == 1)
                {
                    grvCost.DataSource = costTableAdapter.GetCost(dateTimePickerCostFrom.Value, dateTimePickerCostTo.Value, costTypeId, bankAccountId);
                }
                else
                {
                    grvCost.DataSource = null;
                    MessageBox.Show("Bạn không có quyền xem, hãy liên hệ với admin!");

                }
            }
        }

        #endregion EventHandler

        #region CRUD

        private bool UpdateCost(string p)
        {
            DateTime costDate = dateTimePickerCostDate.Value;
            string costName = txtCostName.Text;
            List<string> activeDate = new List<string>();
            string userName = LoginInfor.UserName;
            int bankAccountId = 0;
            int custId = 0;
            if (customerSelectUserControl.Visible)
            {
                custId = customerSelectUserControl.CustId;
            }
            if (cbCostType.Text == Constant.CostType.BANK_TRANSFER)
            {
                bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }
           
            if (costTableAdapter.UpdateCostById(costDate, costName, decimal.Parse(txtAmount.Text), int.Parse(cbCostType.SelectedValue.ToString()), userName, bankAccountId,null, null, int.Parse(p), custId) > 0)
            {
                return true;
            }                        

            return false;
        }

        private bool InsertCost(out int costId)
        {
            DateTime costDate = dateTimePickerCostDate.Value;
            string costName = txtCostName.Text;
            int custId = 0;
            if (customerSelectUserControl.Visible)
            {
                custId = customerSelectUserControl.CustId;
            }
            string userName = LoginInfor.UserName;
            int bankAccountId = 0;
            if (cbCostType.Text == Constant.CostType.BANK_TRANSFER)
            {
                bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }

            object obj;
            
            obj = costTableAdapter.InsertReturnId(costDate, costName, decimal.Parse(txtAmount.Text), int.Parse(cbCostType.SelectedValue.ToString()), userName, bankAccountId, null, null, custId);
                    

            if(!int.TryParse(obj.ToString(), out costId))
            {
                return false;
            }

            if (costId > 0)
            {
                return true;          
            }

            return false;
        }

        private bool DeleteCost(int costId)
        {
            if (costTableAdapter.DeleteCostById(int.Parse(lbCostId.Text)) > 0)
            {
                return true;
            }
            return false;
        }

        #endregion CRUD

        #region Ultility

        private bool ValidateData()
        { 
            decimal amount;
            int costTypeId = 0;
            List<string> activeDate = new List<string>();
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Số tiền nhập không hợp lệ!");
                return false;
            }

            if(!int.TryParse(cbCostType.SelectedValue.ToString(), out costTypeId))
            {
                MessageBox.Show("Loại chi không hợp lệ!");
                return false;
            }

            if (costTypeId==0)
            {
                MessageBox.Show("Loại chi không hợp lệ!");
                return false;
            }

            if (Setting.GetBoolSetting("ActiveDate"))
            {
                activeDate = CommonHelper.GetActiveDates();

                if (!activeDate.Contains(dateTimePickerCostDate.Value.ToShortDateString()))
                {
                    MessageBox.Show("Ngày nhập liệu chưa được kích hoạt");
                    return false;
                                        
                }                
            }

            return true;
        }        

        private void BindDataToEdit(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == grvCost.RowCount-1 || e.RowIndex == -1)
            return;

            DataGridViewRow row = grvCost.Rows[e.RowIndex];
            int costId = int.Parse(row.Cells[COST_ID].Value.ToString());
            JSManagementDataSet.CostDataTable costData = costTableAdapter.GetById(costId);
            if (costData.Rows.Count == 1)
            {
                lbCostHeader.Text = "Sửa Chi Phí".ToUpper();
                lbCostId.Text = costId.ToString();
                txtCostName.Text = costData[0].CostName;
                txtAmount.Text = costData[0].Amount.ToString("#,###");
                cbCostType.SelectedValue = costData[0].CostTypeId;
                TextBox txtCustId = customerSelectUserControl.Controls.Find("txtCustId",true)[0] as TextBox;
                txtCustId.Text = costData[0].CustomerId.ToString();
                if (cbCostType.Text == Constant.CostType.BANK_TRANSFER)
                {
                    cboxBankAccount.SelectedValue = costData[0].BankAccountId;
                }

                dateTimePickerCostDate.Value = costData[0].CostDate;
            }            
        }

        private void BindDataToEdit(int costId)
        {
            JSManagementDataSet.CostDataTable costData = costTableAdapter.GetById(costId);
            if (costData.Rows.Count == 1)
            {
                lbCostHeader.Text = "Sửa Chi Phí".ToUpper();
                lbCostId.Text = costId.ToString();
                txtCostName.Text = costData[0].CostName;
                txtAmount.Text = costData[0].Amount.ToString("#,###");
                cbCostType.SelectedValue = costData[0].CostTypeId;
                TextBox txtCustId = customerSelectUserControl.Controls.Find("txtCustId", true)[0] as TextBox;
                txtCustId.Text = costData[0].CustomerId.ToString();
                if (cbCostType.Text == Constant.CostType.BANK_TRANSFER)
                {
                    cboxBankAccount.SelectedValue = costData[0].BankAccountId;
                }

                dateTimePickerCostDate.Value = costData[0].CostDate;
            }      
        }

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

        #endregion Ultility
      
        private void CostsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

            if (e.Control && e.KeyCode == Keys.A) dateTimePickerCostDate.Focus();

            if (e.Control && e.KeyCode == Keys.U) txtCostName.Focus();

            if (e.Control && e.KeyCode == Keys.S) txtAmount.Focus();

            if (e.Control && e.KeyCode == Keys.L) cbCostType.Focus();

            if (e.Control && e.KeyCode == Keys.S) btSave_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.X) btDelete_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.T) btAddNew_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.P) dateTimePickerCostFrom.Focus();
        }

        private void cbCostType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCostType.Text == Constant.CostType.BANK_TRANSFER)
            {
                cboxBankAccount.Visible = true;
                cboxBankAccount.DataSource = bankAccountTableAdapter.GetData();
                cboxBankAccount.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
                cboxBankAccount.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;
                if (isOpenedByBankAccountManagement)
                {
                    cboxBankAccount.SelectedValue = selectedBankAccountId;
                }
            }
            else
            {
                cboxBankAccount.Visible = false;
            }

            if (cbCostType.Text == Constant.CostType.PRODUCT_INPUT_COST_TYPE)
            {
                customerSelectUserControl.Visible = true;
            }
        }

        private void cbCostTypeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCostTypeFind.Text == Constant.CostType.BANK_TRANSFER)
            {
                cboxBankAccountFind.Visible = true;
                cboxBankAccountFind.DataSource = bankAccountTableAdapter.GetData();
                cboxBankAccountFind.DisplayMember = Constant.BankAccount.Bank_Account_Name_Column_Name;
                cboxBankAccountFind.ValueMember = Constant.BankAccount.Bank_Account_Id_Column_Name;
            }
            else
            {
                cboxBankAccountFind.Visible = false;
            }
        }        
    }
}
