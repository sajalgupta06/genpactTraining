using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct prod = new HerbalProduct(1, "Soap", 343, "anything", new DateTime(12 / 12 / 12), new DateTime(12 / 12 / 13));
            prod.Display();

            Console.ReadKey();
        }
    }
}
