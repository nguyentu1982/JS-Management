using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class OpeningBalanceForm : Form
    {
        JSManagementDataSetTableAdapters.OpeningBalanceTableAdapter openingBalanceTableAdapter;

        int currentMouseOverRow;
        bool isLoad;
        bool isrowEdited;
        public OpeningBalanceForm()
        {
            InitializeComponent();

            openingBalanceTableAdapter = new JSManagementDataSetTableAdapters.OpeningBalanceTableAdapter();
            openingBalanceTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void OpeningBalanceForm_Load(object sender, EventArgs e)
        {
            if (!LoginInfor.IsAdmin) return;
            isLoad = true;
            grvOpeningBalance.DataSource = openingBalanceTableAdapter.GetData();
            isLoad = false;
        }

        private void grvOpeningBalance_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = grvOpeningBalance.HitTest(e.X, e.Y).RowIndex;
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete", new EventHandler(grvOpeningBalance_DeleteRow)));

                if (currentMouseOverRow >= 0)
                {

                }

                m.Show(grvOpeningBalance, new Point(e.X, e.Y));

            }
        }

        private void grvOpeningBalance_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (isLoad) return;

            if (!isrowEdited) return;

            DataGridViewRow row = grvOpeningBalance.Rows[e.RowIndex];
            int openingBalanceId = 0;
            bool isEdit = false;
            int.TryParse(row.Cells[0].Value.ToString(), out openingBalanceId);

            if (openingBalanceId > 0) isEdit = true;

            switch (isEdit)
            {
                case false:
                    InsertOpeningBalance(row);
                    break;
                case true:
                    UpdateOpeningBalance(row);
                    break;

            }

            isrowEdited = false;
        }       

        private void grvOpeningBalance_DeleteRow(object sender, EventArgs e)
        {
            DataGridViewRow row = grvOpeningBalance.Rows[currentMouseOverRow];
            if (row.Cells[0].Value == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Xóa số dư đầu kỳ có thể làm sai số liệu! Bạn có tiếp tục?", "Xóa số dư đầu kỳ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Cancel) return;
            
            DeleteOpeningBalance(row);
        } 

        #region CRUD

        private void InsertOpeningBalance(DataGridViewRow row)
        {
            if (!ValidateData(row))
            {
                return;
            }

            DateTime openingDate;
            decimal receiveable;
            decimal cash;
            decimal bankAcount;
            int openingBalanceId;

            DateTime.TryParse( row.Cells["OpeningDate"].Value.ToString(), out openingDate);
            decimal.TryParse(row.Cells["Receiveable"].Value.ToString(), out receiveable);
            decimal.TryParse(row.Cells["Cash"].Value.ToString(), out cash);
            decimal.TryParse(row.Cells["BankAcount"].Value.ToString(), out bankAcount);

            object openingBalance = openingBalanceTableAdapter.InsertReturnId(openingDate.ToString(), receiveable, cash, bankAcount, LoginInfor.UserName, DateTime.Now.ToString(), LoginInfor.UserName, DateTime.Now.ToString());
            int.TryParse(openingBalance.ToString(), out openingBalanceId);
            if ( openingBalance != null)
            {
                if (openingBalanceId>0)
                {                   
                    MessageBox.Show("Thêm số dư đầu kỳ thành công!");
                    this.BeginInvoke(new MethodInvoker(grvOpeningBalance_Refresh));
                }
            }
        }

        private void UpdateOpeningBalance(DataGridViewRow row)
        {
            DialogResult result = MessageBox.Show("Sửa số dư đầu kỳ có thể làm sai số liệu! Bạn có tiếp tục?", "Sửa số dư đầu kỳ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Cancel) return;
            if (!ValidateData(row))
            {
                return;
            }

            int openingBalanceId;
            DateTime openingDate;
            decimal receiveable;
            decimal cash;
            decimal bankAcount;

            int.TryParse(row.Cells["OpeningBalanceId"].Value.ToString(), out openingBalanceId);
            DateTime.TryParse(row.Cells["OpeningDate"].Value.ToString(), out openingDate);
            decimal.TryParse(row.Cells["Receiveable"].Value.ToString(), out receiveable);
            decimal.TryParse(row.Cells["Cash"].Value.ToString(), out cash);
            decimal.TryParse(row.Cells["BankAcount"].Value.ToString(), out bankAcount);

            if (openingBalanceTableAdapter.UpdateById(openingDate.ToString(), receiveable, cash, bankAcount, LoginInfor.UserName, DateTime.Now.ToString(), openingBalanceId) > 0)
            {
                MessageBox.Show("Sửa số dư đầu kỳ thành công!");
                this.BeginInvoke(new MethodInvoker(grvOpeningBalance_Refresh));
            }
            
        }

        private void DeleteOpeningBalance(DataGridViewRow row)
        {            
            if (openingBalanceTableAdapter.DeleteById(int.Parse(row.Cells[0].Value.ToString())) > 0)
            {
                grvOpeningBalance.DataSource = openingBalanceTableAdapter.GetData();
                MessageBox.Show("Xóa số dư đầu kỳ thành công");
            }
        }

        #endregion CRUD

        private bool ValidateData(DataGridViewRow row)
        {
            DateTime openingDate;
            decimal receiveable;
            decimal cash;
            decimal bankAcount;
            const string NEED_DATE = "Hãy nhập ngày đầu kỳ!";
            const string NEED_RECEIVABLE = "Số dư đầu kỳ nợ phải thu không hợp lệ!";
            const string NEED_CASH = "Số dư đầu kỳ của tiền mặt không hợp lệ!";
            const string NEED_BANK_ACOUNT = "Số dư đầu kỳ của tiền gửi ngân hàng không hợp lệ!";
            if (row.Cells["OpeningDate"].Value == null)
            {
                MessageBox.Show(NEED_DATE);
                return false;
            }

            if (!DateTime.TryParse( row.Cells["OpeningDate"].Value.ToString(), out openingDate))
            {
                MessageBox.Show(NEED_DATE);
                return false;
            }

            if (row.Cells["Receiveable"].Value == null)
            {
                MessageBox.Show(NEED_RECEIVABLE);
                return false;
            }

            if (!decimal.TryParse(row.Cells["Receiveable"].Value.ToString(), out receiveable))
            {
                MessageBox.Show(NEED_RECEIVABLE);
                return false;
            }

            if (row.Cells["Cash"].Value == null)
            {
                MessageBox.Show(NEED_CASH);
                return false;
            }

            if (!decimal.TryParse(row.Cells["Cash"].Value.ToString(), out cash))
            {
                MessageBox.Show(NEED_CASH);
                return false;
            }

            if (row.Cells["BankAcount"].Value == null)
            {
                MessageBox.Show(NEED_BANK_ACOUNT);
                return false;
            }

            if (!decimal.TryParse(row.Cells["BankAcount"].Value.ToString(), out bankAcount))
            {
                MessageBox.Show(NEED_BANK_ACOUNT);
                return false;
            }

            return true;
        }       

        private void grvOpeningBalance_Refresh()
        {
            grvOpeningBalance.DataSource = openingBalanceTableAdapter.GetData();
        }

        private void grvOpeningBalance_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void grvOpeningBalance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isrowEdited = true;
        }

        private void grvOpeningBalance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = Color.Aquamarine;
        }

        private void OpeningBalanceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }           
    }
}
