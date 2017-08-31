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

        double OldFarmCalculator(int totalArea, int secondFarmWidth)
        {


            double deltaRoot = Math.Sqrt((secondFarmWidth * secondFarmWidth) - (4 * (-totalArea)));
            if (deltaRoot > 0)
            {

                double initialLenghtFisrtSolution = (0 - secondFarmWidth + deltaRoot) / 2;
                double initialLenghtSecondSolution = (0 - secondFarmWidth - deltaRoot) / 2;

                if (initialLenghtFisrtSolution > 0)
                {
                    return initialLenghtFisrtSolution * initialLenghtFisrtSolution;
                }
                else
                {
                    return initialLenghtSecondSolution * initialLenghtSecondSolution;
                }
            }
            else if (deltaRoot == 0)
            {
                double initialLenght = (0 - secondFarmWidth) / 2;
                return initialLenght * initialLenght;
            }
            else return 0;

        }
    }
}