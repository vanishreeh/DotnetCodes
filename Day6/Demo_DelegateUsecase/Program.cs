namespace Demo_DelegateUsecase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payment initiated");
            ProcessPayment payment = new ProcessPayment();
            payment.PaymentProcess(500.234M, NotifyUser);
            //Console.WriteLine("Hello, World!");
            //ProcessPayment process = new ProcessPayment(5);
            //process.OnStart += NotifyUser;
            //process.BeginTransaction();
        }


        //static void NotifyUser()
        //{
        //    Console.WriteLine("Event Handler::Process Initiated");
        //}
        static void NotifyUser( string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
