using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToBoolNullable
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingNull()
        {
            var result = ((object)null).ParseTo<bool?>();

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputNull_ExpectingTrue()
        {
            var result = ((object)null).ParseTo<bool?>(true);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputFalseString_ExpectingFalse()
        {
            const string variable = "false";

            var result = variable.ParseTo<bool?>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputFalseString_ExpectingFalse()
        {
            const string variable = "false";

            var result = variable.ParseTo<bool?>(true);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_InputTrueString_ExpectingTrue()
        {
            const string variable = "true";

            var result = variable.ParseTo<bool?>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputTrueString_ExpectingTrue()
        {
            const string variable = "true";

            var result = variable.ParseTo<bool?>(true);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputZero_ExpectingFalse()
        {
            const int variable = 0;

            var result = variable.ParseTo<bool?>();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputZero_ExpectingFalse()
        {
            const int variable = 0;

            var result = variable.ParseTo<bool?>(true);

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ParseTo_InputOne_ExpectingTrue()
        {
            const int variable = 1;

            var result = variable.ParseTo<bool?>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputOne_ExpectingTrue()
        {
            const int variable = 1;

            var result = variable.ParseTo<bool?>(true);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputTwo_ExpectingTrue()
        {
            const int variable = 2;

            var result = variable.ParseTo<bool?>();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputTwo_ExpectingTrue()
        {
            const int variable = 2;

            var result = variable.ParseTo<bool?>(true);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void ParseTo_InputSampleString_ExpectingFalse()
        {
            const string variable = "could be true";

            var result = variable.ParseTo<bool?>();

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTrue_InputSampleString_ExpectingTrue()
        {
            const string variable = "could be false";

            var result = variable.ParseTo<bool?>(true);

            Assert.AreEqual(true, result);
        }
    }
}
