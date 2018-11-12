using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amica.Models.Tests
{
    [TestClass]
    public class Product
    {
        [TestMethod]
        public void DefaultValues()
        {
            var x = new Models.Product();

            Assert.IsTrue(x.IsProduct);
            Assert.IsNotNull(x.Prices);
            Assert.AreEqual(0, x.Prices.Count);
        }

    }
}