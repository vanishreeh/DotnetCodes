using Demo_BikeStoreAPP.Model;
using Demo_BikeStoreAPP.Repository;

namespace Demo_BikeStoreAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBikeRepository repository = new BikeRepository();
            //List<Bike> allBikes= repository.GetAllBikes();
            // foreach(Bike bike in allBikes)
            // {
            //     Console.WriteLine(bike);
            // }
            // Bike bikeObj = new Bike() { BikeId = 9, BikeName = "Activa", Price = 80000M, Quantity = 10 };
            //Bike bikeObj = new Bike() { BikeId = 11, BikeName = "HondaActiva1", Price = 80000M, Quantity = 10 };
            ////var result=repository.AddBike(bikeObj);
            ////Console.WriteLine(result);
            //int addStatus = repository.AddBike(bikeObj);
            //if (addStatus > 0)
            //{
            //    Console.WriteLine("Bike Added successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Bike Addition Failed");
            //}
           int status= repository.UpdateBike(11);
            if (status > 0)
            {
                Console.WriteLine("Updated Bike");
            }
            else
            {
                Console.WriteLine("Updation failed");
            }
        }
    }
}
