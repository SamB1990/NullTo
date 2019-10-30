using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToDecimal
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingZero()
        {
            object variable = null;

            var result = variable.ParseTo<decimal>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultOnePointTwo_InputNull_ExpectingOnePointTwo()
        {
            object variable = null;

            var result = variable.ParseTo<decimal>((decimal)1.2);

            Assert.AreEqual((decimal)1.2, result);
        }

        [TestMethod]
        public void ParseTo_InputOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = (decimal)1.2;

            var result = variable.ParseTo<decimal>();

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = (decimal)1.2;

            var result = variable.ParseTo<decimal>(2);

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_InputStringOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = "1.2";

            var result = variable.ParseTo<decimal>();

            Assert.AreEqual((decimal)1.2, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputStringOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = "1.2";

            var result = variable.ParseTo<decimal>(2);

            Assert.AreEqual((decimal)1.2, result);
        }

        [TestMethod]
        public void ParseTo_InputSampleString_ExpectingZero()
        {
            var variable = "Test";

            var result = variable.ParseTo<decimal>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultOnePointTwo_InputSampleString_ExpectingOnePointTwo()
        {
            var variable = "Test";

            var result = variable.ParseTo<decimal>((decimal)1.2);

            Assert.AreEqual((decimal)1.2, result);
        }
    }
}
