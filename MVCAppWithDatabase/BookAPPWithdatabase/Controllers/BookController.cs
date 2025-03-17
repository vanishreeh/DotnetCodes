using BookAPPWithdatabase.Service;
using Microsoft.AspNetCore.Mvc;

namespace BookAPPWithdatabase.Controllers
{
    public class BookController : Controller
    {
        readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public async Task<IActionResult> GetAllBooks()
        {

            return View(await _bookService.GetAllBooks());
        }
    }
}
