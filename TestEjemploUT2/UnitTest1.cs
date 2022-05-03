using EjemploUT2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEjemploUT2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            int n1 = 2;
            int n2 = 3;


            int res = Program.Suma(n1, n2);

            Assert.AreEqual(5, res);
        }
    }
}
