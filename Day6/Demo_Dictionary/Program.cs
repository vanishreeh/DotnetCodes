namespace Demo_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> userDetails = new Dictionary<int, string>();
            userDetails.Add(1, "Student1");
            userDetails.Add(2, "student2");
            //userDetails.Add(1, "student3");//keys cannot be duplicated
            userDetails.Add(3, "student3");
            //Access all the values from dictionary
            foreach (var item in userDetails)
            {
                //Console.WriteLine(item.GetType());//gets the CLR Types
                Console.WriteLine(item);
            }
            foreach(KeyValuePair<int,string> item in userDetails)
            {
                Console.WriteLine($"Id:{item.Key}\t Name::{item.Value}");
            }
            //Update a value in Dictionary
            userDetails[1] = "Employee1";
            Console.WriteLine("----Updated Dictionary----------");
            foreach (KeyValuePair<int, string> item in userDetails)
            {
                Console.WriteLine($"Id:{item.Key}\t Name::{item.Value}");
            }
            //To remove an entry 
            userDetails.Remove(1);
            foreach (KeyValuePair<int, string> item in userDetails)
            {
                Console.WriteLine($"Id:{item.Key}\t Name::{item.Value}");
            }
            //how to find a existance of user
            bool searchResult = userDetails.ContainsKey(1);
            Console.WriteLine(searchResult);

           bool findResult= userDetails.TryGetValue(1, out string? name);
            //Console.WriteLine(findResult);
            Console.WriteLine(name);



        }
    }
}
