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
            Evaluate evaluation = new Evaluate();
            int expected = evaluation.handledIt("432 + 234");
            int actual = 666;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassSubtract()
        {
            Evaluate evaluation = new Evaluate();
            int expected = evaluation.handledIt("900 - 234");
            int actual = 666;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassMultiply()
        {
            Evaluate evaluation = new Evaluate();
            int expected = evaluation.handledIt("2 * 333");
            int actual = 666;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassDivide()
        {
            Evaluate evaluation = new Evaluate();
            int expected = evaluation.handledIt("1332 / 2");
            int actual = 666;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanClassModulo()
        {
            Evaluate evaluation = new Evaluate();
            int expected = evaluation.handledIt("10 % 3");
            int actual = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BadInput()
        {
            Evaluate evaluation = new Evaluate();
            evaluation.handledIt("10");
        }

    }
}
