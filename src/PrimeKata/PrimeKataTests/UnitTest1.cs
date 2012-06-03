using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeKata;

namespace PrimeKataTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_0_Should_Return_Empty_List()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(0);
            var expected = 0;

            Assert.AreEqual(expected, results.Count);
        }

        [TestMethod]
        public void Given_1_Should_Return_Empty_List()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(1);
            var expected = 0;

            Assert.AreEqual(expected, results.Count);
        }

        [TestMethod]
        public void Given_2_Should_Return_List_With_2()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(2);

            Assert.AreEqual(2, results[0]);
        }

        [TestMethod]
        public void Given_3_Should_Return_List_With_3()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(3);

            Assert.AreEqual(3, results[0]);
        }

        [TestMethod]
        public void Given_4_Should_Return_List_With_2_And_2()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(4);

            Assert.AreEqual(2, results[0]);
            Assert.AreEqual(2, results[1]);
        }

        [TestMethod]
        public void Given_5_Should_Return_List_With_5()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(5);

            Assert.AreEqual(5, results[0]);
        }

        [TestMethod]
        public void Given_6_Should_Return_List_With_2_And_3()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(6);

            Assert.AreEqual(2, results[0]);
            Assert.AreEqual(3, results[1]);
        }

        [TestMethod]
        public void Given_9_Should_Return_List_With_3_And_3()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(9);

            Assert.AreEqual(3, results[0]);
            Assert.AreEqual(3, results[1]);
        }

        [TestMethod]
        public void Given_INTMAX_Should_Return_List_With_INTMAX()
        {
            var primeFinder = new PrimeFinder();

            var results = primeFinder.FindPrimeFactors(int.MaxValue);

            Assert.AreEqual(int.MaxValue, results[0]);
        }
    }
}
