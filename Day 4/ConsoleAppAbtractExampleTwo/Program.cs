using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbtractExampleTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Square sq = new Square(5);
            Console.WriteLine("Area is " + sq.CalcArea());
            Console.ReadKey();
        }
    }
}
