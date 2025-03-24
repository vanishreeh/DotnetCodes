using BooApp.Application.Exceptions;
using BooApp.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Features.BookFeature.Command.DeleteBook
{
    public class DeleteBookCommandhandler : IRequestHandler<DeleteBookCommand, bool>
    {
        readonly IBookRepository _bookRepository;
        public DeleteBookCommandhandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }
        public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
          var bookFindStatus= await _bookRepository.GetBookByIdAsync(request.id);
            if(bookFindStatus is null)
            {
                throw new NotFoundException($"Book with Id::{request.id} not found");

            }
          return await _bookRepository.DeleteBookAsync(bookFindStatus.Id);
          
        }
    }
}
