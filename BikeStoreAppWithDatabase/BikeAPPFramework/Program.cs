using BikeAPPFramework.Model;
using BikeAPPFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeAPPFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeRepository repository = new BikeRepository();
           List<Bike> allBikes= repository.GetAllBikes();
            foreach(Bike item in allBikes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
