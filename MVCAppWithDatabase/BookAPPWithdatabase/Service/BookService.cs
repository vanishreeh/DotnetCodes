using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Repository;

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
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
          return await _bookRepository.GetAllbooks();
        }
    }
}
