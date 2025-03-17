using BookAPPWithdatabase.Models;

namespace BookAPPWithdatabase.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllbooks();
    }
}
