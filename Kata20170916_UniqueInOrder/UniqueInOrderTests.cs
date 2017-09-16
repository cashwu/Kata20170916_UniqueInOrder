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

        [TestMethod]
        public void Input_empty_should_return_empty()
        {
            UniqueInOrderShouldBe("", "");
        }

        [TestMethod]
        public void Input_1_1_should_return_1()
        {
            UniqueInOrderShouldBe(new List<int> { 1 }, new List<int>{ 1, 1 });
        }

        private static void UniqueInOrderShouldBe<T>(IEnumerable<T> expected, IEnumerable<T> iterable)
        {
            var kata = new Kata();
            var actual = kata.UniqueInOrder(iterable);
            CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
        }
    }

    public class Kata
    {
        public IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
        {
            var list = iterable.ToList();

            if (list.Count == 0)
            {
                return list;
            }

            var result = new List<T>
            {
                list[0]
            };

            for (var i = 1; i < list.Count; i++)
            {
                dynamic a = list[i], b = list[i - 1];

                if (a != b)
                {
                    result.Add(list[i]);
                }
                
                //var comparer = Comparer<T>.Default;

                //if (comparer.Compare(list[i], list[i - 1]) != 0)
                //{
                //    result.Add(list[i]);
                //}
            }

            return result;
        }
    }
}
