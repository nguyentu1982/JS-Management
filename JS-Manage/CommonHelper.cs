using System;
using System.Collections.Generic;

using System.Text;
using JS_Manage.JSManagementDataSetTableAdapters;
using System.Data.SqlClient;
using System.Configuration;

namespace JS_Manage
{
    public static class CommonHelper
    {
        public static SqlConnection GetSQLConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["appConnectionString"].ConnectionString;
            SqlConnectionStringBuilder connStringBuilder = new SqlConnectionStringBuilder(connString);
            connStringBuilder.Add("Password", "niemvui");
            return new SqlConnection(connStringBuilder.ToString());
        }

        internal static bool Login(string userName, string password)
        {
            string encrypedpass = EncryptString(password);
            JSManagementDataSetTableAdapters.JS_UserTableAdapter userTalbeAdapter = new JSManagementDataSetTableAdapters.JS_UserTableAdapter();
            userTalbeAdapter.Connection = GetSQLConnection();
            JSManagementDataSet.JS_UserDataTable userData = userTalbeAdapter.GetUserByUserNamePassword(userName, encrypedpass);
            if (userData.Rows.Count == 1)
            {
                LoginInfor.UserName = userData[0].UserName;
                LoginInfor.Role = userData[0].Role;
                LoginInfor.IsSucess = true;
                return true;
            }
            return false;
        }

        private static string EncryptString(string password)
        {
            return password;
        }

        internal static List<string> GetActiveDates()
        {
            ActiveDateTableAdapter activeDateTableAdapter = new ActiveDateTableAdapter();
            activeDateTableAdapter.Connection = GetSQLConnection();
            JSManagementDataSet.ActiveDateDataTable activeDateData = activeDateTableAdapter.GetActiveDate();
            List<string> result = new List<string>();
            foreach (JSManagementDataSet.ActiveDateRow row in activeDateData.Rows)
            {
                result.Add(row.Date.ToShortDateString());
            }
            return result;
        }

        public static bool CheckCurrentDay(DateTime date)
        {
            if (!LoginInfor.IsAdmin && Setting.GetBoolSetting(Constant.Not_Allow_User_Edit_On_Other_CreatedDate))
            {
                if (DateTime.Now.ToShortDateString() != date.ToShortDateString())
                {                    
                    return false;
                }
            }

            return true;
        }
    }
    /// <summary>
    /// Nguồn: Asp.net.vn 
    /// Author:  thanhtungo@yahoo.com
    /// </summary>
    public static class VNCurrency
    {
        public static string ToString(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            str = str.TrimStart();
            string firstChar = str.Substring(0, 1).ToUpper();
            str = str.Substring(1, str.Length-1);
            str = firstChar + str;
            return str + "đồng chẵn";
        }

        public static string ToString(double number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            double decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDouble(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            string firstChar = str.Substring(0, 1).ToUpper();
            str = str.Substring(1, str.Length - 1);
            str = firstChar + str;
            return str + "đồng chẵn";
        }
    }
}
