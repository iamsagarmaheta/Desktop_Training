using System;

namespace GSTBilling
{
    public static class NumberExtensions
    {
        public static string FormatToString(this double data, string format = "{0:n2}")
        {
            //.FormatToString("{0:n0}")
            return string.Format(format, data);
        }
        public static double SalesRateConvert(this double data)
        {
            double returnData = data;
            returnData = Math.Round(data);
            int lastDigit = (int)Math.Abs(returnData) % 10;
            if (lastDigit > 4)
            {
                returnData += (10 - lastDigit);
            }
            else
            {
                returnData -= lastDigit;
            }
            return returnData;
        }
    }
}
