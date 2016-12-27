using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace JS_Manage
{
    public partial class UCTextBoxCurrency : UserControl
    {
        public CultureInfo cul;
        public UCTextBoxCurrency()
        {
            InitializeComponent();
        }

        public decimal Value
        {
            get
            {
                decimal result = 0;
                result =decimal.Parse(textBox1.Text);
                return result;
            }

            set
            {
                if(cul == null)
                {
                    cul = CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);
                }
                textBox1.Text = value.ToString();
            }

        }

        public Label TextLabel
        {
            get { return label1; }
            set { label1 = value; }
        }

        public bool isTextBox1Null
        {
            get;
            set;
        }

        public bool IsTextBox1Enable
        {
            get { return textBox1.Enabled; }
            set { textBox1.Enabled = value; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                isTextBox1Null = true;
                if (this.TextBox_TextChanged != null)
                    this.TextBox_TextChanged(this, e);
                return;
            }
            else
            {
                isTextBox1Null = false;
            }
            decimal amount = decimal.Parse(textBox1.Text);
            label1.Text = VNCurrency.ToString(amount);

            if (this.TextBox_TextChanged != null)
                this.TextBox_TextChanged(this, e);
        }

        public event EventHandler TextBox_TextChanged;
    }

    
}
