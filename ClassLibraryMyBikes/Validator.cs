using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    public class Validator
    {
        public static bool ValidSeatHeight(double value)
        {
            if (value >= 50)
            {
                return true;

            }
            else return false;
        }
       
      

        public static bool IsNullOrEmptyValue(string value)
        {
            bool flag = false;
            if(!String.IsNullOrWhiteSpace(value))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }



        public static bool IsValidColorOption(EnumColor value)
        {
            if (value is EnumColor.Undefined)
            {
                return false;
            }
            else return true;
        }
        public static bool IsValidSpeedRange(double speed)
        {
            if (speed >= 0.0 && speed <= 40.0)
            {
                return true;
            }

            return false;
        }

        public static bool IsValidSuspension(EnumSuspension value)
        {
            if (value is EnumSuspension.Undefined)
            {
                return false;
            }
            else return true;
        }

    }
}
