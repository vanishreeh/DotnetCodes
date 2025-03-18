using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BookAPPWithdatabase
{
    public class AddHeaderAttribute:TypeFilterAttribute
    {
        public AddHeaderAttribute():base(typeof(AddResultFiler))
        {
            
        }
    }
}
