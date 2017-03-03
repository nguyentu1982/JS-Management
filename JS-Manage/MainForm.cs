using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JS_Manage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!LoginInfor.IsSucess)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();

            }
            if (LoginInfor.IsSucess)
            {
                btOperationResult.Visible = LoginInfor.IsAdmin;
                btManageCash.Visible = LoginInfor.IsAdmin;
                JSManagementDataSetTableAdapters.StoreTableAdapter storeTableAdapter = new JSManagementDataSetTableAdapters.StoreTableAdapter();
                storeTableAdapter.Connection = CommonHelper.GetSQLConnection();
                JSManagementDataSet.StoreDataTable storeData = storeTableAdapter.GetDataByStoreIds(LoginInfor.StoreId);

                lbUserName.Text = string.Format("Đăng nhập: {0} {1} Kho hàng: {2}", LoginInfor.UserName, Environment.NewLine ,storeData.Rows[0][1].ToString()); 
            }
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btProductSearch_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                ProductSearchForm prodForm = new ProductSearchForm();                
                prodForm.StartPosition = FormStartPosition.CenterParent;
                prodForm.Show();                
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.ShowDialog();
            }
        }

        private void btLiabilities_Click(object sender, EventArgs e)
        {
            
            if (LoginInfor.IsSucess)
            {
                if (LoginInfor.IsAdmin)
                {
                    LiabilitiesForm liabilitiesForm = new LiabilitiesForm();                                       
                    liabilitiesForm.StartPosition = FormStartPosition.CenterScreen;
                    liabilitiesForm.Show(); 
                }
                else
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.ShowDialog();
                }
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                CustomerForm custForm = new CustomerForm();
                custForm.isAdmin = (LoginInfor.Role == "Admin" ? true : false);
                custForm.StartPosition = FormStartPosition.CenterParent;
                custForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.ShowDialog();
            }
           
           
        }

        private void btProductInput_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                productInputForm proInputForm = new productInputForm();
                proInputForm.isAdmin = (LoginInfor.Role == "Admin" ? true : false);
                proInputForm.StartPosition = FormStartPosition.CenterParent;
                proInputForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterParent;
                loginForm.ShowDialog();
            }           
           
        }  

        private void btCosts_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsAdmin)
            {
                CostsForm costForm = new CostsForm();
                costForm.StartPosition = FormStartPosition.CenterScreen;
                costForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
        }

        private void btAdminTask_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                if (LoginInfor.IsAdmin)
                {
                    AdminTaskForm adminTaskForm = new AdminTaskForm();
                    adminTaskForm.StartPosition = FormStartPosition.CenterScreen;
                    adminTaskForm.Show();
                }
                else
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.ShowDialog();
                }
            }
            else
            { 
                 LoginForm loginForm = new LoginForm();
                 loginForm.StartPosition = FormStartPosition.CenterScreen;
                 loginForm.ShowDialog();            
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                ProductReportForm proReport = new ProductReportForm();
                proReport.StartPosition = FormStartPosition.CenterScreen;
                proReport.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
        }

        private void btOperationResult_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                if (LoginInfor.IsAdmin)
                {
                    OperatingResultsForm operResult = new OperatingResultsForm();
                    operResult.StartPosition = FormStartPosition.CenterScreen;
                    operResult.Show();
                }
                else
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.ShowDialog();
                }
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }           
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            btOperationResult.Visible = false;
            btManageCash.Visible = false;
            LoginInfor.IsSucess = false;
            lbUserName.Text = string.Empty;
            LoginInfor.IsActive = false;            
            LoginInfor.Password = string.Empty;
            LoginInfor.Role = string.Empty;            
            
        }

        private void btIncome_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsAdmin)
            {
                IncomeForm incomeForm = new IncomeForm();
                incomeForm.StartPosition = FormStartPosition.CenterScreen;
                incomeForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
        }

        private void btRecievableFromCustomer_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                ReceivableFromCustomersForm receiveableForm = new ReceivableFromCustomersForm();
                receiveableForm.StartPosition = FormStartPosition.CenterScreen;
                receiveableForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
        }

        private void btPurchaseReceiptOrder_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                PurchaseReceiptOrderForm purchaseReceipOrderForm = new PurchaseReceiptOrderForm();
                purchaseReceipOrderForm.StartPosition = FormStartPosition.CenterScreen;
                purchaseReceipOrderForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
            
        }

        private void btManageCash_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                if (LoginInfor.IsAdmin)
                {
                    CashManagementForm cashManagementForm = new CashManagementForm();
                    cashManagementForm.StartPosition = FormStartPosition.CenterScreen;
                    
                    cashManagementForm.Show();
                }
                else
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.ShowDialog();
                }
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void btProductChecking_Click(object sender, EventArgs e)
        {
            ////MessageBox.Show("Chức năng này đang phát triển");
            ////return;
            ////ProductCheckingForm proCheck = new ProductCheckingForm();
            //proCheck.StartPosition = FormStartPosition.CenterScreen;
            //proCheck.Show();
        }

        private void btBankAccountManagement_Click(object sender, EventArgs e)
        {
            if (LoginInfor.IsSucess)
            {
                if (LoginInfor.IsAdmin)
                {
                    BankAccountManagementForm bankAccountForm = new BankAccountManagementForm();
                    bankAccountForm.StartPosition = FormStartPosition.CenterScreen;
                    bankAccountForm.Show();
                }
                else
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.StartPosition = FormStartPosition.CenterScreen;
                    loginForm.ShowDialog();
                }
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.ShowDialog();
            }
        }
    }
}
