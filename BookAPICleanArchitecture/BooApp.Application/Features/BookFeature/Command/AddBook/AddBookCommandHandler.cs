using BooApp.Application.Interfaces;
using BookApp.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Features.BookFeature.Command.AddBook
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, Book>
    {
        readonly IBookRepository _bookRepository;
        public AddBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }
        public Task<Book> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = _bookRepository.AddBookAsync(request.book);
            return book;
        }
    }
}
