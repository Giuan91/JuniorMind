using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzSorter
    {
        [TestMethod]
        public void NumberIsMultipleOfThreeAndFive()
        {
            StringAssert.Equals("FizzBuzz", FizzBuzzSortingMethod(15));
        }

        [TestMethod]
        public void NumberIsMultipleOfThree()
        {
            StringAssert.Equals("Fizz", FizzBuzzSortingMethod(9));
        }

        [TestMethod]
        public void NumberIsMultipleOfFive()
        {
            StringAssert.Equals("Buzz", FizzBuzzSortingMethod(20));
        }

        [TestMethod]
        public void NumberIsNotMultipleOfThreeNorFive()
        {
            StringAssert.Equals("Number is not a multiple of neighter 3 nor 5", FizzBuzzSortingMethod(7));
        }

        string FizzBuzzSortingMethod(int numberToBeDetermined)
        {

            if (numberToBeDetermined % 3 == 0 & numberToBeDetermined % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (numberToBeDetermined % 3 == 0)
            {
                return "Fizz";
            }
            else if (numberToBeDetermined % 5 == 0)
            {
                return "Buzz";
            }
            else
                return "Number is not a multiple of neighter 3 nor 5";
             
        } 
           

    }

    
}
