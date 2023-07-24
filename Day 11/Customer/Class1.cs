using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    [Serializable]
    public class Customer
    {



        public string Name { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string Id { get; set; }
        public string City { get; set; }

        public bool Write(string filePath, object customer)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, customer);
                Console.WriteLine("Written Inside File");
                stream.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return false;
            }

        }

        public Customer Read(string filePath)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                Customer cus = (Customer)formatter.Deserialize(stream);
             
                return cus;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                Customer cus = new Customer();
                return cus;
            }

        }

    }

}
