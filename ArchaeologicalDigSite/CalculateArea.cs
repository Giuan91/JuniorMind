using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArchaeologicalDigSite
{
    [TestClass]
    public class CalculateArea
    {
        [TestMethod]
        public void FirstThreeColumn()
        {
            double area = CalculateMinimalArea(2, 2, 4, 4, 6, 8);
            Assert.AreEqual(1.88d, area);
        }
        double CalculateMinimalArea(int firstColumnX, int firstColumnY, int secondColumnX, int secondColumnY, int thirdColumnX, int thirdColumnY)
        {
            double a =Math.Round( Math.Sqrt(Math.Pow((secondColumnX - firstColumnX), 2) + Math.Pow((secondColumnY - firstColumnY), 2)), 2);
            double b = Math.Round( Math.Sqrt(Math.Pow((thirdColumnX - secondColumnX),2) + Math.Pow((thirdColumnY - secondColumnY), 2)), 2);
            double c =Math.Round( Math.Sqrt(Math.Pow((firstColumnX - thirdColumnX), 2) + Math.Pow((firstColumnY - thirdColumnY), 2)),2);
            double semiPerimeter = (a+b+c) / 2;
            double minimalArea = Math.Sqrt(semiPerimeter * (semiPerimeter - a)*(semiPerimeter - b) *(semiPerimeter - c));
            return  semiPerimeter-a;
        }
    }
}
