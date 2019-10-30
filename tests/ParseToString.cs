using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToString
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingEmptyString()
        {
            var result = ((object) null).ParseTo<string>();

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultString_InputNull_ExpectingDefaultString()
        {
            const string defaultString = "Just a default";

            var result = ((object) null).ParseTo(defaultString);

            Assert.AreEqual(defaultString, result);
        }


        [TestMethod]
        public void ParseTo_InputSampleString_ExpectingSampleString()
        {
            const string variable = "Return you shall";
            
            var result = variable.ParseTo<string>();

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_WithDefaultString_InputSampleString_ExpectingSampleString()
        {
            const string variable = "Return you shall";

            const string defaultString = "Just a default";

            var result = variable.ParseTo(defaultString);

            Assert.AreEqual(variable, result);
        }
    }
}
