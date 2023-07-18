using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();
            emp.Display();
            emp.Register();
            emp.Display();
            Console.ReadKey();
        }
    }
}
