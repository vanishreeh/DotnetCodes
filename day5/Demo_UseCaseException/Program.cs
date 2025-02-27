using Demo_UseCaseException.Model;
using Demo_UseCaseException.Repository;

namespace Demo_UseCaseException
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            IBikeRepository bikeRepo = new BikeRepository();
           List<Bike>allBikes= bikeRepo.GetAllBikes();
            //foreach(Bike bike in allBikes)
            //{
            //    Console.WriteLine(bike);
            //}
            Bike bike3 = new Bike() { Id = 3, Name = "RoyalEnfield", Price = 30000M };
           bool addStatus= bikeRepo.AddBike(bike3);
            if (addStatus)
            {
                Console.WriteLine("Bike Added Successfully");
            }
            else { Console.WriteLine("Try new name ::"); }
            
            //foreach (Bike bike in allBikes)
            //{
            //    Console.WriteLine(bike);
            //}

        }
    }
}
