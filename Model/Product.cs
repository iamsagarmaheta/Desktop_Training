using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string HsnCode { get; set; }
        public string Unit { get; set; }
        public double SalesRate { get; set; }
        public double PurchaseRate { get; set; }
        public double GstRate { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        //  Below 4 Properties Will Be Mendatory in All The Models/Classes We Create 
        public DateTime Created_Timestamp { get; set; }
        public DateTime Updated_Timestamp { get; set; }
        public string Created_User { get; set; }
        public string Updated_User { get; set; }
    }
}
