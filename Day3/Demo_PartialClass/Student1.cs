using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PartialClass
{
    partial class Student
    {
        public int Id { get; set; }
        public void DebugErrors()
        {
            Console.WriteLine("Debugging Errors");
        }
    }
}
