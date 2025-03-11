using System;
using System.Collections.Generic;

namespace DataBaseFirstApproach.Model
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; } = null!;
        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; } = null!;
    }
}
