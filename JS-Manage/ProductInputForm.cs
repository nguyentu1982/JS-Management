using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;
using System.Transactions;
using System.Globalization;


namespace JS_Manage
{
    public partial class productInputForm : Form
    {
        JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        JSManagementDataSetTableAdapters.ProductInputTableAdapter productInputTableAdapter;
        JSManagementDataSetTableAdapters.ProductInput_ProductTableAdapter productInputProductTableAdapter;
        JSManagementDataSetTableAdapters.ProductInputSumaryTableAdapter productInputSumaryTableAdapter;
        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;
        JSManagementDataSetTableAdapters.ProductInputOrderTableAdapter productInputOrderTableAdapter;
        JSManagementDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        JSManagementDataSetTableAdapters.CostTableAdapter costTableAdapter;
        JSManagementDataSetTableAdapters.CostTypeTableAdapter costTypeTableAdapter;
        JSManagementDataSetTableAdapters.StoreTableAdapter storeTableAdapter;
        CultureInfo cul = CultureInfo.GetCultureInfo(Constant.VN_CULTURE_FORMAT);

        public bool isAdmin = false;
        int rowIndex=0;
        int currentMouseOverRow = 0;



        public productInputForm()
        {
            InitializeComponent();
            productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();
            productInputTableAdapter = new JSManagementDataSetTableAdapters.ProductInputTableAdapter();
            productInputTableAdapter.Connection = CommonHelper.GetSQLConnection();
            productInputProductTableAdapter = new JSManagementDataSetTableAdapters.ProductInput_ProductTableAdapter();
            productInputProductTableAdapter.Connection = CommonHelper.GetSQLConnection();
            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();
            productInputOrderTableAdapter = new JSManagementDataSetTableAdapters.ProductInputOrderTableAdapter();
            productInputOrderTableAdapter.Connection = CommonHelper.GetSQLConnection();
            bankAccountTableAdapter = new JSManagementDataSetTableAdapters.BankAccountTableAdapter();
            bankAccountTableAdapter.Connection = CommonHelper.GetSQLConnection();
            costTableAdapter = new JSManagementDataSetTableAdapters.CostTableAdapter();
            costTableAdapter.Connection = CommonHelper.GetSQLConnection();
            costTypeTableAdapter = new JSManagementDataSetTableAdapters.CostTypeTableAdapter();
            costTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            productInputSumaryTableAdapter = new JSManagementDataSetTableAdapters.ProductInputSumaryTableAdapter();
            productInputSumaryTableAdapter.Connection = CommonHelper.GetSQLConnection();

            storeTableAdapter = new JSManagementDataSetTableAdapters.StoreTableAdapter();
            storeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            // the Event of 'PrintPage'
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler
                        (prnDocument_PrintPage);
        }

        #region Event Handler

        private void ProductInputForm_Load(object sender, EventArgs e)
        {            
            lbInputHeader.Text = "Nhập hàng".ToUpper();
            dateTimePickerProductInput_ValueChanged(new object(), new EventArgs());
            dateTimePickerProductInput.Focus();
            cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.CASH;
            cboxStore.DataSource = storeTableAdapter.GetData();
            cboxStore.DisplayMember = Constant.Store.DISPLAY_MEMBER;
            cboxStore.ValueMember = Constant.Store.VALUE_MEMBER;
            cboxStore.SelectedValue = LoginInfor.StoreId;
            cboxStore.Enabled = LoginInfor.IsAdmin;
            if (this.ProductInputOrderId != 0)
            {
                BindDataToEdit(ProductInputOrderId);
                return;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {               
                if (!ValidateInputData())
                {
                    return;
                }

                string inputDate = dateTimePickerProductInput.Text;
                string supplierId = txtCustomerCode.Text;
                DialogResult result;
                if (lbProductInputOrderId.Text == "0")
                {
                    if (!CheckActiveDate(dateTimePickerProductInput.Value)) return;

                    result = MessageBox.Show("Bạn có chắc chắn tạo phiếu nhập hàng?", "Tạo phiếu nhập hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Cancel) return;

                    InsertProductInput();
                }
                else
                {
                    var productInputOrder = productInputOrderTableAdapter.GetById(int.Parse(lbProductInputOrderId.Text));

                    if (!CommonHelper.CheckCurrentDay(productInputOrder[0].CreatedDate))
                    {
                        MessageBox.Show("Bạn không thể sửa phiếu nhập hàng, hãy liên hệ với Admin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }

                    if (productInputOrder[0] == null)
                    {
                        MessageBox.Show("Phiếu nhập hàng không tồn tại");
                        return;
                    }

                    if (!CheckActiveDate(productInputOrder[0].InputDate)) return;

                    result = MessageBox.Show("Bạn có chắc chắn sửa phiếu nhập hàng?", "Sửa phiếu nhập hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Cancel) return;

                    UpdateProductInput();
                }
                              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập không thành công! Kiểm tra dữ liệu nhập");
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int productInputOrderId = (int.Parse(lbProductInputOrderId.Text));
                var productInputOrder = productInputOrderTableAdapter.GetById(productInputOrderId);
                
                if (productInputOrder[0] == null)
                {
                    MessageBox.Show("Phiếu nhập hàng không tồn tại");
                    return;
                }

                if (!CommonHelper.CheckCurrentDay(productInputOrder[0].CreatedDate))
                {
                    MessageBox.Show("Bạn không thể xóa phiếu nhập hàng, hãy liên hệ với Admin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                if (!CheckActiveDate(productInputOrder[0].InputDate)) return;

                DialogResult result = MessageBox.Show("Xóa phiếu nhập có thể làm cho dữ liệu không chính xác, bạn có muốn tiếp tục?", "Xóa phiếu nhập hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.Cancel) return;

                int productInputId;
                using (TransactionScope tran = new TransactionScope())
                {
                    //check whether costid existed
                    JSManagementDataSet.CostDataTable costData = costTableAdapter.GetCostsByProductInputOrderId(productInputOrderId);
                    //delete all
                    for (int i = 0; i < costData.Rows.Count; i++)
                    {
                        costTableAdapter.DeleteCostById(costData[i].CostId);
                    }  

                    foreach (DataGridViewRow row in grvProducts.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            productInputId = int.Parse(row.Cells["ProductInputId"].Value.ToString());
                            productInputTableAdapter.DeleteProductInputById(productInputId);
                        }
                    }

                    productInputOrderTableAdapter.DeleteById(int.Parse(lbProductInputOrderId.Text));
                    tran.Complete();
                    
                }
                MessageBox.Show("Xóa phiếu nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa phiếu nhập KHÔNG thành công!");
                MessageBox.Show(ex.ToString());
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btFindSupplier_Click(object sender, EventArgs e)
        {
            CustomerForm customerList = new CustomerForm();
            customerList.ShowDialog();
        }

        private void btFindProduct_Click(object sender, EventArgs e)
        {
            ProductSearchForm productSearchForm = new ProductSearchForm();
            productSearchForm.Text = "Tìm hàng nhập";
            productSearchForm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DisableColumnGridViewUserRole(grvInputProduct, "Cost");
            if (grvInputProduct.RowCount == 1)
                ClearData();
            if (LoginInfor.IsAdmin == false)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePickerProductInput.Value.ToShortDateString()))
                    {
                        btSave.Enabled = false;
                        btDelete.Enabled = false;                        
                        return;
                    }
                }
                btSave.Enabled = true;
                btDelete.Enabled = true;           
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            int supId = 0;
            int.TryParse(txtSupplierSearch.Text, out supId);
            grvInputProduct.DataSource = productInputSumaryTableAdapter.GetProductInputSumary(dateTimePickerFrom.Value, dateTimePickerTo.Value, supId, int.Parse(cboxStore.SelectedValue.ToString()));

            grvInputProduct.Columns[Constant.ProductInput.INPUT_DATE_COLUMN_NAME].HeaderText = Constant.ProductInput.INPUT_DATE_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInput.SUPPLIER_ID_COL_NAME].HeaderText = Constant.ProductInput.SUPPLIER_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInput.QUANTITY_COLUMN_NAME].HeaderText = Constant.ProductInput.QUANTITY_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInput.COST_COLUMN_NAME].HeaderText = Constant.ProductInput.COST_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInput.COST_COLUMN_NAME].DefaultCellStyle.Format = Constant.NUMBER_FORMAT;
            grvInputProduct.Columns[Constant.ProductInput.PRODUCT_INPUT_ORDER_ID_COL_NAME].Visible = false;

            if (!LoginInfor.IsAdmin)
                grvInputProduct.Columns["Cost"].Visible = Setting.GetBoolSetting("AllowUserViewInputPrice");

            

        }

        private void dateTimePickerProductInput_ValueChanged(object sender, EventArgs e)
        {
            if (!LoginInfor.IsAdmin)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePickerProductInput.Value.ToShortDateString()))
                    {
                        btSave.Enabled = false;
                        btDelete.Enabled = false;                                                
                        return;
                    }
                }
                btSave.Enabled = true;
                btDelete.Enabled = true;               
            }
        }

        private void grvInputProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvInputProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvInputProduct.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            int productInputOrderId = int.Parse(row.Cells[Constant.ProductInput.PRODUCT_INPUT_ORDER_ID_COL_NAME].Value.ToString());
            BindDataToEdit(productInputOrderId);
        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerCode.Text))
            {
                lbCustomerInfo.Text = string.Empty;
            }
            else
            {
                int custId;
                if (int.TryParse(txtCustomerCode.Text, out custId))
                {
                    var custData = custTableAdapter.GetDataByCustomerId(custId);
                    lbCustomerInfo.Text = string.Empty;
                    if (custData.Rows.Count > 0)
                    {
                        lbCustomerInfo.Text = string.Format("{0}/ {1}/ {2}", custData[0].CustomerName, custData[0].Address, custData[0].Telephone);
                    }
                }

            }
        }

        private void btCopyProduct_Click(object sender, EventArgs e)
        {

        }

        #endregion Event Handler

        #region grvProducts Event Handler

        private void grvProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                grvProducts_KeyDown(new object(), new KeyEventArgs(Keys.Tab));

            if (e.KeyCode == Keys.Tab)
            {

                if (grvProducts.CurrentCell.ColumnIndex == 0)
                {

                    string productCodeSearch = grvProducts.CurrentCell.Value == null ? string.Empty : grvProducts.CurrentCell.Value.ToString();
                    ProductSearchForm proSearchForm = new ProductSearchForm();
                    //TextBox txtProductCodeSearch = proSearchForm.Controls.Find("txtProductCodeSearch", true)[0] as TextBox;
                    //txtProductCodeSearch.Text = productCodeSearch;
                    //ComboBox cboxStoreFind = proSearchForm.Controls.Find("cboxStoreFind", true)[0] as ComboBox;
                    proSearchForm.searchText = productCodeSearch;
                    proSearchForm.inputProductGridRowIndex = grvProducts.CurrentCell.RowIndex;
                    proSearchForm.isOpenedByInputProduct = true;
                    proSearchForm.storeId = int.Parse(cboxStore.SelectedValue.ToString());
                    proSearchForm.ShowDialog();

                }

                int quantity = 0;
                int rowIndex = grvProducts.CurrentCell.RowIndex;
                decimal inputPrice = 0;

                if (grvProducts.CurrentCell.ColumnIndex == 4)
                {                   

                    if (grvProducts.CurrentRow.Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value == null)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = string.Empty;
                        return;
                    }

                    if (!int.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value.ToString(), out quantity))
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = string.Empty;
                        return;
                    }

                    decimal.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInput.COST_COLUMN_NAME].Value.ToString(), out inputPrice);
                    grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = quantity * inputPrice;
                    
                }

                if (grvProducts.CurrentCell.ColumnIndex == 5)
                {

                    if (grvProducts.CurrentRow.Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value == null)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = string.Empty;
                        return;
                    }

                    if (!int.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value.ToString(), out quantity))
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = string.Empty;
                        return;
                    }

                    if (grvProducts.CurrentRow.Cells[Constant.ProductInput.COST_COLUMN_NAME].Value == null)
                    {
                        MessageBox.Show("Giá không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = string.Empty;
                        return;
                    }

                    if (!decimal.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInput.COST_COLUMN_NAME].Value.ToString(), out inputPrice))
                    {
                        MessageBox.Show("Giá không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = string.Empty;
                        return;
                    }

                    grvProducts.CurrentRow.Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value = quantity * inputPrice;
                }
                
                 
                
                UpdateTotalAmountTextBox();
            }

        }

        private void UpdateTotalAmountTextBox()
        {
            decimal totalAmount = 0;
            int quantity = 0;
            for (int i = 0; i < grvProducts.Rows.Count; i++)
            {
                if (grvProducts.Rows[i].Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value != null)
                    totalAmount += decimal.Parse(grvProducts.Rows[i].Cells[Constant.ProductInput.AMOUNT_COLUMN_NAME].Value.ToString());

                if (grvProducts.Rows[i].Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value != null)
                    quantity += int.Parse(grvProducts.Rows[i].Cells[Constant.ProductInput.QUANTITY_COLUMN_NAME].Value.ToString());
            }
            txtTotalAmount.Text = totalAmount.ToString("#,###") == string.Empty ? "0" : totalAmount.ToString("#,###");
            txtTotalQuantity.Text = quantity.ToString();
        }


        private void grvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            grvProducts_KeyDown(new object(), new KeyEventArgs(Keys.Tab));
        }

        private void grvProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = Color.Aquamarine;
        }

        private void grvProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentMouseOverRow = grvProducts.HitTest(e.X, e.Y).RowIndex;
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Delete", new EventHandler(grvProducts_DeleteRow)));

                if (currentMouseOverRow >= 0)
                {

                }

                m.Show(grvProducts, new Point(e.X, e.Y));

            }
        }

        private void grvProducts_DeleteRow(object sender, EventArgs e)
        {
            try
            {
                if (lbProductInputOrderId.Text == "0")
                {
                    if (!grvProducts.Rows[currentMouseOverRow].IsNewRow)
                    {
                        grvProducts.Rows.RemoveAt(currentMouseOverRow);
                    }
                }
                else
                {
                    var productInputOrder = productInputOrderTableAdapter.GetById(int.Parse(lbProductInputOrderId.Text));

                    if (productInputOrder[0] == null)
                    {
                        MessageBox.Show("Phiếu nhập hàng không tồn tại");
                        return;
                    }

                    if(!CheckActiveDate(productInputOrder[0].InputDate)) return;

                    int productInputId = grvProducts.Rows[currentMouseOverRow].Cells["ProductInputId"].Value == null ? 0 : int.Parse(grvProducts.Rows[currentMouseOverRow].Cells["ProductInputId"].Value.ToString());
                    if (productInputId == 0)
                    {
                        if (!grvProducts.Rows[currentMouseOverRow].IsNewRow)
                        {
                            grvProducts.Rows.RemoveAt(currentMouseOverRow);
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Xóa sản phẩm khỏi phiếu nhập hàng?", "Sửa phiếu nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.Cancel)
                        {
                            return;
                        }

                        productInputTableAdapter.DeleteProductInputById(productInputId);
                        grvProducts.Rows.RemoveAt(currentMouseOverRow);
                    }
                }

                UpdateTotalAmountTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion grvProducts Event Handler

        #region CRUD

        private void UpdateProductInput()
        {
            int productInputOrderId = int.Parse(lbProductInputOrderId.Text);
            int supId = int.Parse(txtCustomerCode.Text);
            DateTime inputDate = dateTimePickerProductInput.Value;
            int storeId = int.Parse(cboxStore.SelectedValue.ToString());
            int productId;
            int productInputId;
            int quantity;
            decimal inputPrice;

            using (TransactionScope tran = new TransactionScope())
            {
                //Update InputProductOrder
                productInputOrderTableAdapter.UpdateById(inputDate.ToString(), supId, LoginInfor.UserName, DateTime.Now.ToString(), cboxIsPaidLater.Checked ,storeId ,productInputOrderId);

                //Update Products

                foreach (DataGridViewRow row in grvProducts.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        productId = int.Parse(row.Cells["ProductId"].Value.ToString());
                        productInputId = row.Cells["ProductInputId"].Value==null? 0:int.Parse(row.Cells["ProductInputId"].Value.ToString());
                        quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                        inputPrice = decimal.Parse(row.Cells["Cost"].Value.ToString());
                        if (productInputId > 0)
                        {
                            if (!LoginInfor.IsAdmin && !Setting.GetBoolSetting("AllowUserViewAllCost")) inputPrice = productInputTableAdapter.GetDataId(productInputId)[0].Cost;
                            productInputTableAdapter.UpdateProductInputById(inputDate.ToString(), supId, productId, quantity, inputPrice, productInputId);                            
                        }
                        else
                        {
                            if (!LoginInfor.IsAdmin && !Setting.GetBoolSetting("AllowUserViewAllCost")) inputPrice = productTableAdapter.GetDataByProductId(productId)[0].ProductCost;
                            productInputTableAdapter.Insert(inputDate, supId, productId, quantity, inputPrice, productInputOrderId);
                        }
                    }
                }

                if (cboxIsPaidLater.Checked)
                {
                    //check whether costid existed
                    JSManagementDataSet.CostDataTable costData = costTableAdapter.GetCostsByProductInputOrderId(productInputOrderId);
                    //delete all
                    
                    
                    for (int i = 0; i < costData.Rows.Count; i++)
                    {
                        costTableAdapter.DeleteCostById(costData[i].CostId);
                    }                    
                }
                else
                {
                    //check whether costid existed
                    JSManagementDataSet.CostDataTable costData = costTableAdapter.GetCostsByProductInputOrderId(productInputOrderId);
                    string CostName = string.Format("Thanh toán tiền nhập hàng số {0}", productInputOrderId);
                    int costTypeId = 0;
                    if (costTypeTableAdapter.GetDataByName(Constant.CostType.PRODUCT_INPUT_COST_TYPE).Rows.Count > 0)
                    {
                        costTypeId = costTypeTableAdapter.GetDataByName(Constant.CostType.PRODUCT_INPUT_COST_TYPE)[0].CostTypeId;
                    }
                    int fromBankAccountId = 0;
                    if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
                    {
                        fromBankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
                    }

                    //delete all                    
                    for (int i = 0; i < costData.Rows.Count; i++)
                    {
                        costTableAdapter.DeleteCostById(costData[i].CostId);
                    }
                    costTableAdapter.InsertReturnId(dateTimePickerProductInput.Value, CostName, decimal.Parse(txtTotalAmount.Text), costTypeId, LoginInfor.UserName, null, fromBankAccountId, productInputOrderId, supId);
                }
                tran.Complete();
                
            }

            DialogResult measageResult = MessageBox.Show("Sửa phiếu nhập hàng thành công! Bạn có muốn nhập phiếu khác?", "Tiếp tục nhập hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (measageResult == System.Windows.Forms.DialogResult.OK)
            {
                ClearData();
                return;
            }
        }

        private void InsertProductInput()
        {
            int productInputOrderId = 0;
            DateTime inputDate = dateTimePickerProductInput.Value;
            int supId = int.Parse(txtCustomerCode.Text);
            int storeId = int.Parse(cboxStore.SelectedValue.ToString());
            using (TransactionScope tran = new TransactionScope())
            {
                object result = productInputOrderTableAdapter.InsertReturnId(inputDate, supId, LoginInfor.UserName, DateTime.Now, LoginInfor.UserName, DateTime.Now, cboxIsPaidLater.Checked, storeId);
                             
                if (int.TryParse(result.ToString(), out productInputOrderId))
                {                    
                    foreach (DataGridViewRow r in grvProducts.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            int productId = int.Parse(r.Cells["ProductId"].Value.ToString());
                            int quantity = int.Parse(r.Cells["Quantity"].Value.ToString());
                            decimal inputPrice = decimal.Parse(r.Cells["Cost"].Value.ToString());
                            if (!LoginInfor.IsAdmin && !Setting.GetBoolSetting("AllowUserViewAllCost")) inputPrice = productTableAdapter.GetDataByProductId(productId)[0].ProductCost;
                            productInputTableAdapter.Insert(inputDate, supId, productId, quantity, inputPrice, productInputOrderId);
                        }
                    }
                }

                if (!cboxIsPaidLater.Checked)
                {
                    string costName = string.Format("Chi nhập hàng đơn hàng {0}", productInputOrderId);
                    int costTypeId =0;                    
                    if (costTypeTableAdapter.GetDataByName(Constant.CostType.PRODUCT_INPUT_COST_TYPE).Rows.Count > 0)
                    {
                        costTypeId = costTypeTableAdapter.GetDataByName(Constant.CostType.PRODUCT_INPUT_COST_TYPE)[0].CostTypeId;
                    }                   

                    if (costTypeId == 0)
                    {
                        tran.Dispose();
                        return;
                    }

                    if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.CASH)
                    {
                        
                        costTableAdapter.InsertReturnId(dateTimePickerProductInput.Value, costName, decimal.Parse(txtTotalAmount.Text), costTypeId, LoginInfor.UserName, null, null, productInputOrderId, supId);
                    }

                    if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
                    {
                        costTableAdapter.InsertReturnId(dateTimePickerProductInput.Value, costName, decimal.Parse(txtTotalAmount.Text), costTypeId, LoginInfor.UserName, null, int.Parse(cboxBankAccount.SelectedValue.ToString()), productInputOrderId, supId);
                    }
                }

                tran.Complete();                              
            }

            DialogResult measageResult = MessageBox.Show("Tạo phiếu nhập hàng thành công! Bạn có muốn tiếp tục nhập phiếu khác?", "Tiếp tục nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (measageResult == System.Windows.Forms.DialogResult.OK)
            {
                ClearData();
                return;
            }  

            if(productInputOrderId >0) BindDataToEdit(productInputOrderId);
        }


        #endregion CRUD

        #region Ultility

        private bool ValidateInputData()
        {
            if (txtCustomerCode.Text == string.Empty)
            {
                MessageBox.Show("Thông tin nhà cung cấp không hợp lệ");
                return false;
            }

            int custId;
            if (!int.TryParse(txtCustomerCode.Text, out custId))
            {
                MessageBox.Show("Thông tin nhà cung cấp không hợp lệ");
                return false;
            }

            if (lbCustomerInfo.Text == string.Empty)
            {
                MessageBox.Show("Thông tin nhà cung cấp không hợp lệ");
                return false;
            }

            if (!ValidateProducts())
            {
                return false;
            }

            return true;
        }

        private bool ValidateProducts()
        {
            if (grvProducts.Rows.Count == 1)
            {
                if (grvProducts.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Bạn hãy nhập mã hàng");
                    return false;
                }

                if (grvProducts.Rows[0].Cells[0].Value.ToString() == string.Empty)
                {
                    MessageBox.Show("Bạn hãy nhập mã hàng");
                    return false;
                }

                int quantity;
                if (grvProducts.Rows[0].Cells[4].Value == null)
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    grvProducts.Rows[0].Cells[6].Value = string.Empty;
                    return false;
                }

                if (!int.TryParse(grvProducts.Rows[0].Cells[4].Value.ToString(), out quantity))
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    grvProducts.CurrentRow.Cells[6].Value = string.Empty;
                    return false;
                }

                
                //Validate Price
                decimal inputPrice = 0;
                if (grvProducts.Rows[0].Cells[5].Value == null)
                {
                    MessageBox.Show("Giá nhập không hợp lệ!");
                    grvProducts.CurrentRow.Cells[6].Value = string.Empty;
                    return false;
                }

                if (!decimal.TryParse(grvProducts.Rows[0].Cells[6].Value.ToString(), out inputPrice))
                {
                    MessageBox.Show("Giá nhập không hợp lệ!");
                    grvProducts.Rows[0].Cells[6].Value = string.Empty;
                    return false;
                }
            }

            if (grvProducts.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in grvProducts.Rows)
                {
                    if (row != grvProducts.Rows[grvProducts.Rows.Count - 1])
                    {
                        int quantity;
                        if (row.Cells[4].Value == null)
                        {
                            MessageBox.Show("Số lượng không hợp lệ!");
                            row.Cells[6].Value = string.Empty;
                            return false;
                        }

                        if (!int.TryParse(row.Cells[4].Value.ToString(), out quantity))
                        {
                            MessageBox.Show("Số lượng không hợp lệ!");
                            grvProducts.CurrentRow.Cells[6].Value = string.Empty;
                            return false;
                        }
                        
                        //Validate Sold Price
                        decimal inputPrice = 0;
                        if (row.Cells[5].Value == null)
                        {
                            MessageBox.Show("Giá nhập không hợp lệ!");
                            grvProducts.CurrentRow.Cells[6].Value = string.Empty;
                            return false;
                        }

                        if (!decimal.TryParse(row.Cells[5].Value.ToString(), out inputPrice))
                        {
                            MessageBox.Show("Giá không hợp lệ!");
                            row.Cells[6].Value = string.Empty;
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool CheckActiveDate(DateTime date)
        {
            if (LoginInfor.IsAdmin == false)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(date.ToShortDateString()))
                    {
                        MessageBox.Show("Ngày nhập chưa được kích hoạt, liên hệ ADMIN!");
                        return false;
                    }
                }
            }
            return true;
        }

        private void ReloadInputProductGrid()
        {
            grvInputProduct.DataSource = productInputProductTableAdapter.GetDataByInputDateNewestFirst(dateTimePickerProductInput.Text);
            DisableColumnGridViewUserRole(grvInputProduct, "Cost");

            if (grvInputProduct.RowCount == 1)
                ClearData();
            if (LoginInfor.IsAdmin == false)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePickerProductInput.Value.ToShortDateString()))
                    {
                        btSave.Enabled = false;
                        btDelete.Enabled = false;
                        btAddNew.Enabled = false;
                        return;
                    }
                }
                btSave.Enabled = true;
                btDelete.Enabled = true;
                btAddNew.Enabled = true;
            }
        }

        private void DisableColumnGridViewUserRole(DataGridView gridView, string dataPropertyName)
        {
            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].DataPropertyName == dataPropertyName)
                {
                    gridView.Columns[i].Visible = isAdmin;
                }
            }
        }

        //private void BindDataToEdit(DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0 || e.RowIndex == grvInputProduct.RowCount - 1)
        //        return;

        //    ClearData();

        //    lbInputHeader.Text = "Sửa hàng nhập".ToUpper();
        //    DataGridViewRow row = grvInputProduct.Rows[e.RowIndex];
        //    if (int.Parse(row.Cells["ProductInputOrderId"].Value.ToString()) == 0)
        //    {
        //        return;
        //    }
        //    int productInputOrderId = int.Parse(row.Cells["ProductInputOrderId"].Value.ToString());
        //    DateTime inputDate = DateTime.Parse(row.Cells["InputDate"].Value.ToString());
        //    int supId = int.Parse(row.Cells["SupplierId"].Value.ToString());

        //    lbProductInputOrderId.Text = productInputOrderId.ToString();
        //    txtCustomerCode.Text = supId.ToString();
        //    dateTimePickerProductInput.Value = inputDate;

        //    JSManagementDataSetTableAdapters.InputProductsByProductInputOrderIdTableAdapter inputproductsTableAdapter = new JSManagementDataSetTableAdapters.InputProductsByProductInputOrderIdTableAdapter();
        //    inputproductsTableAdapter.Connection = CommonHelper.GetSQLConnection();
        //    JSManagementDataSet.InputProductsByProductInputOrderIdDataTable dTable = inputproductsTableAdapter.GetInputProductsByProductInputOrderId(productInputOrderId);

        //    decimal inputPrice;
        //    for (int i = 0; i < dTable.Rows.Count; i++)
        //    {
        //        grvProducts.Rows.Add(1);
        //        grvProducts.Rows[i].Cells[0].Value = dTable.Rows[i].ItemArray[0];
        //        grvProducts.Rows[i].Cells[1].Value = dTable.Rows[i].ItemArray[1];
        //        grvProducts.Rows[i].Cells[2].Value = dTable.Rows[i].ItemArray[2];
        //        grvProducts.Rows[i].Cells[3].Value = dTable.Rows[i].ItemArray[3];
        //        grvProducts.Rows[i].Cells[4].Value = dTable.Rows[i].ItemArray[4];
        //        if (LoginInfor.IsAdmin)
        //        {
        //            inputPrice = decimal.Parse(dTable.Rows[i].ItemArray[5].ToString());
        //        }
        //        else
        //        {
        //            inputPrice = Setting.GetBoolSetting("AllowUserViewInputPrice") == false ? 0 : decimal.Parse(dTable.Rows[i].ItemArray[5].ToString());
        //        }

        //        grvProducts.Rows[i].Cells[5].Value = inputPrice;
        //        grvProducts.Rows[i].Cells[5].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
        //        grvProducts.Rows[i].Cells[6].Value = int.Parse(dTable.Rows[i].ItemArray[4].ToString()) * inputPrice;
        //        grvProducts.Rows[i].Cells[6].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
        //        grvProducts.Rows[i].Cells[7].Value = dTable.Rows[i].ItemArray[6];
        //        grvProducts.Rows[i].Cells[8].Value = dTable.Rows[i].ItemArray[7];
        //    }
        //}

        private void BindDataToEdit(int productInputOrderId)
        {
            if (productInputOrderId == 0) return;

            ClearData();

            lbInputHeader.Text = "Sửa hàng nhập".ToUpper();
            productInputOrderTableAdapter = new JSManagementDataSetTableAdapters.ProductInputOrderTableAdapter();
            productInputOrderTableAdapter.Connection = CommonHelper.GetSQLConnection();
            JSManagementDataSet.ProductInputOrderDataTable productInputOrderData =  productInputOrderTableAdapter.GetById(productInputOrderId);
            DateTime inputDate = productInputOrderData[0].InputDate;
            int supId = productInputOrderData[0].SupplierId;

            lbProductInputOrderId.Text = productInputOrderId.ToString();
            txtCustomerCode.Text = supId.ToString();
            dateTimePickerProductInput.Value = inputDate;
            cboxIsPaidLater.Checked = productInputOrderData[0].IsPaidLater;

            JSManagementDataSetTableAdapters.InputProductsByProductInputOrderIdTableAdapter inputproductsTableAdapter = new JSManagementDataSetTableAdapters.InputProductsByProductInputOrderIdTableAdapter();
            inputproductsTableAdapter.Connection = CommonHelper.GetSQLConnection();
            JSManagementDataSet.InputProductsByProductInputOrderIdDataTable dTable = inputproductsTableAdapter.GetInputProductsByProductInputOrderId(productInputOrderId);
            cboxStore.SelectedValue = productInputOrderData[0].StoreId;
            decimal inputPrice;
            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                grvProducts.Rows.Add(1);
                grvProducts.Rows[i].Cells[0].Value = dTable.Rows[i].ItemArray[0];
                grvProducts.Rows[i].Cells[1].Value = dTable.Rows[i].ItemArray[1];
                grvProducts.Rows[i].Cells[2].Value = dTable.Rows[i].ItemArray[2];
                grvProducts.Rows[i].Cells[3].Value = dTable.Rows[i].ItemArray[3];
                grvProducts.Rows[i].Cells[4].Value = dTable.Rows[i].ItemArray[4];
                if (LoginInfor.IsAdmin)
                {
                    inputPrice = decimal.Parse(dTable.Rows[i].ItemArray[5].ToString());
                }
                else
                {
                    inputPrice = Setting.GetBoolSetting("AllowUserViewInputPrice") == false ? 0 : decimal.Parse(dTable.Rows[i].ItemArray[5].ToString());
                }

                grvProducts.Rows[i].Cells[5].Value = inputPrice;
                grvProducts.Rows[i].Cells[5].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
                grvProducts.Rows[i].Cells[6].Value = int.Parse(dTable.Rows[i].ItemArray[4].ToString()) * inputPrice;
                grvProducts.Rows[i].Cells[6].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
                grvProducts.Rows[i].Cells[7].Value = dTable.Rows[i].ItemArray[6];
                grvProducts.Rows[i].Cells[8].Value = dTable.Rows[i].ItemArray[7];
            }

            UpdateTotalAmountTextBox();
        }

        private void UpdateGridView()
        {
            DataGridViewRow row = grvInputProduct.Rows[rowIndex];

            grvInputProduct.Rows[rowIndex].Cells[2].Value = txtCustomerCode.Text;
        }

        private void ClearData()
        {
            lbInputHeader.Text = "Nhập hàng".ToUpper();
            txtCustomerCode.Text = string.Empty;
            lbCustomerInfo.Text = string.Empty;
            lbProductInputOrderId.Text = "0";
            grvProducts.Rows.Clear();
            dateTimePickerProductInput.Value = DateTime.Now;
            cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.CASH;
            cboxBankAccount.Visible = false;
            txtTotalQuantity.Text = "0";
            txtTotalAmount.Text = "0";
            cboxIsPaidLater.Checked = false;
        }        

        #endregion Ultility
           
        private void productInputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

            if (e.Control && e.KeyCode == Keys.A) dateTimePickerProductInput.Focus();

            if (e.Control && e.KeyCode == Keys.U) txtCustomerCode.Focus();

            if (e.Control && e.KeyCode == Keys.H) grvProducts.Focus();

            if (e.Control && e.KeyCode == Keys.S) btSave_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.X) btDelete_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.T) btAddNew_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.G) dateTimePickerFrom.Focus();
        }

        private void cboxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.CASH)
            {
                cboxBankAccount.Visible = false;
                return;
            }

            if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                cboxBankAccount.Visible = true;
                cboxBankAccount.DataSource = bankAccountTableAdapter.GetData();
            }
        }

        public int ProductInputOrderId { get; set; }

        private System.Windows.Forms.PrintPreviewDialog prnPreview;
        private System.Drawing.Printing.PrintDocument prnDocument;
        int leftMargin;
        int rightMargin;
        int topMargin;
        int bottomMargin;
        int InvoiceWidth;
        int InvoiceHeight;

        private void btProductInforPrint_Click(object sender, EventArgs e)
        {
            prnDocument.DefaultPageSettings.Landscape = false;
            prnPreview.Document = prnDocument;
            prnPreview.PrintPreviewControl.Zoom = 1;
            prnPreview.Width = 1000;
            prnPreview.Height = 800;
            prnPreview.ShowDialog();

        }

        private void prnDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;  	// leftMargin, rightMargin, 
            // ... Declared before
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;
            // Draw Invoice Head
            //e.Graphics.RotateTransform(90.0f);
            SetProductsLabel(e.Graphics);
        }

        private void SetProductsLabel(Graphics g)
        {
            Font InvTitleFont = new Font("Arial", 10, FontStyle.Bold);
            Font InvSubTitleFont = new Font("Arial", 10, FontStyle.Regular);
            SolidBrush Brush = new SolidBrush(Color.Black);
            string labelTitle = "Jeans Style - 55 Đội Cấn";
            int CurrentX = 10;
            int CurrentY = 10;
            foreach (DataGridViewRow row in grvProducts.Rows)
            {
                if (!row.IsNewRow)
                {
                    int quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    for (int i = 0; i < quantity; i++)
                    {
                        string productId = row.Cells["ProductId"].Value.ToString();
                        JSManagementDataSet.ProductDataTable productDataTable = productTableAdapter.GetDataByProductId(int.Parse(productId));
                        string productCode = productDataTable.Rows[0]["ProductCode"].ToString();
                        string productType = productDataTable.Rows[0]["ProductType"].ToString();
                        string size = productDataTable.Rows[0]["Size"].ToString();
                        decimal price = decimal.Parse(productDataTable.Rows[0]["Price"].ToString());
                        g.DrawString(labelTitle, InvTitleFont, Brush, CurrentX, CurrentY);
                        CurrentY += 20;
                        g.DrawString(string.Format("{0} MS:{1} Size:{2}", productType, productCode, size), InvSubTitleFont, Brush, CurrentX, CurrentY);
                        CurrentY += 20;
                        g.DrawString(string.Format("Giá:{0}", price.ToString("#,###", cul.NumberFormat)), InvSubTitleFont, Brush, CurrentX, CurrentY);
                        CurrentY += 28;
                        //int labelLength = (int)g.MeasureString(labelTitle, InvSubTitleFont).Width;

                        if (CurrentY > 1050)
                        {
                            CurrentX += 190;
                            CurrentY = 10;
                        }
                       
                    }
                }
            }
        }
    }
}
