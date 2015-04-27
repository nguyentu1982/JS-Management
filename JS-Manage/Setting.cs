using System;
using System.Collections.Generic;
using System.Text;

namespace JS_Manage
{
    public static class Setting
    {
        private static JSManagementDataSetTableAdapters.SettingTableAdapter settingTableAdapter = new JSManagementDataSetTableAdapters.SettingTableAdapter();
        internal static bool GetBoolSetting(string p)
        {            
            settingTableAdapter.Connection = CommonHelper.GetSQLConnection();
            if (settingTableAdapter.GetSettingValueByName(p).Rows.Count == 0)
                return false;

            if (settingTableAdapter.GetSettingValueByName(p)[0].SettingValue.ToLower() == "true")
            {
                return true;
            }
            return false;
        }

        internal static int GetIntergerSetting(string str)
        {            
            settingTableAdapter.Connection = CommonHelper.GetSQLConnection();
            int result = 0;
            if (settingTableAdapter.GetSettingValueByName(str).Rows.Count > 0)
            {                
                if (int.TryParse(settingTableAdapter.GetSettingValueByName(str)[0].SettingValue, out result))
                {
                    return result;
                }
            }
            return result;
        }

        internal static string GetStringSetting(string str)
        {            
            settingTableAdapter.Connection = CommonHelper.GetSQLConnection();
            string result = string.Empty;
            if (settingTableAdapter.GetSettingValueByName(str).Rows.Count > 0)
            {
                return settingTableAdapter.GetSettingValueByName(str)[0].SettingValue;
            }
            return result;
        }

        internal static decimal GetDecimalSetting(string str)
        {
            settingTableAdapter.Connection = CommonHelper.GetSQLConnection();
            decimal result = 0;
            if (settingTableAdapter.GetSettingValueByName(str).Rows.Count > 0)
            {
                if (decimal.TryParse(settingTableAdapter.GetSettingValueByName(str)[0].SettingValue, out result))
                {
                    return result;
                }
            }
            return result;
        }
    }
}
