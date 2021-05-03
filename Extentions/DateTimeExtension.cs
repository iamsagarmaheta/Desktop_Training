using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSTBilling
{
    public static class DateTimeExtension
    {
        public static string GetFinancialYear(this DateTime dateTime, string seprator = "-")
        {
            return (dateTime.Month > 3) ? dateTime.Year.ToString() + seprator + (dateTime.Year + 1).ToString().Substring(2)
                                            : (dateTime.Year - 1).ToString() + seprator + dateTime.Year.ToString().Substring(2);
        }

        public static string ToUserDateFormat(this DateTime dateTime)
        {
            return dateTime.ToString("dd-MM-yyyy");
        }

        public static DateTime GetDateTimeFilterStartValue(this DateTime dateTime)
        {
            return DateTime.Parse(dateTime.ToString("dd-MM-yyyy 01:01 "));
        }

        public static DateTime GetDateTimeFilterEndValue(this DateTime dateTime)
        {
            return DateTime.Parse(dateTime.ToString("dd-MM-yyyy 23:59 "));
        }
    }
}
