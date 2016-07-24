using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.ProductId = 1;
            currentProduct.Description = "15-inch steel blade hand saw";
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            //Act
            var actual = currentProduct.SayHello();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHelloTestParameterizedConstructor()
        {
            //Arrange
            var currentProduct = new Product(1, "Saw", "15-inch steel blade hand saw");
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            //Act
            var actual = currentProduct.SayHello();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}