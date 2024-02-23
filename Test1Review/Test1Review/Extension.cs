using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Review
{
    static class Extension
    {
        public static string ToPercentage(this double value)
        {
            return $"{value:P}";
        }

        public static string ToCurrency(this double value)
        {
            return $"{value:C}";
        }

        public static string ToPhoneNumber(this string phoneNumber)
        {
            return $"({phoneNumber.Substring(0, 3)}) {phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6)}";
        }
    }
}
