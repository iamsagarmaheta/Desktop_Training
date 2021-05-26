using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public static class InvoiceDetailsImplememtation
    {
        public static OperationResult Validate(this InvoiceDetail invoiceDetails)
        {
            var result = new OperationResult(ErrorType.ValidationError);
            if (invoiceDetails.ProductData == null)
            {
                result.AddError("Please Add Product Details.");
            }
            if (invoiceDetails.Quantity <= 0)
            {
                result.AddError("Please Add Valid Quantity.");
            }

            invoiceDetails.Updated_Timestamp = DateTime.Now;
            invoiceDetails.Updated_User= "-";
            if (invoiceDetails.Id == 0)
            {
                invoiceDetails.Created_Timestamp = DateTime.Now;
                invoiceDetails.Created_User = "-";
            }
            return result;
        }
    }
}
