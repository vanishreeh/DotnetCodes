using BookApp.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.domain.Interface
{
   public interface IBookRepository
    {
        List<Book> GetAllBooks();
    }
}
