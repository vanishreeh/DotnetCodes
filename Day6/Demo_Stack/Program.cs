using System.Collections;
namespace Demo_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack();//non genric collection
            Stack<string> history = new Stack<string>();//order is LIFO
            //Push,Pop,Peek--built in methods
            history.Push("C#");
            history.Push("Collections");
            history.Push("LINQ");
            Console.WriteLine(history.Pop());//LINQ--Removes and Returns the element
            Console.WriteLine(history.Count);//2
            Console.WriteLine(history.Peek());//LINQ--Returning the Last Element
            Console.WriteLine(history.Count);//2

        }
    }
}
