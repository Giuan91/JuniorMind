using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateHayConsumption
{
    [TestClass]
    public class CalculateHayConsumption
    {
        [TestMethod]
        public void HayConsumptionForOneDay()
        {
            int kilogramsOfHay = CalculateKilogramsOfHayConsumed(10, 10);
            Assert.AreEqual(100, kilogramsOfHay);
        }

        int CalculateKilogramsOfHayConsumed(int numberOfDays, int numberOfGoats)
        {
            int kilogramsOfHay = numberOfDays * numberOfGoats;
            return kilogramsOfHay;
        }
    }
}
