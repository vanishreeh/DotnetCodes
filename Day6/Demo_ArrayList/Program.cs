using System.Collections;

namespace Demo_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Console.WriteLine(arrayList.Capacity);//0
            arrayList.Add(1);
            arrayList.Add("Vani");
            arrayList.Add(true);
            Console.WriteLine(arrayList.Capacity);
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList[0]);
            var input = arrayList[1];
            string name =(string) arrayList[1];
            Console.WriteLine(input.GetType());
            //Insert value
            arrayList.Insert(1, "veena");
            arrayList.Remove(1);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
