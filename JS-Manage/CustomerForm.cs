using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JS_Manage
{
    public partial class CustomerForm : Form
    {
        JSManagementDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        JSManagementDataSetTableAdapters.CustomerTypeTableAdapter customerTypeTableAdapter;
        JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter rewardPointsHistoryTableAdapter;
        JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter getProductInOutDetailTableAdapter;
        JSManagementDataSetTableAdapters.RewardPointsHistoryByCustomerIdTableAdapter rewardPointsByCustIdTableAdapter;
        public bool isAdmin;
        public bool isOpenByReceivableFromCustomer = false;
        public bool isOpenByPurchaseReceiptOrder = false;
        public bool isOpenByPurchaseReceiptOrderFind = false;
        public bool isOpenByCustomerSelectUserControl = false;
        public bool isOpenBySupplierSelectUserControl = false;
        private int currentMouseOverRow;
        public int CustId;

        private const string CUST_TYPE_NAME = "CustTypeName";
        private const string CUST_TYPE_ID = "CustTypeId";

        private const string Reward_Point_Enable = "RewardPointEnable";       
        private const string Reward_Point_For_Registration = "RewardPointForRegistration";

        public CustomerForm()
        {
            InitializeComponent();
            customerTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            this.customerTableAdapter.Connection = CommonHelper.GetSQLConnection();

            customerTypeTableAdapter = new JSManagementDataSetTableAdapters.CustomerTypeTableAdapter();
            customerTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            rewardPointsHistoryTableAdapter = new JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter();
            rewardPointsHistoryTableAdapter.Connection = CommonHelper.GetSQLConnection();

            getProductInOutDetailTableAdapter = new JSManagementDataSetTableAdapters.GetProductInOutDetailTableAdapter();
            getProductInOutDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();

            rewardPointsByCustIdTableAdapter = new JSManagementDataSetTableAdapters.RewardPointsHistoryByCustomerIdTableAdapter();
            rewardPointsByCustIdTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        #region Event Handler

        private void CustomerForm_Load(object sender, EventArgs e)
        {                    
            grvCustomer.CellEnter += grvCustomer_CellEnter;
            comboBoxCustomerType.DataSource = customerTypeTableAdapter.GetData();
            comboBoxCustomerType.DisplayMember = CUST_TYPE_NAME;
            comboBoxCustomerType.ValueMember = CUST_TYPE_ID;
            //txtCustIdFind.Text = CustId.ToString();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult result;
                if (!ValidateData())
                {
                    return;
                }

                if (lbCustId.Text == "0")
                {
                    result = MessageBox.Show("Bạn có chắc chắn thêm khách hàng mới", "Thêm khách hàng mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Cancel) return;

                    if (!InsertCustomer())
                    {
                        MessageBox.Show("Thêm khách hàng mới KHÔNG thành công!", "Thêm KH không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    

                    result = MessageBox.Show("Thêm khách hàng mới thành công! Bạn có muốn thêm khách hàng mới", "Thêm khách hàng mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        ClearData();
                        return;
                    }
                }
                else
                {
                    result = MessageBox.Show("Bạn có chắc chắn sửa thông tin khách hàng", "Sửa thông tin khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Cancel) return;

                    if (!UpdateCustomer())
                    {
                        MessageBox.Show("Sửa thông tin khách hàng KHÔNG thành công!", "Sửa thông tin khách hàng KHÔNG thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    result = MessageBox.Show("Sửa thông tin khách hàng thành công! Bạn có muốn thêm khách hàng mới", "Thêm khách hàng mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        ClearData();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }          

        private void grvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void grvCustomer_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BindDataToEdit(e);
        }

        private void btFindCust_Click(object sender, EventArgs e)
        {
            int custId = 0;
            int.TryParse(txtCustIdFind.Text, out custId);
            string searchText = txtCustNameSearch.Text;
            bool isContact = cboxIsContactFind.Checked;
            bool hasNote = cboxHasNote.Checked;
            grvCustomer.DataSource = this.customerTableAdapter.GetCustomers(custId, searchText,hasNote,isContact);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form custAddForm = new Form();
            custAddForm.Text = "Thêm khách hàng mới";
            CustomerUserControl custUserControl = new CustomerUserControl();
            custAddForm.Controls.Add(custUserControl);
            custAddForm.Width = custUserControl.Width;
            custAddForm.Show();
        }

        private void txtCustNameSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtCustNameSearch.Text.Length>3)
                btFindCust_Click(sender, e);
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
            grvRewardPointHistory.DataSource = null;
            grvTransactionHistory.DataSource = null;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbCustId.Text == "0")
            {
                MessageBox.Show("Thông tin khách hàng không tồn tại!", "Không thể xóa khách hàng không tồn tại");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa khách hàng", "Xóa khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Cancel) return;

            if (!DeleteCustomer())
            {
                MessageBox.Show("Xóa khách hàng KHÔNG thành công!", "Xóa khách hàng KHÔNG thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Xóa khách hàng thành công!");                       
            ClearData();
            return;            
        }

        #endregion Event Handler

        #region CRUD

        private bool InsertCustomer()
        {
            int registrationRewardPoint = 0;
            int custId = 0;
            if (Setting.GetBoolSetting(Reward_Point_Enable) && checkBoxIsAttendRewardPointProgram.Checked) 
            {
                registrationRewardPoint = Setting.GetIntergerSetting(Reward_Point_For_Registration);
                
            }
            object returnValue = customerTableAdapter.InsertReturnId(txtCustName.Text, txtCustAddress.Text, txtPhone.Text.Trim(), txtNote.Text, int.Parse( comboBoxCustomerType.SelectedValue.ToString()), registrationRewardPoint,cboxIsContact.Checked, checkBoxIsAttendRewardPointProgram.Checked) ;
            if (int.TryParse(returnValue.ToString(), out custId))
            {
                if (Setting.GetBoolSetting(Reward_Point_Enable) && checkBoxIsAttendRewardPointProgram.Checked)
                {
                    rewardPointsHistoryTableAdapter.Insert(custId, 0, registrationRewardPoint, registrationRewardPoint, 0, "Điểm thưởng từ đăng ký thành viên", new DateTime(1990, 01, 01));
                }
                return true;
            }

            return false;
        }

        private bool UpdateCustomer()
        {
            if (customerTableAdapter.UpdateCustomerById(txtCustName.Text, txtCustAddress.Text, txtPhone.Text.Trim(), txtNote.Text, int.Parse(comboBoxCustomerType.SelectedValue.ToString()) ,cboxIsContact.Checked,checkBoxIsAttendRewardPointProgram.Checked,int.Parse(lbCustId.Text)) > 0)
            {
                return true;
            }
            return false;
        }

        private bool DeleteCustomer()
        {
            try
            {


                if (customerTableAdapter.DeleteCustomerById(int.Parse(lbCustId.Text)) > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return false;
        }

        #endregion CRUD

        #region Ultility

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(txtCustName.Text))
            {
                MessageBox.Show("Bạn hãy nhập tên khách hàng!", "Tên khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Bạn hãy nhập số điện thoại khách hàng!", "Số điện thoại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return false;
            }

            if (int.Parse(comboBoxCustomerType.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Bạn hãy nhập phân loại khách hàng!", "Phân loại khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxCustomerType.Focus();
                return false;
            }

            if (CheckCustomerExisted(txtPhone.Text) && lbCustId.Text=="0")
            {
                MessageBox.Show(string.Format("Số điện thoại {0} đã đăng ký!",txtPhone.Text));
                return false;
            }
            
            return true;
        }

        private void BindDataToEdit(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvCustomer.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            int custID = int.Parse(row.Cells[0].Value.ToString());

            JSManagementDataSet.CustomerDataTable custData = customerTableAdapter.GetDataByCustomerId(custID);
            string custName = custData[0].CustomerName;
            string custAddress = custData[0].Address;
            string custPhone = custData[0].Telephone;
            string custNote = custData[0].Note;

            lbCustId.Text = custID.ToString();
            txtCustName.Text = custName;
            txtCustAddress.Text = custAddress;
            txtPhone.Text = custPhone;
            txtNote.Text = custNote;
            comboBoxCustomerType.SelectedValue = custData[0].CustTypeId;
            cboxIsContact.Checked = custData[0].IsContact;
            checkBoxIsAttendRewardPointProgram.Checked = custData[0].IsAttendRewardPointProgram;
            lbHeader.Text = string.Format("Sửa thông tin khách hàng").ToUpper();

            grvTransactionHistory.DataSource = getProductInOutDetailTableAdapter.GetProductInOutDetailByCustomerId(custID);
            //foreach(DataGridViewRow r in grvTransactionHistory.Rows)
            //{
            //    if (!Setting.GetBoolSetting("AllowUserViewAllCost") && !LoginInfor.IsAdmin)
            //    {
            //        if (r.Cells["Action"].Value != null)
            //        {
            //            if (r.Cells["IsReturnSupplier"].Selected && r.Cells["Action"].Value.ToString() == "xuất")
            //            {
            //                r.Cells["Price"].Value = 0;
            //                //r.Cells["ClosingBalance"].Value = 0;
            //            }
            //        }
            //    }
                
            //}

            grvRewardPointHistory.DataSource = rewardPointsByCustIdTableAdapter.GetRewardPointsHistoryByCustomerId(custID);

            if (!Setting.GetBoolSetting("AllowUserViewAllCost") && !LoginInfor.IsAdmin)
            {
                foreach (DataGridViewRow r in grvTransactionHistory.Rows)
                {
                    if (r.Cells["Action"].Value != null)
                    {
                        if (((bool.Parse(r.Cells["IsReturnSupplier"].Value.ToString())) && r.Cells["Action"].Value.ToString().Trim().ToLower() == "xuất") || r.Cells["Action"].Value.ToString() == "nhập")
                        {
                            r.Cells["Price"].Value = 0;
                            //r.Cells["Amount"].Value = 0;
                            //r.Cells["ClosingBalanceAmount"].Value = 0;
                            //r.Cells["ClosingBalance"].Value = 0;
                        }
                    }
                }
            }

        }

        private void GetCustomerInforToPurchaseReceiptOrderFormFind(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvCustomer.Rows[e.RowIndex];
            string custID = row.Cells[0].Value.ToString();
            string custName = row.Cells[1].Value.ToString();
            string custAddress = row.Cells[2].Value.ToString();
            string custPhone = row.Cells[3].Value.ToString();

            FormCollection fc = Application.OpenForms;
            Form PurchaseReceiptOrderForm = new Form();

            foreach (Form f in fc)
            {
                if (f.Name == "PurchaseReceiptOrderForm")
                {
                    PurchaseReceiptOrderForm = f;
                }
            }

            PurchaseReceiptOrderForm.Controls.Find("txtCustomerCodeFind", true)[0].Text = custID;
            PurchaseReceiptOrderForm.Controls.Find("lbCustInforFind", true)[0].Text = string.Format("{0}, {1}, {2}", custName, custAddress, custPhone); ;
            this.Close();
        }

        private void GetCustomerInforToPurchaseReceiptOrderForm(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvCustomer.Rows[e.RowIndex];
            string custID = row.Cells[0].Value.ToString();
            string custName = row.Cells[1].Value.ToString();
            string custAddress = row.Cells[2].Value.ToString();
            string custPhone = row.Cells[3].Value.ToString();

            FormCollection fc = Application.OpenForms;
            Form PurchaseReceiptOrderForm = new Form();

            foreach (Form f in fc)
            {
                if (f.Name == "PurchaseReceiptOrderForm")
                {
                    PurchaseReceiptOrderForm = f;
                }
            }

            PurchaseReceiptOrderForm.Controls.Find("txtCustomerCode", true)[0].Text = custID;
            PurchaseReceiptOrderForm.Controls.Find("lbCustomerInfo", true)[0].Text = string.Format("{0}, {1}, {2}", custName, custAddress, custPhone); 
            this.Close();
        }

        private void GetCustomerInforToReceivableForm(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvCustomer.Rows[e.RowIndex];
            string custID = row.Cells[0].Value.ToString();
            string custName = row.Cells[1].Value.ToString();
            string custAddress = row.Cells[2].Value.ToString();
            string custPhone = row.Cells[3].Value.ToString();
            FormCollection fc = Application.OpenForms;
            Form receivableFromCustForm = new Form();

            foreach (Form f in fc)
            {
                if (f.Name == "ReceivableFromCustomersForm")
                {
                    receivableFromCustForm = f;
                }                
            }

            receivableFromCustForm.Controls.Find("lbCustId", true)[0].Text = custID;
            receivableFromCustForm.Controls.Find("txtCustomer", true)[0].Text = string.Format("{0}, {1}, {2}", custName, custAddress, custPhone);
            this.Close();
        }

        private void ClearData()
        {
            txtCustName.Text = string.Empty;
            txtCustAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtNote.Text = string.Empty;
            lbCustId.Text = "0";
            comboBoxCustomerType.SelectedValue = 0;
            checkBoxIsAttendRewardPointProgram.Checked = Setting.GetBoolSetting(Constant.Setting.REWARD_POINT_ENABLED);
            lbHeader.Text = "Thêm khách hàng".ToUpper();
        }

        #endregion Ultility

        private void CustomerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

            if (e.Control && e.KeyCode == Keys.A) txtCustName.Focus();

            if (e.Control && e.KeyCode == Keys.D) txtCustAddress.Focus();

            if (e.Control && e.KeyCode == Keys.E) txtPhone.Focus();

            if (e.Control && e.KeyCode == Keys.G) txtNote.Focus();

            if (e.Control && e.KeyCode == Keys.S) btSave_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.X) btDelete_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.T) btAddNew_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.K) txtCustNameSearch.Focus();
        }

        private void grvCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = grvCustomer.HitTest(e.X, e.Y).RowIndex;
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Xem lịch sử giao dịch", new EventHandler(viewCustomerTransactionHistory)));
                m.MenuItems.Add(new MenuItem("Xem điểm tích lũy", new EventHandler(viewCustomerRewardPointsHistory)));
                if (currentMouseOverRow >= 0)
                {
                    m.Show(grvCustomer, new Point(e.X, e.Y));
                }
                
            }
        }

        private void viewCustomerRewardPointsHistory(object sender, EventArgs e)
        {
            DataGridViewRow row = grvCustomer.Rows[currentMouseOverRow];
            string custID = row.Cells[0].Value.ToString();
            JSManagementDataSet.CustomerDataTable custData = customerTableAdapter.GetDataByCustomerId(int.Parse(custID));

            if (custData.Rows.Count == 0) return;
            string custName = custData[0].CustomerName;
            string custAddress = custData[0].Address;
            string custPhone = custData[0].Telephone;
            string custNote = custData[0].Note;

            Form custEditForm = new Form();
            custEditForm.Text = "Sửa thông tin khách hàng";

            CustomerRewardPointsHistoryUserControl custUserControl = new CustomerRewardPointsHistoryUserControl();
            TextBox txtCustName = custUserControl.Controls.Find("txtCustName", true)[0] as TextBox;
            TextBox txtCustAddress = custUserControl.Controls.Find("txtCustAddress", true)[0] as TextBox;
            TextBox txtNote = custUserControl.Controls.Find("txtNote", true)[0] as TextBox;
            TextBox txtPhone = custUserControl.Controls.Find("txtPhone", true)[0] as TextBox;
            Label lbCustId = custUserControl.Controls.Find("lbCustId", true)[0] as Label;
            Label lbHeader = custUserControl.Controls.Find("lbHeader", true)[0] as Label;
            ComboBox comboBoxCustomerType = custUserControl.Controls.Find("comboBoxCustomerType", true)[0] as ComboBox;

            comboBoxCustomerType.DataSource = customerTypeTableAdapter.GetData();
            comboBoxCustomerType.DisplayMember = CUST_TYPE_NAME;
            comboBoxCustomerType.ValueMember = CUST_TYPE_ID;

            lbCustId.Text = custID;
            txtCustName.Text = custName;
            txtCustAddress.Text = custAddress;
            txtPhone.Text = custPhone;
            txtNote.Text = custNote;
            comboBoxCustomerType.SelectedValue = custData[0].CustTypeId;
            lbHeader.Text = string.Format("Sửa thông tin khách hàng").ToUpper();

            custEditForm.Controls.Add(custUserControl);
            custEditForm.Width = custUserControl.Width;
            custEditForm.Height = custUserControl.Height;
            custEditForm.Show();

            custEditForm.FormClosed += custEditForm_FormClosed;
        }

        private void viewCustomerTransactionHistory(object sender, EventArgs e)
        {
            DataGridViewRow row = grvCustomer.Rows[currentMouseOverRow];
            string custID = row.Cells[0].Value.ToString();
            JSManagementDataSet.CustomerDataTable custData = customerTableAdapter.GetDataByCustomerId(int.Parse(custID));

            if (custData.Rows.Count == 0) return;
            string custName = custData[0].CustomerName;
            string custAddress = custData[0].Address;
            string custPhone = custData[0].Telephone;
            string custNote = custData[0].Note;

            Form custEditForm = new Form();
            custEditForm.Text = "Sửa thông tin khách hàng";

            CustomerUserControl custUserControl = new CustomerUserControl();
            TextBox txtCustName = custUserControl.Controls.Find("txtCustName", true)[0] as TextBox;
            TextBox txtCustAddress = custUserControl.Controls.Find("txtCustAddress", true)[0] as TextBox;
            TextBox txtNote = custUserControl.Controls.Find("txtNote", true)[0] as TextBox;
            TextBox txtPhone = custUserControl.Controls.Find("txtPhone", true)[0] as TextBox;
            Label lbCustId = custUserControl.Controls.Find("lbCustId", true)[0] as Label;
            Label lbHeader = custUserControl.Controls.Find("lbHeader", true)[0] as Label;
            ComboBox comboBoxCustomerType = custUserControl.Controls.Find("comboBoxCustomerType", true)[0] as ComboBox;
            
            comboBoxCustomerType.DataSource = customerTypeTableAdapter.GetData();
            comboBoxCustomerType.DisplayMember = CUST_TYPE_NAME;
            comboBoxCustomerType.ValueMember = CUST_TYPE_ID;

            lbCustId.Text = custID;
            txtCustName.Text = custName;
            txtCustAddress.Text = custAddress;
            txtPhone.Text = custPhone;
            txtNote.Text = custNote;
            comboBoxCustomerType.SelectedValue = custData[0].CustTypeId;
            lbHeader.Text = string.Format("Sửa thông tin khách hàng").ToUpper();

            custEditForm.Controls.Add(custUserControl);
            custEditForm.Width = custUserControl.Width;
            custEditForm.Height = custUserControl.Height;
            custEditForm.Show();

            
        }

        void custEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindDataToEdit(new DataGridViewCellEventArgs(grvCustomer.CurrentCell.ColumnIndex, grvCustomer.CurrentCell.RowIndex));
        }

        private void grvCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                grvCustomer_CellDoubleClick(new object(), new DataGridViewCellEventArgs(grvCustomer.CurrentCell.ColumnIndex, grvCustomer.CurrentCell.RowIndex));
        }

        private void grvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex == grvCustomer.RowCount - 1)
                return;

            if (isOpenByReceivableFromCustomer)
            {
                GetCustomerInforToReceivableForm(e);
                return;
            }

            if (isOpenByPurchaseReceiptOrder)
            {
                GetCustomerInforToPurchaseReceiptOrderForm(e);
                return;
            }

            if (isOpenByPurchaseReceiptOrderFind)
            {
                GetCustomerInforToPurchaseReceiptOrderFormFind(e);
                return;
            }
            DataGridViewRow row = grvCustomer.Rows[e.RowIndex];
            string custID = row.Cells[0].Value.ToString();
            string custName = row.Cells[1].Value.ToString();
            string custAddress = row.Cells[2].Value.ToString();
            string custPhone = row.Cells[3].Value.ToString();
            string custNote = row.Cells[4].Value.ToString();
            FormCollection fc = Application.OpenForms;
            Form mainform = new Form();

            if (isOpenByCustomerSelectUserControl)
            {
                this.CustId = int.Parse(custID);
                this.Close();
            }

            if (isOpenBySupplierSelectUserControl)
            {
                this.CustId = int.Parse(custID);
                this.Close();
            }

            foreach (Form f in fc)
            {
                if (f.Name == "productOutputForm")
                {
                    mainform = f;
                }
                if (f.Name == "productInputForm")
                {
                    mainform = f;
                }
            }


            if (mainform.Controls.Count > 0)
            {
                //TextBox txtCustomerCode = mainform.Controls.Find("txtCustomerCode", true)[0] as TextBox;
                ////Label lbCustomerInfo = mainform.Controls.Find("lbCustomerInfo", true)[0] as Label;
                ////lbCustomerInfo.Text = string.Format("{0}, {1}, {2}", custName, custAddress, custPhone);
                //txtCustomerCode.Text = custID;
                this.Close();
            }
            else
            {
                //Form custEditForm = new Form();
                //custEditForm.Text = "Sửa thông tin khách hàng";

                //CustomerUserControl custUserControl = new CustomerUserControl();
                //TextBox txtCustName = custUserControl.Controls.Find("txtCustName", true)[0] as TextBox;
                //TextBox txtCustAddress = custUserControl.Controls.Find("txtCustAddress", true)[0] as TextBox;
                //TextBox txtNote = custUserControl.Controls.Find("txtNote", true)[0] as TextBox;
                //TextBox txtPhone = custUserControl.Controls.Find("txtPhone", true)[0] as TextBox;
                //Label lbCustId = custUserControl.Controls.Find("lbCustId", true)[0] as Label;
                //Label lbHeader = custUserControl.Controls.Find("lbHeader", true)[0] as Label;
                BindDataToEdit(e);


                //custEditForm.Controls.Add(custUserControl);
                //custEditForm.Width = custUserControl.Width;
                //custEditForm.Height = custUserControl.Height;
                //custEditForm.Show();
            }

            
        }

        private void cboxContact_CheckedChanged(object sender, EventArgs e)
        {
            btFindCust_Click(sender, e);
        }

        private void cboxHasNote_CheckedChanged(object sender, EventArgs e)
        {
            btFindCust_Click(sender, e);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (lbCustId.Text != "0") return;
            if (txtPhone.Text == string.Empty) return;

            bool isCustomerExisted =  CheckCustomerExisted(txtPhone.Text);
            if (isCustomerExisted)
            {
                MessageBox.Show(String.Format("Số điện thoại {0} đã đăng ký!",txtPhone.Text));
            }
        }

        private bool CheckCustomerExisted(string telephone)
        {
            telephone.Trim();
            telephone = telephone.Replace(" ",string.Empty);
            telephone = telephone.Replace(".",string.Empty);
            customerTableAdapter.ClearBeforeFill = true;
            JSManagementDataSet.CustomerDataTable custData = customerTableAdapter.CheckCustomerExsited(telephone);
            
            if (custData != null)
            {
                if (custData.Rows.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void txtCustIdFind_TextChanged(object sender, EventArgs e)
        {
            btFindCust_Click(sender, e);
        }                
    }
}
