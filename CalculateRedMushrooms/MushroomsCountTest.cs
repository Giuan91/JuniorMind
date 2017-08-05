using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MushroomCount
{
    [TestClass]
    public class MushroomCountTest
    {
        [TestMethod]
        public void TwoTimesMoreRedMushrooms()
        {
            int redMushrooms = CalculateNumberOfRedMushrooms(90, 2);
            Assert.AreEqual(60, redMushrooms);
        }

        [TestMethod]
        public void FiveTimesMoreRedMushrooms()
        {
            int redMushrooms = CalculateNumberOfRedMushrooms(120, 5);
            Assert.AreEqual(100, redMushrooms);
        }


        int CalculateNumberOfRedMushrooms(int totalNumberOfMushrooms, int x)
        {
            int white = totalNumberOfMushrooms / (1 + x);

            return white * x;
        }

    }
}
 