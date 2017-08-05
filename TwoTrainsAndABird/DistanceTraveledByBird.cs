using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoTrainsAndABird
{
    [TestClass]
    public class DistanceTraveledByBird
    {
        [TestMethod]
        public void TrainsStartEightyKmAway()
        {
            int distanceByBird = CalculateDistanceTraveledByBird(80, 10, 10);
            Assert.AreEqual(40, distanceByBird);

        }

        [TestMethod]
        public void TrainsStartTwoHundredKmAway()
        {
            int distanceByBird = CalculateDistanceTraveledByBird(200, 10, 10);
            Assert.AreEqual(100, distanceByBird);

        }

        int CalculateDistanceTraveledByBird(int distanceBetweenTrainsAtStart, int speedOfFirstTrain, int speedOfSecondTrain)

        {
            int forthOfTotalDistance = distanceBetweenTrainsAtStart / 4;
            int distanceBetweenTrainsWhenBirdFlys = 2 * forthOfTotalDistance;
            int sumOfSpeedOfTrains = speedOfFirstTrain + speedOfSecondTrain;
            int speedOfBird = (speedOfFirstTrain * 2);
            int timeSpentFlyingByBird = distanceBetweenTrainsWhenBirdFlys / speedOfBird;
            return speedOfBird * timeSpentFlyingByBird;
        }
    }
}
