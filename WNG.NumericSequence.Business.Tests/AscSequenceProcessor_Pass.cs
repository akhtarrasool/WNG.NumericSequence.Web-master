using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WNG.NumericSequence.Business.Tests
{
    [TestClass]
    public class AscSequenceProcessor_Pass
    {
        [TestMethod]
        public void When_Small_Range_Is_Processed()
        {
            var instance = new AscSequenceProcessor();
            var result = instance.Process(0, 12);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual(13, result.Count());
            Assert.AreEqual("0 1 2 3 4 5 6 7 8 9 10 11 12", String.Join(" ", result.ToArray()));

            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("12", result.Last());
         
        }

        [TestMethod]
        public void When_Large_Range_Is_Processed()
        {
            var instance = new AscSequenceProcessor();
            var result = instance.Process(0, 25);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Count assertion
            Assert.AreEqual(26, result.Count());
            Assert.AreEqual("0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25", String.Join(" ", result.ToArray()));

            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("25", result.Last());
            
            
        }

        [TestMethod]
        public void Whether_Start_Value_Is_Included()
        {
            var instance = new AscSequenceProcessor();
            var result = instance.Process(0, 10);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Boundry assertion
            Assert.AreEqual("0", result.First());
        }

        [TestMethod]
        public void Whether_End_Value_Is_Included()
        {
            var instance = new AscSequenceProcessor();
            var result = instance.Process(0, 10);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Boundry assertion
            Assert.AreEqual("10", result.Last());
        }
    }
}
