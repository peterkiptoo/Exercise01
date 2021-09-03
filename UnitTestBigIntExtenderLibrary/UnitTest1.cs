using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Exercise01;

namespace UnitTestBigIntExtenderLibrary
{
    [TestClass]
    public class UnitTest1
    {

        private BigIntExtenderLibrary extender;

        [TestMethod]
        public void TestValidInput()
        {
            string number = "18000000";
            number = BigIntExtenderLibrary.Towards(double.Parse(number));

            Assert.IsNotNull(number,"18000000");

        }


       

    }
}
