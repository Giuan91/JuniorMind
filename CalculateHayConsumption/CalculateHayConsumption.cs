using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateHayConsumption
{
    [TestClass]
    public class CalculateHayConsumption
    {
        [TestMethod]
        public void HayConsumptionForTenDay()
        {
            int kilogramsOfHay = CalculateKilogramsOfHayConsumed(10, 10, 100);
            Assert.AreEqual(100, kilogramsOfHay);
        }

        [TestMethod]
        public void HayConsumptionForThirtyDay()
        {
            int kilogramsOfHay = CalculateKilogramsOfHayConsumed(30, 30, 900);
            Assert.AreEqual(900, kilogramsOfHay);
        }

        int CalculateKilogramsOfHayConsumed(int numberOfDays, int numberOfGoats, int totalKilogramsOfHay)
        {
            int kilogramsOfHayPerGoatPerDay = totalKilogramsOfHay / numberOfGoats / numberOfDays ;
            return kilogramsOfHayPerGoatPerDay * numberOfGoats * numberOfDays;
        }
    }
}
