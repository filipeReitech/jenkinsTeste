using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnidadeTesteJenkins
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MetodoSemErro()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void MetodoComErro()
        {
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void MetodoComErro2()
        {
            Assert.AreEqual(1, 22);
        }

        [TestMethod]
        public void MetodoComErro3()
        {
            Assert.AreEqual(1, 3);
        }

        //[TestMethod]
        //public void MetodoComErro4()
        //{
        //    Assert.AreEqual(1, 4);
        //}

        [TestMethod]
        public void MetodoSemErro2()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void MetodoSemErro3()
        {
            Assert.AreEqual(3, 3);
        }

    }
}
