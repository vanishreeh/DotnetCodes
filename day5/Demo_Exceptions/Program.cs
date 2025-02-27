namespace Demo_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  system Exceptions basic
            //Console.WriteLine("Enter your Id::");
            //int userInput = int.Parse(Console.ReadLine());
            //string[] cities = { "Mumbai", "Chennai" };
            //for(int i = 0; i <=cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //try
            //{
            //    Console.WriteLine("Enter your Id::");
            //    int userInput = int.Parse(Console.ReadLine());
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //catch (OverflowException oex)
            //{
            //    Console.WriteLine(oex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("This block gets executed always::");
            //}
            #endregion
            ProcessTransaction processTransaction = new ProcessTransaction();
            processTransaction.CheckLimit(3000);

        }
    }
}
