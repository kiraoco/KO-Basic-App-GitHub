using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KO_Basic_App_GitHub; //add

namespace BasicAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 tp = new Class1();
            Assert.AreEqual(tp.Name, "[Firstname Lastname] - Kira OConnor");
        }
    }
}
