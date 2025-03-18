using BookAPPWithdatabase.Models;
using Microsoft.EntityFrameworkCore;
using BookAPPWithdatabase.ViewModels;

namespace BookAPPWithdatabase.Context
{
    public class BookDbContext:DbContext
    {
        //constructor
        public BookDbContext(DbContextOptions<BookDbContext>options):base(options)//connection object
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAPPWithdatabase.ViewModels.BookViewModel>? BookViewModel { get; set; }
    }
}
