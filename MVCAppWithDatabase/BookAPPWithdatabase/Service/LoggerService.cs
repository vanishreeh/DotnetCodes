namespace BookAPPWithdatabase.Service
{
    public class LoggerService : ILoggerService
    {
        public void Log(string msg)
        {
            Console.WriteLine($"Log::{msg}");

        }
    }
}
