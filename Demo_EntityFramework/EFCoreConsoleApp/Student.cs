using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsoleApp
{
    class Student
    {
        [Key]
      
        public int StudentId { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="Length must be less than 50 charcaters")]
        public string Name { get; set; }
        public int Age { get; set; }
        //convention1
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        //Convention2
        //Grade Grade { get; set; }
        //Navigation property for address
        public StudentAddress Address { get; set; }

        //don't map this property
        [NotMapped]
        public int DummyProperty { get; set; }
    }
}
