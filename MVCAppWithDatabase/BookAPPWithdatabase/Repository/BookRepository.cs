using BookAPPWithdatabase.Context;
using BookAPPWithdatabase.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace BookAPPWithdatabase.Repository
{
    public class BookRepository : IBookRepository
    {
        readonly BookDbContext _bookDbContext;
        //constructor depenedency
        public BookRepository(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }

        public  async Task<int> AddBook(Book book)
        {
            await _bookDbContext.Books.AddAsync(book);
           return await _bookDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
           return  await _bookDbContext.Authors.ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetAllbooks()
        {
            return await _bookDbContext.Books.Include(b=>b.Author).ToListAsync();
        }
               

        public async Task<Book> GetBookById(int id)
        {
            return await _bookDbContext.Books.Include(b=>b.Author).FirstOrDefaultAsync(b => b.Id == id);
      
        }
        public async Task<IEnumerable<Book>> Getbooks()
        {
            return await _bookDbContext.Books.Include(b => b.Author).ToListAsync();
        }

        public async Task<IEnumerable<Book>> SearchBook(string name)
        {
            return await _bookDbContext.Books.Include(b => b.Author).Where(b=>b.Title==name ||b.Author.Name==name)
                .ToListAsync();
        }
    }
}
