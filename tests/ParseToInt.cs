using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToInt
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingZero()
        {
            object variable = null;

            var result = variable.ParseTo<int>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultOne_InputNull_ExpectingOne()
        {
            object variable = null;

            var result = variable.ParseTo<int>(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseTo_InputOne_ExpectingOne()
        {
            var variable = 1;

            var result = variable.ParseTo<int>();

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputOne_ExpectingOne()
        {
            var variable = 1;

            var result = variable.ParseTo<int>(2);

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_InputStringOne_ExpectingOne()
        {
            var variable = "1";

            var result = variable.ParseTo<int>();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputStringOne_ExpectingOne()
        {
            var variable = "1";

            var result = variable.ParseTo<int>(2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseTo_InputBadString_ExpectingZero()
        {
            var variable = "Bad to the bone";

            var result = variable.ParseTo<int>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultOne_InputBadString_ExpectingOne()
        {
            var variable = "B-b-b-b-b-b-b-bad";

            var result = variable.ParseTo<int>(1);

            Assert.AreEqual(1, result);
        }
    }
}
