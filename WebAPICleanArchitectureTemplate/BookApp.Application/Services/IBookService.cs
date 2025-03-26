using BookApp.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Application.Services
{
  public  interface IBookService
    {
        List<Book> GetAllBooks();
    }
}
