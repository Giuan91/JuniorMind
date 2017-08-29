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

        decimal PenaltiesCalculator(int rentPerMonth, int numberOfDaysOverdue)
        {
            decimal rentPlusPenalty = rentPerMonth;
            
                if (1 <= numberOfDaysOverdue && numberOfDaysOverdue < 11)
                {
                    rentPlusPenalty = ((2 * rentPerMonth / 100) * numberOfDaysOverdue) + rentPerMonth;
                   
                } else if (11 <= numberOfDaysOverdue && numberOfDaysOverdue < 31)
                {
                    rentPlusPenalty = ((5 * rentPerMonth / 100) * numberOfDaysOverdue) + rentPerMonth;

                } else if (31 <= numberOfDaysOverdue && numberOfDaysOverdue < 41)
                {
                    rentPlusPenalty = ((10 * rentPerMonth / 100) * numberOfDaysOverdue) + rentPerMonth;
                }


            return rentPlusPenalty; 
        }
           
    }
}
