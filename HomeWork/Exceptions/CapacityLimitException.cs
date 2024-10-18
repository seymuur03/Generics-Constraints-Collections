using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exceptions
{
    internal class CapacityLimitException : Exception
    {
        // The first type of creating Exception :
        public CapacityLimitException()
        {

        }

        //The second type of creating Exception :

        public CapacityLimitException(string message) : base(message)
        {

        }
    }
}
