using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var math = new GitUnitTestDemo.Math(5,2);
            var math2 = new GitUnitTestDemo.Math(1234, 0);

            //Act & Assert
            Assert.AreEqual(7, math.Add());
            Assert.AreEqual(3, math.Subtract());
            Assert.AreEqual(10, math.Multiply());
            Assert.AreEqual(2.5, math.Divide());
            Assert.AreEqual(5, math.SumDigits());
            Assert.AreEqual("101", math.Binary());

            Assert.AreEqual(1234, math2.Add());
            Assert.AreEqual(1234, math2.Subtract());
            Assert.AreEqual(0, math2.Multiply());
            Assert.AreEqual(Single.PositiveInfinity, math2.Divide());
            Assert.AreEqual(10, math2.SumDigits());
            Assert.AreEqual("10011010010", math2.Binary());
        }
    }
}
