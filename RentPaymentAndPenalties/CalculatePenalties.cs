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
            Assert.AreEqual(104, PenaltiesCalculator(100, 2));
        }

        [TestMethod]
        public void OverdueForFifteenDays()
        {
            Assert.AreEqual(175, PenaltiesCalculator(100, 15));
        }

        [TestMethod]
        public void OverdueFortherThirtyFiveDays()
        {
            Assert.AreEqual(450, PenaltiesCalculator(100, 35));
        }

        decimal PenaltiesCalculator(int rentPerMonth, int numberOfDaysOverdue)
        {
            decimal rentPlusPenalty = rentPerMonth;
            decimal rentPenaltyPerDay = 0;
            
                if (1 <= numberOfDaysOverdue && numberOfDaysOverdue < 11)
                {
                    rentPenaltyPerDay = 2 * rentPerMonth / 100;
                   
                } else if (11 <= numberOfDaysOverdue && numberOfDaysOverdue < 31)
                {
                    rentPenaltyPerDay = 5 * rentPerMonth / 100;

                } else if (31 <= numberOfDaysOverdue && numberOfDaysOverdue < 41)
                {
                    rentPenaltyPerDay = 10 * rentPerMonth / 100 ;
                }


            return rentPlusPenalty = (rentPenaltyPerDay * numberOfDaysOverdue) + rentPerMonth; 
        }
           
    }
}
