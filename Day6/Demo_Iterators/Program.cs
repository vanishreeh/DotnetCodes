namespace Demo_Iterators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListEvenNumbers();
        }

        private static void ListEvenNumbers()
        {
            foreach(int number in Datasource(10,20))
            {
                Console.WriteLine(number);
            }
        }
        static IEnumerable<int>Datasource(int num1,int num2)
        {
            for(int i = num1; i <= num2; i++)
            {
                if(i%2==0)
                {
                    yield return i;
                }
            }
        }
    }
}
