﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsoleApp
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int GradeId{ get; set; }
        public Grade Grade { get; set; }

    }
}
