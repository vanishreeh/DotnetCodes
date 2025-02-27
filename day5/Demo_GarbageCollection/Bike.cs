using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GarbageCollection
{
    class Bike
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        //constructor
        public Bike()
        {
            
        }
        public Bike(string name, int speed)
        {
            Name = name;
            Speed = speed;
            
        }
    }
}
