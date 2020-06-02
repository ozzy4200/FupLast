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
            // Tjekker om result er det samme som expected result
            var result = TransportCalc.Total("10 15");
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = TransportCalc.Gennemsnit(300, 22.5);
            Assert.AreEqual(7.5, result);
        }
    }
}
