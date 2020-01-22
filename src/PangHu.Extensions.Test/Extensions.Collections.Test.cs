using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using System.Collections.Generic;

namespace PangHu.Extensions.Test
{
    [TestClass]
    public class ExtensionsCollectionsTest
    {
        [TestMethod]
        public void SplitByElement_Test()
        {
            var numbers = Enumerable.Range(1, 1520).ToList();
            var list = numbers.Split(5000);

            Assert.IsTrue(list.Count > 0);
        }


        [TestMethod]
        public void ContainsAny_Test()
        {
            var numbers = Enumerable.Range(1, 20).ToList();
            var result = numbers.ContainsAny(25, 15, 26);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsAll_Test()
        {
            var numbers = Enumerable.Range(1, 20).ToList();
            var result = numbers.ContainsAll(1,5,16,25);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmpty_Test()
        {
            var numbers = new List<int> { 1,2 };
            var result = numbers.IsEmpty();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNotEmpty_Test()
        {
            var numbers = new List<int> { };
            var result = numbers.IsNotEmpty();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ForEach_Test()
        {
            var numbers = Enumerable.Range(1, 100);
            int sum = 0;
            numbers.ForEach(n => sum += n);
            Assert.IsTrue(sum > 0);
        }

        [TestMethod]
        public void StringJoin_Test()
        {
            var numbers = Enumerable.Range(1, 100);
            string result = numbers.StringJoin("$");
            string result2 = numbers.StringJoin('@');
            Assert.IsTrue(!string.IsNullOrEmpty(result));
        }

    }
}
