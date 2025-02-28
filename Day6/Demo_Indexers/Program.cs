//Indexers are special kind of Properties which makes a class to behave like an virtual array
namespace Demo_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRecords studRec = new StudentRecords(1,"Vanishree");
            Console.WriteLine($"{studRec[1]}\t{studRec[2]}");
            StudentRecords studRec1 = new StudentRecords(2, "Vanishree");
            Console.WriteLine($"{studRec1[1]}\t{studRec1[2]}");
            ////Console.WriteLine(studRec.Marks[0]);
            //for
            //Console.WriteLine(studRec[0]);
            //Console.WriteLine(studRec[1]);
        }
    }
}
