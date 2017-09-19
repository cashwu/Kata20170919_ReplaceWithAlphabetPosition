﻿using System;
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
            return (char.Parse(text.ToLower()) - 96).ToString();
        }
    }
}
