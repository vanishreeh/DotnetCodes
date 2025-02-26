using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstraction.Model
{
    abstract  class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //constructor
        protected Trainer(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public void GetTrainerDetails()
        {
            Console.WriteLine($"Id::{Id}\t name::{Name}");
        }
        public abstract int TrainerSalary();
    }
}
