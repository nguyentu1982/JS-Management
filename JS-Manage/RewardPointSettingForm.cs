using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class RewardPointSettingForm : Form
    {
        JSManagementDataSetTableAdapters.SettingTableAdapter settingTableAdapter;

        private const string Reward_Point_Enable = "RewardPointEnable";
        private const string Reward_Point_Exchange_Rate = "RewardPointExchangeRate";
        private const string Reward_Point_For_Registration = "RewardPointForRegistration";
        private const string Reward_Point_For_Purchase_Each = "RewardPointForPurchaseEach";
        private const string Reward_Point_Earn = "RewardPointEarn";

        public RewardPointSettingForm()
        {
            InitializeComponent();
            settingTableAdapter = new JSManagementDataSetTableAdapters.SettingTableAdapter();
            settingTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            using (TransactionScope tran = new TransactionScope())
            {
                settingTableAdapter.UpdateSettingValueBySettingName(checkBoxRewardPointEnable.Checked.ToString(), Reward_Point_Enable);
                settingTableAdapter.UpdateSettingValueBySettingName(textBoxExchangeRate.Text,  Reward_Point_Exchange_Rate);
                settingTableAdapter.UpdateSettingValueBySettingName(textBoxRegistrationRewardPoint.Text, Reward_Point_For_Registration);
                settingTableAdapter.UpdateSettingValueBySettingName(textBoxPurchaseEach.Text, Reward_Point_For_Purchase_Each);
                settingTableAdapter.UpdateSettingValueBySettingName(textBoxRewardPointEarn.Text, Reward_Point_Earn);
                tran.Complete();
            }
        }

        private bool ValidateData()
        {
            if (!checkBoxRewardPointEnable.Checked)
                return true;

            decimal decimalVal;
            if (!decimal.TryParse(textBoxExchangeRate.Text.Trim(), out decimalVal))
            {                
                MessageBox.Show("Tỷ lệ chuyển đổi của 1 điểm thưởng không phù hợp");
                textBoxExchangeRate.Focus();
                return false;
            }            

            int intVal;
            if (!int.TryParse(textBoxRegistrationRewardPoint.Text.Trim(), out intVal))
            {
                MessageBox.Show("");
                textBoxRegistrationRewardPoint.Focus();
                return false;
            }

            if (!decimal.TryParse(textBoxPurchaseEach.Text.Trim(), out decimalVal))
            {
                MessageBox.Show("");
                textBoxPurchaseEach.Focus();
                return false;
            }

            if (!int.TryParse(textBoxRewardPointEarn.Text.Trim(), out intVal))
            {
                MessageBox.Show("");
                textBoxRewardPointEarn.Focus();
                return false;
            }

            return true;
        }

        private void RewardPointSettingForm_Load(object sender, EventArgs e)
        {
            bool isRewardPointEnable ;
            bool.TryParse( settingTableAdapter.GetSettingValueByName(Reward_Point_Enable)[0].SettingValue, out isRewardPointEnable);
            decimal rewardPointExchangeRate;
            decimal.TryParse(settingTableAdapter.GetSettingValueByName(Reward_Point_Exchange_Rate)[0].SettingValue, out rewardPointExchangeRate);
            int rewardPointForRegistration;
            int.TryParse(settingTableAdapter.GetSettingValueByName(Reward_Point_For_Registration)[0].SettingValue, out rewardPointForRegistration);
            decimal rewardPointForPurchaseEach;
            decimal.TryParse(settingTableAdapter.GetSettingValueByName(Reward_Point_For_Purchase_Each)[0].SettingValue, out rewardPointForPurchaseEach);
            int rewardPointEarn;
            int.TryParse(settingTableAdapter.GetSettingValueByName(Reward_Point_Earn)[0].SettingValue, out rewardPointEarn);

            checkBoxRewardPointEnable.Checked = isRewardPointEnable;
            textBoxExchangeRate.Text = rewardPointExchangeRate.ToString();
            textBoxRegistrationRewardPoint.Text = rewardPointForRegistration.ToString();
            textBoxPurchaseEach.Text = rewardPointForPurchaseEach.ToString();
            textBoxRewardPointEarn.Text = rewardPointEarn.ToString();
        }        
    }
}
