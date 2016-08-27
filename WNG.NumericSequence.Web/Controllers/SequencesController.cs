using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WNG.NumericSequence.Business;
using WNG.NumericSequence.BusinessEntities;

namespace WNG.NumericSequence.Web.Controllers
{
    /// <summary>
    /// Sequence controller.
    /// </summary>
    public class SequencesController : Controller
    {

        #region Private 

        /// <summary>
        /// Sequence processor.
        /// </summary>
        private readonly IEnumerable<INumericSequenceProcessor> _seqProcessor;

        #endregion

        #region Constructor

        public SequencesController(INumericSequenceProcessor[] calculators)
        {
            _seqProcessor = calculators;
        }

        #endregion

        #region Views

        /// <summary>
        /// Index view.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// View to process.
        /// </summary>
        /// <param name="paramValue"> sequence value</param>
        /// <returns> Result in json.</returns>
        [HttpPost]
        public JsonResult Process(SequenceModel paramValue)
        {
            NumericSequenceModel model = new NumericSequenceModel();
            if (ModelState.IsValid)
            {
                model.Results = _seqProcessor.Select(s => new SequenceResultModel()
                {
                    ActionType = s.ActionType,
                    Values = s.Process(0, paramValue.SequenceValue)
                });
            }
            return Json(model.Results, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}