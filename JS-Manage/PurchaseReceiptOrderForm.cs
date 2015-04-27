using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace JS_Manage
{
    public partial class PurchaseReceiptOrderForm : Form
    {
        private System.Windows.Forms.PrintDialog prnDialog;
        private System.Windows.Forms.PrintPreviewDialog prnPreview;
        private System.Drawing.Printing.PrintDocument prnDocument;

        private System.Windows.Forms.PrintDialog prnDialogPostOfficeLetter;
        private System.Windows.Forms.PrintPreviewDialog prnPreviewPostOfficeLetter;
        private System.Drawing.Printing.PrintDocument prnDocumentPostOfficeLetter;

        int leftMargin ;             
        int    rightMargin;
        int    topMargin;
        int   bottomMargin;
        int    InvoiceWidth;
        int    InvoiceHeight;

        int currentMouseOverRow;
        
        JSManagementDataSetTableAdapters.CustomerTableAdapter custTableAdapter;
        JSManagementDataSetTableAdapters.PurchaseReceiptOrderTableAdapter purchaseReceiptOrderTableAdapter;
        JSManagementDataSetTableAdapters.OrdersTableAdapter orderTableAdapter;
        JSManagementDataSetTableAdapters.IncomeTableAdapter incomeTableAdapter;
        JSManagementDataSetTableAdapters.PurchaseReceiptOrderSumaryTableAdapter purchaseOrderSumaryTableAdapter;
        JSManagementDataSetTableAdapters.PurchaseReceiptOrderDetailTableAdapter purchaseOrderDetailTableAdapter;
        JSManagementDataSetTableAdapters.JS_UserTableAdapter userTableAdapter;
        JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter rewardPointHistoryTableAdapters;

        private const string SOLD_BY = "SoldBy";
        private const string USER_NAME = "UserName";
        private const string USER_ID = "UserId";
        private const string PRODUCT_CODE_PRODUCT_GRID_COLUMN_NAME = "ProductCode";        
        private const string PRODUCT_TYPE_PRODUCT_GRID_COLUMN_NAME = "ProductType";
        private const string BRAND_PRODUCT_GRID_COLUMN_NAME= "Brand";
        private const string SIZE_PRODUCT_GRID_COLUMN_NAME= "Size";
        private const string PRICE_PRODUCT_GRID_COLUMN_NAME = "Price";
        private const string QUANTITY_PRODUCT_GRID_COLUMN_NAME = "Quantity";
        private const string SOLD_PRICE_PRODUCT_GRID_COLUMN_NAME= "SoldPrice";
        private const string AMOUNT_PRODUCT_GRID_COLUMN_NAME= "Amount";
        private const string PRODUCT_ID_PRODUCT_GRID_COLUMN_NAME= "ProductId";
        private const string CLOSING_BALLANCE_PRODUCT_GRID_COLUMN_NAME= "ClosingBallance";
        private const string ORDER_ID_PRODUCT_GRID_COLUMN_NAME= "OrderId";
        private const string INCOME_ID_PRODUCT_GRID_COLUMN_NAME= "IncomeId";
        private const string SOLD_BY_PRODUCT_GRID_COLUMN_NAME = "SoldBy";
        private const string SETTING_ALLOW_USER_VIEW_COST = "AllowUserViewAllCost";
        private const string PURCHASE_RECEIPT_ORDER_ID_COLUMN_NAME ="PurchaseReceiptOrderId";
        
        
        private const string AMOUNT_ORDER_GRID_COLUMN_NAME = "Amount";
        private const string ORIGINAL_PRICE_ORDER_GRID_COLUMN_NAME ="OrigialPrice";

        private const string PURCHASE_ORDER_DATE = "OrderDate";
		private const string PURCHASE_CUST_ID = "CustId";
		private const string PURCHASE_BILL_NUMBER = "BillNumber";
		private const string PURCHASE_IS_COD = "IsCOD";
		private const string PURCHASE_PRODUCT_CODE = "ProductCode";
		private const string PURCHASE_PRODUCT_TYPE = "ProductType";
		private const string PURCHASE_BRAND = "Brand";
		private const string PURCHASE_SIZE = "Size";
		private const string PURCHASE_ORIGINAL_PRICE = "OrigialPrice";
		private const string PURCHASE_QUANTITY = "Quantity";
		private const string PURCHASE_PRICE = "Price";
		private const string PURCHASE_AMOUNT = "Amount";
        private const string PURCHASE_PRODUCT_ID = "ProductId";
		private const string PURCHASE_ORDER_ID = "OrderId";
		private const string PURCHASE_INCOME_ID = "IncomeId";
		private const string PURCHASE_PURCHASE_ID = "PurchaseReceiptOrderId";
		private const string PURCHASE_USER_ID = "UserId";
        private const string PURCHASE_USER_NAME = "UserName";

        private const string Reward_Point_Enable = "RewardPointEnable";
        private const string Reward_Point_Exchange_Rate = "RewardPointExchangeRate";
        private const string Reward_Point_For_Registration = "RewardPointForRegistration";
        private const string Reward_Point_For_Purchase_Each = "RewardPointForPurchaseEach";
        private const string Reward_Point_Earn = "RewardPointEarn";

        private const string NUMBER_FORMAT = "N0";

        public PurchaseReceiptOrderForm()
        {
            InitializeComponent();

            custTableAdapter = new JSManagementDataSetTableAdapters.CustomerTableAdapter();
            custTableAdapter.Connection = CommonHelper.GetSQLConnection();

            purchaseReceiptOrderTableAdapter = new JSManagementDataSetTableAdapters.PurchaseReceiptOrderTableAdapter();
            purchaseReceiptOrderTableAdapter.Connection = CommonHelper.GetSQLConnection();

            orderTableAdapter = new JSManagementDataSetTableAdapters.OrdersTableAdapter();
            orderTableAdapter.Connection = CommonHelper.GetSQLConnection();

            incomeTableAdapter = new JSManagementDataSetTableAdapters.IncomeTableAdapter();
            incomeTableAdapter.Connection = CommonHelper.GetSQLConnection();

            purchaseOrderSumaryTableAdapter = new JSManagementDataSetTableAdapters.PurchaseReceiptOrderSumaryTableAdapter();
            purchaseOrderSumaryTableAdapter.Connection = CommonHelper.GetSQLConnection();

            purchaseOrderDetailTableAdapter = new JSManagementDataSetTableAdapters.PurchaseReceiptOrderDetailTableAdapter();
            purchaseOrderDetailTableAdapter.Connection = CommonHelper.GetSQLConnection();

            userTableAdapter = new JSManagementDataSetTableAdapters.JS_UserTableAdapter();
            userTableAdapter.Connection = CommonHelper.GetSQLConnection();

            rewardPointHistoryTableAdapters = new JSManagementDataSetTableAdapters.RewardPointsHistoryTableAdapter();
            rewardPointHistoryTableAdapters.Connection = CommonHelper.GetSQLConnection();

            this.prnDialog = new System.Windows.Forms.PrintDialog();
            this.prnPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocument = new System.Drawing.Printing.PrintDocument();
            // the Event of 'PrintPage'
            prnDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler
                        (prnDocument_PrintPage);
            this.prnDialogPostOfficeLetter = new System.Windows.Forms.PrintDialog();
            this.prnPreviewPostOfficeLetter = new System.Windows.Forms.PrintPreviewDialog();
            this.prnDocumentPostOfficeLetter = new System.Drawing.Printing.PrintDocument();
            prnDocumentPostOfficeLetter.PrintPage += prnDocumentPostOfficeLetter_PrintPage;
        }

        #region ProductsGridview Event Handler

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
                    TextBox txtProductCodeSearch = proSearchForm.Controls.Find("txtProductCodeSearch", true)[0] as TextBox;
                    txtProductCodeSearch.Text = productCodeSearch;
                    proSearchForm.purchaseReceiptOrderProductGridRowIndex = grvProducts.CurrentCell.RowIndex;
                    proSearchForm.isOpenedByPurchaseReceiptOrder = true;
                    proSearchForm.ShowDialog();
                    
                }

                if (grvProducts.CurrentCell.ColumnIndex == 6)
                {
                    int rowIndex = grvProducts.CurrentCell.RowIndex;
                    int quantity = 0;
                    
                    if (grvProducts.CurrentRow.Cells[5].Value == null)
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                        return;
                    }

                    if (!int.TryParse(grvProducts.CurrentRow.Cells[5].Value.ToString(), out quantity))
                    {
                        MessageBox.Show("Số lượng không hợp lệ!");
                        grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                        return;
                    }

                    if (int.Parse(grvProducts.CurrentRow.Cells[9].Value.ToString()) - quantity < 0)
                    {
                        DialogResult result = MessageBox.Show("Số lượng xuất bán vượt quá lượng tồn! Tiếp tục xuất?", "Xuất quá số lượng tồn", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result == System.Windows.Forms.DialogResult.Cancel)
                        {
                            grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                            return;    
                        }                        
                    }

                    decimal soldPrice = 0;
                    if (grvProducts.CurrentRow.Cells[6].Value == null)
                    {
                        MessageBox.Show("Giá không hợp lệ!");
                        grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                        return;
                    }

                    if (!decimal.TryParse(grvProducts.CurrentRow.Cells[6].Value.ToString(), out soldPrice))
                    {
                        MessageBox.Show("Giá không hợp lệ!");
                        grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                        return;
                    }

                    grvProducts.CurrentRow.Cells[7].Value = quantity * soldPrice;

                    UpdateTotalAmountTextBox();                    
                    
                }
            }
            
        }

        private void grvProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = Color.Aquamarine;
        }

        private void grvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {            
            grvProducts_KeyDown(new object(), new KeyEventArgs(Keys.Tab));
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
            //Int32 rowToDelete = grvProducts.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            try
            {
                if (lbPurchaseReceiptOrderId.Text == "0")
                {
                    if (!grvProducts.Rows[currentMouseOverRow].IsNewRow)
                    {
                        grvProducts.Rows.RemoveAt(currentMouseOverRow);
                        UpdateTotalAmountTextBox();
                        grvProducts.ClearSelection();
                        return;
                    }
                }
                if (lbPurchaseReceiptOrderId.Text != "0")
                {
                    int purchaseReceiptOrderId = int.Parse(lbPurchaseReceiptOrderId.Text);
                    var purchaseReceiptOrder = purchaseReceiptOrderTableAdapter.GetById(purchaseReceiptOrderId);

                    if (purchaseReceiptOrder[0] == null)
                    {
                        MessageBox.Show("Phiếu xuất hàng không tồn tại");
                        return;
                    }

                    if (!CheckActiveDate(purchaseReceiptOrder[0].OrderDate)) return;

                    if (cboxIsCod.Enabled == false)
                    {
                        MessageBox.Show("Phiếu xuất hàng đã có hóa đơn thanh toán, không cho phép xóa sản phẩm!");
                        return;
                    }

                    DialogResult result = MessageBox.Show("Bạn muốn xóa sản phẩm khỏi đơn hàng?", "Xóa sản phẩm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        JSManagementDataSet.IncomeDataTable incomeDataTable = incomeTableAdapter.GetIncomesByPurchaseOrderId(purchaseReceiptOrderId);
                        int orderId = int.Parse(grvProducts.Rows[currentMouseOverRow].Cells[10].Value.ToString());
                        int incomeId = incomeDataTable.Count == 0 ? 0 : incomeDataTable[0].IncomeId;
                        using (TransactionScope tran = new TransactionScope())
                        {                           
                            if (orderTableAdapter.DeleteOrderById(orderId) > 0)
                            {
                                grvProducts.Rows.RemoveAt(currentMouseOverRow);
                                grvProducts.ClearSelection();                         
                            }
                            tran.Complete();
                        }
                        
                        UpdateTotalAmountTextBox();

                        if (incomeId > 0)
                        {
                            incomeTableAdapter.UpdateAmountById(decimal.Parse(txtTotalAmount.Text), LoginInfor.UserName, DateTime.Now.ToString(), incomeId);
                        }
                        MessageBox.Show("Xóa sản phẩm khỏi đơn hàng thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion ProductsGridview Event Handler

        #region Event Handler

        private void btSave_Click(object sender, EventArgs e)
        {            

            if (!ValidateData())
            {
                return;
            }            

            if (lbPurchaseReceiptOrderId.Text == "0")
            {
                if (!CheckActiveDate(dateTimePickerPerchaseReceiptDate.Value)) return;

                DialogResult insertConfirmMessage = MessageBox.Show("Bạn có chắc chắn tạo phiếu xuất hàng?", "Tạo phiếu xuất hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (insertConfirmMessage == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }

                InsertPurchaseReceiptOrder();                
            }
            else
            {
                var purchaseReceiptOrder = purchaseReceiptOrderTableAdapter.GetById(int.Parse(lbPurchaseReceiptOrderId.Text));
                if (!CommonHelper.CheckCurrentDay(purchaseReceiptOrder[0].CreatedDate))
                {
                    MessageBox.Show("Bạn không thể sửa phiếu bán hàng, hãy liên hệ với Admin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                
                if (purchaseReceiptOrder[0] == null)
                {
                    MessageBox.Show("Phiếu xuất hàng không tồn tại");
                    return;
                }

                if (!CheckActiveDate(purchaseReceiptOrder[0].OrderDate)) return;

                DialogResult mesageResult = MessageBox.Show("Bạn có muốn sửa phiếu xuất hàng?", "Sửa phiếu xuất hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (mesageResult == System.Windows.Forms.DialogResult.Cancel)
                    return;
                UpdatePurchaseReceiptOrder();
            }
        }
        
        private void btDelete_Click(object sender, EventArgs e)
        {
            var purchaseReceiptOrder = purchaseReceiptOrderTableAdapter.GetById(int.Parse(lbPurchaseReceiptOrderId.Text));

            if (!CommonHelper.CheckCurrentDay(purchaseReceiptOrder[0].CreatedDate))
            {
                MessageBox.Show("Bạn không thể xóa phiếu bán hàng, hãy liên hệ với Admin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (purchaseReceiptOrder[0] == null)
            {
                MessageBox.Show("Phiếu xuất hàng không tồn tại");
                return;
            }

            if (!CheckActiveDate(purchaseReceiptOrder[0].OrderDate)) return;

            if (!ValidateData())
            {
                return;
            }

            DialogResult mesageResult = MessageBox.Show("Bạn có muốn XÓA phiếu xuất hàng?", "XÓA phiếu xuất hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (mesageResult == System.Windows.Forms.DialogResult.Cancel)
                return;

            DeletePurchaseReceiptOrder();
        }        

        private void btAddNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {
            int custId=0;
            if (string.IsNullOrEmpty(txtCustomerCode.Text))
            {
                lbCustomerInfo.Text = string.Empty;
            }
            else
            {                
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

            if (Setting.GetBoolSetting(Reward_Point_Enable))
            {
                CalcuateRewardPoints(custId);
            }
        }        

        private void cboxIsCod_CheckedChanged(object sender, EventArgs e)
        {
            if (lbPurchaseReceiptOrderId.Text == "0") return;            

            int purchaseReceiptOrderId;
            decimal amount = 0;
            int bankAccountId = 0;            
            if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }

            if (lbPurchaseReceiptOrderId.Text != "0")
            {
                var purchaseReceiptOrder = purchaseReceiptOrderTableAdapter.GetById(int.Parse(lbPurchaseReceiptOrderId.Text));
                if (!LoginInfor.IsAdmin && Setting.GetBoolSetting(Constant.Not_Allow_User_Edit_On_Other_CreatedDate))
                {
                    if (DateTime.Now.ToShortDateString() != purchaseReceiptOrder[0].CreatedDate.ToShortDateString())
                    {
                        MessageBox.Show("Bạn không thể sửa phiếu bán hàng, hãy liên hệ với Admin", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                }

                purchaseReceiptOrderId = int.Parse(lbPurchaseReceiptOrderId.Text);
                CheckBox cboxIsCOD = (CheckBox)sender;
                if (cboxIsCod.Checked)
                {
                    DialogResult mesageResult = MessageBox.Show("Bạn có chắc chắn phiếu này thanh toán sau?", "Sửa phương thức thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (mesageResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        cboxIsCod.Checked = false;
                        return;
                    }

                    using (TransactionScope tran = new TransactionScope())
                    {
                        if (bankAccountId == 0)
                        {
                            purchaseReceiptOrderTableAdapter.UpdateById(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, DateTime.Now, LoginInfor.UserName, null, purchaseReceiptOrderId);
                        }
                        else
                        {
                            purchaseReceiptOrderTableAdapter.UpdateById(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, DateTime.Now, LoginInfor.UserName, bankAccountId, purchaseReceiptOrderId);
                        }

                        JSManagementDataSet.IncomeDataTable incomeData = incomeTableAdapter.GetIncomesByPurchaseOrderId(int.Parse(lbPurchaseReceiptOrderId.Text));

                        for (int i = 0; i < incomeData.Rows.Count; i++)
                        {
                            incomeTableAdapter.DeleteIncomeById(incomeData[i].IncomeId);
                        }                       

                        tran.Complete();
                    }

                }
                if (!cboxIsCod.Checked)
                {
                    DialogResult mesageResult = MessageBox.Show("Bạn có chắc chắn phiếu này đã thanh toán?", "Sửa phương thức thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (mesageResult == System.Windows.Forms.DialogResult.Cancel)
                    {
                        cboxIsCod.Checked = true;
                        return;
                    }
                    using (TransactionScope tran = new TransactionScope())
                    {
                        amount = decimal.Parse(txtTotalAmountPaid.Text);
                        if (bankAccountId == 0)
                        {
                            purchaseReceiptOrderTableAdapter.UpdateById(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, DateTime.Now, LoginInfor.UserName, null, purchaseReceiptOrderId);
                        }
                        else
                        {
                            purchaseReceiptOrderTableAdapter.UpdateById(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, DateTime.Now, LoginInfor.UserName, bankAccountId, purchaseReceiptOrderId);
                        }
                        incomeTableAdapter.InsertIncomeReturnId(dateTimePickerPerchaseReceiptDate.Value, "", string.Format("Mã KH:{0} / {1}", txtCustomerCode.Text, lbCustomerInfo.Text), string.Format("Thu tiền đơn hàng mã số {0}", purchaseReceiptOrderId.ToString()), amount, LoginInfor.UserName, DateTime.Now, LoginInfor.UserName, DateTime.Now, null, null, purchaseReceiptOrderId, null, null);
                        tran.Complete();
                    }
                }
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string paymentMethod = "Tất cả";
            int isCOD = -1;
            if (chkListBox.SelectedItem != null)
                paymentMethod = chkListBox.SelectedItem.ToString();

            if (paymentMethod == "Trả sau / COD")
                isCOD = 1;

            if (paymentMethod == "Trả trước")
                isCOD = 0;

            int custId = 0;
            int.TryParse(txtCustomerCodeFind.Text.Trim(), out custId);

            string outputType = "Tất cả";
            int isReturnSupplier =-1;

            if (checkedListBoxOutputType.SelectedItem != null)
                outputType = checkedListBoxOutputType.SelectedItem.ToString();

            switch (outputType)
            {
                case "Xuất trả": isReturnSupplier = 1;
                    break;
                case "Xuất bán": isReturnSupplier = 0;
                    break;
            }

            
            DateTime startDate = new DateTime(dateTimePickerPurchaseReceiptFromFind.Value.Year, dateTimePickerPurchaseReceiptFromFind.Value.Month, dateTimePickerPurchaseReceiptFromFind.Value.Day);
            DateTime endDate = new DateTime(dateTimePickerPurchaseReceiptToFind.Value.Year, dateTimePickerPurchaseReceiptToFind.Value.Month, dateTimePickerPurchaseReceiptToFind.Value.Day, 23, 59, 59);
            grvPurchaseReceiptOrderSumary.DataSource = purchaseOrderSumaryTableAdapter.GetPurchaseReceiptOrderSumary(startDate, endDate, custId, txtBillNumberFind.Text, isCOD, int.Parse(comboBoxSoldBy.SelectedValue.ToString()),isReturnSupplier);
            RenderPurchaseReceiptOrderGridview(grvPurchaseReceiptOrderSumary);
        }

        private void grvPurchaseReceiptOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
                      
        }
        
        private void btFindCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm custForm = new CustomerForm();
            custForm.isOpenByPurchaseReceiptOrder = true;
            custForm.StartPosition = FormStartPosition.CenterScreen;
            custForm.ShowDialog();
        }

        private void btFindCustomerFind_Click(object sender, EventArgs e)
        {
            CustomerForm custForm = new CustomerForm();
            custForm.isOpenByPurchaseReceiptOrderFind = true;
            custForm.StartPosition = FormStartPosition.CenterScreen;
            custForm.ShowDialog();
        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < chkListBox.Items.Count; ++ix)
                {
                    if (e.Index != ix) chkListBox.SetItemChecked(ix, false);
                }
            }
        }

        private void grvPurchaseReceiptOrderDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grvPurchaseReceiptOrderSumary.Rows[e.RowIndex];
            if (row.IsNewRow) return;
            int purchaseReceiptOrderId = int.Parse(row.Cells["PurchaseReceiptOrderId"].Value.ToString());
            BindDataToEdit(purchaseReceiptOrderId);       
        }

        private void dateTimePickerPerchaseReceiptDate_ValueChanged(object sender, EventArgs e)
        {
            if (!LoginInfor.IsAdmin)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePickerPerchaseReceiptDate.Value.ToShortDateString()))
                    {
                        btSave.Enabled = false;
                        btDelete.Enabled = false;                       
                        //MessageBox.Show("Ngày nhập chưa được kích hoạt, liên hệ ADMIN!");
                        return;
                    }
                }
                btSave.Enabled = true;
                btDelete.Enabled = true;                
            }

            if (Setting.GetBoolSetting(Reward_Point_Enable))
            {
                int custId = 0;
                if (int.TryParse(txtCustomerCode.Text, out custId))
                {
                    CalcuateRewardPoints(custId);
                }
            }
        }                
        #endregion Event Handler

        #region CRUD

        private void UpdatePurchaseReceiptOrder()
        {
            int purchaseReceiptOrderId = int.Parse(lbPurchaseReceiptOrderId.Text);            
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    int orderId;
                    int productId;
                    string size;
                    int quantity;
                    decimal soldPrice;
                    int incomeIds = 0;
                    decimal amount = 0;
                    int soldBy;
                    int bankAccountId = 0;                  
                    if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
                    {
                        bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
                    }

                    JSManagementDataSet.IncomeDataTable incomeDataTable = incomeTableAdapter.GetIncomesByPurchaseOrderId(purchaseReceiptOrderId);
                    incomeIds = incomeDataTable.Count == 0 ? 0 : incomeDataTable[0].IncomeId;

                    if (cboxIsCod.Checked && incomeIds != 0)
                    {
                        MessageBox.Show("Đã có phiếu thu, không được phép sửa!");
                        return;
                    }

                    if (bankAccountId == 0)
                    {
                        purchaseReceiptOrderTableAdapter.UpdateById(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, DateTime.Now, LoginInfor.UserName, null, purchaseReceiptOrderId);
                    }
                    else
                    {
                        purchaseReceiptOrderTableAdapter.UpdateById(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, DateTime.Now, LoginInfor.UserName, bankAccountId, purchaseReceiptOrderId);
                    }
                    
                    foreach (DataGridViewRow row in grvProducts.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            orderId = row.Cells[ORDER_ID_PRODUCT_GRID_COLUMN_NAME].Value == null ? 0 : int.Parse(row.Cells[ORDER_ID_PRODUCT_GRID_COLUMN_NAME].Value.ToString());
                            quantity = int.Parse(row.Cells[QUANTITY_PRODUCT_GRID_COLUMN_NAME].Value.ToString());
                            size = row.Cells[SIZE_PRODUCT_GRID_COLUMN_NAME].Value.ToString();
                            productId = int.Parse(row.Cells[PRODUCT_ID_PRODUCT_GRID_COLUMN_NAME].Value.ToString());
                            soldPrice = decimal.Parse(row.Cells[SOLD_PRICE_PRODUCT_GRID_COLUMN_NAME].Value.ToString());
                            soldBy = int.Parse(row.Cells[SOLD_BY].Value.ToString());

                            if (orderId != 0)
                            {
                                orderTableAdapter.UpdateOrderById(dateTimePickerPerchaseReceiptDate.Text, int.Parse(txtCustomerCode.Text), productId, size, quantity, soldPrice, txtBillNumber.Text, cboxIsCod.Checked, soldBy, orderId);
                            }

                            if (orderId == 0)
                            {
                                object orderIdReturn = orderTableAdapter.InsertReturnId(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), productId, size, quantity, soldPrice, txtBillNumber.Text, cboxIsCod.Checked, purchaseReceiptOrderId, soldBy);
                            }

                            if (!cboxIsCod.Checked && !checkBoxProductReturn.Checked)
                            {
                                amount += soldPrice * quantity;
                            }
                        }
                    }

                    if (Setting.GetBoolSetting(Reward_Point_Enable))
                    {
                        UpdateRewardPointEarn(int.Parse(txtCustomerCode.Text), purchaseReceiptOrderId);
                    }


                    decimal rewardPointForPurchaseEach = Setting.GetDecimalSetting(Reward_Point_For_Purchase_Each);
                    int rewardPointEarnSetting = Setting.GetIntergerSetting(Reward_Point_Earn);
                    int usedRewardPoint = 0;
                    decimal usedAmountRewardPoint = 0;                  

                    if (int.Parse(lbAvaiableRewardPoint.Text) > 0)
                    {
                        usedRewardPoint = int.Parse(lbAvaiableRewardPoint.Text);
                        usedAmountRewardPoint = usedRewardPoint * Setting.GetDecimalSetting(Reward_Point_Exchange_Rate);                       
                    }

                    if (!cboxIsCod.Checked && !checkBoxProductReturn.Checked)
                    {
                        if (incomeIds == 0)
                        {
                            incomeTableAdapter.InsertIncomeReturnId(dateTimePickerPerchaseReceiptDate.Value, "", string.Format("Mã KH:{0} / {1}", txtCustomerCode.Text, lbCustomerInfo.Text), string.Format("Thu tiền đơn hàng mã số {0}", purchaseReceiptOrderId.ToString()), amount - usedAmountRewardPoint, LoginInfor.UserName, DateTime.Now, LoginInfor.UserName, DateTime.Now, null, null, purchaseReceiptOrderId,null,null);
                        }
                        else
                        {
                            incomeTableAdapter.UpdateIncomeById(dateTimePickerPerchaseReceiptDate.Value, "", string.Format("Mã KH:{0} / {1}", txtCustomerCode.Text, lbCustomerInfo.Text), string.Format("Thu tiền đơn hàng mã số {0}", purchaseReceiptOrderId.ToString()), amount - usedAmountRewardPoint, LoginInfor.UserName, DateTime.Now, null, null, incomeIds, purchaseReceiptOrderId, null, null);
                        }
                    }
                    tran.Complete();
                }

                DialogResult measageResult = MessageBox.Show("Sửa phiếu xuất hàng thành công! Bạn có muốn tiếp tục xuất hàng?", "Tiếp tục xuất hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (measageResult == System.Windows.Forms.DialogResult.OK)
                {
                    ClearData();
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }          

        private void InsertPurchaseReceiptOrder()
        {
            int purchaseReceiptOrderId;
            DateTime createdDate = DateTime.Now;
            DateTime lastEditedDate = DateTime.Now;
            string createdBy = LoginInfor.UserName;
            string lastEditedBy = LoginInfor.UserName;
            int bankAccountId=0;
            object result;
            if (cboxPaymentMethod.SelectedItem.ToString() == Constant.PaymentMethod.BANK_TRANSFER)
            {
                bankAccountId = int.Parse(cboxBankAccount.SelectedValue.ToString());
            }
            using (TransactionScope tran = new TransactionScope())
            {
                if (bankAccountId == 0)
                {
                    result = purchaseReceiptOrderTableAdapter.InsertReturnId(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, createdDate, createdBy, lastEditedDate, lastEditedBy, null);
                }
                else
                {
                    result = purchaseReceiptOrderTableAdapter.InsertReturnId(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), txtBillNumber.Text, cboxIsCod.Checked, txtOrderNote.Text, checkBoxProductReturn.Checked, createdDate, createdBy, lastEditedDate, lastEditedBy, bankAccountId);
                }
                
                if (result == null)
                    return;
                if (result.ToString() == "0")
                    return;                
                decimal amount = 0;
                if (int.TryParse(result.ToString(), out purchaseReceiptOrderId))
                {
                    int productId;
                    string size;
                    int quantity;
                    decimal soldPrice;
                    int soldBy;
                    
                    foreach (DataGridViewRow row in grvProducts.Rows)
                    {
                        if (row != grvProducts.Rows[grvProducts.Rows.Count - 1])
                        {
                            quantity = int.Parse(row.Cells[5].Value.ToString());
                            size = row.Cells[3].Value.ToString();
                            productId = int.Parse(row.Cells[8].Value.ToString());
                            soldPrice = decimal.Parse(row.Cells[6].Value.ToString());
                            soldBy = int.Parse(row.Cells[SOLD_BY].Value.ToString());
                            object orderId = orderTableAdapter.InsertReturnId(dateTimePickerPerchaseReceiptDate.Value, int.Parse(txtCustomerCode.Text), productId, size, quantity, soldPrice, txtBillNumber.Text, cboxIsCod.Checked, purchaseReceiptOrderId, soldBy);
                            if (!cboxIsCod.Checked && !checkBoxProductReturn.Checked)
                                amount += soldPrice * quantity;
                                
                        }
                    }
                }

                decimal usedAmountRewardPoint = 0;
                if (cboxIsRewardPointUse.Checked && !checkBoxProductReturn.Checked)
                {
                    usedAmountRewardPoint = InsertRewardPointUsed(int.Parse(txtCustomerCode.Text), purchaseReceiptOrderId);
                }

                if (Setting.GetBoolSetting(Reward_Point_Enable) && !checkBoxProductReturn.Checked)
                {
                    InsertRewardPointEarn(int.Parse(txtCustomerCode.Text), purchaseReceiptOrderId);
                }

                if (!cboxIsCod.Checked && !checkBoxProductReturn.Checked)
                {
                    incomeTableAdapter.InsertIncomeReturnId(dateTimePickerPerchaseReceiptDate.Value, "", string.Format("Mã KH:{0} / {1}", txtCustomerCode.Text, lbCustomerInfo.Text), string.Format("Thu tiền đơn hàng mã số {0}", purchaseReceiptOrderId.ToString()), amount - usedAmountRewardPoint, LoginInfor.UserName, DateTime.Now, LoginInfor.UserName, DateTime.Now, null, null, purchaseReceiptOrderId,null,null);
                }

                tran.Complete();
                            
            }

            BindDataToEdit(purchaseReceiptOrderId);

            PurchaseOrderMessageBoxForm purchaseOrderMessageBoxForm = new PurchaseOrderMessageBoxForm();
            purchaseOrderMessageBoxForm.StartPosition = FormStartPosition.CenterScreen;
            purchaseOrderMessageBoxForm.ShowDialog();

            if (purchaseOrderMessageBoxForm.MessageBoxResult == PurchaseOrderDialogResult.PrintBill)
            { 
                btPrint_Click(new object(), new EventArgs());
                return;
            }
            
            if(purchaseOrderMessageBoxForm.MessageBoxResult == PurchaseOrderDialogResult.PrintPostOfficeLeter)
            {
                btPrintPostOfficeLetter_Click(new object(),new EventArgs());
                return;
            }

            if(purchaseOrderMessageBoxForm.MessageBoxResult == PurchaseOrderDialogResult.CreateOtherPurchaseOrder)
            {
                ClearData();
                return;
            }

            //DialogResult measageResult = MessageBox.Show("Tạo phiếu xuất hàng thành công! Bạn có muốn tiếp tục xuất hàng?", "Tiếp tục xuất hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            //if (measageResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    ClearData();
            //    return;
            //}
                         
        }
        
        private void DeletePurchaseReceiptOrder()
        {
            int purchaseReceiptOrderId = int.Parse(lbPurchaseReceiptOrderId.Text);
            
            using (TransactionScope tran = new TransactionScope())
            {
                JSManagementDataSet.IncomeDataTable incomeDataTable = incomeTableAdapter.GetIncomesByPurchaseOrderId(purchaseReceiptOrderId);
                int orderId;
                int incomeId = incomeDataTable.Count == 0 ? 0 : incomeDataTable[0].IncomeId;
                bool isPaid = false;
                foreach (DataGridViewRow row in grvProducts.Rows)
                {
                    if (row != grvProducts.Rows[grvProducts.Rows.Count - 1])
                    {
                        
                        if (incomeId > 0)
                        {
                            isPaid = true;
                        }
                    }
                }

                foreach (DataGridViewRow row in grvProducts.Rows)
                {
                    if (row != grvProducts.Rows[grvProducts.Rows.Count - 1])
                    {
                        orderId = int.Parse(row.Cells[10].Value.ToString());                            
                        

                        if (orderId > 0)
                        {
                            if (!cboxIsCod.Checked)
                            {
                                incomeTableAdapter.DeleteIncomeById(incomeId);
                                orderTableAdapter.DeleteOrderById(orderId);
                            }
                            else
                            {
                                if (isPaid)
                                {
                                    MessageBox.Show("Đơn hàng này đã có phiếu thu, bạn không thể xóa");                                    
                                    return;
                                }
                                else
                                {
                                    orderTableAdapter.DeleteOrderById(orderId);
                                }
                            }
                        }                  
                    }
                }

                
                DeleteRewardPoint(int.Parse(txtCustomerCode.Text), purchaseReceiptOrderId);                

                purchaseReceiptOrderTableAdapter.DeleteById(purchaseReceiptOrderId);
                tran.Complete();                
            }
            MessageBox.Show("Xóa phiếu xuất hàng thành công!");
            ClearData();            
        }                

        #endregion CRUD

        #region Ultility

        private void ClearData()
        {
            lbPerchaseReceiptOrderHeader.Text = "Xuất hàng".ToUpper();
            lbCustomerInfo.Text = string.Empty;
            txtCustomerCode.Text = string.Empty;
            lbPurchaseReceiptOrderId.Text = "0";
            txtBillNumber.Text = string.Empty;
            cboxIsCod.Checked = false;
            grvProducts.Rows.Clear();            
            cboxIsCod.Enabled = true;
            txtTotalAmount.Text = "0";
            checkBoxProductReturn.Checked = false;
            txtOrderNote.Text = string.Empty;
            dateTimePickerPerchaseReceiptDate.Value = DateTime.Now;
            lbAvaiableRewardPoint.Text = "0";
            lbPointsBalanceAmount.Text = "0";
            checkBoxProductReturn.Checked = false;
            cboxIsRewardPointUse.Enabled = true;
            cboxIsRewardPointUse.Checked = false;
            cboxIsCod.CheckedChanged -= cboxIsCod_CheckedChanged;
            cboxPaymentMethod.SelectedItem = "Tiền mặt";
            cboxBankAccount.Visible = false;
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

        private bool ValidateData()
        {
            if (txtCustomerCode.Text == string.Empty)
            {
                MessageBox.Show("Thông tin khách hàng không hợp lệ!");
                return false;
            }

            if (!ValidateProducts())
            {
               // MessageBox.Show("Thông tin sản phẩm không hợp lệ!");
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
                if (grvProducts.Rows[0].Cells[5].Value == null)
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    grvProducts.Rows[0].Cells[7].Value = string.Empty;
                    return false;
                }

                if (!int.TryParse(grvProducts.Rows[0].Cells[5].Value.ToString(), out quantity))
                {
                    MessageBox.Show("Số lượng không hợp lệ!");
                    grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                    return false;
                }

                if (int.Parse(grvProducts.Rows[0].Cells[9].Value.ToString()) - quantity < 0)
                {
                    DialogResult result = MessageBox.Show("Số lượng xuất bán vượt quá lượng tồn! Tiếp tục xuất?", "Xuất quá số lượng tồn", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                        return false;
                    }
                }
                //Validate Sold Price
                decimal soldPrice = 0;
                if (grvProducts.Rows[0].Cells[6].Value == null)
                {
                    MessageBox.Show("Giá không hợp lệ!");
                    grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                    return false;
                }

                if (!decimal.TryParse(grvProducts.Rows[0].Cells[6].Value.ToString(), out soldPrice))
                {
                    MessageBox.Show("Giá không hợp lệ!");
                    grvProducts.Rows[0].Cells[7].Value = string.Empty;
                    return false;
                }

                if (grvProducts.Rows[0].Cells[SOLD_BY].Value == null)
                {
                    MessageBox.Show("Bạn hãy nhập người bán!");
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
                        if (row.Cells[5].Value == null)
                        {
                            MessageBox.Show("Số lượng không hợp lệ!");
                            row.Cells[7].Value = string.Empty;
                            return false;
                        }

                        if (!int.TryParse(row.Cells[5].Value.ToString(), out quantity))
                        {
                            MessageBox.Show("Số lượng không hợp lệ!");
                            grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                            return false;
                        }

                        if (int.Parse(row.Cells[9].Value.ToString()) - quantity < 0)
                        {
                            DialogResult result = MessageBox.Show("Số lượng xuất bán vượt quá lượng tồn! Tiếp tục xuất?", "Xuất quá số lượng tồn", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == System.Windows.Forms.DialogResult.Cancel)
                            {
                                grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                                return false;
                            }
                        }
                        //Validate Sold Price
                        decimal soldPrice = 0;
                        if (row.Cells[6].Value == null)
                        {
                            MessageBox.Show("Giá không hợp lệ!");
                            grvProducts.CurrentRow.Cells[7].Value = string.Empty;
                            return false;
                        }

                        if (!decimal.TryParse(row.Cells[6].Value.ToString(), out soldPrice))
                        {
                            MessageBox.Show("Giá không hợp lệ!");
                            row.Cells[7].Value = string.Empty;
                            return false;
                        }

                        DataGridViewComboBoxCell cboxSoldBy = row.Cells[SOLD_BY] as DataGridViewComboBoxCell;
                        if (cboxSoldBy.Value == null)
                        {
                            MessageBox.Show("Bạn hãy nhập người bán!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void RenderPurchaseReceiptOrderGridview(DataGridView grvPurchaseReceiptOrderSumary)
        {
            //int soldById = 0;
            //int purchaseReceiptOrderId = 0;
            //bool isReturnSuppiler = false;
            //decimal totalAmount = decimal.Parse( grvPurchaseReceiptOrderSumary.Rows[0].Cells[AMOUNT_ORDER_GRID_COLUMN_NAME].Value.ToString());
            //decimal totalPoitsUsedAmount = 0;
            
            //DataGridViewTextBoxCell soldByCell = new DataGridViewTextBoxCell();
            //DataGridViewColumn soldByColumn = new DataGridViewColumn(soldByCell);
            //soldByColumn.Name = PURCHASE_USER_NAME;

            //if (grvPurchaseReceiptOrderSumary.Columns[PURCHASE_USER_NAME]==null)
            //grvPurchaseReceiptOrderSumary.Columns.Add(soldByColumn);

            //List<int> ListPurchaseReceiptOrderId = new List<int>();
            //foreach (DataGridViewRow row in grvPurchaseReceiptOrderSumary.Rows)
            //{
            //    if (!row.IsNewRow)
            //    {
            //        purchaseReceiptOrderId = int.Parse(row.Cells[PURCHASE_RECEIPT_ORDER_ID_COLUMN_NAME].Value.ToString());                   

            //        if (purchaseReceiptOrderId != 0)
            //        {                        
            //            isReturnSuppiler = purchaseReceiptOrderTableAdapter.GetById(purchaseReceiptOrderId)[0].IsReturnSupplier;
            //            soldById = int.Parse(row.Cells[PURCHASE_USER_ID].Value.ToString());
            //            row.Cells[PURCHASE_USER_NAME].Value = userTableAdapter.GetDataById(soldById)[0].UserName;

            //            if (isReturnSuppiler && !LoginInfor.IsAdmin)
            //            {
            //                if (Setting.GetBoolSetting(SETTING_ALLOW_USER_VIEW_COST) == false)
            //                {
            //                    row.Cells[PRICE_ORDER_GRID_COLUMN_NAME].Value = 0;
            //                    totalAmount -= decimal.Parse(row.Cells[AMOUNT_ORDER_GRID_COLUMN_NAME].Value.ToString());
            //                    row.Cells[AMOUNT_ORDER_GRID_COLUMN_NAME].Value = 0;                                
            //                }
            //            }
            //        }
            //        if (purchaseReceiptOrderId != 0)
            //        {
            //            if (!ListPurchaseReceiptOrderId.Contains(purchaseReceiptOrderId))
            //            {
            //                ListPurchaseReceiptOrderId.Add(purchaseReceiptOrderId);
            //            }
            //        }
                    
            //    }
            //}

            //foreach (int p in ListPurchaseReceiptOrderId)
            //{
            //    if (rewardPointHistoryTableAdapters.GetRewardPointsUsedByPurchaseReceiptOrderId(p).Rows.Count > 0)
            //    {
            //        decimal poitsUsedAmount = rewardPointHistoryTableAdapters.GetRewardPointsUsedByPurchaseReceiptOrderId(p)[0].UsedAmount;
            //        totalPoitsUsedAmount += poitsUsedAmount;
            //        totalAmount -= poitsUsedAmount;
            //    }
            //}

            
            grvPurchaseReceiptOrderSumary.Columns["OrderDate"].HeaderText = Constant.PurchaseReceiptOrder_OrderDate;
            grvPurchaseReceiptOrderSumary.Columns["CustId"].HeaderText = Constant.PurchaseReceiptOrder_CustId;
            grvPurchaseReceiptOrderSumary.Columns["BillNumber"].HeaderText = Constant.PurchaseReceiptOrder_BillNumber;
            grvPurchaseReceiptOrderSumary.Columns["IsCOD"].HeaderText = Constant.PurchaseReceiptOrder_IsCOD;            
            grvPurchaseReceiptOrderSumary.Columns[ORIGINAL_PRICE_ORDER_GRID_COLUMN_NAME].HeaderText = Constant.PurchaseReceiptOrder_OriginalPrice;
            grvPurchaseReceiptOrderSumary.Columns[ORIGINAL_PRICE_ORDER_GRID_COLUMN_NAME].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvPurchaseReceiptOrderSumary.Columns["Quantity"].HeaderText = Constant.PurchaseReceiptOrder_Quantity;
            grvPurchaseReceiptOrderSumary.Columns["Discount"].HeaderText = Constant.PurchaseReceiptOrder_Discount;
            grvPurchaseReceiptOrderSumary.Columns["Discount"].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvPurchaseReceiptOrderSumary.Columns["UsedAmount"].HeaderText = Constant.PurchaseReceiptOrder_UsedAmount;
            grvPurchaseReceiptOrderSumary.Columns["UsedAmount"].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvPurchaseReceiptOrderSumary.Columns[AMOUNT_ORDER_GRID_COLUMN_NAME].HeaderText = Constant.PurchaseReceiptOrder_Amount;
            grvPurchaseReceiptOrderSumary.Columns[AMOUNT_ORDER_GRID_COLUMN_NAME].DefaultCellStyle.Format = NUMBER_FORMAT;
            grvPurchaseReceiptOrderSumary.Columns[PURCHASE_USER_NAME].HeaderText = Constant.PurchaseReceiptOrder_SoldBy;
            grvPurchaseReceiptOrderSumary.Columns["PurchaseReceiptOrderId"].Visible = false;
            grvPurchaseReceiptOrderSumary.Columns[PURCHASE_USER_ID].Visible = false;
            
        }      

        private void BindDataToEdit(int purchaseReceiptOrderId)
        {
            if (purchaseReceiptOrderId == 0)
                return;

            ClearData();
            cboxIsCod.CheckedChanged-=cboxIsCod_CheckedChanged;

            JSManagementDataSet.PurchaseReceiptOrderDataTable purchaseReceiptOrderData = purchaseReceiptOrderTableAdapter.GetById(purchaseReceiptOrderId);

            if (purchaseReceiptOrderData.Rows.Count == 0) return;

            DateTime orderDate = purchaseReceiptOrderData[0].OrderDate;
            string custId = purchaseReceiptOrderData[0].CustId.ToString();
            string billNumber = purchaseReceiptOrderData[0].BillNumber.ToString();
            bool isCOD = purchaseReceiptOrderData[0].IsCOD;
            decimal soldPrice = 0;
            decimal amount = 0;
            int quantity = 0;
            int bankAccountId=0;
            bool isReturnToSupplier = purchaseReceiptOrderData[0].IsReturnSupplier;

            lbPerchaseReceiptOrderHeader.Text = Constant.PurchaseReceiptOrder_Header.ToUpper();
            lbPurchaseReceiptOrderId.Text = purchaseReceiptOrderId.ToString();
            dateTimePickerPerchaseReceiptDate.Value = orderDate;
            txtCustomerCode.Text = custId;
            txtBillNumber.Text = billNumber;
            cboxIsCod.Checked = isCOD;
            cboxIsCod.Enabled = true;
            txtOrderNote.Text = purchaseReceiptOrderData[0].OrderNote;
            checkBoxProductReturn.Checked = purchaseReceiptOrderData[0].IsReturnSupplier;

            bankAccountId = purchaseReceiptOrderData[0].BankAccountId;          
            if (bankAccountId != 0)
            {
                cboxPaymentMethod.SelectedItem = Constant.PaymentMethod.BANK_TRANSFER;
                cboxBankAccount.SelectedValue = bankAccountId;
            }


            if (!LoginInfor.IsAdmin)
            {
                if (Setting.GetBoolSetting("ActiveDateEnabled") == true)
                {
                    if (!CommonHelper.GetActiveDates().Contains(dateTimePickerPerchaseReceiptDate.Value.ToShortDateString()))
                    {
                        cboxIsCod.Enabled = false;
                    }
                }
                else
                {
                    cboxIsCod.Enabled = true;
                }
            }

            

            JSManagementDataSet.PurchaseReceiptOrderDetailDataTable purchaseReceiptOrderDetailTable = purchaseOrderDetailTableAdapter.GetPurchaseReceiptOrderById(purchaseReceiptOrderId);
            JSManagementDataSetTableAdapters.ProductTableAdapter productTableAdapter = new JSManagementDataSetTableAdapters.ProductTableAdapter();
            productTableAdapter.Connection = CommonHelper.GetSQLConnection();

            for (int i = 0; i < purchaseReceiptOrderDetailTable.Rows.Count; i++)
            {
                grvProducts.Rows.Add(1);
                int productId = purchaseReceiptOrderDetailTable[i].ProductId;

                if (productTableAdapter.GetProductById(productId).Rows.Count > 0)
                {
                    grvProducts.Rows[i].Cells[PRODUCT_CODE_PRODUCT_GRID_COLUMN_NAME].Value = productTableAdapter.GetProductById(productId)[0].ProductCode;
                    grvProducts.Rows[i].Cells[PRODUCT_TYPE_PRODUCT_GRID_COLUMN_NAME].Value = productTableAdapter.GetProductById(productId)[0].ProductType;
                    grvProducts.Rows[i].Cells[BRAND_PRODUCT_GRID_COLUMN_NAME].Value = productTableAdapter.GetProductById(productId)[0].Brand;
                    grvProducts.Rows[i].Cells[SIZE_PRODUCT_GRID_COLUMN_NAME].Value = productTableAdapter.GetProductById(productId)[0].Size;
                    grvProducts.Rows[i].Cells[PRICE_PRODUCT_GRID_COLUMN_NAME].Value = productTableAdapter.GetProductById(productId)[0].Price;
                    grvProducts.Rows[i].Cells[QUANTITY_PRODUCT_GRID_COLUMN_NAME].Value = purchaseReceiptOrderDetailTable[i].Quantity;

                    quantity = int.Parse(grvProducts.Rows[i].Cells[QUANTITY_PRODUCT_GRID_COLUMN_NAME].Value.ToString());
                    soldPrice = purchaseReceiptOrderDetailTable[i].Price;
                    amount = decimal.Parse((quantity * soldPrice).ToString());
                    if (purchaseReceiptOrderData[0].IsReturnSupplier && !LoginInfor.IsAdmin)
                    {
                        if (!Setting.GetBoolSetting(SETTING_ALLOW_USER_VIEW_COST))
                        {
                            soldPrice = 0;
                            amount = 0;
                        }
                    }

                    grvProducts.Rows[i].Cells[SOLD_PRICE_PRODUCT_GRID_COLUMN_NAME].Value = soldPrice;
                    grvProducts.Rows[i].Cells[AMOUNT_PRODUCT_GRID_COLUMN_NAME].Value = amount;
                    grvProducts.Rows[i].Cells[PRODUCT_ID_PRODUCT_GRID_COLUMN_NAME].Value = purchaseReceiptOrderDetailTable[i].ProductId;
                    grvProducts.Rows[i].Cells[CLOSING_BALLANCE_PRODUCT_GRID_COLUMN_NAME].Value = productTableAdapter.GetProductById(productId)[0].ClosingBalance + purchaseReceiptOrderDetailTable[i].Quantity;
                    grvProducts.Rows[i].Cells[ORDER_ID_PRODUCT_GRID_COLUMN_NAME].Value = purchaseReceiptOrderDetailTable[i].OrderId;
                    DataGridViewComboBoxCell cboxSoldBy = grvProducts.Rows[i].Cells[SOLD_BY] as DataGridViewComboBoxCell;
                    cboxSoldBy.DisplayMember = USER_NAME;
                    cboxSoldBy.ValueMember = USER_ID;
                    cboxSoldBy.Value = userTableAdapter.GetDataById(int.Parse(purchaseReceiptOrderDetailTable[i].UserId))[0].UserId;

                }

            }

            if (incomeTableAdapter.GetIncomesByPurchaseOrderId(purchaseReceiptOrderId).Count > 0)
            {
                if (incomeTableAdapter.GetIncomesByPurchaseOrderId(purchaseReceiptOrderId)[0].IncomeNumber != string.Empty)
                {
                    cboxIsCod.Enabled = false;
                }
            }
            UpdateTotalAmountTextBox();
            cboxIsCod.CheckedChanged += cboxIsCod_CheckedChanged;
        }

        

        private void UpdateTotalAmountTextBox()
        {
            decimal totalAmount = 0;
            for (int i = 0; i < grvProducts.Rows.Count; i++)
            {
                if (grvProducts.Rows[i].Cells[7].Value != null)
                    totalAmount += decimal.Parse(grvProducts.Rows[i].Cells[7].Value.ToString());
            }
            txtTotalAmount.Text = totalAmount.ToString("#,###") == string.Empty ? "0" : totalAmount.ToString("#,###");
        }

        private decimal InsertRewardPointUsed(int custId, int purchaseOrderId)
        {
            RewardPointReturn r = new RewardPointReturn();
            //decimal totalAmount = decimal.Parse(txtTotalAmount.Text);

            decimal rewardPointForPurchaseEach = Setting.GetDecimalSetting(Reward_Point_For_Purchase_Each);
            int rewardPointEarnSetting = Setting.GetIntergerSetting(Reward_Point_Earn);            
            int usedRewardPoint = 0;
            decimal usedAmount = 0;
            
            DateTime createdOn = DateTime.Now;

            if (int.Parse(lbAvaiableRewardPoint.Text) > 0)
            {
                usedRewardPoint = int.Parse(lbAvaiableRewardPoint.Text);
                usedAmount = usedRewardPoint * Setting.GetDecimalSetting(Reward_Point_Exchange_Rate);
                string message = string.Format("Sử dụng điểm thưởng cho đơn hàng #{0}", purchaseOrderId);                
                rewardPointHistoryTableAdapters.Insert(custId, purchaseOrderId, -usedRewardPoint, 0, usedAmount, message, createdOn);
            }
            System.Threading.Thread.Sleep(1000);
            return usedAmount;
        }

        private void InsertRewardPointEarn(int custId, int purchaseReceiptOrderId)
        {
            decimal totalAmountPaid = decimal.Parse(txtTotalAmountPaid.Text);
            decimal rewardPointForPurchaseEachSetting = Setting.GetDecimalSetting(Reward_Point_For_Purchase_Each);
            int rewardPointEarnSetting = Setting.GetIntergerSetting(Reward_Point_Earn);
            int rewardPointEarn = int.Parse(Math.Floor(totalAmountPaid / rewardPointForPurchaseEachSetting).ToString()) * rewardPointEarnSetting;
            int pointsBallance = 0;

            if (rewardPointHistoryTableAdapters.GetRewardPointsBalances(custId, DateTime.Now).Rows.Count > 0)
            {
                pointsBallance = rewardPointHistoryTableAdapters.GetRewardPointsBalances(custId, DateTime.Now)[0].PointsBalance;
            }
            string message = string.Format("Thưởng điểm cho đơn hàng #{0}", purchaseReceiptOrderId);
            rewardPointHistoryTableAdapters.Insert(custId, purchaseReceiptOrderId, rewardPointEarn, rewardPointEarn + pointsBallance, 0, message, DateTime.Now);

        }

        private void UpdateRewardPointEarn(int custId, int purchaseReceiptOrderId)
        {
            decimal totalAmount = decimal.Parse(txtTotalAmount.Text);
            decimal rewardPointForPurchaseEachSetting = Setting.GetDecimalSetting(Reward_Point_For_Purchase_Each);
            int rewardPointEarnSetting = Setting.GetIntergerSetting(Reward_Point_Earn);
            int rewardPointEarn = int.Parse(Math.Floor(totalAmount / rewardPointForPurchaseEachSetting).ToString()) * rewardPointEarnSetting;
            int pointsBallance = 0;
            int rewardPointAdjusts = 0;
            string message = string.Format("Thưởng điểm cho đơn hàng #{0}", purchaseReceiptOrderId);

            if (rewardPointHistoryTableAdapters.GetRewardPointsEarningByPurchaseReceiptOrderId(purchaseReceiptOrderId).Rows.Count > 0)
            {
                int rewardpointsHistoryId = rewardPointHistoryTableAdapters.GetRewardPointsEarningByPurchaseReceiptOrderId(purchaseReceiptOrderId)[0].RewardPointsHistoryID;
                int rewardPointEarnOld = rewardPointHistoryTableAdapters.GetRewardPointsEarningByPurchaseReceiptOrderId(purchaseReceiptOrderId)[0].Points;
                pointsBallance = rewardPointHistoryTableAdapters.GetRewardPointsEarningByPurchaseReceiptOrderId(purchaseReceiptOrderId)[0].PointsBalance;
                rewardPointAdjusts = rewardPointEarn - rewardPointEarnOld;
                rewardPointHistoryTableAdapters.UpdateRewardPointsInfoById(rewardPointEarn, pointsBallance + rewardPointAdjusts, 0, rewardpointsHistoryId);
            }
            else
            {
                rewardPointHistoryTableAdapters.Insert(custId, purchaseReceiptOrderId, rewardPointEarn, rewardPointEarn, 0, message, DateTime.Now);
            }

            JSManagementDataSet.RewardPointsHistoryDataTable continueRewardPointsHistoryData = rewardPointHistoryTableAdapters.GetContinueRewardPointHistoryByCustomerId(purchaseReceiptOrderId, custId);
            for (int i = 0; i < continueRewardPointsHistoryData.Rows.Count; i++)
            {
                pointsBallance = continueRewardPointsHistoryData[i].PointsBalance;
                int rewardPointHistoryId = continueRewardPointsHistoryData[i].RewardPointsHistoryID;
                rewardPointHistoryTableAdapters.UpdatePointsBalanceById(pointsBallance + rewardPointAdjusts, rewardPointHistoryId);
            }
        }

        private void DeleteRewardPoint(int custId, int purchaseReceiptOrderId)
        {
            //Delete reward point used
            int rewardpointUsed = 0;
            int rewardpointEarned = 0;
            int pointsBallance = 0;
            if (rewardPointHistoryTableAdapters.GetRewardPointsUsedByPurchaseReceiptOrderId(purchaseReceiptOrderId).Rows.Count > 0)
            {
                rewardpointUsed = rewardPointHistoryTableAdapters.GetRewardPointsUsedByPurchaseReceiptOrderId(purchaseReceiptOrderId)[0].Points;
                
            }
            //Delete reward point earn
            if (rewardPointHistoryTableAdapters.GetRewardPointsEarningByPurchaseReceiptOrderId(purchaseReceiptOrderId).Rows.Count >0)
            {
                rewardpointEarned = rewardPointHistoryTableAdapters.GetRewardPointsEarningByPurchaseReceiptOrderId(purchaseReceiptOrderId)[0].Points;
            }

            rewardPointHistoryTableAdapters.DeleteByPurchaseReceiptOrderId(purchaseReceiptOrderId);
            JSManagementDataSet.RewardPointsHistoryDataTable continueRewardPointsHistoryData = rewardPointHistoryTableAdapters.GetContinueRewardPointHistoryByCustomerId(purchaseReceiptOrderId, custId);
            for (int i = 0; i < continueRewardPointsHistoryData.Rows.Count; i++)
            {
                pointsBallance = continueRewardPointsHistoryData[i].PointsBalance;
                int rewardPointHistoryId = continueRewardPointsHistoryData[i].RewardPointsHistoryID;
                rewardPointHistoryTableAdapters.UpdatePointsBalanceById(pointsBallance - rewardpointEarned + rewardpointUsed, rewardPointHistoryId);
            }
        }

        private void CalcuateRewardPoints(int custId)
        {
            int purchaseReceiptOrderId = int.Parse(lbPurchaseReceiptOrderId.Text);
            int pointsBalance;
            DateTime date = DateTime.Now;
            JSManagementDataSet.RewardPointsHistoryDataTable rewardpointUsedData = rewardPointHistoryTableAdapters.GetRewardPointsUsedByPurchaseReceiptOrderId(purchaseReceiptOrderId);            

            if (!string.IsNullOrEmpty(txtCustomerCode.Text))
            {                
                if (rewardPointHistoryTableAdapters.GetRewardPointsBalances(custId, date).Rows.Count > 0)
                {
                    if (purchaseReceiptOrderId == 0)
                    {
                        pointsBalance = rewardPointHistoryTableAdapters.GetRewardPointsBalances(custId, date)[0].PointsBalance;
                        lbAvaiableRewardPoint.Text = pointsBalance.ToString();
                        lbPointsBalanceAmount.Text = (Setting.GetDecimalSetting(Reward_Point_Exchange_Rate) * pointsBalance).ToString("#,###");
                    }
                    else
                    {
                        if (rewardPointHistoryTableAdapters.GetRewardPointsUsedByPurchaseReceiptOrderId(purchaseReceiptOrderId).Rows.Count > 0)
                        {
                            int usedPoint = rewardPointHistoryTableAdapters.GetRewardPointsUsedByPurchaseReceiptOrderId(purchaseReceiptOrderId)[0].Points;
                            lbAvaiableRewardPoint.Text = (-usedPoint).ToString();
                            lbPointsBalanceAmount.Text = (-Setting.GetDecimalSetting(Reward_Point_Exchange_Rate) * usedPoint).ToString("#,###");
                            cboxIsRewardPointUse.Checked = true;
                        }
                        else
                        {
                            cboxIsRewardPointUse.Checked = false;
                        }

                        cboxIsRewardPointUse.Enabled = false;
                    }
                }
                else
                {
                    lbAvaiableRewardPoint.Text = "0";                    
                    lbPointsBalanceAmount.Text = "0";
                    
                }
            }

        }
        

        #endregion Ultitlity        

        #region Print

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (lbPurchaseReceiptOrderId.Text == "0")
            {
                MessageBox.Show("Bạn cần lưu đơn hàng trước khi in phiếu!");
                return;
            }

            
            prnDocument.DefaultPageSettings.Landscape = false;
            prnPreview.Document = prnDocument;           
            prnPreview.PrintPreviewControl.Zoom = 1;
            prnPreview.Width = 1000;
            prnPreview.Height = 800;
            prnPreview.ShowDialog();
            //prnDocument.Print();
            
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
            e.Graphics.RotateTransform(90.0f);
            SetInvoice(e.Graphics); 
        }

        private void SetInvoice(Graphics g)
        {            
            //Invoice title:
            string InvTitle = Setting.GetStringSetting("InvoiceHeader");
            //Title Font:
            Font InvTitleFont = new Font("Arial", 18, FontStyle.Bold);
            Font InvSubTitleFont = new Font("Arial", 10, FontStyle.Bold);
            //Title Color:
            SolidBrush HeadBrush = new SolidBrush(Color.Black);
            
            //Title Height:
            int InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            //Title Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            //Coordinate:
            int CurrentX = leftMargin + (InvoiceWidth -
            lenInvTitle) / 2; //to set the title in center 
            int CurrentY = -790;
            CurrentX = 10;
            //draw the title:
            g.DrawString(InvTitle, InvTitleFont, HeadBrush, 110, CurrentY);

            //draw the invoice header
            Font InvInvoiceFont = new Font("Arial", 10, FontStyle.Regular);            
            int custId = int.Parse(txtCustomerCode.Text);
            int purchaseReceiptOrderId = int.Parse(lbPurchaseReceiptOrderId.Text);
            //string custInfo = lbCustomerInfo.Text.Substring(0, lbCustomerInfo.Text.IndexOf('/'));
            string orderDate = dateTimePickerPerchaseReceiptDate.Value.ToShortDateString();
            string billNumber = txtBillNumber.Text;
            string custName = custTableAdapter.GetDataByCustomerId(custId)[0].CustomerName;
            string custAddress = custTableAdapter.GetDataByCustomerId(custId)[0].Address;
            string custPhone = custTableAdapter.GetDataByCustomerId(custId)[0].Telephone;
            string storeLocation = Setting.GetStringSetting("StoreLocation");
            string storeTelephone = Setting.GetStringSetting("StoreTelephone");
            string website = Setting.GetStringSetting("Website");

            decimal totalAmount=0;

            Font InvInvoiceFontSubTitle = new Font("Arial", 8, FontStyle.Regular);
            CurrentY += 30;
            g.DrawString(storeLocation, InvInvoiceFontSubTitle, HeadBrush, 80, CurrentY);

            CurrentY += 15;
            g.DrawString(storeTelephone, InvInvoiceFontSubTitle, HeadBrush, 90, CurrentY);

            CurrentY += 15;
            g.DrawString(website, InvInvoiceFontSubTitle, HeadBrush, 100, CurrentY);

            CurrentY += 20;
            CurrentX = 110;
            g.DrawString(Setting.GetStringSetting("InvoiceSubHeader").ToUpper(), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);

            CurrentY += 20;
            CurrentX = 100;
            g.DrawString(Setting.GetStringSetting("InvoiceSubHeader2").ToUpper(), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);

            CurrentY = CurrentY + 20;
            CurrentX = 10;
            g.DrawString(Setting.GetStringSetting("InvoiceDateHeader"), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);
            int invoiceDateHeaderTitleLength = (int)g.MeasureString(Setting.GetStringSetting("InvoiceDateHeader"), InvSubTitleFont).Width;
            CurrentX += invoiceDateHeaderTitleLength;
            g.DrawString(string.Format("{0}", orderDate), InvInvoiceFont, HeadBrush, CurrentX, CurrentY);

            CurrentY = CurrentY + 20;
            CurrentX = 10;
            g.DrawString(Setting.GetStringSetting("InvoiceNumberTitle"), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);
            int invoiceNumberTitleLength = (int)g.MeasureString(Setting.GetStringSetting("InvoiceNumberTitle"), InvSubTitleFont).Width;
            CurrentX += invoiceNumberTitleLength;
            g.DrawString(string.Format("{0}", lbPurchaseReceiptOrderId.Text), InvInvoiceFont, HeadBrush, CurrentX, CurrentY);

            CurrentY = CurrentY + 20;
            CurrentX = 10;
            g.DrawString(Setting.GetStringSetting("InvoiceCustomerNameTitle"), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);
            int invoiceCustomerNameTitleLength = (int)g.MeasureString(Setting.GetStringSetting("InvoiceCustomerNameTitle"), InvSubTitleFont).Width;
            CurrentX += invoiceCustomerNameTitleLength;
            g.DrawString(string.Format("{0}", custName), InvInvoiceFont, HeadBrush, CurrentX, CurrentY);

            if (custAddress != string.Empty)
            {
                CurrentX = 10;
                string[] custAdressStrings = custAddress.Split(' ');                
                
                CurrentY += 20;
                g.DrawString(Setting.GetStringSetting("ReceiverAddressTitle"), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);

                int receiverAddressTitleLength = (int)g.MeasureString(Setting.GetStringSetting("ReceiverAddressTitle"), InvSubTitleFont).Width;
                for (int i = 0; i < custAdressStrings.Length; i++)
                {
                    if (receiverAddressTitleLength > 320)
                    {
                        CurrentY += 20;
                        receiverAddressTitleLength = 0;
                    }

                    g.DrawString(string.Format("{0} ", custAdressStrings[i]), InvInvoiceFont, HeadBrush, receiverAddressTitleLength + CurrentX, CurrentY);

                    receiverAddressTitleLength += (int)g.MeasureString(custAdressStrings[i], InvInvoiceFont).Width;
                }
            }

            CurrentY += 20;
            g.DrawString(Setting.GetStringSetting("ReceiverPhoneTitle"), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);
            g.DrawString(custPhone, InvInvoiceFont, HeadBrush, (int)g.MeasureString(Setting.GetStringSetting("ReceiverPhoneTitle"), InvSubTitleFont).Width + 10 + CurrentX, CurrentY);

            if (txtBillNumber.Text != string.Empty)
            {
                CurrentY = CurrentY + 20;
                g.DrawString(Setting.GetStringSetting("InvoiceBillNumberTitle"), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);
                g.DrawString(txtBillNumber.Text, InvInvoiceFont, HeadBrush, (int)g.MeasureString(Setting.GetStringSetting("InvoiceBillNumberTitle"), InvSubTitleFont).Width + 10 + CurrentX, CurrentY);                
            }

            JSManagementDataSet.PurchaseReceiptOrderDetailDataTable purchaseReceiptOrderDetailData = purchaseOrderDetailTableAdapter.GetPurchaseReceiptOrderById(purchaseReceiptOrderId);
            if (purchaseReceiptOrderDetailData.Rows.Count > 0)
            {
                CurrentX = CurrentX + 20;
                CurrentY = CurrentY + 25;
                g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));

                g.DrawString("Mã SP", InvSubTitleFont, HeadBrush, 10, CurrentY + 5);
                g.DrawString("Size", InvSubTitleFont, HeadBrush, 70, CurrentY + 5);
                g.DrawString("SLg", InvSubTitleFont, HeadBrush, 110, CurrentY + 5);
                g.DrawString("Đơn Giá", InvSubTitleFont, HeadBrush, 150, CurrentY + 5);
                g.DrawString("KM/1sp", InvSubTitleFont, HeadBrush, 220, CurrentY + 5);
                g.DrawString("Thành tiền", InvSubTitleFont, HeadBrush, 290, CurrentY + 5);
                CurrentY = CurrentY + 25;
                g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));

                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                int quantity = 0;
                decimal total = 0;
                decimal discount = 0;
                decimal totalDiscount = 0;
                int totalStringLength = 0;
                int totalDiscountStringLength = 0;
                int totalPaymentStringLength = 0;
                for (int i = 0; i < purchaseReceiptOrderDetailData.Rows.Count; i++)
                {
                    var row = purchaseReceiptOrderDetailData[i];         
                    g.DrawString(row.ProductCode, InvInvoiceFont, HeadBrush, 10, CurrentY + 5);
                    g.DrawString(row.Size.ToString(), InvInvoiceFont, HeadBrush, 70, CurrentY + 5);
                    quantity = int.Parse(row.Quantity.ToString());
                    g.DrawString(quantity.ToString(), InvInvoiceFont, HeadBrush, 110, CurrentY + 5);                    
                    g.DrawString((row.OrigialPrice).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 150, CurrentY + 5);

                    discount = (decimal.Parse(row.OrigialPrice.ToString()) - decimal.Parse(row.Price.ToString()));
                    g.DrawString((discount).ToString("#,###", cul.NumberFormat)==string.Empty?"0": (discount).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 220, CurrentY + 5);
                    total = decimal.Parse(row.OrigialPrice.ToString()) * quantity;
                    g.DrawString((total).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 290, CurrentY + 5);
                    totalAmount += total;
                    totalDiscount += discount * quantity;
                    CurrentY = CurrentY + 20;
                }
                
                CurrentY = CurrentY + 5;
                g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));
                CurrentY = CurrentY + 5;
                g.DrawString("Tổng tiền hàng", InvSubTitleFont, HeadBrush, 10, CurrentY);
                g.DrawString((totalAmount).ToString("#,###", cul.NumberFormat), InvSubTitleFont, HeadBrush, 290, CurrentY);
                CurrentY = CurrentY + 20;
                g.DrawString("Tổng KM", InvSubTitleFont, HeadBrush, 10, CurrentY);
                totalStringLength = (int)g.MeasureString((totalAmount).ToString("#,###", cul.NumberFormat), InvSubTitleFont).Width;
                totalDiscountStringLength = (int)g.MeasureString((totalDiscount).ToString("#,###", cul.NumberFormat), InvInvoiceFont).Width;
                g.DrawString((totalDiscount).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 290 + (totalStringLength - totalDiscountStringLength), CurrentY);

                decimal totalRewardPointAmount = 0;
                if (cboxIsRewardPointUse.Checked)
                {
                    totalRewardPointAmount = decimal.Parse(lbPointsBalanceAmount.Text);
                    CurrentY = CurrentY + 20;
                    g.DrawString(string.Format("Sử dụng {0} điểm thưởng", lbAvaiableRewardPoint.Text), InvSubTitleFont, HeadBrush, 10, CurrentY);
                    totalStringLength = (int)g.MeasureString((totalAmount).ToString("#,###", cul.NumberFormat), InvSubTitleFont).Width;
                    totalDiscountStringLength = (int)g.MeasureString(lbPointsBalanceAmount.Text, InvInvoiceFont).Width;
                    g.DrawString(lbPointsBalanceAmount.Text, InvInvoiceFont, HeadBrush, 290 + (totalStringLength - totalDiscountStringLength), CurrentY);
                }

                CurrentY = CurrentY + 20;
                g.DrawString("Tiền thanh toán", InvSubTitleFont, HeadBrush, 10, CurrentY);
                g.DrawString(((totalAmount - totalDiscount-totalRewardPointAmount)).ToString("#,###", cul.NumberFormat), InvSubTitleFont, HeadBrush, 290, CurrentY);
                CurrentY = CurrentY + 20;
                Font InvStringTotalFont = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
                totalPaymentStringLength = (int)g.MeasureString(VNCurrency.ToString((totalAmount - totalDiscount-totalRewardPointAmount)), InvStringTotalFont).Width;
                g.DrawString(VNCurrency.ToString((totalAmount - totalDiscount-totalRewardPointAmount)), InvStringTotalFont, HeadBrush, (360-totalPaymentStringLength)/2, CurrentY);
                CurrentY = CurrentY + 20;
                g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));                
            }

            if (Setting.GetBoolSetting(Reward_Point_Enable) && cboxIsRewardPointPrint.Checked)
            {
                if (rewardPointHistoryTableAdapters.GetRewardPointsBalances(custId, DateTime.Now).Rows.Count > 0)
                {
                    CurrentY += 10;
                    CurrentX = 20;
                
                    int pointsBalance = rewardPointHistoryTableAdapters.GetRewardPointsBalances(custId, DateTime.Now)[0].PointsBalance;
                    decimal rewardPointAmountEarn = pointsBalance * Setting.GetDecimalSetting(Reward_Point_Exchange_Rate);
                    g.DrawString(string.Format("Điểm thưởng hiện tại: {0} điểm = {1} VNĐ", pointsBalance, rewardPointAmountEarn.ToString("#,###")).ToUpper(), InvSubTitleFont, HeadBrush, CurrentX, CurrentY);
                    CurrentY = CurrentY + 20;
                    g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));
                }
            }

            //Print footer 1
            if (Setting.GetStringSetting("InvoiceFooter1") != string.Empty)
            {
                string[] invoiceFooter1 = Setting.GetStringSetting("InvoiceFooter1").Split(' ');
                Font InvFooter1Font = new Font("Arial", 10, FontStyle.Italic);
                CurrentX = 10;
                CurrentY += 20;
                for (int i = 0; i < invoiceFooter1.Length; i++)
                {
                    if (CurrentX > 320)
                    {
                        CurrentY += 15;
                        CurrentX = 10;
                    }

                    g.DrawString(string.Format("{0} ", invoiceFooter1[i]), InvFooter1Font, HeadBrush, CurrentX, CurrentY);

                    CurrentX += (int)g.MeasureString(invoiceFooter1[i], InvFooter1Font).Width;
                }
            }

            

            //Print footer 2
            if (Setting.GetStringSetting("InvoiceFooter2") != string.Empty)
            {
                string[] invoiceFooter2 = Setting.GetStringSetting("InvoiceFooter2").Split(' ');
                Font InvFooter2Font = new Font("Arial", 10, FontStyle.Italic|FontStyle.Bold);
                CurrentX = 50;
                CurrentY += 20;
                for (int i = 0; i < invoiceFooter2.Length; i++)
                {
                    if (CurrentX > 320)
                    {
                        CurrentY += 15;
                        CurrentX = 30;
                    }

                    g.DrawString(string.Format("{0} ", invoiceFooter2[i].ToUpper()), InvFooter2Font, HeadBrush, CurrentX, CurrentY);

                    CurrentX += (int)g.MeasureString(string.Format("{0} ", invoiceFooter2[i].ToUpper()), InvFooter2Font).Width;
                }
            }
            
        }       

        void prnDocumentPostOfficeLetter_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            leftMargin = (int)e.MarginBounds.Left;  	// leftMargin, rightMargin, 
            // ... Declared before
            rightMargin = (int)e.MarginBounds.Right;
            topMargin = (int)e.MarginBounds.Top;
            bottomMargin = (int)e.MarginBounds.Bottom;
            InvoiceWidth = (int)e.MarginBounds.Width;
            InvoiceHeight = (int)e.MarginBounds.Height;
            // Draw Invoice Head
            SetPostOfficeLetter(e.Graphics); 
        }

        private void SetPostOfficeLetter(Graphics g)
        {
            if (!ValidateData())
            {
                return;
            }
            string custName;
            string custAddress;
            string custPhone;
            int custId = int.Parse(txtCustomerCode.Text);
           
            custName = custTableAdapter.GetDataByCustomerId(custId)[0].CustomerName;
            custAddress = custTableAdapter.GetDataByCustomerId(custId)[0].Address;
            custPhone = custTableAdapter.GetDataByCustomerId(custId)[0].Telephone;

            if (custName.Trim() == string.Empty)
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!");
                return;
            }

            if (custAddress.Trim() == string.Empty)
            {
                MessageBox.Show("Địa chỉ khách hàng không hợp lệ!");
                return;
            }

            if (custPhone.Trim() == string.Empty)
            {
                MessageBox.Show("Số điện thoại khách hàng không hợp lệ!");
                return;
            }

            //Invoice title:
            string InvTitle = Setting.GetStringSetting("InvoiceHeaderPostOfficeLeter");
            //Title Font:
            Font InvTitleFont = new Font("Arial", 12, FontStyle.Bold);
            Font InvTitleFontReceiver = new Font("Arial", 12, FontStyle.Bold| FontStyle.Underline| FontStyle.Italic);
            //Title Color:
            SolidBrush HeadBrush = new SolidBrush(Color.Black);

            //Title Height:
            int InvTitleHeight = (int)(InvTitleFont.GetHeight(g));
            //Title Length:
            int lenInvTitle = (int)g.MeasureString(InvTitle, InvTitleFont).Width;
            //Coordinate:
            int CurrentX = leftMargin + (InvoiceWidth -
            lenInvTitle) / 2; //to set the title in center 
            int CurrentY = 10;
            //draw the title:
            g.DrawString(InvTitle, InvTitleFont, HeadBrush, 10, CurrentY);

            
            //draw the invoice header
            Font InvInvoiceFont = new Font("Arial", 10, FontStyle.Regular);
            string storeLocation = Setting.GetStringSetting("StoreLocation");
            string storeTelephone = Setting.GetStringSetting("StoreTelephone");
            string productInvoiceHeader = Setting.GetStringSetting("ProductInvoiceHeader");
            int purchaseReceiptOrderId = int.Parse(lbPurchaseReceiptOrderId.Text);
                        
            decimal totalAmount = 0;

            CurrentY +=20;
            g.DrawString(storeLocation, InvInvoiceFont, HeadBrush, 10, CurrentY);

            CurrentY += 20;
            g.DrawString(storeTelephone, InvInvoiceFont, HeadBrush, 10, CurrentY);

            CurrentY += 20;
            g.DrawString(Setting.GetStringSetting("Website"), InvInvoiceFont, HeadBrush, 10, CurrentY);

            Font InvProductTitleFont = new Font("Arial", 10, FontStyle.Bold);
            CurrentY += 20;
            g.DrawString(productInvoiceHeader, InvProductTitleFont, HeadBrush, 110, CurrentY);                    

            JSManagementDataSet.PurchaseReceiptOrderDetailDataTable purchaseReceiptOrderDetailData = purchaseOrderDetailTableAdapter.GetPurchaseReceiptOrderById(purchaseReceiptOrderId);
            int totalStringLength = 0;
            int totalDiscountStringLength = 0;
            if (purchaseReceiptOrderDetailData.Rows.Count > 0)
            {
                CurrentX = CurrentX + 20;
                CurrentY = CurrentY + 25;
                g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));

                g.DrawString("Mã SP", InvProductTitleFont, HeadBrush, 10, CurrentY + 5);
                g.DrawString("Size", InvProductTitleFont, HeadBrush, 70, CurrentY + 5);
                g.DrawString("SLg", InvProductTitleFont, HeadBrush, 110, CurrentY + 5);
                g.DrawString("Đơn Giá", InvProductTitleFont, HeadBrush, 150, CurrentY + 5);
                g.DrawString("KM/1sp", InvProductTitleFont, HeadBrush, 220, CurrentY + 5);
                g.DrawString("Thành tiền", InvProductTitleFont, HeadBrush, 290, CurrentY + 5);
                CurrentY = CurrentY + 25;
                g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));

                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                int quantity = 0;
                decimal discountPerProduct = 0;
                decimal totalDiscount = 0;
                int totalPaymentStringLength;
                for (int i = 0; i < purchaseReceiptOrderDetailData.Rows.Count; i++ )
                {
                    var row = purchaseReceiptOrderDetailData[i];
                    g.DrawString(row.ProductCode.ToString(), InvInvoiceFont, HeadBrush, 10, CurrentY + 5);
                    g.DrawString(row.Size.ToString(), InvInvoiceFont, HeadBrush, 70, CurrentY + 5);
                    g.DrawString(row.Quantity.ToString(), InvInvoiceFont, HeadBrush, 120, CurrentY + 5);
                    if (cboxIsCod.Checked == true)
                    {
                        g.DrawString((decimal.Parse(row.OrigialPrice.ToString())).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 150, CurrentY + 5);
                        discountPerProduct = decimal.Parse(row.OrigialPrice.ToString()) - decimal.Parse(row.Price.ToString());
                        g.DrawString(discountPerProduct == 0 ? "0" : (discountPerProduct).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 220, CurrentY + 5);
                        quantity = int.Parse(row.Quantity.ToString());
                        g.DrawString(((decimal.Parse(row.OrigialPrice.ToString()) * quantity)).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 290, CurrentY + 5);
                        totalAmount += (decimal.Parse(row.OrigialPrice.ToString()) * quantity);
                        totalDiscount += discountPerProduct * quantity;
                    }
                    else
                    {
                        g.DrawString((decimal.Parse(row.Price.ToString())).ToString("#,###", cul.NumberFormat), InvInvoiceFont, HeadBrush, 150, CurrentY + 5);
                        g.DrawString(Setting.GetStringSetting("OrderIsPaid"), InvInvoiceFont, HeadBrush, 270, CurrentY + 5);
                    }
                    CurrentY = CurrentY + 20;
                }

                CurrentY = CurrentY + 5;
                g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));
                if (cboxIsCod.Checked == true)
                {                    
                    CurrentY = CurrentY + 5;
                    g.DrawString(Setting.GetStringSetting("ProductInvoiceCODTotalTitle"), InvProductTitleFont, HeadBrush, 10, CurrentY);
                    g.DrawString((totalAmount).ToString("#,###", cul.NumberFormat), InvProductTitleFont, HeadBrush, 290, CurrentY);
                    CurrentY = CurrentY + 20;
                    g.DrawString(Setting.GetStringSetting("ProductInvoiceCODDiscountTotalTitle"), InvProductTitleFont, HeadBrush, 10, CurrentY);

                    totalStringLength = (int)g.MeasureString((totalAmount).ToString("#,###", cul.NumberFormat), InvProductTitleFont).Width;
                    totalDiscountStringLength = (int)g.MeasureString((totalDiscount).ToString("#,###", cul.NumberFormat), InvProductTitleFont).Width;

                    g.DrawString((totalDiscount).ToString("#,###", cul.NumberFormat), InvProductTitleFont, HeadBrush, 290 + (totalStringLength - totalDiscountStringLength), CurrentY);
                    CurrentY = CurrentY + 20;
                    g.DrawString(Setting.GetStringSetting("ProductInvoiceCODTitle"), InvProductTitleFont, HeadBrush, 10, CurrentY);
                    g.DrawString(((totalAmount-totalDiscount)).ToString("#,###", cul.NumberFormat), InvProductTitleFont, HeadBrush, 290, CurrentY);

                    CurrentY = CurrentY + 20;
                    Font InvStringTotalFont = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
                    totalPaymentStringLength = (int)g.MeasureString(VNCurrency.ToString((totalAmount - totalDiscount)), InvStringTotalFont).Width;
                    g.DrawString(VNCurrency.ToString((totalAmount - totalDiscount)), InvStringTotalFont, HeadBrush, (360 - totalPaymentStringLength) / 2, CurrentY);

                    CurrentY = CurrentY + 20;
                    g.DrawLine(new Pen(HeadBrush), new Point(10, CurrentY), new Point(360, CurrentY));
                }
            }

            CurrentX = 380;
            CurrentY=200;

            g.DrawString(Setting.GetStringSetting("Receiver"), InvTitleFontReceiver, HeadBrush, CurrentX, CurrentY);
            g.DrawString(custName, InvTitleFont, HeadBrush, 500, CurrentY);

            CurrentY += 25;
            g.DrawString(Setting.GetStringSetting("ReceiverAddressTitle"), InvTitleFontReceiver, HeadBrush, CurrentX, CurrentY);

            string[] custAdressStrings = custAddress.Split(' ');

            int receiverAddressTitleLength = (int)g.MeasureString(Setting.GetStringSetting("ReceiverAddressTitle"), InvTitleFontReceiver).Width;
            for (int i=0 ; i < custAdressStrings.Length; i++)
            {
                if (receiverAddressTitleLength > 380)
                {
                    CurrentY += 25;
                    receiverAddressTitleLength = 0;
                    
                }

                g.DrawString(string.Format("{0} ", custAdressStrings[i]), InvTitleFont, HeadBrush, receiverAddressTitleLength + CurrentX, CurrentY);

                receiverAddressTitleLength += (int)g.MeasureString(custAdressStrings[i], InvTitleFont).Width;

            }

            //g.DrawString(custAddress, InvInvoiceFont, HeadBrush, (int)g.MeasureString(Setting.GetStringSetting("ReceiverAddressTitle"), InvProductTitleFont).Width + 10 + CurrentX, CurrentY);

            CurrentY += 25;
            g.DrawString(Setting.GetStringSetting("ReceiverPhoneTitle"), InvTitleFontReceiver, HeadBrush, CurrentX, CurrentY);
            g.DrawString(custPhone, InvTitleFont, HeadBrush, (int)g.MeasureString(Setting.GetStringSetting("ReceiverPhoneTitle"), InvTitleFontReceiver).Width + 10 + CurrentX, CurrentY);
           
            //CurrentY+=30;
            //g.DrawLine(new Pen(HeadBrush), new Point(0, CurrentY), new Point(1000, CurrentY));
        }

        private void btPrintPostOfficeLetter_Click(object sender, EventArgs e)
        {
            if (lbPurchaseReceiptOrderId.Text == "0")
            {
                MessageBox.Show("Bạn cần lưu đơn hàng trước khi in phiếu!");
                return;
            }

            if (!cboxIsCod.Checked)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn đơn hàng này đã thanh toán? Hãy đánh dấu chọn vào COD/Trả sau để đổi phương thức thanh toán nếu cần! Click OK để tiếp tục in, CANCEL để hủy in.", "Kiểm tra tình trạng thanh toán của đơn hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }

            prnDocumentPostOfficeLetter.DefaultPageSettings.Landscape = false;
            prnPreview.Document = prnDocumentPostOfficeLetter;
            prnPreview.Width = 1000;
            prnPreview.Height = 800;
            prnPreview.PrintPreviewControl.Zoom = 1;
            prnPreview.ShowDialog();
        }

        #endregion Print

        private void PurchaseReceiptOrderForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();

            if (e.Control && e.KeyCode == Keys.S)
            {
                btSave_Click(new object(), new EventArgs());
            }

            if (e.Control && e.KeyCode == Keys.X)
            {
                btDelete_Click(new object(), new EventArgs());
            }

            if (e.Control && e.KeyCode == Keys.T)
            {
                btAddNew_Click(new object(), new EventArgs());
            }

            if (e.Control && e.KeyCode == Keys.I)
            {
                btPrint_Click(new object(), new EventArgs());
            }

            if (e.Control && e.KeyCode == Keys.B)
            {
                btPrintPostOfficeLetter_Click(new object(), new EventArgs());
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                dateTimePickerPerchaseReceiptDate.Focus();
            }

            if (e.Control && e.KeyCode == Keys.K)
            {
                txtCustomerCode.Focus();
            }

            if (e.Control && e.KeyCode == Keys.U)
            {
                txtBillNumber.Focus();
            }

            if (e.Control && e.KeyCode == Keys.O)
            {
                cboxIsCod.Focus();
            }

            if (e.Control && e.KeyCode == Keys.H)
            {
                grvProducts.Focus();
            }

            if (e.Control && e.KeyCode == Keys.G)
            {
                dateTimePickerPurchaseReceiptFromFind.Focus();
            }
        }

        private void PurchaseReceiptOrderForm_Load(object sender, EventArgs e)
        {

            DataGridViewComboBoxColumn cboxSoldBy = grvProducts.Columns[SOLD_BY] as DataGridViewComboBoxColumn;
            cboxSoldBy.DataSource = userTableAdapter.GetData();
            cboxSoldBy.DisplayMember = USER_NAME;
            cboxSoldBy.ValueMember = USER_ID;

            comboBoxSoldBy.DataSource = userTableAdapter.GetData();
            comboBoxSoldBy.DisplayMember = USER_NAME;
            comboBoxSoldBy.ValueMember = USER_ID;

            cboxPaymentMethod.SelectedItem = "Tiền mặt";

            this.WindowState = FormWindowState.Maximized;

            if (PurchaseOrderId != 0)
            {
                BindDataToEdit(PurchaseOrderId);
                return;
            }
        }

        private void grvProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }        

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            decimal totalAmountPaid = decimal.Parse(txtTotalAmount.Text) - decimal.Parse(txtRewardPointUsedAmount.Text);
            txtTotalAmountPaid.Text = totalAmountPaid == 0 ? "0" : totalAmountPaid.ToString("#,###");
        }

        private void txtRewardPointUsedAmount_TextChanged(object sender, EventArgs e)
        {
            decimal totalAmountPaid = decimal.Parse(txtTotalAmount.Text) - decimal.Parse(txtRewardPointUsedAmount.Text);
            txtTotalAmountPaid.Text = totalAmountPaid==0?"0": totalAmountPaid.ToString("#,###");
        }

        private void cboxIsRewardPointUse_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxIsRewardPointUse.Checked)
            {
                txtRewardPointUsedAmount.Text = lbPointsBalanceAmount.Text == "0"? "0" :decimal.Parse(lbPointsBalanceAmount.Text).ToString("#,###");
            }
            else
            {
                txtRewardPointUsedAmount.Text = "0";
            }
        }

        private void cboxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxPaymentMethod.SelectedItem.ToString() == "Chuyển khoản")
            {
                cboxBankAccount.Visible = true;
                JSManagementDataSetTableAdapters.BankAccountTableAdapter bankAccountTableAdapter = new JSManagementDataSetTableAdapters.BankAccountTableAdapter();
                bankAccountTableAdapter.Connection = CommonHelper.GetSQLConnection();
                cboxBankAccount.DataSource = bankAccountTableAdapter.GetData();
                cboxBankAccount.DisplayMember = "BankAccountName";
                cboxBankAccount.ValueMember = "BankAccountId";
            }
            else
            {
                cboxBankAccount.Visible = false;
            }
        }

        private void PurchaseReceiptOrderForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;
            Point p = groupBox1.PointToScreen(grvPurchaseReceiptOrderSumary.Location);
            Point p1 = groupBox1.Location;

            grvPurchaseReceiptOrderSumary.Height = this.Height - p.Y < 20 ? 100 : this.Height - p.Y-30;
            groupBox1.Height = this.Height - p1.Y - 40;
           
        }

        public int PurchaseOrderId { get; set; }

        private void checkedListBoxOutputType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < checkedListBoxOutputType.Items.Count; ++ix)
                {
                    if (e.Index != ix) checkedListBoxOutputType.SetItemChecked(ix, false);
                }
            }
        }
    }
}
