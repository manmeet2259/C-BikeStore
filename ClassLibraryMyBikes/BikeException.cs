using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    public class BikeException : Exception
    {
        private static string message = "Message From Base Class : Something Went Wrong..\n Choose any color ";

        //public constructors
        public BikeException() : base(message)
        {

        }
        public BikeException(string msg) : base(msg)
        {

        }
    }
}
