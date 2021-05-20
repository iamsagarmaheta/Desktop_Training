using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public static class ProductImplementation
    {
        //  Save
        public static OperationResult Save(this Product product)
        {
            OperationResult result = product.Validate();
            if (result.IsValid == false)
            {
                return result;
            }
            result.ErrorType = ErrorType.DatabaseError;

            //code to save details in database           

            return result;
        }

        //  Validation
        public static OperationResult Validate(this Product product)
        {
            OperationResult validationResult = new OperationResult(ErrorType.ValidationError);

            if (product.CategoryName.Length == 0)
            {
                validationResult.AddError("Enter Valid Category Name.");
            }
            if (product.ProductName.Length == 0)
            {
                validationResult.AddError("Enter Valid Product Name.");
            }
            if (product.SalesRate == 0)
            {
                validationResult.AddError("Enter Valid Sales Rate.");
            }
            if (FindByProductName(product.ProductName, product.Id) != null)
            {
                validationResult.AddError("Product Name Already Exists.");
            }

            return validationResult;
        }

        //  Delete
        public static bool DeleteById(int id)
        {
            bool result = false;
            
            return result;
        }

        //  Multiple Function To Filter Data
        public static Product FindById(int id)
        {
            return new Product() {
                CategoryName = "Saree",
                ProductName = "Bandhni Saree",
                EntryDate = DateTime.Now,
                SalesRate = 5270
            };
        }

        public static Product FindByProductName(string productName, int id = 0)
        {
            if (productName == "saree")
            {
                return new Product()
                {
                    CategoryName = "Saree",
                    ProductName = "Bandhni Saree",
                    EntryDate = DateTime.Now,
                    SalesRate = 5270
                };
            }

            return null;
        }

        //  Data Suggestion Functions
        public static string[] Suggest_ProudctCategory()
        {
            return new string[4] { "category 1", "category 2", "saree", "groccery" };            
        }

        public static string[] Suggest_ProudctName()
        {
            return new string[1] { "dummy Name" };
        }
    }
}
