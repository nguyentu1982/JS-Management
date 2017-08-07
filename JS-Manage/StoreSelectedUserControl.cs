using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class StoreSelectedUserControl : UserControl
    {
        public int StoreId
        {
            get
            {
                if(cboxStore.SelectedValue != null)
                    return int.Parse(cboxStore.SelectedValue.ToString());
                return 0;
            }
            set
            {
                cboxStore.SelectedValue = value;
            }
        }

        public string StoreName
        {
            get
            {
                return cboxStore.GetItemText(cboxStore.SelectedItem);
            }
        }

        public object StoreDataSource
        {
            set { cboxStore.DataSource = value; }
        }

        public string  StoreDisplayMember
        {
            set { cboxStore.DisplayMember = value; }
        }

        public string StoreValueMember
        {
            set { cboxStore.ValueMember = value; }
        }
        public string LabelStoreInOrOut
        {
            set
            {
                labelInOrOut.Text = value;
            }
        }

        public StoreSelectedUserControl()
        {
            InitializeComponent();
            cboxStore.DisplayMember = Constant.Store.DISPLAY_MEMBER;
            cboxStore.ValueMember = Constant.Store.VALUE_MEMBER;
        }
    }
}
