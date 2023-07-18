using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    public class Emp
    {
        int id;
        string name;

        public Emp()
        {
            Console.WriteLine("COnstructor of class Emp");
            id = -1;
            name = "not given";
        }

        public void Register()
        {
            Console.WriteLine("ENter Employee Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            name = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("ID : \t" +  id);
            Console.WriteLine("Name: \t" + name);
        }


    }
}
