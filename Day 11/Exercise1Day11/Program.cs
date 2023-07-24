using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Customer;

namespace Exercise1Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter person name and Dob");

            Customer.Customer customer = new Customer.Customer(); 
            customer.Name = Console.ReadLine();
            customer.Dob = Console.ReadLine();

            string path = "C:\\customer/";
            string fileName = $"{customer.Name}_{customer.Dob}.txt";
            string filePath = path + fileName;
            File.Create(filePath).Close();
            Console.WriteLine("FileCreated");

           Console.WriteLine("Enter User's Id City Address");

            customer.Id = Console.ReadLine();
            customer.City = Console.ReadLine();
            customer.Address = Console.ReadLine();

            if (customer.Write(filePath, customer))
            {
                Customer.Customer cus = customer.Read(filePath);
                Console.WriteLine("ID - " + cus.Id);
                Console.WriteLine("Name - " + cus.Name);
                Console.WriteLine("Dob - " + cus.Dob);
                Console.WriteLine("City - " + cus.City);
            };


           

           Console.ReadKey(); 
         
        }
    }
}
