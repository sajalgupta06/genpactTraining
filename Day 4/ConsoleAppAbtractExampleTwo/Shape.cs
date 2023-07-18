using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbtractExampleTwo
{
    internal abstract class Shape
    {
       public abstract double CalcArea();

        public void Display()
        {
            Console.WriteLine("Welcome to Shapes");
        }
    }
}
