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
            int kilogramsOfHay = CalculateKilogramsOfHayConsumed(1, 10, 100);
            Assert.AreEqual(0, kilogramsOfHay);
        }

        int CalculateKilogramsOfHayConsumed(int numberOfDays, int numberOfGoats, int kilogramsOfHay)
        {
            return 0;
        }
    }
}
