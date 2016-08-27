using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WNG.NumericSequence.Business.Tests
{
    [TestClass]
    public class FibonacciProcessor_Pass
    {
        [TestMethod]
        public void When_Small_Range_Is_Processed()
        {
            var instance = new FibonacciProcessor();
            var result = instance.Process(0, 8);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual(7, result.Count());
            Assert.AreEqual("0, 1, 1, 2, 3, 5, 8", String.Join(", ", result.ToArray()));

            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("8", result.Last());
            
        }

        [TestMethod]
        public void When_Large_Range_Is_Processed()
        {
            var instance = new FibonacciProcessor();
            var result = instance.Process(0, 10000);

            //Object existance assertion
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());

            //Overall assertion
            Assert.AreEqual(22, result.Count());
            Assert.AreEqual("0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10000", String.Join(", ", result.ToArray()));

            //Boundry assertion
            Assert.AreEqual("0", result.First());
            Assert.AreEqual("10000", result.Last()); 
           
            
        }

    }
}
