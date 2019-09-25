using Excersise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExcersise
{
    [TestClass]
    public class TestExcersise
    {
        [TestMethod]
        public void Task1Test()
        {
            Assert.AreEqual(78, Task1.SumIntInString("5 62 ar 11"));
        }

        [TestMethod]
        public void Task2Test()
        {
            Assert.AreEqual(720, Task2.Factorial(6));
        }

        [TestMethod]
        public void Task3Test()
        {
            Assert.AreEqual(-1, Task3.FindClosestToZero(new int[] {-5, -1, 2, 4}));
            Assert.AreEqual(1, Task3.FindClosestToZero(new int[] {-5, -1, 1, 4}));
            Assert.AreEqual(2, Task3.FindClosestToZero(new int[] {-5, -3, 2, 4}));
        }

        [TestMethod]
        public void Task5Test()
        {
            Assert.AreEqual(4, Task5.FindOddEleement(new int[] { 5, 1, 2, 4, 1, 2, 5}));
            Assert.AreEqual(5, Task5.FindOddEleement(new int[] { 4, 1, 2, 4, 1, 2, 5 }));
            Assert.AreEqual(1, Task5.FindOddEleement(new int[] { 5, 4, 2, 4, 1, 2, 5 }));
        }
    }
}
