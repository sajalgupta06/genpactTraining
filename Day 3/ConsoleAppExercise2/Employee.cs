using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise2
{
    internal class Employee
    {
        int id;
        string name;
        double salary;
        public static int count = 0;

         public Employee(int id, string name, double salary)
        {
            if(name.Length<=6)
            {
                this.name = "invalid name";
            }
            else
            {
                this.name= name;
            }
            this.id = id;
            this.salary = salary;
            count++;
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public double getSalary()
        {
            return salary;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public static int getCount()
        {
            return count;
        }
        public void Details()
        {
            Console.WriteLine($"Id : {id}\t Name: {name}\t  Salary: {salary}");
        }



    }
}
