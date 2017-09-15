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
            string prefix = string.Empty;
            /* while (phraseOne[i] == phraseTwo[i] && i < shortestLenght)
             {
                 i++;
             }
             string prefix = phraseOne.Substring(0, i); */

            for (i = 0; i < shortestLenght; i++)
                if (phraseOne[i] != phraseTwo[i])
                {
                    prefix = phraseOne.Substring(0, i);
                    break;
                }
            return prefix;
        }
    }
}