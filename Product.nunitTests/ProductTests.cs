

using System.Diagnostics;
using System.Drawing;

namespace EcommerceApp.nUnitTests

{
    public class ProductTests
    {

        private Product _product { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _product = new Product();
        }

        [TestCase(1)]//minimum boundary value
        [TestCase(5000)]//intermediate boundary value
        [TestCase(10000)]//max boundary value
        public void GetPdtId_Test(int pdtId)
        {

            //Act
           
            _product.ProductID = pdtId;
            var actual = _product.ProductID;

            //Assert
            Assert.That(actual, Is.EqualTo(pdtId));

        }

        [TestCase(1)]//minimum boundary value
        [TestCase(2500)]//intermediate boundary value
        [TestCase(5000)]//max boundary value
        public void GetPrice_Test(double price)
        {

            //Act

            _product.Price = price;
            var actual = _product.Price;

            //Assert
            Assert.That(actual, Is.EqualTo(price));

        }

        [TestCase(1)]//minimum boundary value
        [TestCase(50000)]//intermediate boundary value
        [TestCase(100000)]//max boundary value
        public void GetStock_Test(double stock)
        {

            //Act

            _product.Stock = stock;
            var actual = _product.Stock;

            //Assert
            Assert.That(actual, Is.EqualTo(stock));

        }
        [TestCase("Test")]
        [TestCase("Test Product")]
        [TestCase("Test Product like laptop")]
        public void GetPdtName_Test(string pdtName)
        {

            //Act

            _product.ProductName = pdtName;
            var actual = _product.ProductName;

            //Assert
            Assert.That(actual, Is.EqualTo(pdtName));

        }
       

        [TestCase(1, 99999)]
        [TestCase(1, 99998)]
        [TestCase(10000, 0)]
        public void IncreaseStock_Test(int count,double stock)
        {
            // Arrange
            _product.Stock = stock;
           
            double expected = count+stock;

            // Act
            _product.IncreaseStock(count);
            double actual = _product.Stock; 

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(1, 1)]
        [TestCase(100, 500)]
        [TestCase(5000, 10000)]
        public void DecreaseStock_Test(int count, double stock)
        {
            // Arrange
            _product.Stock = stock;

            double expected = stock-count;

            // Act
            _product.DecreaseStock(count);
            double actual = _product.Stock;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }


    }
}