using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNG.NumericSequence.BusinessEntities
{
    /// <summary>
    /// Sequence result model.
    /// </summary>
    public class SequenceResultModel
    {

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public SequenceResultModel()
        {
            Values = Enumerable.Empty<string>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Action type.
        /// </summary>
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Sequence result values.
        /// </summary>
        public IEnumerable<string> Values { get; set; }

        #endregion
    }

    /// <summary>
    /// Action type enum.
    /// </summary>
    public enum ActionType
    {
        Ascending = 0,
        EvenAscending = 1,
        OddAscending = 2,
        Fibonacci = 3,
        Substitution = 4
    }
}
