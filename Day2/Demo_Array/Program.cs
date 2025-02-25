namespace Demo_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Single dimension Array
           // string filePath = @"c:\Cognixia\DotnetCodes";
            //declare an Array
            //int[] marks;
            //int[] marks = new int[5];
            //int[] mark1 = { 100, 90, 80 };
            //string[] cities = { "Bangalore", "Chennai", "Mumbai" };
            
            ////Access individual elements
            ////Console.WriteLine(cities[0]);//Bangalore
            ////foreach(string item in cities)
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////Boxing---converting value to reference type
            ////int age = 30;
            ////object newAge = age;
            //////unboxing----reference to value types
            ////object mark = 100;
            ////int myMarks =(int) mark;

            // object[] details = { "vani", 12345, "Bangalore" };

            ////Array Functions
            ////Sort an Array
            //int[] marks = { 75, 45, 100, 80 };
            //Console.WriteLine("Sorting an Array");
            //Array.Sort(marks);//sort an array
            //foreach(int mark in marks)
            //{
            //    Console.WriteLine(mark);
            //}
            //Array.Reverse(marks);

            ////find city named chennai 
            //Console.WriteLine("Searching an element");
            //string cityToBeSearched = "delhi";
            //int findResult1 = Array.Find(marks, c => c == 100);
            //object findResult=Array.Find(details, c => c == 100);
            //if (findResult != null)
            //{
            //    Console.WriteLine(findResult);
            //}
            //else
            //{
            //    Console.WriteLine("City not found!!");
            //}
            #endregion
            //2-d Array
            int[,] stuMarks = new int[2, 2];
            int[,] stuMarks1 = new int[2, 2]
            {
                {1,100 },
                {2,80 }
            };
            for(int i = 0; i < stuMarks1.GetLength(1); i++)
            {
                if (stuMarks1[i, 0] == 2)
                {
                    Console.WriteLine(stuMarks1[i,1]);
                }
                else
                {
                    Console.WriteLine("");
                }
            }

        }


    }
}
