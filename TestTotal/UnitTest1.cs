using FupLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestTotal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // 
            var result = TransportCalc.Total("1015");
            Assert.AreEqual(25, result);
        }
    }
}
