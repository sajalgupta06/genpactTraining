using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Emp emp1 = new Emp();

            List<Emp> arr  = new List<Emp>();

            emp1.Id = 1;
            emp1.Name ="Abc";
            emp1.Designation = "Developer";
            emp1.Salary = 30000;
            emp1.DOJ = new DateTime(2023, 05, 05);


            arr.Add(emp1)

            Console.ReadLine();



        }
    }
}
