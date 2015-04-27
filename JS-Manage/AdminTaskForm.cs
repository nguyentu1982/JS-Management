using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class AdminTaskForm : Form
    {
        public AdminTaskForm()
        {
            InitializeComponent();
        }

        private void btActiveDate_Click(object sender, EventArgs e)
        {
            if (!LoginInfor.IsAdmin)
            {
                return;
            }

            ActiveDateForm activeDateForm = new ActiveDateForm();
            activeDateForm.StartPosition = FormStartPosition.CenterScreen;
            activeDateForm.Show();
        }

        private void btOpeningBalance_Click(object sender, EventArgs e)
        {
            if (!LoginInfor.IsAdmin)
            {
                return;
            }

            OpeningBalanceForm openingBalanceForm = new OpeningBalanceForm();
            openingBalanceForm.StartPosition = FormStartPosition.CenterScreen;
            openingBalanceForm.Show();
        }

        private void AdminTaskForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void btRewardPoint_Click(object sender, EventArgs e)
        {
            RewardPointSettingForm rewardPointSettingForm = new RewardPointSettingForm();
            rewardPointSettingForm.StartPosition = FormStartPosition.CenterScreen;
            rewardPointSettingForm.Show();
        }
    }
}
