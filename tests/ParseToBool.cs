using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToBool
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingFalse()
        {
            var result = ((object) null).ParseTo<bool>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputNull_ExpectingTrue()
        {
            var result = ((object)null).ParseTo(true);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputFalseString_ExpectingFalse()
        {
            const string variable = "false";

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputFalseString_ExpectingFalse()
        {
            const string variable = "false";

            var result = variable.ParseTo(true);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_InputTrueString_ExpectingTrue()
        {
            const string variable = "true";

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputTrueString_ExpectingTrue()
        {
            const string variable = "true";

            var result = variable.ParseTo(true);

            Assert.AreEqual(true, result);
        }
        
        [TestMethod]
        public void ParseTo_InputZero_ExpectingFalse()
        {
            const int variable = 0;

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_InputInt16Zero_ExpectingFalse()
        {
            const Int16 variable = 0;

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_InputInt64Zero_ExpectingFalse()
        {
            const Int64 variable = 0;

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputZero_ExpectingFalse()
        {
            const int variable = 0;

            var result = variable.ParseTo(true);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_InputOne_ExpectingTrue()
        {
            const int variable = 1;

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputInt16One_ExpectingTrue()
        {
            const Int16 variable = 1;

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputInt64One_ExpectingTrue()
        {
            const Int64 variable = 1;

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputOne_ExpectingTrue()
        {
            const int variable = 1;

            var result = variable.ParseTo(true);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputTwo_ExpectingTrue()
        {
            const int variable = 2;

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputTwo_ExpectingTrue()
        {
            const int variable = 2;

            var result = variable.ParseTo(true);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputSampleString_ExpectingFalse()
        {
            const string variable = "could be true";

            var result = variable.ParseTo<bool>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputSampleString_ExpectingTrue()
        {
            const string variable = "could be false";

            var result = variable.ParseTo(true);

            Assert.AreEqual(true, result);
        }
    }
}
