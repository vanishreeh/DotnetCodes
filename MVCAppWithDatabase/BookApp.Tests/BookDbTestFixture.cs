using BookAPPWithdatabase.Context;
using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Repository;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Tests
{
    public class BookDbTestFixture
    {
        internal BookDbContext _bookdbContext;
        public IBookRepository BookRepository { get; set; }
        //constructor
        public BookDbTestFixture()
        {
            var bookDbContextoptions = new DbContextOptionsBuilder<BookDbContext>().UseInMemoryDatabase("BookLocalDb").Options;
            var _bookdbContext = new BookDbContext(bookDbContextoptions);
            var author = new Author { Id = 1, Name = "Author1" };
            _bookdbContext.Add(author);
            _bookdbContext.Add(new Book { Id = 1, Title = "Book1", Isbn = "I001", AddedAt = DateTime.Now, AuthorId = 1, Author = author });
            _bookdbContext.SaveChanges();
            BookRepository = new BookRepository(_bookdbContext);
        }
       
    }
}
