using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToDouble
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingZero()
        {
            object variable = null;

            var result = variable.ParseTo<double>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultOnePointTwo_InputNull_ExpectingOnePointTwo()
        {
            object variable = null;

            var result = variable.ParseTo<double>((double)1.2);

            Assert.AreEqual((double)1.2, result);
        }

        [TestMethod]
        public void ParseTo_InputOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = (double)1.2;

            var result = variable.ParseTo<double>();

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = (double)1.2;

            var result = variable.ParseTo<double>(2);

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_InputStringOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = "1.2";

            var result = variable.ParseTo<double>();

            Assert.AreEqual((double)1.2, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultTwo_InputStringOnePointTwo_ExpectingOnePointTwo()
        {
            var variable = "1.2";

            var result = variable.ParseTo<double>(2);

            Assert.AreEqual((double)1.2, result);
        }

        [TestMethod]
        public void ParseTo_InputSampleString_ExpectingZero()
        {
            var variable = "Test";

            var result = variable.ParseTo<double>();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultOnePointTwo_InputSampleString_ExpectingOnePointTwo()
        {
            var variable = "Test";

            var result = variable.ParseTo<double>((double)1.2);

            Assert.AreEqual((double)1.2, result);
        }
    }
}
