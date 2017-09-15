using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrefixFinder
{
    [TestClass]
    public class PrefixFind
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringAssert .StartsWith("semico", PrefixFinder("semiconductor", "semicolon"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            StringAssert.StartsWith("aaa", PrefixFinder("aaab", "aaaaaabbaa"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            StringAssert.StartsWith("bb", PrefixFinder("bb", "bbbccc"));
        }

        string PrefixFinder(string phraseOne, string phraseTwo)
        {
            int i = 0;
            int shortestLenght = Math.Min(phraseOne.Length, phraseTwo.Length);

            while (phraseOne[i] == phraseTwo[i] && i < shortestLenght)
            {
                i++;
            }
            string prefix = phraseOne.Substring(0, i);
            return prefix;
        }
    }
}
