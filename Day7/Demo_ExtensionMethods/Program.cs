//Extension methods are special kind of static methods used to extend the functionality of the existing class
using ManagerExtensionLibrary;
namespace Demo_ExtensionMethods
{
    internal class Program
    {
        public delegate void GetId(int id);
        static void Main(string[] args)
        {
            #region Extending Builtin type
            ////string name = "vanishree";
            //string name1 = "team";
            //Console.WriteLine(name1.CapitalizeInput()); 
            #endregion
            Manager manager = new Manager();
            manager.ManageTeam();
            //manager.TrackProgress();
            GetId getId = delegate (int input)
            {

                Console.WriteLine(input);
            };
            getId(200);
           
        }
    }
}
