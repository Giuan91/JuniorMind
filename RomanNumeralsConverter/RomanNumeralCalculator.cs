using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsConverter
{
    [TestClass]
    public class RomanNumeralCalculator
    {
        [TestMethod]
        public void ConvertNine()
        {
            Assert.AreEqual("IX", NumberConverter(9));
        }
        string NumberConverter(int numberToBeConverted)
        {
            string romanValue = null;
            return romanValue;
        }
    }
}
