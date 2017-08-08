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
            int numberOfTilesNeeded = CalculatePavementNeeds(6, 6, 4, 4);
            Assert.AreEqual(4.0m, numberOfTilesNeeded);
        }

        int CalculatePavementNeeds (int surfaceLenght, int surfaceWidth, int pavementPieceLenght, int pavementPieceWidth)
        {
            int lenghtNeed = surfaceLenght / pavementPieceLenght;
            if (surfaceLenght % pavementPieceLenght != 0)
                {
                    lenghtNeed += 1;
            }

            int widthtNeed = surfaceWidth / pavementPieceWidth;
            if (surfaceWidth % pavementPieceLenght != 0)
            {
                widthtNeed += 1;
            }
            
            return lenghtNeed * widthtNeed;
        }
    }
}
