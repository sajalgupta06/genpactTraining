using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass obj = new MyClass();
            Interface1 obj1 = obj;
            obj1.Display();


            Interface2 obj2 = obj;
            obj2.Display();

            Console.ReadLine();
        }
    }
}
