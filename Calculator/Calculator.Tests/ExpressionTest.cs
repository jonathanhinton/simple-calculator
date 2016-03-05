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
            Container fullExpression = myExp.ParseExpression("2+3");
            //act
            int expected = fullExpression.LHS;
            int actual = 2;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanParseRightSide()
        {
            //arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("392394*984738");
            // act
            int expected = fullExpression.RHS;
            int actual = 984738;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanParseOperator()
        {
            //arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("432 * 234");
            //act
            char expected = fullExpression.OP;
            char actual = '*';
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanAdd()
        {
            //arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("432 + 234");
            //act
            int expected = fullExpression.add_me(432, 234);
            int actual = 666;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
