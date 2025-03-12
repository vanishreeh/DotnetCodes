using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FluentApi
{
    class Address
    {
        public int AddressId { get; set; }
        public string City { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
