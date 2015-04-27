using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JS_Manage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                FormCollection fc = Application.OpenForms;
                Form mainform = new Form();
                foreach (Form f in fc)
                {
                    if (f.Name == "MainForm")
                    {
                        mainform = f;
                    }                    
                }
                if (mainform.Controls.Count > 1)
                {                    
                    Label lbUserName = mainform.Controls.Find("lbUserName", true)[0] as Label;                    
                    lbUserName.Text = LoginInfor.UserName;                    
                    mainform.Controls.Find("btOperationResult", true)[0].Visible = LoginInfor.IsAdmin;
                    mainform.Controls.Find("btManageCash", true)[0].Visible = LoginInfor.IsAdmin;
                    
                }
                Close();
            }
        }

        private bool Login()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            return CommonHelper.Login(userName, password);            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btLogin_Click(new object(), new EventArgs());
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
