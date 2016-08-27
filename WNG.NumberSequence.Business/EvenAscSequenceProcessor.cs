using System;
using System.Collections.Generic;
using System.Linq;
using WNG.NumericSequence.BusinessEntities;

namespace WNG.NumericSequence.Business
{
    /// <summary>
    /// Even ascendig sequence processor.
    /// </summary>
    public class EvenAscSequenceProcessor : INumericSequenceProcessor
    {
        #region Properties

        /// <summary>
        /// Action performed on numeric sequence.
        /// </summary>
        public ActionType ActionType
        {
            get { return ActionType.EvenAscending; }
        }

        #endregion


        #region Methods

        /// <summary>
        /// Processes numeric sequence in ascending order with even numbers.
        /// </summary>
        /// <param name="numFirst"> First number.</param>
        /// <param name="numLast">Last number.</param>
        /// <returns>Processed string containing numeric sequence.</returns>
        public IEnumerable<string> Process(int numFirst, int numLast)
        {
            if (numFirst > numLast)
            {
                throw new ArgumentOutOfRangeException("Invalid starting number", "Starting number must be greater than the last number.");
            }

            return Enumerable.Range(numFirst, numLast - numFirst + 1).Where(i => i % 2 == 0).Select(i => i.ToString());
        }

        #endregion

    }
}
