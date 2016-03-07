using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void EvaluateIsNotNull()
        {
            Evaluate evaluation = new Evaluate();
            Assert.IsNotNull(evaluation);
        }

        [TestMethod]
        public void CanClassAdd()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int actual = evaluation.handledIt("432 + 234");
            int expected = 666;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassSubtract()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int actual = evaluation.handledIt("900 - 234");
            int expected = 666;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassMultiply()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int actual = evaluation.handledIt("2 * 333");
            int expected = 666;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassDivide()
        {

            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int actual = evaluation.handledIt("1332 / 2");
            int expected = 666;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassModulo()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int actual = evaluation.handledIt("10 % 3");
            int expected = 1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BadInput()
        {
            Evaluate evaluation = new Evaluate();
            evaluation.handledIt("10");
        }

        [TestMethod]
        public void StackLastQWorking()
        {

            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int eval = evaluation.handledIt("10 % 3");
            string expected = "10 % 3";
            string actual = evaluation.stack_record.lastQ;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StackLastWorking()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int eval = evaluation.handledIt("234 +432");
            int expected = 666;
            int actual = evaluation.stack_record.last;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LastInputTest()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int eval = evaluation.handledIt("234 +432");
            string expected = "234 +432";
            string actual = evaluation.LastInput("lAsTq");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BadLastQInputTest()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int eval = evaluation.handledIt("234 +432");
            string expected = "234 +432";
            string actual = evaluation.LastInput("Bumb bum bum bum");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BadLastInputTest()
        {
            //Arrange
            Evaluate evaluation = new Evaluate();

            //Act
            int eval = evaluation.handledIt("234 +432");
            string expected = "234 +432";
            int actual = evaluation.LastOutput("Bow chicka wow wow");

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
