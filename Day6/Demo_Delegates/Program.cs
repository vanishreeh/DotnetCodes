//Func delegate----point to a function which has value return type
//Action delegate---points to a function which doesn't return any value
//Predicate delegate--points to a function which  return bool value
namespace Demo_Delegates
{
    //Delegate is a type which references to methods with some parameterList and return type
    //call back methods and Events
    //used to pass method as an argument to another

    //Declaration of Delegate
    //public delegate string DeleagteToGetMethod(string input);
    // public delegate int DelegateToMultiply(int n1, int n2);
    //public delegate void DelegateToMultiply1(int n1, int n2);
    //public delegate bool DelegateToCheck(string input);
    //make a delegate
    delegate void Mailer(string email);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegates Basic
            ////Instantiate a delegate
            //DeleagteToGetMethod di = new DeleagteToGetMethod(GetInfo);
            ////Invoke a delegate
            //Console.WriteLine(di.Invoke("Vani"));
            //Console.WriteLine(di("vanishree"));
            #endregion
            #region Generic Delegates
            ////DelegateToMultiply dm = new DelegateToMultiply(Multiply);
            //// Func<int, int, int> dm = Multiply;
            //Func<int, int, int> dm = (num1, num2) => num1 * num2;
            //Console.WriteLine(dm(100,100));
            ////DelegateToMultiply1 dm1 = new DelegateToMultiply1(Multiply1);
            //// Action<int, int> dm1 = Multiply1;
            //Action<int, int> dm1 = (num1, num2) => Console.WriteLine(num1 * num2); 
            //dm1(100, 100);
            ////DelegateToCheck dc = new DelegateToCheck(Check);
            ////Predicate<string> dc = Check;
            //Predicate<string> dc = (msg) =>
            //{
            //    if (msg.Count() > 3)
            //    {
            //        return true;
            //    }
            //    return false;
            //};
            //Console.WriteLine(dc("Welcome"));
            #endregion
            //Multicast Delegate
            //Mailer mail = new Mailer(InternalMail);
            //Mailer mailer = ExternalMail;
            //mailer += InternalMail;
            //mailer("C# training");
           


        }

        static void InternalMail(string msg)
        {
            Console.WriteLine($"This is from internal office::{msg}");
        }

        static void ExternalMail(string msg)
        {
            Console.WriteLine($"This is from External office::{msg}");
        }

        //static string GetInfo(string name)
        //{
        //    return name;
        //}

        //static int Multiply(int num1,int num2)
        //{
        //    return num1 * num2;
        //}
        //static void Multiply1(int num1, int num2)
        //{
        //    Console.WriteLine(num1 * num2); 
        //}
        //static bool Check(string msg)
        //{
        //    if (msg.Count() > 4)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
