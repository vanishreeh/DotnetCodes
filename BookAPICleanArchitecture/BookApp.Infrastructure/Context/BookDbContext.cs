using BookApp.Domain;
using BookApp.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Infrastructure.Context
{
   public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors{ get; set; }

    }
}
