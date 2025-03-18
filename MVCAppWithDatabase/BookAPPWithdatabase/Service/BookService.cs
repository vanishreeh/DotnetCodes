using BookAPPWithdatabase.Exceptions;
using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Repository;
using BookAPPWithdatabase.ViewModels;

namespace BookAPPWithdatabase.Service
{
    public class BookService : IBookService
    {
        readonly IBookRepository _bookRepository;
        //constructor
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> AddBook(Book book)
        {
          return await _bookRepository.AddBook(book);
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _bookRepository.GetAllAuthors();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
          return await _bookRepository.GetAllbooks();
        }

        public async Task<Book> GetBookById(int id)
        {
           var book=  await _bookRepository.GetBookById(id);
            if (book == null)
                throw new BookNotFoundException($"Book with Id{id} not found");
            return book;
        }

        public async  Task<IEnumerable<BookViewModel>> GetBooks()
        {
            var books = await _bookRepository.Getbooks();
          return  books.Select(b => new BookViewModel
            {
                Id = b.Id,
                Title = b.Title,
                AuthorName = b.Author.Name

            }).ToList();
        }

        public async Task<IEnumerable<Book>> SearchBook(string name)
        {
          return await  _bookRepository.SearchBook(name);
        }
    }
}
