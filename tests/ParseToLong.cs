using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToLong
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingZero()
        {
            object variable = null;

            var result = variable.ParseTo<long>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultOne_InputNull_ExpectingOne()
        {
            object variable = null;

            var result = variable.ParseTo<long>(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseTo_InputOne_ExpectingOne()
        {
            const int variable = 1;

            var result = variable.ParseTo<long>();

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputOne_ExpectingOne()
        {
            const int variable = 1;

            var result = variable.ParseTo<long>(2);

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_InputStringOne_ExpectingOne()
        {
            const string variable = "1";

            var result = variable.ParseTo<long>();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputStringOne_ExpectingOne()
        {
            const string variable = "1";

            var result = variable.ParseTo<long>(2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseTo_InputBadString_ExpectingZero()
        {
            const string variable = "I shot the sheriff";

            var result = variable.ParseTo<long>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputBadString_ExpectingTwo()
        {
            const string variable = "but I did not shoot the deputy";

            var result = variable.ParseTo<long>(2);

            Assert.AreEqual(2, result);
        }
    }
}
