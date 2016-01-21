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
    }
}
