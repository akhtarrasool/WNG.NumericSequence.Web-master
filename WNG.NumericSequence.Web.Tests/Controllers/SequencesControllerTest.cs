using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WNG.NumericSequence.Web;
using WNG.NumericSequence.Web.Controllers;
using Moq;
using WNG.NumericSequence.Business;
using WNG.NumericSequence.BusinessEntities;

namespace WNG.NumericSequence.Web.Tests.Controllers
{
    [TestClass]
    public class SequencesControllerTest
    {
        [TestMethod]
        public void When_Index_Returns_As_A_View()
        {
            // Arrange
            SequencesController controller = new SequencesController(null);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Process()
        {
            // Arrange
            var controller = new SequencesController(new[] { new EvenAscSequenceProcessor() });
            var model = new SequenceModel() { SequenceValue = 5 };

            // Act
            var result = controller.Process(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Data != null);

            Assert.IsInstanceOfType(result, typeof(JsonResult));

            var viewResult = result as JsonResult;
            Assert.AreEqual(viewResult.JsonRequestBehavior, JsonRequestBehavior.AllowGet);
        }


    }
}
