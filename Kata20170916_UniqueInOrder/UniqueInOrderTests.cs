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

        [TestMethod]
        public void Input_AAA_should_return_A()
        {
            UniqueInOrderShouldBe("A", "AAA");
        }

        [TestMethod]
        public void Input_AAB_should_return_AB()
        {
            UniqueInOrderShouldBe("AB", "AAB");
        }

        [TestMethod]
        public void Input_AAAABBBCCDAABBB_should_return_ABCDAB()
        {
            UniqueInOrderShouldBe("ABCDAB", "AAAABBBCCDAABBB");
        }

        [TestMethod]
        public void Input_ABBCcAD_should_return_ABCcAD()
        {
            UniqueInOrderShouldBe("ABCcAD", "ABBCcAD");
        }

        [TestMethod]
        public void Input_12233_should_return_123()
        {
            UniqueInOrderShouldBe("123", "12233");
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

                var result = new List<char>
                {
                    list[0]
                };

                for (var i = 1; i < list.Count; i++)
                {
                    if (list[i] != list[i - 1])
                    {
                        result.Add(list[i]);
                    }
                }

                return string.Concat(result).Cast<T>();
            }
            
            return iterable;
        }
    }
}
