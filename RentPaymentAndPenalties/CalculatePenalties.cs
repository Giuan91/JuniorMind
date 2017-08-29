using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RentPaymentAndPenalties
{
    [TestClass]
    public class CalculatePenalties
    {
        [TestMethod]
        public void OverdueForTwoDays()
        {
            Assert.AreEqual(4, PenaltiesCalculator(100, 2));
        }

        decimal PenaltiesCalculator(int rentPerMonth, int numberOfDaysOverdue)
        {
            return 0;
        }
           
    }
}
