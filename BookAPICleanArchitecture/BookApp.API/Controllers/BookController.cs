using BooApp.Application.Exceptions;
using BooApp.Application.Features.BookFeature.Command.AddBook;
using BooApp.Application.Features.BookFeature.Command.DeleteBook;
using BooApp.Application.Features.BookFeature.Query.GetAllBooks;
using BooApp.Application.Features.BookFeature.Query.GetBookById;
using BookApp.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        readonly IMediator _mediator;
        //constructor dependency
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
            
        }
        #region
        //[HttpGet("Status-Code")]
        ////using statuscode method
        //public IActionResult GetCustomStatusCode()
        //{
        //    return StatusCode(445, new { message = "This is CustomStatuscode" });
        //}
        //[HttpGet("objectResult")]
        //public IActionResult GetCustomStatusCodeWithobjectResult()
        //{
        //    return new ObjectResult(new { message = "Custom objectresult" }) { StatusCode = 450 };
        //}
        //[HttpGet("ActionResult-code")]
        //public ActionResult<string> GetCustomStatusCodeWithAction()
        //{
        //    return StatusCode(351,"custom result with Action");
        //}
        //[HttpGet("ProblemResult")]
        //public IActionResult GetCustomStatusCodeWithProblemResult()
        //{
        //    return Problem(
        //        title: "Error Response",
        //        detail: "request Not correct",
        //        statusCode: 299
        //        );
        //}
        //[HttpGet("contextResult")]
        //public void GetCustomStatusCodeWithcontextResult()
        //{
        //    HttpContext.Response.StatusCode = 203;
        //}


        #endregion
        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
          var allBooks= await _mediator.Send(new GetAllBooksQuery());
            return Ok(allBooks);
        }
        [HttpPost]
        public async Task<IActionResult> AddBooksAsync(Book book)
        {
            var result = await _mediator.Send(new AddBookCommand(book));
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookByIdAsync(int id)
        {
            var result = await _mediator.Send(new GetBookByIdQuery(id));
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookAsync(int id)
        {
            #region Exception Handling
            //try
            //{
            //    var result = await _mediator.Send(new DeleteBookCommand(id));
            //    return Ok(result);
            //}
            //catch(NotFoundException ex)
            //{
            //    return NotFound(ex.Message);
            //}
            #endregion
            var result = await _mediator.Send(new DeleteBookCommand(id));
            return Ok(result);

        }
    }
}
