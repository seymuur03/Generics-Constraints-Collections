using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exceptions
{
    internal class ProductCountIsZeroException:Exception
    {
        //first type of creating Exception :
        public ProductCountIsZeroException()
        {

        }

        //second type of creating Exception :
        public ProductCountIsZeroException(string message):base(message) 
        {
            
        }

    }
}
