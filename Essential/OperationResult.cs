using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public class OperationResult
    {
        private string Error;
        public int InsertedId { get; set; }
        public ErrorType ErrorType { get; set; }
        public bool IsValid { get; private set; }

        public OperationResult(ErrorType _errorType)
        {
            ErrorType = _errorType;
            IsValid = true;
            Error = "Please Enter Following Details Carefully : " + Environment.NewLine;
        }

        public void AddError(string err)
        {
            IsValid = false;
            Error += Environment.NewLine + err;
        }

        public string getError()
        {
            return Error;
        }
    }
}
