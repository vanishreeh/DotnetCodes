using Demo_Abstraction.Model;

namespace Demo_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trainer trainer = new Trainer();//not allowed to create an instance of Abstarct classes
            FreeLanceTrainer freeLanceTrainer = new FreeLanceTrainer(1,"vani",1000,8);
            //Console.WriteLine($"Salary is::{freeLanceTrainer.TrainerSalary()}");
            Trainer trainer = new FreeLanceTrainer(1, "vani", 1000, 8);//creating baseclass instance with child class reference
            //trainer.GetTrainerDetails();
            trainer.GetTrainerDetails();
            Console.WriteLine(trainer.TrainerSalary()); 

            
        }
    }
}
