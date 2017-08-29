using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumeralsConverter
{
    [TestClass]
    public class RomanNumeralCalculator
    {
        [TestMethod]
        public void ConvertFour()
        {
            Assert.AreEqual("IV", NumberConverter(4));
        }

        [TestMethod]
        public void ConvertEight()
        {
            Assert.AreEqual("VIII", NumberConverter(8));
        }

        [TestMethod]
        public void ConvertNine()
        {
            Assert.AreEqual("IX", NumberConverter(9));
        }


        [TestMethod]
        public void ConvertFifteen()
        {
            Assert.AreEqual("XV", NumberConverter(15));
        }


        [TestMethod]
        public void ConvertThirty()
        {
            Assert.AreEqual("XXX", NumberConverter(30));
        }


        [TestMethod]
        public void ConvertThirtyNine()
        {
            Assert.AreEqual("XXXIX", NumberConverter(39));
        }


        [TestMethod]
        public void ConvertFortyOne()
        {
            Assert.AreEqual("XLI", NumberConverter(41));
        }


        [TestMethod]
        public void ConvertFortyFive()
        {
            Assert.AreEqual("XLV", NumberConverter(45));
        }


        [TestMethod]
        public void ConvertNinetyNine()
        {
            Assert.AreEqual("XCIX", NumberConverter(99));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),"Out of bounds")]
        public void ConvertOneHundredAndTwo()
        {
            AssertFailedException.Equals("Out of bounds", NumberConverter(102));
        }

        string NumberConverter(int numberToBeConverted)
        {
            /*  if (numberToBeConverted < 0 || numberToBeConverted > 100) throw new ArgumentOutOfRangeException("Out of bounds");
              if (numberToBeConverted < 1) return string.Empty;
              if (numberToBeConverted == 100) return "C" + NumberConverter(numberToBeConverted - 100);
              if (numberToBeConverted >= 90) return "XC" + NumberConverter(numberToBeConverted - 90);
              if (numberToBeConverted >= 50) return "L" + NumberConverter(numberToBeConverted - 50);
              if (numberToBeConverted >= 40) return "XL" + NumberConverter(numberToBeConverted - 40);
              if (numberToBeConverted >= 10) return "X" + NumberConverter(numberToBeConverted - 10);
              if (numberToBeConverted >= 9) return "IX" + NumberConverter(numberToBeConverted - 9);
              if (numberToBeConverted >= 5) return "V" + NumberConverter(numberToBeConverted - 5);
              if (numberToBeConverted >= 4) return "IV" + NumberConverter(numberToBeConverted - 4);
              if (numberToBeConverted >= 1) return "I" + NumberConverter(numberToBeConverted - 1);
              throw new ArgumentOutOfRangeException("Out Of bounds");*/

            var units = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            var tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

            if (numberToBeConverted < 0 || numberToBeConverted > 100)
            {
                throw new ArgumentOutOfRangeException("Out of bounds");
            } else {

                string romanNumeral = tens[numberToBeConverted / 10] + units[numberToBeConverted % 10];

                return romanNumeral; }


        }
    }
}
