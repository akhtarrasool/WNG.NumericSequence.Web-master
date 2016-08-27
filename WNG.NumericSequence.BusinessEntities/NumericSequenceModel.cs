using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNG.NumericSequence.BusinessEntities
{
    /// <summary>
    /// Numeric Sequence model.
    /// </summary>
    public class NumericSequenceModel
    {
        /// <summary>
        /// Sequence value.
        /// </summary>
        public int SequenceValue { get;  set; }

        /// <summary>
        /// Sequence result.
        /// </summary>
        public IEnumerable<SequenceResultModel> Results { get; set; }
    }

}
