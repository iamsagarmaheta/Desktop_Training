using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public static class CharExtenstions
    {
        public static bool IsInt(this char _char)
        {
            if (!(char.IsDigit(_char) || char.IsControl(_char)))
            {
                return false;
            }
            return true;
        }

        public static bool IsFloat(this char _char)
        {
            if (!(char.IsDigit(_char) || char.IsControl(_char) || _char == '.' || _char == '-'))
            {
                return false;
            }
            return true;
        }
    }
}
