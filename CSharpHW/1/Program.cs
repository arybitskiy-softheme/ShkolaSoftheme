using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string name = "Alexander Rybitskiy";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("My name is {0}", name);
            Console.ReadKey();
        }
    }
}
