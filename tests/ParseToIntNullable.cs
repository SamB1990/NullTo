using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToIntNullable
    {

        [TestMethod]
        public void ParseToNullable_InputNull_ExpectingNull()
        {
            var result = ((object) null).ParseTo<int?>();

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void ParseToNullable_WithDefaultOne_InputNull_ExpectingNull()
        {
            var result = ((object) null).ParseTo<int?>(1);

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void ParseToNullable_InputOne_ExpectingOne()
        {
            object variable = 1;

            var result = variable.ParseTo<int?>();

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseToNullable_WithDefaultTwo_InputOne_ExpectingOne()
        {
            object variable = 1;

            var result = variable.ParseTo<int?>(2);

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseToNullable_InputStringOne_ExpectingOne()
        {
            const string variable = "1";

            var result = variable.ParseTo<int?>();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseToNullable_WithDefaultTwo_InputStringOne_ExpectingOne()
        {
            const string variable = "1";

            var result = variable.ParseTo<int?>(2);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ParseToNullable_InputBadString_ExpectingNull()
        {
            const string variable = "Because I'm bad, I'm bad come on";

            var result = variable.ParseTo<int?>();

            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void ParseToNullable_WithDefaultOne_InputBadString_ExpectingOne()
        {
            const string variable = "You know I'm bad, I'm bad come on, you know";

            var result = variable.ParseTo<int?>(1);

            Assert.AreEqual(1, result);
        }
    }
}
