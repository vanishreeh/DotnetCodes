namespace Demo_valAndRefTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sample sample1Obj = new Sample();
            //sample1Obj.x = 100;
            //sample1Obj.y = 100;
            //Sample sample2Obj = sample1Obj;
            //Console.WriteLine(sample1Obj.x);
            //Console.WriteLine(sample1Obj.y);
            //Console.WriteLine(sample2Obj.x);
            //Console.WriteLine(sample2Obj.y);
            //Console.WriteLine("Change sample2Obj value");
            //sample2Obj.x = 500;
            //Console.WriteLine(sample1Obj.x);//100
            //Console.WriteLine(sample2Obj.x);//500
            RefClass refObj1 = new RefClass();
            refObj1.x = 100;
            refObj1.y = 100;
            Console.WriteLine("assign refobj1 to obj2");
            RefClass refObj2 = refObj1;
            Console.WriteLine(refObj1.x);
            Console.WriteLine(refObj1.x);
            Console.WriteLine(refObj2.x);
            Console.WriteLine(refObj2.x);
            refObj2.x = 600;
            Console.WriteLine(refObj1.x);//600
            Console.WriteLine(refObj2.x);//600

        }
    }
}
