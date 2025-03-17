namespace BookAPPWithdatabase.Exceptions
{
    public class BookNotFoundException:ApplicationException
    {
        public BookNotFoundException()
        {
            
        }
        public BookNotFoundException(string msg):base(msg)
        {
            
        }
    }
}
