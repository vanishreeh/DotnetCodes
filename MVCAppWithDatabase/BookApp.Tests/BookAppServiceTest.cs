using BookAPPWithdatabase.Exceptions;
using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Repository;
using BookAPPWithdatabase.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookApp.Tests
{
   public class BookAppServiceTest
    {
        readonly Mock<IBookRepository> _mockRepository;
        readonly BookService _bookService;
        public BookAppServiceTest()
        {
            _mockRepository = new Mock<IBookRepository>();
            _bookService = new BookService(_mockRepository.Object);
        }
        [Fact]
        public async Task Service_Test_To_GetAllBooks()
        {
            var bookList = new List<Book>
            {
                new Book{Id=1,Title="Book1"},
                new Book{Id=2,Title="Book2"}
            };
            //Mocking the Repository
            //var mockRepository = new Mock<IBookRepository>();
            _mockRepository.Setup(r => r.GetAllbooks()).ReturnsAsync(bookList);
            //var bookRepository = _mockRepository.Object;
            //call for dev code
            var booksFromRepo = (await _bookService.GetAllBooks()).ToList();

            //Assert
            Assert.Equal(bookList.Count, booksFromRepo.Count);

        }
        [Fact]
        public async Task Test_GetBookById()
        {
            //create a mock
           // var mockRepository = new Mock<IBookRepository>();
            _mockRepository.Setup(r => r.GetBookById(1)).ReturnsAsync(new Book { Id = 1, Title = "Book2" });
           // var bookService = new BookService(_mockRepository.Object);
            //call the dev code
            var book=await _bookService.GetBookById(1);

            //Assert
            Assert.NotNull(book);
            Assert.Contains("Book2", book.Title);
        }

        [Fact]
        public async Task Test_To_Check_Exception()
        {
            //creating mock object
            //var mockRepository = new Mock<IBookRepository>();
            //Define setup method
            _mockRepository.Setup(r => r.GetBookById(1)).ReturnsAsync((Book)null);
            //var bookService = new BookService(_mockRepository.Object);

            //Assert
           await Assert.ThrowsAnyAsync<BookNotFoundException>(() => _bookService.GetBookById(1));
        }
    }
}
