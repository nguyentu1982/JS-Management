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
        JSManagementDataSetTableAdapters.InputTypeTableAdapter inputTypeTableAdapter;
        JSManagementDataSetTableAdapters.ProductTransOrderTableAdapter productTransOrderTableAdapter;
        JSManagementDataSetTableAdapters.ProductTransMappingTableAdapter productTransMappingTableAdapter;
        JSManagementDataSetTableAdapters.InputProductsByProductInputOrderIdTableAdapter inputproductsTableAdapter;
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

            inputTypeTableAdapter = new JSManagementDataSetTableAdapters.InputTypeTableAdapter();
            inputTypeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            productTransOrderTableAdapter = new JSManagementDataSetTableAdapters.ProductTransOrderTableAdapter();
            productTransOrderTableAdapter.Connection = CommonHelper.GetSQLConnection();
            productTransMappingTableAdapter = new JSManagementDataSetTableAdapters.ProductTransMappingTableAdapter();
            productTransMappingTableAdapter.Connection = CommonHelper.GetSQLConnection();

            inputproductsTableAdapter = new JSManagementDataSetTableAdapters.InputProductsByProductInputOrderIdTableAdapter();
            inputproductsTableAdapter.Connection = CommonHelper.GetSQLConnection();

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
            ucPaymentMethod.BankAccountDataSource = bankAccountTableAdapter.GetData();
            ucPaymentMethod.CboxBankAccountDisplayMember = Constant.BankAccount.BANK_ACCOUNT_NAME_DISPLAY_MEMBER;
            ucPaymentMethod.CboxBankAccountValueMember = Constant.BankAccount.BANK_ACCOUNT_ID_Value_MEMBER;
            ucPaymentMethod.PaymentMethod = Constant.PaymentMethod.CASH;
            ucInputStore.StoreDataSource = storeTableAdapter.GetData();
            ucInputStore.StoreId = LoginInfor.StoreId;
            ucInputStore.Enabled = LoginInfor.IsAdmin;
            ucInputStore.LabelStoreInOrOut = Constant.Store.KHO_NHAP;
            cboxInputType.DataSource = inputTypeTableAdapter.GetData();
            cboxInputType.DisplayMember = Constant.InputType.DISPLAY_MEMBER;
            cboxInputType.ValueMember = Constant.InputType.VALUE_MEMBER;
            cboxInputType.SelectedValue = Constant.InputType.NH;

            JSManagementDataSet.InputTypeDataTable inputTypeTable = inputTypeTableAdapter.GetData();
            DataRow drow = inputTypeTable.NewRow();
            drow["InputTypeCode"] = Constant.InputType.ALL;
            drow["InputTypeDesc"] = Constant.InputType.ALL_DESC;
            inputTypeTable.Rows.InsertAt(drow, 0);
            cboxFindInputType.DataSource = inputTypeTable;
            cboxFindInputType.DisplayMember = Constant.InputType.DISPLAY_MEMBER;
            cboxFindInputType.ValueMember = Constant.InputType.VALUE_MEMBER;
            cboxFindInputType.SelectedValue = Constant.InputType.ALL;
            

            if (this.ProductInputOrderId != 0 )
            {
                BindDataToEdit(ProductInputOrderId);
                return;
            }

            if(this.ProductTransOrderId != 0)
            {
                BindProductTrans(ProductTransOrderId);
                return;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxInputType.SelectedValue.ToString().Trim() == Constant.InputType.NCK)
                {
                    if (cboxApprove.Checked && !cboxApprove.Enabled) return; //nếu đã duyệt rồi thì user ko được duyệt lại nữa

                    string approvedText = cboxApprove.Checked == true? "DUYỆT":"KHÔNG DUYỆT";
                    string note = txtNote.Text;
                    int productTransOrderId = int.Parse(lbProductInputOrderId.Text);
                    DialogResult result;
                    result = MessageBox.Show(string.Format("Bạn có chắc chắn {0} phiếu nhập chuyển hàng?", approvedText), "Duyệt phiếu nhập chuyển hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Cancel) return;
                    
                    productTransOrderTableAdapter.ApprovedProductTransOrderById(note, cboxApprove.Checked, LoginInfor.UserName, DateTime.Now, productTransOrderId);

                    DialogResult measageResult = MessageBox.Show("Duyệt phiếu nhập chuyển hàng thành công!", "Duyệt phiếu nhập chuyển hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindProductTrans(productTransOrderId);
                }
                if (cboxInputType.SelectedValue.ToString().Trim() == Constant.InputType.NH)
                {
                    if (!ValidateInputData())
                    {
                        return;
                    }

                    string inputDate = dateTimePickerProductInput.Text;
                    int supplierId = ucSupplierSelect.CustId;
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
                if (cboxInputType.SelectedValue.ToString().Trim() == Constant.InputType.NH)
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
            int supId = ucFindCustSelect.CustId;
            string inputTypeCode = cboxFindInputType.SelectedValue.ToString();
            int tranStatus = -1;
            if (cklFindTransStatus.Visible && cklFindTransStatus.SelectedItem!=null)
            {
                if (cklFindTransStatus.SelectedItem.ToString() == Constant.InputType.NCK_APPROVED)
                {
                    tranStatus = 1;
                }

                if (cklFindTransStatus.SelectedItem.ToString() == Constant.InputType.NCK_NOT_APPROVED)
                {
                    tranStatus = 0;
                }
            }
            DateTime startDate = new DateTime(dateTimePickerFrom.Value.Year, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Day);
            DateTime endDate = new DateTime(dateTimePickerTo.Value.Year, dateTimePickerTo.Value.Month, dateTimePickerTo.Value.Day, 23, 59, 59);

            grvInputProduct.DataSource = productInputSumaryTableAdapter.GetProductInputSumary(startDate, endDate, supId, ucInputStore.StoreId, inputTypeCode, tranStatus);

            grvInputProduct.Columns[Constant.ProductInputColumnName.INPUT_DATE_COLUMN_NAME].HeaderText = Constant.ProductInputColumnName.INPUT_DATE_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInputColumnName.SUPPLIER_ID_COL_NAME].HeaderText = Constant.ProductInputColumnName.SUPPLIER_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInputColumnName.QUANTITY].HeaderText = Constant.ProductInputColumnName.QUANTITY_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInputColumnName.COST].HeaderText = Constant.ProductInputColumnName.COST_COL_HEADER;
            grvInputProduct.Columns[Constant.ProductInputColumnName.COST].DefaultCellStyle.Format = Constant.NUMBER_FORMAT;
            grvInputProduct.Columns[Constant.ProductInputColumnName.PRODUCT_INPUT_ORDER_ID].Visible = false;

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
            //grvProducts_KeyDown(new object(), new KeyEventArgs(Keys.Tab));
        }

        private void grvInputProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvInputProduct.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            int productInputOrderId = int.Parse(row.Cells[Constant.ProductInputColumnName.PRODUCT_INPUT_ORDER_ID].Value.ToString());
            string inputTypeCode = row.Cells[Constant.ProductInputColumnName.INPUT_TYPE_CODE].Value.ToString();
            if(inputTypeCode == Constant.InputType.NH)
                BindDataToEdit(productInputOrderId);
            if (inputTypeCode == Constant.InputType.NCK)
                BindProductTrans(productInputOrderId);
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
                    proSearchForm.storeId = ucInputStore.StoreId;
                    proSearchForm.ShowDialog();

                }

                int quantity = 0;
                int rowIndex = grvProducts.CurrentCell.RowIndex;
                decimal inputPrice = 0;

                if (grvProducts.CurrentCell.ColumnIndex == 4)
                {                   

                    if (grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.QUANTITY].Value == null)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = string.Empty;
                        return;
                    }

                    if (!int.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.QUANTITY].Value.ToString(), out quantity))
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = string.Empty;
                        return;
                    }

                    decimal.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.COST].Value.ToString(), out inputPrice);
                    grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = quantity * inputPrice;
                    
                }

                if (grvProducts.CurrentCell.ColumnIndex == 5)
                {

                    if (grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.QUANTITY].Value == null)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = string.Empty;
                        return;
                    }

                    if (!int.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.QUANTITY].Value.ToString(), out quantity))
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = string.Empty;
                        return;
                    }

                    if (grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.COST].Value == null)
                    {
                        MessageBox.Show("Giá không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = string.Empty;
                        return;
                    }

                    if (!decimal.TryParse(grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.COST].Value.ToString(), out inputPrice))
                    {
                        MessageBox.Show("Giá không hợp lệ!");
                        grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = string.Empty;
                        return;
                    }

                    grvProducts.CurrentRow.Cells[Constant.ProductInputColumnName.AMOUNT].Value = quantity * inputPrice;
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
                if (grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.AMOUNT].Value != null)
                    totalAmount += decimal.Parse(grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.AMOUNT].Value.ToString());

                if (grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.QUANTITY].Value != null)
                    quantity += int.Parse(grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.QUANTITY].Value.ToString());
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
            int supId = ucSupplierSelect.CustId;
            DateTime inputDate = dateTimePickerProductInput.Value;
            int storeId = ucInputStore.StoreId;
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

                    ////if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
                    ////{
                    ////    fromBankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
                    ////}
                    if(ucPaymentMethod.PaymentMethod == Constant.PaymentMethod.BANK_TRANSFER)
                    {
                        fromBankAccountId = ucPaymentMethod.BankAccountIds[0];
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
            int supId = ucSupplierSelect.CustId;
            int storeId = ucInputStore.StoreId;
            string note = txtNote.Text;
            string inputTypeCode = cboxInputType.SelectedValue.ToString();
            using (TransactionScope tran = new TransactionScope())
            {
                object result = productInputOrderTableAdapter.InsertReturnId
                    (
                        inputDate, 
                        supId, 
                        LoginInfor.UserName, 
                        DateTime.Now, 
                        LoginInfor.UserName, 
                        DateTime.Now, 
                        cboxIsPaidLater.Checked, 
                        storeId, 
                        note, 
                        inputTypeCode
                        );
                        
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

                    if (ucPaymentMethod.PaymentMethod == Constant.PaymentMethod.CASH)
                    {

                        costTableAdapter.InsertReturnId(dateTimePickerProductInput.Value, costName, decimal.Parse(txtTotalAmount.Text), costTypeId, LoginInfor.UserName, null, null, productInputOrderId, supId);
                    }

                    if (ucPaymentMethod.PaymentMethod == Constant.PaymentMethod.BANK_TRANSFER)
                    {
                        costTableAdapter.InsertReturnId(dateTimePickerProductInput.Value, costName, decimal.Parse(txtTotalAmount.Text), costTypeId, LoginInfor.UserName, null, ucPaymentMethod.BankAccountIds[0], productInputOrderId, supId);
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
            if (ucSupplierSelect.CustId ==0 )
            {
                MessageBox.Show("Thông tin nhà cung cấp không hợp lệ");
                return false;
            }

            int custId;
            if (!int.TryParse(ucSupplierSelect.CustId.ToString(), out custId))
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
        private void BindDataToEdit(int productInputOrderId)
        {
            if (productInputOrderId == 0) return;

            ClearData();

            lbInputHeader.Text = "Sửa phiếu nhập hàng".ToUpper();
            JSManagementDataSet.ProductInputOrderDataTable productInputOrderData =  productInputOrderTableAdapter.GetById(productInputOrderId);
            DateTime inputDate = productInputOrderData[0].InputDate;
            int supId = productInputOrderData[0].SupplierId;
            cboxInputType.SelectedValue = Constant.InputType.NH;
            lbProductInputOrderId.Text = productInputOrderId.ToString();
            ucSupplierSelect.CustId = supId;
            dateTimePickerProductInput.Value = inputDate;
            cboxIsPaidLater.Checked = productInputOrderData[0].IsPaidLater;

            JSManagementDataSet.InputProductsByProductInputOrderIdDataTable dTable = inputproductsTableAdapter.GetInputProductsByProductInputOrderId(productInputOrderId);
            ucInputStore.StoreId = productInputOrderData[0].StoreId;
            decimal inputPrice;

            JSManagementDataSet.CostDataTable costData = costTableAdapter.GetCostsByProductInputOrderId(productInputOrderId);
            if(costData.Rows.Count>0)
            {             
                List<int> bankIds = new List<int>();
                foreach(DataRow r in costData.Rows)
                {
                    if(r[8] != DBNull.Value)
                    {
                        bankIds.Add(int.Parse(r[8].ToString()));
                    }                    
                }
                JSManagementDataSet.BankAccountDataTable bankAccountData = bankAccountTableAdapter.GetData();
                ucPaymentMethod.LoadData(bankIds, bankAccountData);
            }

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                JSManagementDataSet.ProductDataTable product = productTableAdapter.GetDataByProductId(dTable[i].ProductId);
                grvProducts.Rows.Add(1);
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_CODE].Value = product[0].ProductCode;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_TYPE].Value = product[0].ProductType;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.BRAND].Value = product[0].Brand;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.SIZE].Value = product[0].Size;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.QUANTITY].Value = dTable[i].Quantity;
                if (LoginInfor.IsAdmin)
                {
                    inputPrice = decimal.Parse(dTable[i].Cost.ToString());
                }
                else
                {
                    inputPrice = Setting.GetBoolSetting("AllowUserViewInputPrice") == false ? 0 : decimal.Parse(dTable[i].Cost.ToString());
                }

                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.COST].Value = inputPrice;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.COST].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.AMOUNT].Value = dTable[i].Quantity * inputPrice;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.AMOUNT].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_ID].Value = dTable[i].ProductId;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_INPUT_ID].Value = dTable[i].ProductInputId;
            }

            UpdateTotalAmountTextBox();
        }
        private void BindProductTrans(int productTransOrderId)
        {
            if (productTransOrderId == 0) return;

            ClearData();

            lbInputHeader.Text = "Duyệt phiếu nhập chuyển hàng".ToUpper();

            JSManagementDataSet.ProductTransOrderDataTable productTransOrderData = productTransOrderTableAdapter.GetDataById(productTransOrderId);
            DateTime transDate = productTransOrderData[0].TransDate;
            cboxInputType.SelectedValue = Constant.InputType.NCK;
            lbProductInputOrderId.Text = productTransOrderId.ToString();
            ucInputStore.StoreId = productTransOrderData[0].ToStoreId;
            ucOutputStore.StoreId = productTransOrderData[0].FromStoreId;
            dateTimePickerProductInput.Value = transDate;
            cboxApprove.Checked = productTransOrderData[0].Approved;
            cboxApprove.Enabled = LoginInfor.IsAdmin? true : !productTransOrderData[0].Approved;
            cboxApprove.ForeColor = cboxApprove.Checked == true ? Color.Blue : Color.Red;
            cboxApprove.Text = cboxApprove.Checked == true ? "Đã Duyệt" : "Chưa Duyệt";
            int productId;
            JSManagementDataSet.ProductTransMappingDataTable dTable = productTransMappingTableAdapter.GetDataByProductTransOrderId(productTransOrderId);


            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                productId = dTable[i].ProductId;
                JSManagementDataSet.ProductDataTable product = productTableAdapter.GetDataByProductId(productId);
                grvProducts.Rows.Add(1);
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_CODE].Value = product[0].ProductCode;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_TYPE].Value = product[0].ProductType;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.BRAND].Value = product[0].Brand;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.SIZE].Value = product[0].Size;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.QUANTITY].Value = dTable[i].Quantity;

                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.COST].Value = 0;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.COST].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.AMOUNT].Value = 0;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.AMOUNT].ReadOnly = LoginInfor.IsAdmin == true ? false : !Setting.GetBoolSetting("AllowUserViewInputPrice");
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_ID].Value = productId;
                grvProducts.Rows[i].Cells[Constant.ProductInputColumnName.PRODUCT_INPUT_ID].Value = dTable[i].ProductTransMappingId;
            }

        }
        private void UpdateGridView()
        {
            DataGridViewRow row = grvInputProduct.Rows[rowIndex];

            grvInputProduct.Rows[rowIndex].Cells[2].Value = ucSupplierSelect.CustId;
        }

        private void ClearData()
        {
            lbInputHeader.Text = "Tạo phiếu Nhập hàng".ToUpper();
            ucSupplierSelect.CustId = 0;            
            cboxInputType.SelectedValue = Constant.InputType.NH;
            lbProductInputOrderId.Text = "0";
            grvProducts.Rows.Clear();
            dateTimePickerProductInput.Value = DateTime.Now;
            ucPaymentMethod.PaymentMethod = Constant.PaymentMethod.CASH;
            ////cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.CASH;
            txtTotalQuantity.Text = "0";
            txtTotalAmount.Text = "0";
            cboxIsPaidLater.Checked = false;
            txtNote.Text = string.Empty;
        }        

        #endregion Ultility
           
        private void productInputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

            if (e.Control && e.KeyCode == Keys.A) dateTimePickerProductInput.Focus();

            if (e.Control && e.KeyCode == Keys.U) ucSupplierSelect.Focus();

            if (e.Control && e.KeyCode == Keys.H) grvProducts.Focus();

            if (e.Control && e.KeyCode == Keys.S) btSave_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.X) btDelete_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.T) btAddNew_Click(new object(), new EventArgs());

            if (e.Control && e.KeyCode == Keys.G) dateTimePickerFrom.Focus();
        }

        public int ProductInputOrderId { get; set; }

        public int ProductTransOrderId { get; set; }

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

        private void cboxInputType_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if(cboxInputType.SelectedValue.ToString().Trim() == Constant.InputType.NCK.Trim())
            {
                ucOutputStore.Visible = true;
                ucOutputStore.StoreDataSource = storeTableAdapter.GetData();
                ucOutputStore.LabelStoreInOrOut = Constant.Store.KHO_XUAT;                
                cklFindTransStatus.Enabled = false;
                ucOutputStore.Enabled = false;
                cboxApprove.Visible = true;
            }
            else
            {
                ucOutputStore.Visible = false;
                cboxApprove.Visible = false; 
            }
        }

        private void cklFindTransStatus_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < cklFindTransStatus.Items.Count; ++ix)
                {
                    if (e.Index != ix) cklFindTransStatus.SetItemChecked(ix, false);
                }
            }
        }

        private void cboxFindInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string inputType = cboxFindInputType.SelectedValue == null? string.Empty : cboxFindInputType.SelectedValue.ToString();
            if(inputType ==  Constant.InputType.NCK)
            {
                cklFindTransStatus.Visible = true;
            }
            else
            {
                cklFindTransStatus.Visible = false;
            }
        }

        private void grvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboxIsPaidLater_CheckedChanged(object sender, EventArgs e)
        {

            if (cboxIsPaidLater.Checked)
            {
                ucPaymentMethod.Enabled = false;
            }
            else
                ucPaymentMethod.Enabled = true;
        }

        
    }
}
