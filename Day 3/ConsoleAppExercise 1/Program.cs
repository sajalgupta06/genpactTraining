using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise_1
{


    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length Breadth and Area");
            double length;
            double breadth;
            double area;
            length = double.Parse(Console.ReadLine());
            breadth =double.Parse(Console.ReadLine()) ;
            area = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(length,breadth,area);
            if(area==0)
            {

            Console.WriteLine("Area is : "+ rect.Area());
            }
            else if (length == 0)
            {

                Console.WriteLine("Length is : "+ rect.Length());
            }
            else if  (breadth == 0)
            {

                Console.WriteLine("Breadth is : "+ rect.Breadth());
            }


            Console.ReadKey();


        }
    }
}
