using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class IsItPangram
    {
        [TestMethod]
        public void FirstPhrase()
        {
            Assert.AreEqual(true, Pangram("The quick brown fox jumps over the lazy dog"));
        }


        bool Pangram( string phrase)
        {
            return false;
        }
    }
}
