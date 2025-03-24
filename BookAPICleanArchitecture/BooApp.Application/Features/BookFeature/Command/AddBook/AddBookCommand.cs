using BookApp.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Features.BookFeature.Command.AddBook
{
   public record AddBookCommand(Book book):IRequest<Book>;
    
}
