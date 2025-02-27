using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UseCaseException.Exceptions
{
    class BikeAlreadyExistException:ApplicationException
    {
        //create default constructor
        public BikeAlreadyExistException()
        {
            
        }
        //create Parameterized constructor
        public BikeAlreadyExistException(string msg):base(msg)
        {
            
        }
    }
}
