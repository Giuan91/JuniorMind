using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard
{
    [TestClass]
    public class SquaresCalculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(204, ChessBoardTotalSquaresCalculator(8));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(385, ChessBoardTotalSquaresCalculator(10));
        }
        int ChessBoardTotalSquaresCalculator(int unit)
        {
            int i, square, sum = 0;
            for (i = 1; i <= unit; i++)
            {
                square = i * i;
                sum += square;
            } 
            return sum;
        }
    }
}
