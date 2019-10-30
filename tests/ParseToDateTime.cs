using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToDateTime
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingMinDateTime()
        {
            var result = ((object) null).ParseTo<DateTime>();

            Assert.AreEqual(DateTime.MinValue, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultDateTime_InputNull_ExpectingDefaultDateTime()
        {
            var defaultDT = DateTime.Now;

            var result = ((object) null).ParseTo<DateTime>(defaultDT);

            Assert.AreEqual(defaultDT, result);
        }

        [TestMethod]
        public void ParseTo_InputBadString_ExpectingDateString()
        {
            const string input = "Im a very bad string!";

            var result = input.ParseTo<DateTime>();

            Assert.AreEqual(DateTime.MinValue, result);
        }


        [TestMethod]
        public void ParseTo_WithDefaultDateTime_InputBadString_ExpectingDateString()
        {
            const string input = "think ^ he's bad wait till you see me!";

            var defaultDT = DateTime.Now;

            var result = input.ParseTo<DateTime>(defaultDT);

            Assert.AreEqual(defaultDT, result);
        }


        [TestMethod]
        public void ParseTo_InputDateString_ddmmyyyy_ExpectingDateString()
        {
            const string input = "10/11/2019";
            
            var result = input.ParseTo<DateTime>();

            Assert.AreEqual(Convert.ToDateTime(input), result);
        }


        [TestMethod]
        public void ParseTo_WithDefaultDateTime_InputDateString_ddmmyyyy_ExpectingDateString()
        {
            const string input = "10/11/2019";

            var result = input.ParseTo<DateTime>(DateTime.Now);

            Assert.AreEqual(Convert.ToDateTime(input), result);
        }

        [TestMethod]
        public void ParseTo_InputDateNow_ExpectingDateNow()
        {
            var input = DateTime.Now;

            var result = input.ParseTo<DateTime>();

            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultDateTime_InputDateNow_ExpectingDateNow()
        {
            var input = DateTime.Now;

            var result = input.ParseTo<DateTime>(DateTime.Now.AddDays(1));

            Assert.AreEqual(input, result);
        }
    }
}
