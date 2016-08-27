using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WNG.NumericSequence.Business.Tests
{
    [TestClass]
    public class EvenAscSequenceProcessor_Pass
    {
        [TestMethod]
        public void When_Small_Range_Is_Processed()
        {
            var instance = new EvenAscSequenceProcessor();
            var result = instance.Process(0, 6);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual("0 2 4 6", String.Join(" ", result.ToArray()));
            Assert.AreEqual(4, result.Count());

            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("6", result.Last());            
            
        }

        [TestMethod]
        public void When_Large_Range_Is_Processed()
        {
            var instance = new EvenAscSequenceProcessor();
            var result = instance.Process(0, 12);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual("0 2 4 6 8 10 12", String.Join(" ", result.ToArray()));
            Assert.AreEqual(7, result.Count());

            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("12", result.Last());


        }

        [TestMethod]
        public void When_Starts_With_Even()
        {
            var instance = new EvenAscSequenceProcessor();
            var result = instance.Process(6, 12);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Boundry assertion
            Assert.AreEqual("6", result.First());
            Assert.AreEqual("12", result.Last());
        }

        [TestMethod]
        public void When_Starts_With_Odd()
        {
            var instance = new EvenAscSequenceProcessor();
            var result = instance.Process(9, 21);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Boundry assertion
            Assert.AreEqual("10", result.First());
            Assert.AreEqual("20", result.Last());
        }

    }
}
