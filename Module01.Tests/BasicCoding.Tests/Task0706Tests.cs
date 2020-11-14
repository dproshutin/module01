//-----------------------------------------------------------------------
// <copyright file="Task0706Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task06
    /// </summary>
    internal class Task0706Tests
    {
        [TestCase(7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17, ExpectedResult = new int[] { 7, 70, 17 })]
        [TestCase(6, 1, 2, 3, 4, 5, 7, 8, 9, 15, -34, 58, 0, -789, 45, ExpectedResult = new int[] { })]
        [TestCase(5, -567, 0, 123, -4, 7, 8, 9, ExpectedResult = new int[] {  -567 })]
        [TestCase(5, ExpectedResult = new int[] { })]

        /// <summary>Method to test correctness of filtering sequence of integer numbers by those having specified digit
        /// </summary>
        ///  <param name="digit">A digit from 0 to 9</param>
        ///  <param name="numbers">The array of integers</param>
        /// <returns>The array of filtered numbers</returns>
        public int[] CheckFilterDigit(int digit, params int[] numbers)
        {
            return Task0706.FilterDigit(digit, numbers);
        }
    }
}
