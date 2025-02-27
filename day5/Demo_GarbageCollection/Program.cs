namespace Demo_GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("Ola", 60);
            Console.WriteLine($"Name::{bike.Name}\tSpeed::{bike.Speed}");
            Console.WriteLine("Estimated memory on Heap");
            Console.WriteLine(GC.GetTotalMemory(false));
            //Maximum Generation supported
            Console.WriteLine(GC.MaxGeneration);//1916648 bytes required
            //GC.Collect();//forced to invoke garbage collection
            //GC.WaitForPendingFinalizers();//current thread is suspended untill queue is empty
            //GC.SuppressFinalize(bike);//donot call finalizer
            Console.WriteLine(GC.GetGeneration(bike));//Gen0

            object[] moreObjects = new object[40000];
            for(int i = 0; i < 40000; i++)
            {
                moreObjects[i] = new object();
            }
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            Console.WriteLine(GC.GetGeneration(bike)); 
            if (moreObjects[8000] != null)
            {
                Console.WriteLine(GC.GetGeneration(moreObjects[8000]));
            }
            else
            {
                Console.WriteLine("moreObjects[8000] is deleted");
            }
            Console.WriteLine($"Generation 0 has deleted::{GC.CollectionCount(0)}");
            Console.WriteLine($"Generation 1 has deleted::{GC.CollectionCount(1)}");
            Console.WriteLine($"Generation 2 has deleted::{GC.CollectionCount(2)}");
        }

        public static void AddBike()
        {
            Bike bike1 = new Bike();
            bike1 = null;//
        }
    }
}
