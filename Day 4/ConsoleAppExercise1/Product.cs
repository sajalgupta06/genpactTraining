using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise1
{
    internal class Product
    {

        int pid;
        string pname;
        double pprice;

        public Product(int id , string name, double price)
        {
            this.pid = id;
            this.pname = name;  
            this.pprice = price;
        }

       public virtual void SetInfo(int id, string name, double price)
        {
            this.pid = id;
            this.pname = name;
            this.pprice = price;
        } 

        public virtual void Display()
        {
            Console.WriteLine($"id : {pid}\t name :{pname}\t price:{pprice}");
        }
    }
}
