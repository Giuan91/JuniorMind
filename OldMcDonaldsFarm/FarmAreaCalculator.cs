using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OldMcDonaldsFarm
{
    [TestClass]
    public class FarmAreaCalculator
    {
        [TestMethod]
        public void TestForFirstSolution()
        {
            Assert.AreEqual(592900, OldFarmCalculator(770000, 230));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), ("Lenght is negative"))]
        public void LenghtIsNegative()
        {
            AssertFailedException.Equals("Lenght is negative", OldFarmCalculator(1, 1));
        }


        double OldFarmCalculator(int totalArea, int secondFarmWidth)
        {


            double deltaRoot = Math.Sqrt((secondFarmWidth * secondFarmWidth) - (4 * (-totalArea)));
            if (deltaRoot > 0)
            {
                double initialWidthFisrtSolution = (0 - secondFarmWidth + deltaRoot) / 2;
                double initialWidthSecondSolution = (0 - secondFarmWidth - deltaRoot) / 2;

                if (initialWidthFisrtSolution > 0)
                {
                    return initialWidthFisrtSolution * initialWidthFisrtSolution;
                }
                else
                {
                    throw new IndexOutOfRangeException("Lenght is negative");
                }
            }
            else if (deltaRoot == 0)
            {
                double initialWidth = (-secondFarmWidth) / 2;
                return initialWidth * initialWidth;
            }
            else
            {
                return 0;

            }

        }
    }
}