﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Features.BookFeature.Command.DeleteBook
{
    public record DeleteBookCommand(int id):IRequest<bool>;
    
}
