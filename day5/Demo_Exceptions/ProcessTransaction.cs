using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exceptions
{
    class ProcessTransaction
    {
        int maxLimit = 2000;
        public void CheckLimit(int amount)
        {
            try
            {
                if (amount > maxLimit)
                {
                    throw new Exception("Cannot withdraw more than 2000");
                }
                else
                {
                    Console.WriteLine("collect your money");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//Textual description of error
                Console.WriteLine(ex.StackTrace);//calls that triggered the exception
                Console.WriteLine(ex.TargetSite);//name of method which threw exception
                Console.WriteLine(ex.InnerException);// previous exception that caused current exception
            }
        }
    }
}
