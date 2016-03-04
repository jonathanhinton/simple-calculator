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
            //arrange
            Expression myExp = new Expression();
            //assert
            Assert.IsNotNull(myExp);
        }

        [TestMethod]
        public void CanRemoveSpaces()
        {
            //arrange
            Expression myExp = new Expression();
            //act
            string expected = myExp.RemoveSpaces("2 + 3");
            string actual = "2+3";
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanParseLeftSideExpression()
        {
            //arrange
            Expression myExp = new Expression();
            //act
            string[] expected = myExp.ParseExpression("2+3");
            string actual = "2";
            //assert
            Assert.AreEqual(expected[0], actual);
        }
        [TestMethod]
        public void CanParseRightSide()
        {
            //arrange
            Expression myExp = new Expression();
            // act
            string[] expected = myExp.ParseExpression("392394*984738");
            string actual = "984738";

            //assert
            Assert.AreEqual(expected[1], actual);
        }
    }
}
