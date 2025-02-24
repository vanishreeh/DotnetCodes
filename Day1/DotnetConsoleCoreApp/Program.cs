
namespace DotnetConsoleCoreApp
{
    // cw+tab----console.writeLine
    //ctrl+kc----multiple line commenting
    //ctrl+ku----uncommenting
    //ctrl+kd----format the code
    internal class Program
    {
        static void Main(string[] args)
        {
            #region datatypes basic
            //Explicit type variables
            //int productId = 100;
            //string productName = "TV";
            //double productPrice = 10000;
            //float rating = 4.5F;
            //decimal totalValue = 25000.897M;
            //bool isAvailable = true;


            ////Console.WriteLine("productId is:::"+productId);
            //Console.WriteLine($"ProductId::{productId}\tName::{productName}\tprice::{productPrice}");
            //Console.WriteLine(productName);
            //Console.WriteLine();
            #endregion
            #region Default values
            //int age = default;
            //string name=default;
            //bool isValid = default;
            //Console.WriteLine($"age::{age}\tname::{name}\tboolType::{isValid}");
            //int? marks = null;
            //string city = null;
            //bool? isTrue = null;
            #endregion
            #region var and dynamic
            //Implicit declaration
            //var name = "vansihree";
            //Console.WriteLine(name.GetType());
            //var name;not allowed needs to be intialised
            //int marks = 90;
            //double marks1 = marks;
            //double price = 1200;
            //marks = (int)price;
            //dynamic marks=100;
            //Console.WriteLine(marks.GetType());
            #endregion
            #region Taking userInput
            Console.WriteLine("Enter your Name::");
            string name=Console.ReadLine();
            
            Console.WriteLine("Enter your Age::");
            ////string userAge = null;
            //int userAge1 = Convert.ToInt32(userAge);
            ////int userAge1 = int.Parse(userAge);
            //Console.WriteLine(userAge1);

            int age = Convert.ToInt32( Console.ReadLine());
            if (name == "vanishree")
            {
                Console.WriteLine("you have logged in successfully");
            }
            else
            {
                Console.WriteLine("enter correct name");
            }
            //int age1 = int.Parse(Console.ReadLine()); 
            bool result;
            int a;
            //string age =null;
            result = int.TryParse(Console.ReadLine(),out a);
           
            //Console.WriteLine(result);
            // Console.WriteLine($"Name::{name}\t age::{a}");
            #endregion















        }
    }

}