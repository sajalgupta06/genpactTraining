using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppExercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee DOB");
            string dob = Console.ReadLine();

            string path = "C:\\Employees/";
            string fileName = path + name + "_" + dob+".txt"; 

            File.Create(fileName).Close();
            Console.WriteLine("File Created");
            

            Console.WriteLine("Enter Employee Id , City and Address");

            string id = Console.ReadLine();
            string city= Console.ReadLine();
            string address= Console.ReadLine();

            File.WriteAllText(fileName,$"id : {id}, Name:{name} City :{city} Address : {address} Dob :{dob}");
            Console.WriteLine("Task Completed");

            string[] lines;
            if (File.Exists(fileName))
            {
                lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();


        }
    }
}
