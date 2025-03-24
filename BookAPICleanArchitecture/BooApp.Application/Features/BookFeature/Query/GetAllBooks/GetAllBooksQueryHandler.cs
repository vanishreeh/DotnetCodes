using BooApp.Application.Interfaces;
using BookApp.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Features.BookFeature.Query.GetAllBooks
{
    public class GetAllBooksQueryHandler : IRequestHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        readonly IBookRepository _bookRepository;
        //constructor
        public GetAllBooksQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var allBooks=await _bookRepository.GetBooks();
            return allBooks;
        }
    }
}
