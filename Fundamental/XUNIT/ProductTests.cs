using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;

namespace QuickKartTestProject
{
    public class ProductTests
    {
        [Fact]
        public void ProductTest()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, -18000, 10);
            double actualPrice = target.Price;
            double expectedPrice = 0;

            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]                      //attribute that decorate the methods ProductTest() and CheckAvailabilityTest(). This attribute is used to identify a method that contain code to test a unit (a small piece of code like for example, a method)
        public void ProductTestTwo()
        {
            Product target = new Product("P102", "Motorola G3 Turbo", 1, 0, 10);
            double actualPrice = target.Price;
            double expectedPrice = 0;

            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]                      //attribute that decorate the methods ProductTest() and CheckAvailabilityTest(). This attribute is used to identify a method that contain code to test a unit (a small piece of code like for example, a method)
        public void ProductTestThree()
        {
            Product target = new Product("P103", "Motorola G3 Turbo", 1, 18000, 10);
            double actualPrice = target.Price;
            double expectedPrice = 18000;

            Assert.Equal(expectedPrice, actualPrice);
        }

        [Fact]
        public void CheckAvailabilityTestOne()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 5;
            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void CheckAvailabilityTestTwo()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 11;
            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = false;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void CheckAvailabilityTestThree()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 10;
            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void CheckAvailabilityTestFour()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 0;
            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void CheckAvailabilityTestFive()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = -1;
            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.Equal(expected, actual);

        }
    }
}
