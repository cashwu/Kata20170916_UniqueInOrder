using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170916_UniqueInOrder
{
    [TestClass]
    public class UniqueInOrderTests
    {
        [TestMethod]
        public void Input_AB_should_return_AB()
        {
            UniqueInOrderShouldBe("AB", "AB");
        }

        private static void UniqueInOrderShouldBe(string expected, string iterable)
        {
            var kata = new Kata();
            var actual = kata.UniqueInOrder(iterable);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            return iterable;
        }
    }
}
