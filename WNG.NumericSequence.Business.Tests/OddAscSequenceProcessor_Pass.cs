using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WNG.NumericSequence.Business.Tests
{
    [TestClass]
    public class OddAscSequenceProcessor_Pass
    {
        [TestMethod]
        public void When_Small_Range_Is_Processed()
        {
            var instance = new OddAscSequenceProcessor();
            var result = instance.Process(0, 9);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual("1 3 5 7 9", String.Join(" ", result.ToArray()));
            Assert.AreEqual(5, result.Count());

            //Boundry assertion
            Assert.AreEqual("1", result.First());
            Assert.AreEqual("9", result.Last());

        }

        [TestMethod]
        public void When_Large_Range_Is_Processed()
        {
            var instance = new OddAscSequenceProcessor();
            var result = instance.Process(0, 11);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual("1 3 5 7 9 11", String.Join(" ", result.ToArray()));
            Assert.AreEqual(6, result.Count());

            //Boundry assertion
            Assert.AreEqual("1", result.First());
            Assert.AreEqual("11", result.Last());


        }

        [TestMethod]
        public void When_Starts_With_Even()
        {
            var instance = new OddAscSequenceProcessor();
            var result = instance.Process(6, 12);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Boundry assertion
            Assert.AreEqual("7", result.First());
            Assert.AreEqual("11", result.Last());
        }

        [TestMethod]
        public void When_Starts_With_Odd()
        {
            var instance = new OddAscSequenceProcessor();
            var result = instance.Process(9, 21);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Boundry assertion
            Assert.AreEqual("9", result.First());
            Assert.AreEqual("21", result.Last());
        }
    }
}
