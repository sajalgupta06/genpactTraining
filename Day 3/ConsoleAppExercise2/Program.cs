using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee(1, "rohan", 50000);
            emp1.Details();
            Console.WriteLine(Employee.getCount());

            Employee emp2 = new Employee(12, "ranveer", 30000);
            emp2.Details();
            Console.WriteLine(Employee.getCount());


            Employee emp3 = new Employee(34, "Any Name", 23000);
            emp3.Details();
            Console.WriteLine(Employee.getCount());

            Console.ReadKey();

        }
    }
}
