using BooApp.Application.Interfaces;
using BookApp.Domain;
using BookApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
      protected  readonly BookDbContext _bookDbContext;
        //constructor injection
        public BookRepository(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }
        public  async Task<Book> AddBookAsync(Book book)
        {
           await _bookDbContext.Books.AddAsync(book);
            await _bookDbContext.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book =  await GetBookByIdAsync(id);
            if(book is not null)
            {
                _bookDbContext.Books.Remove(book);
                return  await _bookDbContext.SaveChangesAsync() > 0;

            }
            return false;
           
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
           return await _bookDbContext.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

        public  async Task<IEnumerable<Book>> GetBooks()
        {
           return await _bookDbContext.Books.ToListAsync();
        }

        public Task<Book> UpdateBookAsync(int bookId, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
