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
    public partial class ProductAddForm : Form
    {
        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        JSManagementDataSetTableAdapters.ProdTableAdapter prodTableAdapter;
        public ProductAddForm()
        {
            InitializeComponent();
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();
            prodTableAdapter = new JSManagementDataSetTableAdapters.ProdTableAdapter();
            prodTableAdapter.Connection = CommonHelper.GetSQLConnection();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }

            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            decimal inputPrice = decimal.Parse(txtInputPrice.Text);
            decimal price = decimal.Parse(txtPrice.Text);
            decimal price2 = 0;
            decimal.TryParse(txtPrice2.Text, out price2);
            decimal price3 = 0;
            decimal.TryParse(txtPrice3.Text, out price3);
            decimal price4 = 0;
            decimal.TryParse(txtPrice4.Text, out price4);
            string note = txtNote.Text;
            int prodId=0;

            using (TransactionScope tran = new TransactionScope())
            {
                int.TryParse(prodTableAdapter.InsertProdReturnId(productCode, brand, inputPrice, price, price2, price3, price4, productType, note).ToString(), out prodId);
                if(prodId != 0)
                {
                    foreach (object item in chkListBoxSize.CheckedItems)
                    {
                        productTableAdapter.InsertProductReturnId(item.ToString(), price, inputPrice, price2, price3, price4, prodId);
                    }
                }                

                tran.Complete();
            }

            DialogResult result = MessageBox.Show("Tạo mã hàng thành công, bạn có muốn tạo mã hàng mới?", "Tạo mã hàng thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ClearData();
            }
            else
            {
                this.Close();
            }
        }

        private void ClearData()
        {            
            txtProductCode.Text = string.Empty;
            cbBoxProductType.Text = string.Empty;
            cbBoxBrand.Text = string.Empty;           
            txtInputPrice.Text = "0";
            txtPrice.Text = string.Empty;
            txtPrice2.Text = string.Empty;
            txtPrice3.Text = string.Empty;
            txtPrice4.Text = string.Empty;
            txtNote.Text = string.Empty;
            foreach (int i in chkListBoxSize.CheckedIndices)
            {
                chkListBoxSize.SetItemCheckState(i, CheckState.Unchecked);
            }
            txtProductCode.Focus();
        }

        private bool ValidateData()
        {
            decimal inputPrice = 0;
            decimal price = 0;
            string productCode = txtProductCode.Text;
            string productType = cbBoxProductType.Text;
            string brand = cbBoxBrand.Text;
            bool isProductExisted=false;

            if (string.IsNullOrEmpty(txtProductCode.Text) || string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("Bạn hãy nhập mã hàng!");
                return false;
            }

            if (string.IsNullOrEmpty(cbBoxProductType.Text) || string.IsNullOrWhiteSpace(cbBoxProductType.Text))
            {
                MessageBox.Show("Bạn hãy nhập loại hàng!");
                return false;
            }


            if (string.IsNullOrEmpty(cbBoxBrand.Text) || string.IsNullOrWhiteSpace(cbBoxBrand.Text))
            {
                MessageBox.Show("Bạn hãy nhập nhãn hiệu!");
                return false;
            }

            if (chkListBoxSize.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn hãy nhập size!");
                return false;
            }

            
            if (!decimal.TryParse(txtInputPrice.Text, out inputPrice))
            {
                MessageBox.Show("Giá nhập không hợp lệ");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Giá bán không hợp lệ");
                return false;
            }

            foreach (object item in chkListBoxSize.CheckedItems)
            {
                if (productTableAdapter.GetProductByCodeBrandSizeType(productCode, brand, item.ToString(), productType).Rows.Count > 0)
                {
                    MessageBox.Show(string.Format("Mã hàng: {0}, Loại hàng: {1}, Nhãn hiệu: {2}, Size: {3} đã tồn tại, bạn hãy tạo mã khác!", productCode, productType, brand, item.ToString()));
                    isProductExisted = true;
                }
            }

            if (isProductExisted)
            {
                return false;
            }

            return true;
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }

        private void LoadDefaultData()
        {
            JSManagementDataSetTableAdapters.BrandTableAdapter brandTableAdapter = new JSManagementDataSetTableAdapters.BrandTableAdapter();
            brandTableAdapter.Connection = CommonHelper.GetSQLConnection();
            JSManagementDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter = new JSManagementDataSetTableAdapters.ProductTypeTableAdapter();
            productTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();            

            cbBoxBrand.DataSource = brandTableAdapter.GetDistinctBrand();

            cbBoxProductType.DataSource = productTypeTableAdapter.GetDistinctProductType();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox picture;
            Image img;
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            int x = 0 ;
            Point p;
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                 foreach(string s in open.FileNames)
                 {
                     picture = new PictureBox();
                     picture.Image = null;
                     img = Image.FromFile(s);
                     float width = img.Width;
                     float height = img.Height;
                     float ratio = width/height;
                     if(ratio >1)
                     {
                         picture.Image = img.GetThumbnailImage(Convert.ToInt32(100*ratio), 100, () => false, IntPtr.Zero);
                         picture.Height = 100;
                         picture.Width = Convert.ToInt32(100 * ratio);
                        
                     }
                     else
                     {
                         picture.Image = img.GetThumbnailImage(100, Convert.ToInt32(100*ratio), () => false, IntPtr.Zero);
                         picture.Width = 100;
                         picture.Height = Convert.ToInt32(100 * ratio);                         
                     }                        
                     
                     panelPictures.Controls.Add(picture);
                     p = new Point();
                     p.X = x;
                     picture.Location = p;
                     x += picture.Width;   
                     picture.Click +=picture_Click(s);
                 }
                
            }
            
            
            
        }

        private EventHandler picture_Click(string s)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
