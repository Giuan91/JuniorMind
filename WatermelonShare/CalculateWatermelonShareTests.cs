using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WatermelonShare
{
    [TestClass]
    public class CalculateWatermelonShareTests
    {
        [TestMethod]
        public void PrimeNumberOfKilograms()
        {
            StringAssert.Equals("YES", WatermelonShareCalculator(8));
        }

        [TestMethod]
        public void OddNumberOfKilograms()
        {
            StringAssert.Equals("NO", WatermelonShareCalculator(5));
        }

        [TestMethod]
        public void IfEqualsTwo()
        {
            StringAssert.Equals("NO", WatermelonShareCalculator(2));
        }

        string WatermelonShareCalculator(int watermelonWeigtInKilograms)
        {
            if(watermelonWeigtInKilograms % 2 == 0)
            {
                return "YES";
            }else if(watermelonWeigtInKilograms == 2)
            {
                return "NO";
            }else
            {
                return "NO";
            }
            
        }
    }
}
