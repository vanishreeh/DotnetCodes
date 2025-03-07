using Demo_BikeStoreAPP.Model;
using Demo_BikeStoreAPP.Repository;

namespace Demo_BikeStoreAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBikeRepository repository = new BikeRepository();
           List<Bike> allBikes= repository.GetAllBikes();
            foreach(Bike bike in allBikes)
            {
                Console.WriteLine(bike);
            }
        }
    }
}
