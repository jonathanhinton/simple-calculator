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
    }
}
