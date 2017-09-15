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
            StringAssert .StartsWith("semic", PrefixFinder("semiconductor", "semicolon"));
        }

        string PrefixFinder(string a, string b)
        {
            return null;
        }
    }
}
