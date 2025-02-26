using Demo_Inheritance.Model;

namespace Demo_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike(1,"Ola",200000);
            ElectricBike electricBike = new ElectricBike(1,"Ola",10000.00M,200,60);
            Bike bike1 = new ElectricBike(1, "Ola", 10000.00M, 200, 60);//Covariance
            //ElectricBike eleB = (ElectricBike)new Bike(1, "Ola", 10000.00M);
            //Console.WriteLine($"Id::{electricBike.BikeId}\tName::{electricBike.BikeName}\tPrice::{electricBike.Price}\tCapacity::{electricBike.Capacity}\tRange::{electricBike.Range}");
            //Console.WriteLine(electricBike.GetAllBikeDetails());
            //Console.WriteLine(bike.GetAllBikeDetails());
            Console.WriteLine(bike1.GetAllBikeDetails());//
            // GetBikeDetails(bike as ElectricBike);//to convert types
           
        }
        public static void GetBikeDetails(ElectricBike electricBike)
        {

        }
       
    }
}
