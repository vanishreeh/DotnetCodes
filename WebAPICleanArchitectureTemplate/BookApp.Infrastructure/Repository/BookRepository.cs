using BookApp.domain.Interface;
using BookApp.domain.Models;
using BookApp.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {
        //object of dbcontext
        readonly BookDbContext _bookDbContext;
        public BookRepository(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }
        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}
