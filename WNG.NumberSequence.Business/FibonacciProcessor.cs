using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WNG.NumericSequence.BusinessEntities;

namespace WNG.NumericSequence.Business
{
    /// <summary>
    /// Fibonacci sequence processor.
    /// </summary>
    public class FibonacciProcessor : INumericSequenceProcessor
    {
        #region Properties

        /// <summary>
        /// Action performed on numeric sequence.
        /// </summary>
        public ActionType ActionType
        {
            get { return ActionType.Fibonacci; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Processes numeric sequence with respect to fibonacci series.
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

            if (numFirst < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid starting number", "Starting number must be greater than zero(0).");
            }

            Int64 first = 0;
            Int64 second = 1;
            bool finish = true;

            // Initial two result are always 1.
            yield return first.ToString();
            yield return second.ToString();


            while (finish)
            {
                Int64 current;

                if (first + second < numLast)
                {
                    current = first + second;
                    yield return current.ToString();
                    first = second;
                    second = current;
                }
                else
                {
                    finish = false;
                    current = numLast;
                    yield return current.ToString();
                }
            }

        }

        #endregion
    }
}
