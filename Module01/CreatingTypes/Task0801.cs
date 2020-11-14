//-----------------------------------------------------------------------
// <copyright file="Task0801.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01
{
    using System;

    /// <summary>
    /// The class for solving task01 in 08.CreatingTypes
    /// </summary>
    public class Task0801
    {
        /// <summary>Method to find Nth root with Newton's method for a given accuracy
        /// </summary>
        ///  <param name="number">A real number</param>
        ///  <param name="orderOfRoot">An integer positive number</param>
        ///  <param name="accuracy">A real positive number</param>
        /// <returns>The real number that is Nth root</returns>
        public static double? FindNthRoot(double number, int orderOfRoot, double accuracy)
        {
            if ((number < 0 && orderOfRoot % 2 == 0) || (orderOfRoot < 0) || (accuracy < 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            double estimate;
            double? nextEstimate = null;
            do
            {
                estimate = nextEstimate ?? 1.0;
                nextEstimate = (1.0 / orderOfRoot) * (((orderOfRoot - 1) * estimate) + (Math.Abs(number) / Math.Pow(estimate, (double)(orderOfRoot - 1))));
            } 
            while (Math.Abs((double)nextEstimate - estimate) >= accuracy);

            return (number >= 0) ? nextEstimate : -nextEstimate;
        }
    }
}
