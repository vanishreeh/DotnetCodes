using BookAPPWithdatabase.Models;

namespace BookAPPWithdatabase.Service
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
