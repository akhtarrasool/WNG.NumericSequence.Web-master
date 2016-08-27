using System;
using System.Collections.Generic;
using WNG.NumericSequence.BusinessEntities;

namespace WNG.NumericSequence.Business
{
    /// <summary>
    /// Interface for numeric sequence processing.
    /// </summary>
    public interface INumericSequenceProcessor
    {
        #region Properties

        /// <summary>
        /// Action performed on numeric sequence.
        /// </summary>
        ActionType ActionType { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Processes numeric sequence
        /// </summary>
        /// <param name="numFirst"> First number.</param>
        /// <param name="numLast">Last number.</param>
        /// <returns>Processed string containing numeric sequence.</returns>
        IEnumerable<string> Process(int numFirst, int numLast);

        #endregion
    }
}
