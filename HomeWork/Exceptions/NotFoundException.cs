using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exceptions
{
    internal class NotFoundException:Exception
    {
        //first type of creating Exception :
        public NotFoundException()
        {
            
        }

        //second type of creating Exception :
        public NotFoundException(string message) : base(message) 
        {
            
        }
    }
}
