
using System;

namespace Demo_Threading
{
    internal class Program
    {
        static int counter = 0; //shared resource
        static void Main(string[] args)
        {
            #region SingleThread Concept  
            //Thread thread = Thread.CurrentThread;//by default they dont have names
            //thread.Name = "PrimaryThread";
            //Console.WriteLine(thread.Name);
            //Console.WriteLine(Thread.CurrentThread.Name);
            //Method1();
            //Console.WriteLine("Method 1 is completed");
            //Method2();
            //Console.WriteLine("Method 2 is completed");
            //Method3();
            //Console.WriteLine("Method 3 is completed");
            #endregion
            #region Creating Multiple Threads
            //Console.WriteLine("Main Thread has Started");
            ////Create Threads
            //Thread thread1 = new Thread(Method1)
            //{
            //    Name = "Thread1"
            //};
            //Thread thread2 = new Thread(Method2)
            //{
            //    Name = "Thread2"
            //};
            //Thread thread3 = new Thread(Method3)
            //{
            //    Name = "Thread3"
            //};
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            //Console.WriteLine("Main thread Completed");
            #endregion
            #region Constructors of thread class
            //Thread t = new Thread(PrintNumbers);
            //ThreadStart ts = new ThreadStart(PrintNumbers);
            // ParameterizedThreadStart pts = new ParameterizedThreadStart(PrintNumbers);
            //HelperClass helper = new HelperClass(10);
            //ThreadStart ts = new ThreadStart(helper.PrintNumbers);
            //Thread t = new Thread(ts);
            ////t.Start("vani");//this throws run time error
            //t.Start();
            #endregion
            Console.WriteLine("Main thread Started");
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);
            Thread t3 = new Thread(Increment);
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine($"Counter Value is::{counter}");//


        }

        //private static void PrintNumbers()
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //private static void PrintNumbers(Object num)
        //{
        //    for (int i = 0; i <(int) num; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        static void Method1()
        {
            Console.WriteLine($"Method1 using Thread::{Thread.CurrentThread.Name}");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Method1 is executing::{i}");
            }
            Console.WriteLine($"Method1 ended using Thread::{Thread.CurrentThread.Name}");
            
        }
        static void Method2()
        {
            Console.WriteLine($"Method2 using Thread::{Thread.CurrentThread.Name}");
            for (int i = 0; i < 4; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Code execution started");
                    Thread.Sleep(10000);
                    Console.WriteLine("Code execution Completed");
                }
                Console.WriteLine($"Method2 is executing::{i}");
            }
            Console.WriteLine($"Method2 ended using Thread::{Thread.CurrentThread.Name}");

        }
        static void Method3()
        {
            Console.WriteLine($"Method3 ended using Thread::{Thread.CurrentThread.Name}");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Method3 is executing::{i}");
            }
            Console.WriteLine($"Method3 ended using Thread::{Thread.CurrentThread.Name}");

        }
        static void Increment()
        {
            for(int i = 0; i < 5000; i++)
            {
                counter++;
            }
        }
    }
    class HelperClass
    {
        int _max;
        public HelperClass(int max)
        {
            _max = max;
        }
        public  void PrintNumbers()
        {
            for (int i = 0; i < _max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
