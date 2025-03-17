using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public async Task<IActionResult> AddBook()
        {
            ViewData["AuthorId"] = new SelectList(await _bookService.GetAllAuthors(),"Id" ,"Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(Book book)
        {
            //if (ModelState.IsValid)
            //{
            //    int addStatus = await _bookService.AddBook(book);

            //}
            await _bookService.AddBook(book);
            return RedirectToAction("GetAllBooks");
            //if (ModelState.IsValid)
            //{
            //    int result = await _bookService.AddBook(book);
            //    if (result > 0)
            //    {
            //        TempData["message"] = "Book Added Successfully";
            //        return RedirectToAction("GetAllbooks");
            //    }
            //    else
            //    {
            //        TempData["Msg"] = "Book Addition Failed";
            //        return View(book);
            //    }


            //}
            //else
            //{
            //    return View(book);
            //}



        }
        public async Task<IActionResult>GetBookById(int id)
        {
            try
            {
                var bookResult = await _bookService.GetBookById(id);
                return View(bookResult);
            }
            catch(Exception ex)
            {
                return Content(ex.Message);
            }
           
        }
    }
}
