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
            float kilogramsOfHay = CalculateKilogramsOfHayConsumed(10, 10, 100, 20, 20);
            Assert.AreEqual(400, kilogramsOfHay);
        }

        [TestMethod]
        public void HayConsumptionForThirtyDay()
        {
            float kilogramsOfHay = CalculateKilogramsOfHayConsumed(30, 20, 900, 40, 30);
            Assert.AreEqual(1800, kilogramsOfHay);
        }

        float CalculateKilogramsOfHayConsumed(float numberOfDays, float numberOfGoats, float totalKilogramsOfHay, float secondNumberOfDays, float secondNumberOfGoats)
        {
            float kilogramsOfHayPerGoatPerDay = totalKilogramsOfHay / numberOfGoats / numberOfDays ;
            return kilogramsOfHayPerGoatPerDay * secondNumberOfGoats * secondNumberOfDays;
        }
    }
}
