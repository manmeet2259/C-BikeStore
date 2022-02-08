using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    public class NotInRangeExc : Exception
    {
        private static string message = "Invalid Range";
        public NotInRangeExc() : base(message)
        {

        }
        public NotInRangeExc(string msg) : base(msg)
        {

        }
    }
}
