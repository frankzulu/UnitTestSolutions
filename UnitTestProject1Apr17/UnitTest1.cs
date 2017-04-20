using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1Apr17
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("abc","ABC",true,"abc comparison failed");

        }
    }
}
