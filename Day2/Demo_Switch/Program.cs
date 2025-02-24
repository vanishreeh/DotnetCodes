namespace Demo_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //design a menu based application where user is provided
            //with choices like login, register, logout
            //print respective messages depending on the choice
            int choice = 0;
            do
            {
                Console.WriteLine("1.Register\n2.Login\n3.Logout\n4.exit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter you name::");
                        string userName = Console.ReadLine();
                        Console.WriteLine($"{userName} you  have Registered successfully");
                        break;
                    case 2:
                        Console.WriteLine("Enter your name::");
                        string userEneteredName = Console.ReadLine();
                        if (userEneteredName == "Vani")
                        {
                            Console.WriteLine($"Welcome:{userEneteredName}");
                        }
                        else
                        {
                            Console.WriteLine("RegisterFirst");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Logged out");
                        break;
                    case 4:
                        Console.WriteLine("existing application");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 4);

           
        }
    }
}
