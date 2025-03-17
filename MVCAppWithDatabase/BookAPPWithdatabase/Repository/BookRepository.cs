using BookAPPWithdatabase.Context;
using BookAPPWithdatabase.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Book>> GetAllbooks()
        {
            return await _bookDbContext.Books.Include(b=>b.Author).ToListAsync();
        }
    }
}
