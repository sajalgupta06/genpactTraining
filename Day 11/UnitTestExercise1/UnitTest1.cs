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


      

            Assert.AreEqual(customer, cus);

        }


        [TestMethod]

        public void ReadTest()
        {
            string path = "C:\\customer/";
            string fileName = $"{customer.Name}_{customer.Dob}.txt";
            string filePath = path + fileName;

            customer.Name = "Test User";
            customer.Id = "123Cus";
            customer.Write(filePath, customer);
            Assert.AreEqual(customer, customer.Read(filePath));

        }

    }
}
