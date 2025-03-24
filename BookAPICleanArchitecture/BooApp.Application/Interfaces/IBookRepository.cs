using BookApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Interfaces
{
   public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBookByIdAsync(int id);
        Task<Book> AddBookAsync(Book book);
        Task<Book> UpdateBookAsync(int bookId,Book book);
        Task<bool> DeleteBookAsync(int id);


    }
}
