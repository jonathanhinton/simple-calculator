using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        //at least 3 tests
        [TestMethod]
        public void IsNotNull()
        {
            Expression myExp = new Expression();
            Assert.IsNotNull(myExp);
        }
        [TestMethod]
        public void CanRemoveSpaces()
        {
            //arrange
            Expression myExp = new Expression();
            //act
            string expected = myExp.UserInput("2 + 3");
            string actual = "2+3";
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
