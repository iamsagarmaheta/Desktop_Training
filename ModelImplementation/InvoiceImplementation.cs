using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public static class InvoiceImplementation
    {
        public static OperationResult Save(this Invoice invoiceData)
        {
            var result = Validate(invoiceData);
            if (result.IsValid == false)
            {
                return result;
            }
            result.ErrorType = ErrorType.DatabaseError;

            return result;
        }

        public static OperationResult Validate(this Invoice invoiceData)
        {
            var result = new OperationResult(ErrorType.ValidationError);

            invoiceData.Updated_Timestamp = DateTime.Now;
            invoiceData.Updated_User = "";
            if (invoiceData.Id == 0)
            {
                //  Generating New Invoice Number
                invoiceData.InvoiceNo = GenerateInvoiceNo(invoiceData.InvoiceDate.GetFinancialYear());
                invoiceData.Created_Timestamp = DateTime.Now;
                invoiceData.Created_User = "";
            }

            if (invoiceData.CustomerData == null)
            {
                result.AddError("Please Enter Valid Customer Details.");
            }
            if (invoiceData.InvoiceDetails.Where(i => i.IsDeleted == false).Count() == 0)
            {
                result.AddError("Please Enter Atleast One Item In Invoice.");
            }

            return result;
        }

        public static string GenerateInvoiceNo(string series)
        {
            string generatedNumber = "0001";

            return $@"{generatedNumber}-{series}";
        }

        public static bool DeleteById(int id)
        {
            bool result = false;

            return result;
        }

        public static Invoice FindById(int id)
        {
            return new Invoice();
        }

        public static string[] Suggest_InvoiceNo()
        {
            return new string[1] { "0001-2021-22" };
        }
    }

}
