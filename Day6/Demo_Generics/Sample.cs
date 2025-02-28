using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generics
{
    class Sample
    {
        //public void GetDetails(string name)
        //{
        //    Console.WriteLine(name);
        //}
        public void GetDetails<T>(T value1)
        {
            Console.WriteLine(value1);
        }
        //public void GetDetails(object name)
        //{
        //    Console.WriteLine(name);
        //}
        //public void CheckNumbers<T>(object num1,object num2)
        //{
        //    Console.WriteLine("");
        //}
        public void CheckNumbers<T>(T num1, T num2)
        {
            Console.WriteLine("");
        }
    }
}
