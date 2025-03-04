

namespace Demo_DeadLock
{
    internal class Program
    {
        //static object lock1 = new object();
        //static object lock2 = new object();
        static void Main(string[] args)
        {
            #region Avoiding Deadlocks
            //Thread t1 = new Thread(Thread1);
            //Thread t2 = new Thread(Thread2);
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();
            //Console.WriteLine("Both threads Executed");
            #endregion
            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Method1));
            }
            Console.WriteLine("Main thread Completed");
        }

        private static void Method1(object? state)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine($"BackGround::{thread.IsBackground}\t Thread Pool::{thread.IsThreadPoolThread}\tThreadId::{thread.ManagedThreadId}");
        }

        private static void Thread2(object? obj)
        {
            #region DeadLock
            //lock (lock2)//lock2 acquired
            //{
            //    Console.WriteLine("Thread2 acquired lock2 waiting for lock 1");
            //    Thread.Sleep(1000);
            //    lock (lock1)
            //    {
            //        Console.WriteLine("Thread2 acquired lock1 ");
            //    }

            //}
            #endregion
            #region Avoiding DeadLocks
            //    lock (lock1)//
            //    {
            //        Console.WriteLine("Thread 2 applied for lock and waiting for lock2");
            //        Thread.Sleep(1000);
            //        lock (lock2)
            //        {
            //            Console.WriteLine("Thread 2 acquired lock2");
            //        }

            //    }
            //}

            //private static void Thread1()
            //{
            //    lock (lock1)//
            //    {
            //        Console.WriteLine("Thread 1 applied for lock and waiting for lock2");
            //        Thread.Sleep(1000);
            //        lock (lock2)
            //        {
            //            Console.WriteLine("Thread 1 acquired lock2");
            //        }

            //    }
            //}
            #endregion
        }
    }
}
