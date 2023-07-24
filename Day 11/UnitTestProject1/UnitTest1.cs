using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = "Welcome";
            Calclib.Calc obj = new Calclib.Calc();
            string actualResult = obj.Welcome();
            Assert.AreEqual(result, actualResult);



        }
    }
}
