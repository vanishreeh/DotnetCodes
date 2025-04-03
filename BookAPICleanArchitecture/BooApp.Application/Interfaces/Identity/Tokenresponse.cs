using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Interfaces.Identity
{
   public class Tokenresponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
