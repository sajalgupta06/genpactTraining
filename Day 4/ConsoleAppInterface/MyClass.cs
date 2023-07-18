using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    internal class MyClass: Interface1, Interface2
    {
        void Interface1.Display()
        {

            Console.WriteLine("Interface1 Display");
        }

        void Interface2.Display()
        {

            Console.WriteLine("Interface2 Display");
        }

    }
}
