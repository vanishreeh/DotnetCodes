using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.ViewModels;
using System.Collections;

namespace BookAPPWithdatabase.Service
{
    public interface IBookService
    {
        Task<int> AddBook(Book book);
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task<IEnumerable<BookViewModel>> GetBooks();
    }
}
