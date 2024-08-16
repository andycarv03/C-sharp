using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void ProductTest()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, -18000, 10);

            double actualPrice = target.Price;
            double expectedPrice = 0;

            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod()]
        public void ProductTestTwo()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 0, 10);

            double actualPrice = target.Price;
            double expectedPrice = 0;

            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod()]
        public void ProductTestThree()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);

            double actualPrice = target.Price;
            double expectedPrice = 18000;

            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod()]
        public void CheckAvailabilityTestOne()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 5;

            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckAvailabilityTestTwo()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 11;

            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckAvailabilityTestThree()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 10;

            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckAvailabilityTestFour()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = 0;

            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckAvailabilityTestFive()
        {
            Product target = new Product("P101", "Motorola G3 Turbo", 1, 18000, 10);
            int quantityToPurchase = -1;

            bool actual = target.CheckAvailability(quantityToPurchase);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}