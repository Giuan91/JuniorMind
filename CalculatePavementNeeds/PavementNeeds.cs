using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatePavementNeeds
{
    [TestClass]
    public class PavementNeeds
    {
        [TestMethod]
        public void TestForSixBySixSurface()
        {
            decimal numberOfTilesNeeded = CalculatePavementNeeds(6, 6, 4, 4);
            Assert.AreEqual(4.0m, numberOfTilesNeeded);
        }

        int CalculatePavementNeeds (int surfaceLenght, int surfaceWidth, int pavementPieceLenght, int pavementPieceWidth)
        {
            int lenghtNeed;
            if (surfaceLenght % pavementPieceLenght != 0)
                {
                    lenghtNeed = surfaceLenght / pavementPieceLenght + pavementPieceLenght;
            }else
            {
                lenghtNeed = surfaceLenght / pavementPieceLenght;
            }

            int widthtNeed;
            if (surfaceWidth % pavementPieceLenght != 0)
            {
                widthtNeed = surfaceWidth / pavementPieceWidth + pavementPieceWidth;
            }
            else
            {
                widthtNeed = surfaceWidth / pavementPieceWidth;
            }
            return lenghtNeed * widthtNeed;
        }
    }
}
