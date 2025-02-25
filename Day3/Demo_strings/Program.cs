using System.Text;

namespace Demo_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string Declaration
            //string name = "vani";
            //string? city = null;
            //string state = "";
            //string fName = "Vani";
            //string lName = "shree";
            //fName += lName;
            //Console.WriteLine(fName);
            #endregion
            #region
            //string builder
            //StringBuilder sb = new StringBuilder();
            //DateTime startTime;
            //DateTime endTime;
            //TimeSpan totalTime;
            //string s = "";
            ////startTime = DateTime.Now;
            ////for(int i = 0; i < 10000; i++)
            ////{
            ////    s += i;
            ////}
            ////endTime = DateTime.Now;
            ////totalTime = endTime - startTime;
            ////Console.WriteLine($"Total time taken is::{totalTime.TotalSeconds}");//0.213
            ////stringbuilder
            //StringBuilder sb1 = new StringBuilder(50);
            //Console.WriteLine(sb1.Capacity);
            //startTime = DateTime.Now;
            //for (int i = 0; i < 10000; i++)
            //{
            //    sb1.Append(i);
            //}
            //endTime = DateTime.Now;
            //totalTime = endTime - startTime;
            //Console.WriteLine($"Total time taken is::{totalTime.TotalSeconds}");//0.014
            #endregion
            // string query = "toDay is C#Session neoSoft";
            string fname = "vanishree";
            string lname = "shree";
            Console.WriteLine(fname.Contains(lname));
            Console.WriteLine(string.Compare(fname,lname));
            Console.WriteLine(fname.Equals(lname));
            fname.ToUpper();
            Console.WriteLine(fname.Length);//length of the string
            Console.WriteLine(fname.Any(char.IsUpper));



        }
    }
}
