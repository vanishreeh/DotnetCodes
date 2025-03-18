using BookAPPWithdatabase.Models;

namespace BookAPPWithdatabase.Repository
{
    public interface IBookRepository
    {
        Task<int> AddBook(Book book);
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<IEnumerable<Book>> GetAllbooks();
        Task<Book> GetBookById(int id);
        Task<IEnumerable<Book>> Getbooks();
        Task<IEnumerable<Book>> SearchBook(string name);
    }
}
