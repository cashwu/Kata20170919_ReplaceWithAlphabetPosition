using System;
using System.Linq;
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

        [TestMethod]
        public void input_b_should_return_2()
        {
            AlphabetPositionShouldBe("2", "b");
        }

        [TestMethod]
        public void input_z_should_return_26()
        {
            AlphabetPositionShouldBe("26", "z");
        }

        [TestMethod]
        public void input_A_should_return_1()
        {
            AlphabetPositionShouldBe("1", "A");
        }

        [TestMethod]
        public void input_ab_should_return_1_2()
        {
            AlphabetPositionShouldBe("1 2", "ab");
        }

        [TestMethod]
        public void input_ab_cd_should_return_1_2_3_4()
        {
            AlphabetPositionShouldBe("1 2 3 4", "ab cd");
        }

        [TestMethod]
        public void input_Ab_Cd_should_return_1_2_3_4()
        {
            AlphabetPositionShouldBe("1 2 3 4", "Ab Cd");
        }

        [TestMethod]
        public void input_ab_plus_cd_should_return_1_2_3_4()
        {
            AlphabetPositionShouldBe("1 2 3 4", "ab + cd");
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
            return string.Join(" ", text.Where(char.IsLetter).Select(c => char.ToLower(c) - 96));
        }
    }
}
