using System;

namespace GSTBilling
{
    public static class StringExtenstions
    {
        public static bool IsInt(this string S)
        {
            int a = 0;
            return int.TryParse(S, out a);
        }

        public static int ToInt(this string S)
        {
            int a = 0;
            int.TryParse(S, out a);
            return a;
        }

        public static bool IsDouble(this string S)
        {
            double a = 0;
            return double.TryParse(S, out a);
        }

        public static double ToDouble(this string S)
        {
            double a = 0;
            double.TryParse(S, out a);
            return a;
        }

        public static bool ToBool(this string s)
        {
            bool a = false;
            if (s != null && s.Trim().Length != 0)
            {
                bool.TryParse(s, out a);
            }
            return a;
        }

        public static decimal GetWeightFromScaleData(this string _data)
        {
            decimal weight = 0;

            _data = _data.ToLower().Trim();
            _data = _data.Replace("s", " ");
            _data = _data.Replace("e", " ");            
            _data = _data.Trim();

            double _temp = 0;
            double.TryParse(_data, out _temp);

            _temp = Math.Round((_temp / 100),3);

            weight = (decimal)_temp;

            return weight;
        }
    }
}
