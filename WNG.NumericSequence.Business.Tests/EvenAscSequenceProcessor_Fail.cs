using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WNG.NumericSequence.Business.Tests
{
    [TestClass]
    public class EvenAscSequenceProcessor_Fail
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void When_Start_Is_Negative()
        {
            var instance = new EvenAscSequenceProcessor();
            var result = instance.Process(15, -2);
            result.ToArray();
            Assert.Fail("Exception");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void When_Start_Is_Greater_Than_End()
        {
            var instance = new EvenAscSequenceProcessor();
            var result = instance.Process(15, 5);
            result.ToArray();
            Assert.Fail("Exception");
        }
    }
}
