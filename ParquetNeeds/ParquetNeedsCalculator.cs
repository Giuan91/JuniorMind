using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParquetNeeds
{
    [TestClass]
    public class ParquetNeedsCalculator
    {
        [TestMethod]
        public void CalulateForTwentySquareMMeters()
        {
            double parquetNeeds = ParquetCalculator(1000, 1000, 50, 100);
            Assert.AreEqual(200, parquetNeeds);
        }

        [TestMethod]
        public void CalulateForTwentySquareMMeter()
        {
            double parquetNeeds = ParquetCalculator(600, 300, 20, 150);
            Assert.AreEqual(69, parquetNeeds);
        }

        double ParquetCalculator(double roomLenght, double roomWidth, double boardLenght, double boardWidth)
        {
            double roomSurface = roomLenght * roomWidth;
            double fifteenPercent = 15/100 * roomSurface;
            double roomSurfacePlusError = roomSurface + fifteenPercent;
            double singleParquetBoardSurface = boardLenght * boardWidth;
            Math.Round(roomSurfacePlusError, 2);
            Math.Round(singleParquetBoardSurface, 2);
            return roomSurfacePlusError / singleParquetBoardSurface;
        }
    }
}
