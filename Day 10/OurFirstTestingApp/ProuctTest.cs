using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstTestingApp
{
    [TestFixture]
    public class ProuctTest
    {
        private Product<string> prodList;

        [SetUp]
        public  void Setup()
        {
            prodList = new Product<string>();
        }
        [Test]
        public void CountTestOnAdd()
        {
            prodList.AddProduct("Laptop");
            prodList.AddProduct("Mobile");
            prodList.AddProduct("CAmera");
            prodList.AddProduct("Mouse");

            Assert.AreEqual(4, prodList.Count);
        }
        [Test]

        public void CountTestOnRemove()
        {
            prodList.AddProduct("Laptop");
            prodList.AddProduct("Mobile");
            prodList.AddProduct("CAmera");
            prodList.AddProduct("Mouse");

            prodList.RemoveProduct("Mouse");
            Assert.AreEqual(3, prodList.Count);
        }
        
    }
}
