using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ExtensionMethods
{
    static class ManagerExtensionMethod
    {
        public static void TrackProgress(this Manager manager)
        {
            Console.WriteLine("Progress is being tracked");
        }
    }
}
