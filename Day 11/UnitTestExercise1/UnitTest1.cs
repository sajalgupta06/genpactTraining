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

        public void Setup()
        {
            customer = new Customer.Customer();
        }

        [TestMethod]

        public void Test()
        {
           
            customer.Name = "Test User";
            customer.Id = "123Cus";
            customer.City = "Noida";
            customer.Dob = "12 June";
            customer.Address = "Noida";


            string filePath = "C:\\OurFile.txt";
            IFormatter formatter = new BinaryFormatter();


            using(FileStream fs = new FileStream(filePath, FileMode.Create,FileAccess.Write)) {
            formatter.Serialize(fs, customer);
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                Customer.Customer desCUstomer = (Customer.Customer)formatter.Deserialize(fs);
                Assert.AreEqual(customer.Id, desCUstomer.Id);
            }


            
        }    
    }
}
