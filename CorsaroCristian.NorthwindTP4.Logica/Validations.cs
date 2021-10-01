using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaroCristian.NorthwindTP4.Logica
{
    public class Validations
    {
        public static bool ValidateStringLength(string stringToValidate, int length)
        {
            bool result = true;
            if(stringToValidate.Length > length)
            {
                result = false;
            }
            return result;
        }

        public static bool IsDate(string date)
        {
            try
            {
                DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsNumber(string number)
        {
            try
            {
                int.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsFloat(string number)
        {
            try
            {
                decimal.Parse(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
