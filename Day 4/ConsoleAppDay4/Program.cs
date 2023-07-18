using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OurDerived obj = new OurDerived();
            obj.Display("Hello World");
            Console.ReadKey();
        }
    }
}
