using BookAPPWithdatabase.Models;
using System.Collections;

namespace BookAPPWithdatabase.Service
{
    public interface IBookService
    {
        Task<int> AddBook(Book book);
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
    }
}
