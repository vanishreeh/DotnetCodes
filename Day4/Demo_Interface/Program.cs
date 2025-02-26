namespace Demo_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new Bike();
            order.OrderBike();
            order.GetBikeById(1);
        }
    }
}
