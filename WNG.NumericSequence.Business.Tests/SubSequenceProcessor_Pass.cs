using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WNG.NumericSequence.Business.Tests
{
    [TestClass]
    public class SubSequenceProcessor_Pass
    {
        [TestMethod]
        public void When_Threes_Are_Subsituted()
        {
            var instance = new SubstitutionSequenceProcessor();
            var result = instance.Process(0, 20);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual(21, result.Count());
            Assert.AreEqual(5, result.Count(r => r == "C")); // Number of values divisible by 3
            Assert.AreEqual("0 1 2 C 4 E C 7 8 C E 11 C 13 14 Z 16 17 C 19 E", String.Join(" ", result.ToArray()));


            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("E", result.Last());
       
        }

        [TestMethod]
        public void When_Fives_Are_Subsituted()
        {
            var instance = new SubstitutionSequenceProcessor();
            var result = instance.Process(0, 20);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual(21, result.Count());
            Assert.AreEqual(3, result.Count(r => r == "E")); // Number of values divisible by 5
            Assert.AreEqual("0 1 2 C 4 E C 7 8 C E 11 C 13 14 Z 16 17 C 19 E", String.Join(" ", result.ToArray()));


            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("E", result.Last());

        }

        [TestMethod]
        public void When_Multiples_Of_Three_And_Five_Are_Subsituted()
        {
            var instance = new SubstitutionSequenceProcessor();
            var result = instance.Process(0, 20);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual(21, result.Count());
            Assert.AreEqual("Z", result.Skip(15).First());

            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("E", result.Last());      
         
        }
    }
}
