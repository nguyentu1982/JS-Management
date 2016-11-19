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
    public partial class ProductTypeBrandSizeUserControl : UserControl
    {           
        private object _brandComboboxDataSource;
        private object _productComboboxDataSource;
        private object _sizeComboboxDataSource;
        
        private string _brand;
        private string _productType;
        private string _size;

        public ProductTypeBrandSizeUserControl()
        {
            InitializeComponent();         
            this.Load += new EventHandler(ProductTypeBrandSizeUserControl_Load);
            
        }

        void ProductTypeBrandSizeUserControl_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {           
           comboBoxBrandFind.DataSource = _brandComboboxDataSource;
           comboBoxProductTypeFind.DataSource = _productComboboxDataSource;
           comboBoxSizeFind.DataSource = _sizeComboboxDataSource;
        }               

        private void comboBoxProductTypeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            _productType = comboBoxProductTypeFind.Text;
        }

        private void comboBoxBrandFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            _brand = comboBoxBrandFind.Text;
        }

        private void comboBoxSizeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            _size = comboBoxSizeFind.Text;
        }

        public object BrandComboboxDataSource
        {
            get { return _brandComboboxDataSource; }
            set { _brandComboboxDataSource = value; }
        }
        public object ProductComboboxDataSource
        {
            get { return _productComboboxDataSource; }
            set { _productComboboxDataSource = value; }
        }
        public object SizeComboboxDataSource
        {
            get { return _sizeComboboxDataSource; }
            set { _sizeComboboxDataSource = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string ProductType
        {
            get { return _productType; }
            set { _productType = value; }
        }

        public string ProductSize
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}
