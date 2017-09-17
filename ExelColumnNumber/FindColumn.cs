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

        [TestMethod]
        public void TestForDoubleLettersColumn()
        {
            Assert.AreEqual("AA", ColumnPosition(27));
        }

        [TestMethod]
        public void TestForThreeLettersColumn()
        {
            Assert.AreEqual("AAA", ColumnPosition(703));
        }

        string ColumnPosition(int columnNumber)
        {
            
            string columnName = String.Empty;
            
            while (columnNumber > 0)
            {
                int modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                columnNumber = (columnNumber - modulo) / 26;
            }

            return columnName;
        }
    

    }
}
