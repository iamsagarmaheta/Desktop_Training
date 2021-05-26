using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public static class CustomerImplementation
    {
        //  Save
        public static OperationResult Save(this Customer customer)
        {
            OperationResult result = customer.Validate();
            if (result.IsValid == false)
            {
                return result;
            }
            result.ErrorType = ErrorType.DatabaseError;

            //code to save details in database           

            return result;
        }

        public static OperationResult Validate(this Customer customer)
        {
            OperationResult result = new OperationResult(ErrorType.ValidationError);

            if (customer.Id == 0)
            {
                customer.Created_Timestamp = DateTime.Now;
                customer.Created_User = "";
            }
            customer.Updated_Timestamp = DateTime.Now;
            customer.Updated_User = "";

            if (customer.CustomerName.Length == 0)
            {
                result.AddError("Please Enter Valid Customer Name.");
            }
            else if (FindByCustomerName(customer.CustomerName, customer.Id) != null)
            {
                result.AddError("Duplicate Customer Name.");
            }
            if (customer.ContactPerson.Length == 0)
            {
                result.AddError("Please Enter Valid Contact Person.");
            }
            

            return result;
        }

        public static bool DeleteById(int id)
        {
            var result = false;

            return result;
        }

        public static Customer FindByCustomerName(string customerName, int id = 0)
        {
            if (customerName.ToLower() == "Sagar".ToLower())
            {
                return new Customer() {
                    CustomerName = "Sagar",
                    ContactNumber = "88800088800"
                };
            }
            return null;
        }

        public static Customer FindById(int id)
        {
            return new Customer();
        }

        public static string[] Suggest_CustomerName()
        {
            return new string[1] { "Sagar" };
        }

        public static string[] Suggest_ContactNumber()
        {
            return new string[1] { "Dummy Customer name" };
        }

        public static string[] Suggest_ContactPerson()
        {
            return new string[3] { "Dummy Contact Person", "person2", "sagar" };
        }
    }
}
