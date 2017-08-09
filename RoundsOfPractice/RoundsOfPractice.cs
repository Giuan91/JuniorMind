using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateRoundsOfPractice
{
    [TestClass]
    public class RoundsOfPractice
    {
        [TestMethod]
        public void CalculateRepetitionsForFiveMaximumRepetitions()
        {
            int numberOfReps = CalculateNumberOfRepetitions(5);
            Assert.AreEqual(25, numberOfReps);
        }

        [TestMethod]
        public void CalculateRepetitionsForNineMaximumRepetitions()
        {
            int numberOfReps = CalculateNumberOfRepetitions(9);
            Assert.AreEqual(81, numberOfReps);
        }

        int CalculateNumberOfRepetitions(int numberOfMaximumRepetitions)
        {
            int numberOfRounds = numberOfMaximumRepetitions + (numberOfMaximumRepetitions - 1);
            int numberOfRepetitionsForFirstRounds = (numberOfMaximumRepetitions * (numberOfMaximumRepetitions + 1)) / 2;
            int numberOfRepetitionsForSecondRounds = (numberOfMaximumRepetitions * (numberOfMaximumRepetitions - 1)) / 2;
            int numberOfRepetitions = numberOfRepetitionsForFirstRounds + numberOfRepetitionsForSecondRounds;


            return numberOfRepetitions;
        }
    }
}
