namespace Demo_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.GetDetails("Vani");
            sample.GetDetails(1);
            sample.GetDetails(true);
            sample.CheckNumbers("1", "1");//Typesafety
            sample.CheckNumbers("1",1.ToString());
            List<string> names = new List<string>();
            string name1 = names[0];
            GenericList<int> list1 = new GenericList<int>();
            list1.Add("vanishree");//Typechecking error coz string type
            list1.Add(1);
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("vanishree");
            GenericList<Sample> list3 = new GenericList<Sample>();
            list3.Add(new Sample());
      

        }
    }
}
