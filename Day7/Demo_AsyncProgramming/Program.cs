
using System.Threading.Tasks;

namespace Demo_AsyncProgramming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Blocking and nonBlocking
            //Console.WriteLine("Getting Data");
            //#region Blocking Thread
            ////string data = GetDataFromApI();
            ////Console.WriteLine($"Data received::{data}");
            //#endregion
            //Task<string> result = GetDataFromApIAsync();
            //Console.WriteLine("Doing Some other Work while waiting");
            ////Result from API
            //string response = await result;
            //Console.WriteLine($"Data Is Received::{response}");
            #endregion
            ToDo todo = new ToDo();
            var task = await todo.GetDataAsync();
            Console.WriteLine(task);
        }

        //private static string GetDataFromApI()
        //{
        //    Console.WriteLine("Calling API");
        //    //Delay
        //    Thread.Sleep(4000);
        //    return "API Returned Response";
        //}
        private static async Task<string>  GetDataFromApIAsync()
        {
            Console.WriteLine("Calling API");
            //Delay
            //Thread.Sleep(4000);
            await Task.Delay(5000);
            return "API Returned Response";
        }

    }


}
