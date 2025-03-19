using BookAPPWithdatabase.Models;
using Microsoft.EntityFrameworkCore;
using BookAPPWithdatabase.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BookAPPWithdatabase.Configurations;

namespace BookAPPWithdatabase.Context
{
    public class BookDbContext:IdentityDbContext
    {
        //constructor
        public BookDbContext(DbContextOptions<BookDbContext>options):base(options)//connection object
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAPPWithdatabase.ViewModels.BookViewModel>? BookViewModel { get; set; }
    }
}
