using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace JS_Manage
{
    public partial class CustomerRewardPointsHistoryUserControl : UserControl
    {
        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;
        JSManagementDataSetTableAdapters.RewardPointsHistoryByCustomerIdTableAdapter rewardPointsByCustIdTableAdapter;
        JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter rewardPointHistoryTableAdapter;
        int currentMouseOverRow;
        public const string Reward_Points_History_ID = "RewardPointsHistoryID";

        public CustomerRewardPointsHistoryUserControl()
        {
            InitializeComponent();
            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();

            rewardPointsByCustIdTableAdapter = new JSManagementDataSetTableAdapters.RewardPointsHistoryByCustomerIdTableAdapter();
            rewardPointsByCustIdTableAdapter.Connection = CommonHelper.GetSQLConnection();

            rewardPointHistoryTableAdapter = new JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter();
            rewardPointHistoryTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCustId.Text == "0")
                {
                    lbHeader.Text = string.Format("Thêm khách hàng mới").ToUpper();
                    DialogResult result = MessageBox.Show("Bạn có muốn thêm khách hàng mới?", "Thêm khách hàng mới", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        //custTableAdapter.Insert(txtCustName.Text, txtCustAddress.Text, txtPhone.Text, txtNote.Text);
                       // MessageBox.Show("Thêm khách hàng mới thành công");
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin?", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {                        
                        //custTableAdapter.UpdateCustomerById(txtCustName.Text, txtCustAddress.Text, txtPhone.Text, txtNote.Text , int.Parse(lbCustId.Text));
                        //MessageBox.Show("Sửa thông tin khách hàng thành công");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Kiểm tra dữ liệu nhập!");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn XÓA thông tin?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {                
                custTableAdapter.DeleteCustomerById(int.Parse( lbCustId.Text));
                MessageBox.Show("Xóa thông tin khách hàng thành công!");
            }
        }

        private void ReloadCustomer()
        {
            FormCollection fc = Application.OpenForms;
            Form mainform = new Form();
            foreach (Form f in fc)
            {
                if (f.Name == "CustomerForm")
                {
                    mainform = f;
                }
            }           
            
        }

        private void lbCustId_TextChanged(object sender, EventArgs e)
        {
            int custId;
            if(int.TryParse(lbCustId.Text, out custId))
            {                
                dataGridView1.DataSource = rewardPointsByCustIdTableAdapter.GetRewardPointsHistoryByCustomerId(custId);
                
            }
            
        }

        private const string REWARD_POINT_HISTORY_ID_COLUMN_NAME = "RewardPointsHistoryID";
        private const string POINTS_COLUMN_NAME = "Points";
        private const string POINTS_BALANCE_COLUMN_NAME = "PointsBalance";
        private const string USED_AMOUNT_COLUMN_NAME = "UsedAmount";

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult message = MessageBox.Show("Bạn có chắc chắn sửa điểm tích lũy?", "Sửa điểm tích lũy", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (message == DialogResult.Cancel) return;            

            if (e.RowIndex == -1)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row.Cells[REWARD_POINT_HISTORY_ID_COLUMN_NAME].Value.ToString() == "-1")
            { 
                //Insert Reward point
                return;
            }

            int rewardPointHistoryId = int.Parse(row.Cells[REWARD_POINT_HISTORY_ID_COLUMN_NAME].Value.ToString());
            int point = int.Parse(row.Cells[POINTS_COLUMN_NAME].Value.ToString());
            int pointBalance = int.Parse(row.Cells[POINTS_BALANCE_COLUMN_NAME].Value.ToString());
            decimal usedAmount = decimal.Parse(row.Cells[USED_AMOUNT_COLUMN_NAME].Value.ToString()); 

            JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter rewardPointHistoryTableAdapter = new JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter();
            rewardPointHistoryTableAdapter.Connection = CommonHelper.GetSQLConnection();
            rewardPointHistoryTableAdapter.UpdateRewardPointsInfoById(point, pointBalance, usedAmount, rewardPointHistoryId);

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                ContextMenu m = new ContextMenu();                
                m.MenuItems.Add(new MenuItem("Xóa điểm tích lũy", new EventHandler(DeleteCustomerRewardPointsHistory)));
                if (currentMouseOverRow >= 0)
                {
                    m.Show(dataGridView1, new Point(e.X, e.Y));
                }

            }
        }

        private void DeleteCustomerRewardPointsHistory(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[currentMouseOverRow];
            if (row.IsNewRow) return;

            if (row.Cells[Reward_Points_History_ID].Value == null) return;

            DialogResult message = MessageBox.Show("Bạn có chắc chắn xóa điểm tích lũy?", "Xóa điểm tích lũy", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (message == DialogResult.Cancel) return;            

            int rewardPointHistoryId = int.Parse(row.Cells[Reward_Points_History_ID].Value.ToString());

            if (rewardPointHistoryTableAdapter.DeleteRewardPointHistoryById(rewardPointHistoryId) > 0)
            {
                MessageBox.Show("Xóa điểm tích lũy thành công");
                lbCustId_TextChanged(new object(), new EventArgs());
            }
        }       
    }
}
