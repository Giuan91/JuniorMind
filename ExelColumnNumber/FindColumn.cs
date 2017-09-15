using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExelColumnNumber
{
    [TestClass]
    public class FindColumn
    {
        [TestMethod]
        public void TestForFirstColumn()
        {
            Assert.AreEqual("A", ColumnPosition(1));
        }

        string ColumnPosition(int columnNumber)
        {
            return null;
        }

    }
}
