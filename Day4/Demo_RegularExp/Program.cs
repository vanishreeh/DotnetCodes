using System.Text.RegularExpressions;

namespace Demo_RegularExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "welcome";
            Regex reg = new Regex(pattern);
            Console.WriteLine(reg.IsMatch("welcome"));//true
            Console.WriteLine(Regex.IsMatch("welcome",pattern));//true

            string mystr = "Today is wednesday 26th of feb 2025 day of the week is 3";
            Match matchResult = Regex.Match(mystr, "day");
            Console.WriteLine(matchResult.Index);//2
            //charcaters classes
            Console.WriteLine("***************");
           // MatchCollection matchcollection=Regex.Matches(mystr, @"\d");
            MatchCollection matchcollection = Regex.Matches(mystr, @"\d{2,4}");
            foreach (Match match in matchcollection)
            {
                Console.WriteLine(match);
            }
            
        }
    }
}
