using BooApp.Application.Interfaces;
using BookApp.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Features.BookFeature.Query.GetBookById
{
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, Book>
    {
        readonly IBookRepository _bookRepository;
        public GetBookByIdQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }
        public async Task<Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
           var bookFindStatus=await  _bookRepository.GetBookByIdAsync(request.id);
            return bookFindStatus;
        }
    }
}
