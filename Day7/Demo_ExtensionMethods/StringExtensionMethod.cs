namespace Demo_ExtensionMethods
{
   static class  StringExtensionMethod
    {
        public static string CapitalizeInput(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                return char.ToUpper(input[0]) + input.Substring(1);
            }
        }

    }
}
