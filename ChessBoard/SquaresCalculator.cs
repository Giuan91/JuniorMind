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
            Assert.AreEqual(92, ChessBoardTotalSquaresCalculator(8, 8));
        }
        int ChessBoardTotalSquaresCalculator(int m, int n)
        {
            return 0;
        }
    }
}
