using Demo_ExtensionMethods;
namespace ManagerExtensionLibrary
{
    static public class ManagerExtension
    {
        public static void TrackProgress(this Manager manager)
        {
            Console.WriteLine("Tracking Progress");
        }


    }
}
