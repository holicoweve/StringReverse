using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString.Tests
{
    [TestClass()]
    public class ReverseStringTests
    {
        [TestMethod()]
        public void ReverseStackTestABC()
        {
            string input = "abc";
            string expect = "cba";
            string actual = ReverseString.ReverseStack(input);
            Assert.AreEqual<string>(expect, actual);
        }

        [TestMethod()]
        public void ReverseStackTestEmpty()
        {
            string input = "";
            string expect = "";
            string actual = ReverseString.ReverseStack(input);
            Assert.AreEqual<string>(expect, actual);
        }

        [TestMethod()]
        public void ReverseIterateTestABC()
        {
            string input = "abc";
            string expect = "cba";
            string actual = ReverseString.ReverseIterate(input);
            Assert.AreEqual<string>(expect, actual);
        }

        [TestMethod()]
        public void ReverseIterateTestEmpty()
        {
            string input = "";
            string expect = "";
            string actual = ReverseString.ReverseIterate(input);
            Assert.AreEqual<string>(expect, actual);
        }

        [TestMethod()]
        public void ReverseRecursionTestABC()
        {
            string input = "abc";
            string expect = "cba";
            string actual = ReverseString.ReverseRecursion(input);
            Assert.AreEqual<string>(expect, actual);
        }

        [TestMethod()]
        public void ReverseRecursionTestEmpty()
        {
            string input = "";
            string expect = "";
            string actual = ReverseString.ReverseRecursion(input);
            Assert.AreEqual<string>(expect, actual);
        }
    }
}