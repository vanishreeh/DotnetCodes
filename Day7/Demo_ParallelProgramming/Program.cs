namespace Demo_ParallelProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Main thread Started::{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("C# Normal Forloop");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value of i is::{i}\t Thread::{Thread.CurrentThread.ManagedThreadId}");
            }
            //ParallelOptions options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
            //Console.WriteLine("Parallel For Loop");
            //Parallel.For(1, 11, n => { Console.WriteLine($"Value of i is::{n}\t Thread::{Thread.CurrentThread.ManagedThreadId}"); });
            //Console.WriteLine($"Main thread Completed::{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine("Parallel ForeachLoop");
            List<int> marks = Enumerable.Range(1, 10).ToList();
            Parallel.ForEach(marks, m =>
            {
                Console.WriteLine($"Value of i is::{m}\t Thread::{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);

            });
            Parallel.Invoke(
                () => GetId(1),
                () => GetId(2));

            //PLINQ
            var source = Enumerable.Range(100, 500);
            var evenNumbers =
                            from num in source.AsParallel()
                            where num % 2 == 0
                            select num;
            Console.WriteLine($"Even Numbers::{evenNumbers.Count()}\tSourceCount::{source.Count()}");


        }
        static void GetId(int id)
        {
            Console.WriteLine($" Id is ::{id}\t Thread::{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
