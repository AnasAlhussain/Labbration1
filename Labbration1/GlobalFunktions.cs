using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labbration1
{
    internal class GlobalFunktions
    {
        public static void UniversalReadKeyMethod()//Two methods to clean up the code with ReadKey
        {
            Console.WriteLine("Invalid input. Please enter a valid option...");
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
        }

        public static void UniqueReadKeyMethod()
        {
            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
        }

       
    }
}
