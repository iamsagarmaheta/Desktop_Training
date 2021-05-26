using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public class Invoice
    {
        public int Id { get; set; }
        public Customer CustomerData { get; set; }
        public int CustomerDataId { get; set; }
        public string CustomerName { get { return CustomerData == null ? "" : CustomerData.CustomerName; } }
        public string ContactNumber { get { return CustomerData == null ? "" : CustomerData.ContactNumber; } }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public double SubTotal { get { return InvoiceDetails.Where(i => i.IsDeleted == false).Sum(i => i.SubTotal); } }
        public double Discount { get { return InvoiceDetails.Where(i => i.IsDeleted == false).Sum(i => i.Discount); } }
        public double TaxableValue { get { return InvoiceDetails.Where(i => i.IsDeleted == false).Sum(i => i.TaxableValue); } }
        public double TaxAmount { get { return InvoiceDetails.Where(i => i.IsDeleted == false).Sum(i => i.TaxAmount); } }
        public double TotalAmount { get { return InvoiceDetails.Where(i => i.IsDeleted == false).Sum(i => i.TotalAmount); } }
        public double RoundOff { get; set; }
        public double GrandTotal { get { return TotalAmount - RoundOff; } }
        public GstType Gst_Type { get; set; }
        public double CGSTAmount { get { return Gst_Type == GstType.LocalGST ? TaxAmount / 2 : 0; } }
        public double SGSTAmount { get { return Gst_Type == GstType.LocalGST ? TaxAmount / 2 : 0; } }
        public double IGSTAmount { get { return Gst_Type == GstType.IntegratedGST ? TaxAmount : 0; } }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created_Timestamp { get; set; }
        public DateTime Updated_Timestamp { get; set; }
        public string Created_User { get; set; }
        public string Updated_User { get; set; }
    }
}
