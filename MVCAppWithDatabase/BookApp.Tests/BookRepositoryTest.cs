using BookAPPWithdatabase.Context;
using BookAPPWithdatabase.Exceptions;
using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookApp.Tests
{
   public class BookRepositoryTest:IClassFixture<BookDbTestFixture>
    {
        //readonly BookDbContext _context;
        readonly IBookRepository _bookRepository;
        public BookRepositoryTest(BookDbTestFixture bookDbTestFixture)
        {
            //    _context = bookDbTestFixture._bookdbContext;
            //    _bookRepository = new BookRepository(_context);
            _bookRepository = bookDbTestFixture.BookRepository ?? throw new ArgumentNullException(nameof(bookDbTestFixture.BookRepository));
           
         }


            [Fact]
        public async Task Test_To_GetAllBooks()
        {
            //Act
            var allBooks = await _bookRepository.GetAllbooks();
            var bookList = allBooks.ToList();

            //Assert
            // Assert.NotEmpty(allBooks);
            Assert.NotEmpty(bookList);
            Assert.NotNull(allBooks);
            Assert.Equal(2, bookList.Count);

        }

        [Fact]
        public async Task Test_To_AddBook()
        {
            //Arrange
            var book = new Book
            {
                Title = "Book2",
                Isbn = "I002",
                AddedAt = DateTime.Now,
                AuthorId = 1

            };
            //Act
            await _bookRepository.AddBook(book);
            var books = await _bookRepository.GetAllbooks();
            var allBooks = books.ToList();
            //Assert
            Assert.Contains(allBooks, b => b.Title == "Book2");
        }
        [Fact]
        public async Task Test_To_GetBookBy_Id()
        {
           var book= await _bookRepository.GetBookById(100);
            //Assert.Equal(null, book);
            Assert.Null(book);
        }
        public async Task Test_To_GetBookBy_Id_ThrowsException()
        {
            var book = _bookRepository.GetBookById(100);
           // var book = await Assert.ThrowsAnyAsync<BookNotFoundException>(()=>_bookRepository.GetBookById(100));
            //Assert.Equal("Book with 100 not found", book.Message);
            Assert.Null(book);
        }
    }
}
