using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public enum ErrorType
    {
        ValidationError,
        DatabaseError,
        RangeError
    }

    public enum OperationType
    {
        New = 1,
        Edit = 2
    }

    public enum GstType
    {
        LocalGST = 1,
        IntegratedGST = 2
    }
}
