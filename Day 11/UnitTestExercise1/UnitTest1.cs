using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Customer;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace UnitTestExercise1
{
    [TestClass]
    public class UnitTest1
    {

        Customer.Customer customer;
        [TestInitialize]

        public void setup()
        {
            customer = new Customer.Customer();
        }

        [TestMethod]



        public void Test()
        {
            string path = "C:\\customer/";
            string fileName = $"{customer.Name}_{customer.Dob}.txt";
            string filePath = path + fileName;

            customer.Name = "Test User";
            customer.Id = "123Cus";
            customer.City = "Noida";


            IFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, customer);


            stream.Seek(0, SeekOrigin.Begin);

            Customer.Customer cus = (Customer.Customer)formatter.Deserialize(stream);

            Assert.AreEqual(customer, cus);

        }


      
    }
}
