using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Abstraction.Model
{
    class FreeLanceTrainer:Trainer
    {
        public int Hourbasis { get; set; }
        public int TotalHrs { get; set; }
        public FreeLanceTrainer(int id, string name,int hrs,int thrs):base(id,name)
        {
            Hourbasis = hrs;
            TotalHrs = thrs;
        }
        public override int TrainerSalary()
        {
            return Hourbasis * TotalHrs;
        }

    }
}
