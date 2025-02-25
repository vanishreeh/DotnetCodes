using Demo_ClassAndObjects.Model;

namespace Demo_ClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class is blue print to create an object
            //object-real entity created using class
            //state---data(properties)
            //Behaviour---functionality(methods)
            //Bike bike = new Bike();
            //bike.bikeId = 1;
            //bike.SetId(1);

            //bike.bikeName = "Royal Enfield";
            //bike.bikePrice = 200000;
            //Assign values during creation of object
            //Bike bike1 = new Bike { bikeId = 2, bikeName = "Splender", bikePrice = 190000 };
             Bike bike1 = new Bike { BikeId= 2, BikeName = "Splender", BikePrice = 190000 };
            //Console.WriteLine($"Id::{bike.bikeId}\tname::{bike.bikeName}\tprice::{bike.bikePrice}");
            // Console.WriteLine($"Id::{bike1.BikeId}\tname::{bike1.BikeName}\tprice::{bike1.BikePrice}");
            //Bike bike = new Bike(1, "Splender", 190000);
            //Console.WriteLine(bike);
            Console.WriteLine(bike1);
            Bike.name = "Splender1";
            Console.WriteLine(Bike.name);
            
            
        }
    }
}
