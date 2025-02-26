using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExUseCase
{
    class MobileNumberValidation
    {
        public const string pattern = @"^[+]?91[-\s]?[6-9][0-9]{9}$";
        
        //method to implement logic
        public static bool ValidateMobNum(string num)
        {
            if (num != null)
            {
                return Regex.IsMatch(num, pattern);
            }
            return false;

        }
    }
}
