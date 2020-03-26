namespace ProjectEulerTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ProjectEuler;
    using System;
    using Xunit;

    [TestClass]
    public class Program2to20Tests
    {
        [DataTestMethod]
        [DataRow(10, 3)]
        [DataRow(11, 6)]
        [DataRow(100, 10)]
        [DataRow(110, 16)]
        [DataRow(111, 19)]
        [DataRow(121, 22)]
        [DataRow(900, 11)]
        [DataRow(51, 8)]
        [DataRow(151, 21)]
        [DataRow(841, 23)]
        [DataRow(99, 10)]
        [DataRow(911, 20)]
        [DataRow(999, 24)]
        [DataRow(1000, 11)]
        public void NumberLetterCountTest(int inputValue, int expectedValue)
        {
            Assert.AreEqual(Program2to20.NumberLetterCount(inputValue), expectedValue);
        }

        [DataTestMethod]
        [DataRow(10, 39)]
        public void AllNumberLetterCountFactTest(int inputValue, int expectedValue)
        {
            Assert.AreEqual(Program2to20.AllNumberLetterCount(inputValue), expectedValue);
        }
    }
}
