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
            List<string> list = new List<string>() { "name1","name2"};
           
            LargeDataCollection ldc = new LargeDataCollection(list);

            ldc.Add("Sam");
            ldc.Add("Tom");
            ldc.Remove("Sam");

            ldc.Search("Tom");

            Console.WriteLine("Item in the List are");
            ldc.Print();
            ldc.Dispose();

            Console.ReadKey();

        }
    }
}
