using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixFinder
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual("semic", PrefixFinder());
        }

        string PrefixFinder(string prefix)
        {
            return prefix;
        }
    }
}
