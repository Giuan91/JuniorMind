using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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

        [TestMethod]
        public void Secondphrae()
        {
            Assert.AreEqual(false, Pangram("This is not a pangram"));
        }

        static bool Pangram( string phrase)
        {
            return phrase.ToLower().Where(i => Char.IsLetter(i)).GroupBy(i => i).Count() == 26;
        }
    }
}
