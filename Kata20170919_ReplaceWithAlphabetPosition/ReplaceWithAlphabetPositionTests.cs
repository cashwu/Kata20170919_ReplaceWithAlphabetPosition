using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170919_ReplaceWithAlphabetPosition
{
    [TestClass]
    public class ReplaceWithAlphabetPositionTests
    {
        [TestMethod]
        public void input_a_should_return_1()
        {
            AlphabetPositionShouldBe("1", "a");
        }

        private static void AlphabetPositionShouldBe(string expected, string text)
        {
            var kata = new Kata();
            var actual = kata.AlphabetPosition(text);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public string AlphabetPosition(string text)
        {
            return "1";
        }
    }
}
