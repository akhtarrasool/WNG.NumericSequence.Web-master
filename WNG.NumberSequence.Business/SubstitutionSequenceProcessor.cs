using System;
using System.Collections.Generic;
using System.Linq;
using WNG.NumericSequence.BusinessEntities;

namespace WNG.NumericSequence.Business
{
    /// <summary>
    /// Substitution sequence processor.
    /// </summary>
    public class SubstitutionSequenceProcessor : INumericSequenceProcessor
    {
        #region Properties

        /// <summary>
        /// Action performed on numeric sequence.
        /// </summary>
        public ActionType ActionType
        {
            get { return ActionType.Substitution; }
        }

        #endregion


        #region Methods

        /// <summary>
        /// Processes numeric sequence and substitutes 3 and 5 multiples with alphabets.
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

            for (int i = numFirst; i <= numLast; i++)
            {
                var is3Multiple= i != 0 && i % 3 == 0;
                var is5Multiple = i != 0 && i % 5 == 0;

                if (is3Multiple && is5Multiple)
                {
                    yield return "Z";
                }
                else if (is3Multiple)
                {
                    yield return "C";
                }
                else if (is5Multiple)
                {
                    yield return "E";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }

        #endregion
    }
}
