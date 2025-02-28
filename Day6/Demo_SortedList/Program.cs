using System.ComponentModel.DataAnnotations;

namespace Demo_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList<int, Student> studentDetails = new SortedList<int, Student>();
            //studentDetails.Add(10, new Student() { Name = "vani", Marks = 80 });
            //studentDetails.Add(2, new Student() { Name = "vanishree", Marks = 85 });
            //studentDetails.Add(1, new Student() { Name = "veena", Marks = 90 });
            SortedList<string, Student> studentDetails = new SortedList<string, Student>();
            studentDetails.Add("stud1", new Student() { Name = "vani", Marks = 80 });
            studentDetails.Add("Emp1", new Student() { Name = "vanishree", Marks = 85 });
            studentDetails.Add("Cmp2", new Student() { Name = "veena", Marks = 90 });

            foreach (KeyValuePair<string,Student> item in studentDetails)
            {
                Console.WriteLine($"{item.Key}\t{item.Value.Name}\t{item.Value.Marks}");
            }
           
        }
    }
}
