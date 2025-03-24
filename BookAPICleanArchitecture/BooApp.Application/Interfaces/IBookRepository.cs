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
        Task<Book> GetBookByIdAsync();
        Task<Book> AddBookAsync();
        Task<Book> UpdateBookAsync(int bookId,Book book);
        Task<bool> DeleteBookAsync();


    }
}
