using BookAPPWithdatabase.AspectOrientedProgramming;
using BookAPPWithdatabase.Logginglogic;
using BookAPPWithdatabase.Models;
using BookAPPWithdatabase.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.CompilerServices;

namespace BookAPPWithdatabase.Controllers
{
    [ServiceFilter(typeof(ExceptionHandlerAttribute))]
    [ServiceFilter(typeof(CustomLogger))]
    //[Authorize(Roles ="Admin")]
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
            ViewData["AuthorId"] = new SelectList(await _bookService.GetAllAuthors(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromForm] Book book)
        {
            //if (ModelState.IsValid)
            //{
            //    int addStatus = await _bookService.AddBook(book);

            //}
            //await _bookService.AddBook(book);
            //return RedirectToAction("GetAllBooks");
            ModelState.Remove("Author");
            if (ModelState.IsValid)
            {
                int result = await _bookService.AddBook(book);
                if (result > 0)
                {
                    TempData["message"] = "Book Added Successfully";
                    return RedirectToAction("GetAllbooks");
                }
                else
                {
                    TempData["Msg"] = "Book Addition Failed";
                    return View(book);
                }


            }
            else
            {
                return View(book);
            }



        }
        public async Task<IActionResult> GetBookById(int id)
        {
            //try
            //{
                var bookResult = await _bookService.GetBookById(id);
                return View(bookResult);
           // }
            //catch (Exception ex)
            //{
            //    return Content(ex.Message);
            //}

        }
        #region ViewModelReturnType
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookService.GetBooks();
            return View(books);
        }
        #endregion
        #region ModelBinding
        public string Get([FromRoute] int id, [FromQuery] string name, [FromHeader(Name = "Accept-Language")] string language)
        {
            return $"Id::{id} name::{name}Language::{language}";
        }

        public string Get1(int id, string name, string language)
        {
            return $"Id::{id} name::{name}Language::{language}";
        }
        public async Task<IActionResult> AddBook1(FormCollection formCollection)
        {
            Book book = new Book();
            book.Id = Convert.ToInt32(formCollection["Id"]);
            book.Title = (formCollection["Title"]);
            book.AuthorId = Convert.ToInt32((formCollection["AuthorId"]));
            book.Isbn = (formCollection["Isbn"]);
            _bookService.AddBook(book);

            return View();

        }
        #endregion

        public async Task<IActionResult>Search(string name)
        {
         var books= await  _bookService.SearchBook(name);
            return View(books);
        }
    }
}
