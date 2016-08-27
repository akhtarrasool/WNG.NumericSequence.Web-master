using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WNG.NumericSequence.BusinessEntities;

namespace WNG.NumericSequence.Business
{
    /// <summary>
    /// Odda scendig sequence processor.
    /// </summary>
    public class OddAscSequenceProcessor : INumericSequenceProcessor
    {
        #region Properties

        /// <summary>
        /// Action performed on numeric sequence.
        /// </summary>
        public ActionType ActionType
        {
            get { return ActionType.OddAscending; }
        }

        #endregion


        #region Methods

        /// <summary>
        /// Processes numeric sequence in ascending order with odd numbers.
        /// </summary>
        /// <param name="numFirst"> First number.</param>
        /// <param name="numLast">Last number.</param>
        /// <returns>Processed string containing numeric sequence.</returns>
        public IEnumerable<string> Process(int numFirst, int numLast)
        {
            if (numFirst < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid starting number", "Starting number must be greater than zero(0).");
            }
            if (numFirst > numLast)
            {
                throw new ArgumentOutOfRangeException("Invalid starting number", "Starting number must be greater than the last number.");
            }

            return Enumerable.Range(numFirst, numLast - numFirst + 1).Where(i => i % 2 == 1).Select(i => i.ToString());
        }

        #endregion
    }
}
