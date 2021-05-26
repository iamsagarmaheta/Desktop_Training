using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        public Invoice InvoiceData { get; set; }
        public int InvoiceDataId { get; set; }
        public Product ProductData { get; set; }
        public int ProductDataId { get; set; }
        public string ProductName { get { return ProductData == null ? "" : ProductData.ProductName; } }
        public double Quantity { get; set; }
        public double SalesRate { get; set; }
        public double SubTotal { get { return Math.Round(Quantity * SalesRate, 2); } }
        public double Discount { get; set; }
        public double TaxableValue { get { return SubTotal - Discount; } }
        public double TaxRate { get; set; }
        public double TaxAmount { get { return Math.Round(TaxableValue * TaxRate / 100, 2); } }
        public double TotalAmount { get { return Math.Round(TaxableValue + TaxAmount, 2); } }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created_Timestamp { get; set; }
        public DateTime Updated_Timestamp { get; set; }
        public string Created_User { get; set; }
        public string Updated_User { get; set; }
    }
}
