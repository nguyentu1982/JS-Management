using System;
using System.Collections.Generic;
using System.Text;

namespace JS_Manage
{
    public static class Constant
    {
        public const string VN_CULTURE_FORMAT = "vi-VN";
        public const string NUMBER_FORMAT = "N0";
        public const string PurchaseReceiptOrder_OrderDate = "Ngày";
        public const string PurchaseReceiptOrder_CustId = "Mã KH";
        public const string PurchaseReceiptOrder_BillNumber = "Mã bưu gửi";
        public const string PurchaseReceiptOrder_IsCOD = "COD/Trả sau";
        public const string PurchaseReceiptOrder_ProductCode = "Mã SP";
        public const string PurchaseReceiptOrder_ProductType = "Loại SP";
        public const string PurchaseReceiptOrder_Brand = "Hiệu";
        public const string PurchaseReceiptOrder_Size = "Size";
        public const string PurchaseReceiptOrder_Quantity = "Số Lượng";
        public const string PurchaseReceiptOrder_Price = "Giá bán";
        public const string PurchaseReceiptOrder_OriginalPrice = "Tổng";
        public const string PurchaseReceiptOrder_Discount = "Khuyến mãi";
        public const string PurchaseReceiptOrder_UsedAmount = "Điểm thưởng";
        public const string PurchaseReceiptOrder_Amount = "Thành tiền";
        public const string PurchaseReceiptOrder_Header = "Sửa phiếu xuất";
        public const string PurchaseReceiptOrderReturned_Header = "Đã Nhận Được Hàng Hoàn";
        public const string PURCHASRE_HEADER_PRE = "Lập phiếu";
       

        public const string PurchaseReceiptOrder_SoldBy = "Người bán";
        public const string Not_Allow_User_Edit_On_Other_CreatedDate = "NotAllowUserEditOnOtherCreatedDate";
        public const string PurchaseReceiptOrder_Paid = "Thanh Toán";

        public const string Update_Text = "SỬA";
        public const string Delete_Text = "XÓA";
        public const string Return_Text = "CẬP NHẬT ĐÃ HOÀN HÀNG";
        public const string NotReturn_Text = "CẬP NHẬT CHƯA HOÀN HÀNG";

        public static class ProductGridColumName
        {
            public const string PRODUCT_CODE = "ProductCode";
            public const string PRODUCT_TYPE = "ProductType";
            public const string BRAND = "Brand";
            public const string SIZE = "Size";
            public const string ORIGINAL_PRICE = "OrigialPrice";
            public const string QUANTITY = "Quantity";
            public const string PRICE = "Price";
            public const string AMOUNT = "Amount";
            public const string PRODUCT_ID = "ProductId";
            public const string PRODUCT_MAPPING_ID = "OrderId";
            public const string INCOME_ID = "IncomeId";
            public const string PURCHASE_RECEIPT_ORDER_ID = "PurchaseReceiptOrderId";
            public const string USER_ID = "UserId";
            public const string USER_NAME = "UserName";
            public const string CLOSING_BALANCE = "ClosingBallance";

            public const string SOLD_PRICE = "SoldPrice";

            public const string ORDER_ID = "OrderId";
        }
        public static class BankAccount
        {
            public const string Bank_Account_Name_Column_Name = "BankAccountName";
            public const string Bank_Account_Id_Column_Name = "BankAccountId";
            public const string BANK_ACCOUNT_NAME_DISPLAY_MEMBER = "BankAccountName";
            public const string BANK_ACCOUNT_ID_Value_MEMBER = "BankAccountId";
        }

        public static class BankAccountDetail
        {
            public static class ColumnName
            {
                public const string INCOME_ID = "IncomeId";
                public const string INCOME_DATE = "IncomeDate";
                public const string INCOME_NUMBER ="IncomeNumber";
                public const string PAYER_NAME = "PayerName"; 
			    public const string REASON = "Reason"; 
			    public const string AMOUNT = "Amount";
			    public const string AMOUNT1 = "Amount1"; 
			    public const string RUNING_TOTAL = "RuningTotal";			
			    public const string CREATED_BY = "CreateBy"; 
			    public const string CREATED_DATE = "CreatedDate"; 
			    public const string LAST_EDITED_BY = "LastEditedBy"; 
			    public const string LAST_EDITED_DATE = "LastEditedDate"; 
			    public const string ORDER_ID = "OrderId"; 
			    public const string COST_ID = "CostId";
			    public const string PURCHASE_RECEIPT_ORDER_ID = "PurchaseReceiptOrderId";
			    public const string  TO_BANK_ACCOUNT_ID = "ToBankAccountId";
			    public const string  FROM_BANK_ACCOUNT_ID = "FromBankAccountId";
                public const string PURCHASE_ORDER_BANK_ACCOUNT_ID = "PurchaseOrderBankAccountId";
            }

            public static class ColumnHeaderText
            {
                public const string INCOME_ID = "IncomeId";
                public const string INCOME_DATE = "Ngày";
                public const string INCOME_NUMBER = "Số hóa đơn";
                public const string PAYER_NAME = "Người trả tiền";
                public const string REASON = "Diễn giải";
                public const string AMOUNT = "Nợ";
                public const string AMOUNT1 = "Có";
                public const string RUNING_TOTAL = "Lũy kế";
                public const string CREATED_BY = "CreateBy";
                public const string CREATED_DATE = "CreatedDate";
                public const string LAST_EDITED_BY = "LastEditedBy";
                public const string LAST_EDITED_DATE = "LastEditedDate";
                public const string ORDER_ID = "OrderId";
                public const string COST_ID = "CostId";
                public const string PURCHASE_RECEIPT_ORDER_ID = "PurchaseReceiptOrderId";
                public const string TO_BANK_ACCOUNT_ID = "ToBankAccountId";
                public const string FROM_BANK_ACCOUNT_ID = "FromBankAccountId";
                public const string PURCHASE_ORDER_BANK_ACCOUNT_ID = "PurchaseOrderBankAccountId";
            }
        }

        public static class PaymentMethod
        {
            public const string CASH = "Tiền mặt";
            public const string BANK_TRANSFER = "Chuyển khoản";
            public const string ALL = "Tất cả";
        }

        public static class ReceiveableFromCustomer
        {
            public const string BANK_ACCOUNT_COMBOBOX_CONTROL_NAME = "cboxBankAccount";
            
        }

        public static class CostType
        {
            public const string BANK_TRANSFER = "Chuyển khoản";
            public const string BUSINESS_COST = "Chi HĐKD";
            public const string PRODUCT_INPUT_COST_TYPE ="Chi nhập hàng";
            public const string COST_TYPE_NAME = "CostType";
            public const string COST_TYPE_ID = "CostTypeId";
            public const string COST_TYPE_COMBOBOX_CONTROL_NAME = "cbCostType";
        }

        public static class Income
        {
            public const string BANK_TRANSFER = "Chuyển khoản";
            public const string PAYMENT_METHOD_COMBOBOX_CONTROL_NAME = "cboxPaymentMethod";
            public const string RECEIVABLE_FROM_CUSTOMER_CHECKBOX_CONTROL_NAME = "cboxReceivableFromCustomer";
            public const string LABEL_FROM_BANK_ACCOUNT_CONTROL_NAME = "lableFromBankAccount";
            public const string COMBOBOX_FROM_BANK_ACCOUNT_CONTROL_NAME = "cboxFromBankAccount";
            public const string LABEL_INCOME_HEADER_CONTROL_NAME = "lbIncomeHeader";
            public const string BANK_TRANSFER_BILL = "PHIẾU CHUYỂN TIỀN";

            public static class IncomeGrid
            {
                public static string INCOME_ID_COLUMN_NAME = "IncomeId";
                public static string INCOME_DATE_COLUMN_NAME = "IncomeDate";
                public static string INCOME_NUMBER_COLUMN_NAME = "IncomeNumber";
                public static string PAYER_NAME_COLUMN_NAME = "PayerName";
                public static string REASON_COLUMN_NAME = "Reason";
                public static string AMOUNT_COLUMN_NAME = "Amount";
                public static string CREATED_BY_COLUMN_NAME = "CreateBy";
                public static string CREATED_DATE_COLUMN_NAME = "CreatedDate";
                public static string LAST_EDITED_BY_COLUMN_NAME = "LastEditedBy";
                public static string LAST_EDITED_DATE_COLUMN_NAME = "LastEditedDate";
                public static string ORDER_ID_COLUMN_NAME = "OrderId";
                public static string COST_ID_COLUMN_NAME = "CostId";
                public static string PURCHASE_ORDER_ID_COLUMN_NAME = "PurchaseReceiptOrderId";
                public static string TO_BANK_ACCOUNT_COLUMN_NAME = "ToBankAccount";
                public static string FROM_BANK_ACCOUNT_COLUMN_NAME = "FromBankAccount";
                public static string TO_BANK_ACCOUNT_ID_COLUMN_NAME = "ToBankAccountId";
                public static string FROM_BANK_ACCOUNT_ID_COLUMN_NAME = "FromBankAccountId";

                public static string INCOME_ID_COLUMN_HEADER = "ID";
                public static string INCOME_DATE_COLUMN_HEADER = "Ngày";
                public static string INCOME_NUMBER_COLUMN_HEADER = "Số phiếu";
                public static string PAYER_NAME_COLUMN_HEADER = "Người nộp";
                public static string REASON_COLUMN_HEADER = "Lý do";
                public static string AMOUNT_COLUMN_HEADER = "Số tiền";
                public static string CREATED_BY_COLUMN_HEADER = "Người tạo";
                public static string CREATED_DATE_COLUMN_HEADER = "Ngày tạo";
                public static string LAST_EDITED_BY_COLUMN_HEADER = "Người sửa";
                public static string LAST_EDITED_DATE_COLUMN_HEADER = "Ngày sửa";
                public static string ORDER_ID_COLUMN_HEADER = "OrderId";
                public static string COST_ID_COLUMN_HEADER = "Mã phiếu chi";
                public static string PURCHASE_ORDER_ID_COLUMN_HEADER = "Mã đơn hàng";
                public static string TO_BANK_ACCOUNT_COLUMN_HEADER = "Tới tài khoản";
                public static string FROM_BANK_ACCOUNT_COLUMN_HEADER = "Từ tài khoản";
            }
        }

        public static class Cost
        { 
            public const string COMBOBOX_BANK_ACCOUNT_CONTROL_NAME ="cboxBankAccount";
            public const string COST_ID_COLUMN_NAME = "CostId";
            
		    public const string COST_DATE_COLUMN_NAME = "CostDate"; 
		    public const string COST_NAME_COLUMN_NAME = "CostName"; 
		    public const string AMOUNT_COLUMN_NAME = "Amount";
            public const string COST_TYPE_COLUMN_NAME ="CostType"; 
		    public const string USER_NAME_COLUMN_NAME ="UserName";
            public const string COST_TYPE_ID_COLUMN_NAME = "CostTypeId";

            public const string COST_ID_COLUMN_HEADER = "ID";
            public const string COST_DATE_COLUMN_HEADER = "Ngày";
            public const string COST_NAME_COLUMN_HEADER = "Nội dung";
            public const string AMOUNT_COLUMN_HEADER = "Số tiền";
            public const string COST_TYPE_COLUMN_HEADER = "Loại chi";
            public const string USER_NAME_COLUMN_HEADER = "Người tạo";
            public const string COST_TYPE_ID_COLUMN_HEADER = "Mã loại chi"; 
        }

        public static class Cash
        { 
            public const string DATE_COLUMN_NAME ="Date";
        }

       

        public static class Liabilities
        {
            public static class ColumnName
            {
                public const string ProInOutDetailId = "ProInOutDetailId";
                public const string DATE="Date" ;
	            public const string ACTION = "Action";
	            public const string PRODUCT_CODE = "ProductCode";
	            public const string BRAND = "Brand";
	            public const string PRODUCT_TYPE = "ProductType";
	            public const string SIZE = "Size"; 		
	            public const string QUANTITY ="Quantity";		
                public const string PRICE = "Price";
                public const string AMOUNT ="Amount";
                public const string IS_RETURN_SUPPLIER = "IsReturnSupplier";
                public const string CLOSING_BALANCE = "ClosingBalance";
                public const string CLOSING_BALANCE_AMOUNT = "ClosingBalanceAmount";
            }

            public static class ColumnHeader
            {                
                public const string DATE = "Ngày";
                public const string ACTION = "Xuất/Nhập";
                public const string PRODUCT_CODE = "Mã hàng";
                public const string BRAND = "Hiệu";
                public const string PRODUCT_TYPE = "Loại";
                public const string SIZE = "Size";
                public const string QUANTITY = "Số lượng";
                public const string PRICE = "Giá";
                public const string AMOUNT = "Thành tiền";
                public const string IS_RETURN_SUPPLIER = "Xuất trả hàng";               
                public const string CLOSING_BALANCE_AMOUNT = "Lũy kế";
            }
        }

        public static class ProductSearch
        {
            public static class ProductGridColumnName
            { 
                public const string PRODUCT_ID = "ProductId"; 
		        public const string PRODUCT_CODE = "ProductCode";
		        public const string BRAND = "Brand"; 
		        public const string SIZE = "Size"; 
		        public const string PRODUCT_COST = "ProductCost"; 
		        public const string PRICE = "Price";
                public const string PRICE2 = "Price2";
                public const string PRICE3 = "Price3";
                public const string PRICE4 = "Price4";
		        public const string PRODUCT_TYPE = "ProductType"; 
		        public const string OPENING_BALANCE = "OpeningBalance"; 
		        public const string INPUT = "Input";
		        public const string OUTPUT ="Output";
                public const string CLOSING_BALANCE = "ClosingBalance";
                public const string STORE_ID = "StoreId";
                public const string ProdId = "ProdId";
            }

            public static class ProductGridColumnHeader
            {
                public const string PRODUCT_ID = "ProductId";
                public const string PRODUCT_CODE = "Mã sản phẩm";
                public const string BRAND = "Hiệu";
                public const string SIZE = "Size";
                public const string PRODUCT_COST = "ProductCost";
                public const string PRICE = "Giá";
                public const string PRODUCT_TYPE = "Loại";
                public const string OPENING_BALANCE = "Số dư đầu kỳ";
                public const string INPUT = "Nhập trong kỳ";
                public const string OUTPUT = "Xuất trong kỳ";
                public const string CLOSING_BALANCE = "Tồn cuối kỳ";
            }

            public static class ProductInOutDetailGridColumnName
            {
                public const string ID = "ID";
                public const string ACTION = "Action";
                public const string XUAT = "xuất";
                public const string NHAP = "nhập";
                public const string DATE ="DATE";
                public const string QUANTITY ="Quantity";
                public const string CLOSING_BALANCE = "ClosingBalance";

                public const string IN_OUT_TYPE_CODE = "InOutTypeCode";
            }

            public static class ProductInOutDetailGridColumnHeader
            {
                public const string ID = "ID";
                public const string ACTION = "Xuất/Nhập";
                public const string DATE = "Ngày";
                public const string QUANTITY = "Số lượng";
                public const string CLOSING_BALANCE = "Tồn lũy kế";
            }
        }

        public static class CashManagement
        { 
            
        }

        public static class Setting
        {
            public const string Select_Multi_Product_On_Input = "SelectMultiProductOnInput";
            public const string ALLOW_USER_VIEW_ALL_COST = "AllowUserViewAllCost";
            public const string REWARD_POINT_ENABLED = "RewardPointEnable";
            public const string AllowUserViewProductOtherStore = "AllowUserViewProductOtherStore";
        }

        public static class ProductsSelectedDialog
        { 
            public const string PRODUCT_CODE_LABEL_CONTROL_NAME ="lbProductCode";
            public const string PRODUCT_TYPE_LABEL_CONTROL_NAME = "lbProductType";
            public const string PRODUCT_BRAND_LABEL_CONTROL_NAME = "lbBrand";
            public const string PROD_ID_LABEL_CONTROL_NAME = "lbProdId";
        }

        public static class ProductInputColumnName
        {
            public const string PRODUCT_CODE = "ProductCode";
            public const string PRODUCT_TYPE = "ProductType";
            public const string BRAND = "Brand";
            public const string SIZE= "Size";
            public const string QUANTITY = "Quantity";
            public const string COST="Cost";
            public const string AMOUNT = "Amount";
            public const string PRODUCT_ID = "ProductId";
            public const string PRODUCT_INPUT_ID = "ProductInputId";
            public const string PRODUCT_INPUT_ORDER_ID = "ProductInputOrderId";

            public const string INPUT_DATE_COLUMN_NAME="InputDate";
            public const string SUPPLIER_ID_COL_NAME ="SupplierId";
            public const string QUANTITY_COL_HEADER = "Số lượng";
            public const string COST_COL_HEADER = "Tổng tiền";
            public const string INPUT_DATE_COL_HEADER = "Ngày nhập";
            public const string SUPPLIER_COL_HEADER = "Mã NCC";

            public const string INPUT_TYPE_CODE = "InputTypeCode";
        }

        public static class ProductOutputColumnName
        {
            public const string PRODUCT_CODE = "ProductCode";
            public const string PRODUCT_TYPE = "ProductType";
            public const string BRAND = "Brand";
            public const string SIZE = "Size";
            public const string PRICE = "Price";
            public const string QUANTITY = "Quantity";
            public const string SOLD_PRICE = "SoldPrice";
            public const string AMOUNT = "Amount";
            public const string PRODUCT_ID = "ProductId";
            public const string CLOSING_BALLANCE = "ClosingBallance";
            public const string ORDER_ID = "OrderId";
            public const string INCOME_ID = "IncomeId";
            public const string SOLD_BY = "SoldBy";
        }

        public static class Store
        {
            public const string DISPLAY_MEMBER = "StoreName";
            public const string VALUE_MEMBER = "StoreId";
            public const string KHO_NHAP = "Kho Nhập";
            public const string KHO_XUAT = "Kho Xuất";
        }
        public static class OutputType
        {
            public const string DISPLAY_MEMBER = "OutputTypeDesc";
            public const string VALUE_MEMBER = "OutputTypeCode";
            public const string XBH = "XBH"; //xuất bán hàng
            public const string XTH = "XTH"; //xuất trả hàng
            public const string XCK = "XCK"; //xuất chuyển kho
            public const string XDH = "XDH"; //xuất đổi hàng


            public const string COLUMN_NAME_OUTPUT_TYPE_CODE = "OutputTypeCode";
        }
        public static class InputType
        {
            public const string DISPLAY_MEMBER = "InputTypeDesc";
            public const string VALUE_MEMBER = "InputTypeCode";
            public const string NH = "NH"; //nhập hàng
            public const string NCK = "NCK"; //nhập chuyển kho hàng
            public const string ALL = "ALL";

            public const string ALL_DESC = "Tất cả";
            public const string NCK_NOT_APPROVED = "Chưa duyệt";
            public const string NCK_APPROVED = "Đã duyệt";
        }

        public static class Message
        {
            public const string PRE_PAID_NOT_VALID = "Số tiền trả trước không hợp lệ";
        }

        
    }
}
