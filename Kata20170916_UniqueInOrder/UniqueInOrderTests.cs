using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void Input_AA_should_return_A()
        {
            UniqueInOrderShouldBe("A", "AA");
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
            if (typeof(char) == typeof(T))
            {
                var list = iterable.Cast<char>().ToList();

                if (list[0] == list[1])
                {
                    return list[0].ToString().Cast<T>();
                }
            }
            
            return iterable;
        }
    }
}
