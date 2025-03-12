using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FluentApi
{
    class Student
    {
        public int StudentId { get; set; }
       
        public string Name { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }

        public Address Adress { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
