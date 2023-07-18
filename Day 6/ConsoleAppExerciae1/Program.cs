using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExerciae1
{
    internal class Program
    {

        public static SortedList<int, Customer> arr = new SortedList<int, Customer>();


        public static void Remove(int key)
        {
            if (arr.Keys.Contains(key))
            {
                   arr.Remove(key);
                Console.WriteLine("Key Removed");


            }
            else
            {
                Console.WriteLine("Key Not Found");
            }
         
        
            
        }

        public static  void Print()
        {
            foreach(var item in arr)

            {
                
                Console.WriteLine(item.Key + "--" + item.Value.Name + "," + item.Value.CCity + "," + item.Value.ODLimit );
            }
        }
        static void Main(string[] args)
        {
            Customer cus1 = new Customer();cus1.Name = "Test";cus1.CCity = "city1";cus1.ODLimit = 1000;
            Customer cus2 = new Customer(); cus2.Name = "Test2"; cus2.CCity = "city2"; cus2.ODLimit = 1200;
            Customer cus3 = new Customer(); cus3.Name = "Test3"; cus3.CCity = "city3"; cus3.ODLimit = 14700;
            Customer cus4 = new Customer(); cus4.Name = "Test3"; cus4.CCity = "city4"; cus4.ODLimit = 23000;
            Customer cus5 = new Customer(); cus5.Name = "Test3"; cus5.CCity = "city5"; cus5.ODLimit = 4500;


            arr.Add(1, cus1);
            arr.Add(2, cus2);
            arr.Add(3, cus3);
            arr.Add(4, cus4);
            arr.Add(5, cus5);

            Remove(2);

            Print();
           
            Console.ReadLine();

        }
    }
}
