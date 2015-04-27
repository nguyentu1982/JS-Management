using System;
using System.Collections.Generic;
using System.Text;


namespace JS_Manage
{
    public static class LoginInfor
    {
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
        public static bool IsActive { get; set; }
        public static bool IsSucess { get; set; }
        public static bool IsAdmin
        {
            get
            {
                return Role.ToLower() == "Admin".ToLower() ? true : false; 
            }
        }

    }
}
