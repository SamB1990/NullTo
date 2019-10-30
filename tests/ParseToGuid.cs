using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseTo.Extensions;

namespace ParseTo.UnitTests
{
    [TestClass]
    public class ParseToGuid
    {
        [TestMethod]
        public void ParseTo_InputNull_ExpectingDefaultGuid()
        {
            object variable = null;

            var result = variable.ParseTo<Guid>();

            Assert.AreEqual(Guid.Empty, result);
        }

        [TestMethod]
        public void ParseTo_InputSampleStringGuid_ExpectingSampleGuid()
        {
            var variable = "90ef9ff7-37dd-44f1-81aa-6500fdadb370";
            
            var result = variable.ParseTo<Guid>();

            Assert.AreEqual(Guid.Parse(variable), result);
        }

        [TestMethod]
        public void ParseTo_InputSampleGuid_ExpectingSampleGuid()
        {
            var variable = Guid.Parse("90ef9ff7-37dd-44f1-81aa-6500fdadb370");

            var result = variable.ParseTo<Guid>();

            Assert.AreEqual(variable, result);
        }

        [TestMethod]
        public void ParseTo_InputOne_ExpectingDefaultGuid()
        {
            var variable = 1;

            var result = variable.ParseTo<Guid>();

            Assert.AreEqual(Guid.Empty, result);
        }
    }
}
