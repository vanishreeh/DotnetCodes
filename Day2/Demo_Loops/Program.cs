namespace Demo_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region loops
            //for Loop
            //Console.WriteLine("Printing for loop");
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"value of i is ::{i}");
            //}
            //Console.WriteLine("While loop");
            //int j = 0;
            //while (j<10)
            //{
            //    Console.WriteLine($"the value of j is :{j}");
            //    j++;
            //}
            //int k = 0;
            //do
            //{
            //    Console.WriteLine($"the value of k is::{k}");
            //    k++;
            //} while (k < 10);
            #endregion
            #region Break and Continue
            //for(int i=0;i<10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);//break-0,1,2,3,4
            //                         //continue-skpis the 5 and prints rest numbers 0-9
            //}
            #endregion
            //Jump statments
            //take user password as input field
            //user should be given three chances if he enters wrong password
            //if he eneters correctly print respective msg els show him the prompt again
            // print respective msg for 3 time wrong attempt
            int chances = 0;
        login:
            Console.WriteLine("Enter your  Password");
            string password = Console.ReadLine();
            if (password != "Password")
            {
                chances++;
                if (chances < 3)
                {
                    Console.WriteLine("wrong credentials Try again!!!");
                    goto login;
                }
                else
                {
                    Console.WriteLine("your account is blocked try after 24 hrs!!!");
                }
                
            }
            else
            {
                Console.WriteLine("welcome to our APP!!!");
            }

        }
    }
}
