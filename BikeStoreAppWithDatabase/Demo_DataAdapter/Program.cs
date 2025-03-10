using Demo_DataAdapter.Model;
using Demo_DataAdapter.Repository;

namespace Demo_DataAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBikeRepository bikeRepository = new BikeRepository();
            Bike bike = new Bike() { BikeId = 14, BikeName = "Access", CategoryId = 1, Price = 50000, Quantity = 10 };
            bikeRepository.AddBike(bike);
            // bikeRepository.UpdateChanges();
            List<Bike> allBikes = bikeRepository.GetAllBikes();
            foreach (var item in allBikes)
            {
                Console.WriteLine($"Id::{item.BikeId}\tName::{item.BikeName}");
            }
        }
    }
}
