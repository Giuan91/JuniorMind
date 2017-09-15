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

        [TestMethod]
        public void Secondphrae()
        {
            Assert.AreEqual(false, Pangram("This is not a pangram"));
        }

        static bool Pangram( string phrase)
        {
            
            
            for (char i = 'a'; i <= 'z'; i++)
                if (phrase.IndexOf(i) == -1)
                {
                    return false;
                }

            return true;
        }
    }
}
