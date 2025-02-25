namespace Demo_jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] marks = new int[3][];
            marks[0] = new int[] { 90, 50, 60 };//stud1
            marks[1] = new int[] { 70, 65 };//stud2
            marks[2] = new int[] { 80, 90, 95, 70 };//stud3

            //access single value
            Console.WriteLine(marks[0][0]);//90
            foreach(int[] item in marks)
            {
                foreach(int mark in item)
                {
                    Console.WriteLine(mark);
                }
            }
            //for(int i = 0; i < marks.Length; i++)
            //{
            //    int sum = 0;
            //    for(int j = 0; j < marks[i].Length; j++)
            //    {
            //        sum += marks[i][j];
            //    }
            //    Console.WriteLine($"Student{i+1}:marks:{sum}");
            //}
            for (int i = 0; i < marks.Length; i++)
            {
                int sum = marks[i].Sum();
                double average =Math.Round(sum / (double)marks[i].Length,3);
                Console.WriteLine($"student{i+1}:\t sum ::{sum}\t average{average}");

            }

        }
    }
}
