using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime JoiningDate { get; set; }
        public string CustomerName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public double OutstadningBalance { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }        
        public DateTime Created_Timestamp { get; set; }
        public DateTime Updated_Timestamp { get; set; }
        public string Created_User { get; set; }
        public string Updated_User { get; set; }
    }
}
