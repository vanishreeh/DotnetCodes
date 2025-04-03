using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooApp.Application.Models.Identity
{
   public class RequestToken
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
