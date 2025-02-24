namespace Demo_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object of structure
            Address address = new Address();
            address.houseNumber = "F=151";
            address.city = "Bangalore";
            Console.WriteLine($"House Num::{address.houseNumber}\t city::{address.city}");
            //Console.WriteLine(Roles.user);
            
        }
    }
    //enum Roles
    //{
    //    admin,
    //    user
    //}
}
