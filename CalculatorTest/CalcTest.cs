﻿using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(Calc.Add(40, 1), 41);
        }
    }
}
