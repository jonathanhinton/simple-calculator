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
            //Arrange
            Expression myExp = new Expression();
            
            //Assert
            Assert.IsNotNull(myExp);
        }

        [TestMethod]
        public void CanRemoveSpaces()
        {
            //Arrange
            Expression myExp = new Expression();
            
            //Act
            string actual = myExp.RemoveSpaces("2 + 3");
            string expected = "2+3";
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanParseLeftSideExpression()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("2 + 3");
            
            //Act
            int actual = fullExpression.LHS;
            int expected = 2;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanParseRightSide()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("392394*984738");
            
            // Act
            int actual = fullExpression.RHS;
            int expected = 984738;

            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanParseOperator()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("432 * 234");
            
            //Act
            char actual = fullExpression.OP;
            char expected = '*';
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanParseIdentityOperator()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("x = 234");

            //Act
            char actual = fullExpression.OP;
            char expected = '=';

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoOperatorException()
        {
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("2 @ 2");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BadInputException()
        {
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("23423+");
        }

        [TestMethod]
        public void CanAdd()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("432 + 234");
            
            //Act
            int actual = fullExpression.add_me();
            int expected = 666;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanSubtract()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("900 - 234");
            
            //Act
            int actual = fullExpression.subtract_me();
            int expected = 666;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanMultiply()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("333 * 2");
            
            //Act
            int actual = fullExpression.multiply_me();
            int expected = 666;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanDivide()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("1332 / 2");
            
            //Act
            int actual = fullExpression.divide_me();
            int expected = 666;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanModulo()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("10 % 3");

            //Act
            int actual = fullExpression.modulo_me();
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanAssignConstant()
        {
            //Arrange
            Expression myExp = new Expression();
            Container fullExpression = myExp.ParseExpression("X = 4");

            //Act
            string actual = fullExpression.CONS;
            string expected = "x";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanUseConstantInEquation()
        {
            //Arrange
            Expression myExp = new Expression();
            Evaluate my_eval = new Evaluate();
            Container fullExpression = myExp.ParseExpression("x = 4");
            int actual = my_eval.handledIt("x + 3");
            int expected = 7;

            Assert.AreEqual(expected, actual);

        }

    }
}
