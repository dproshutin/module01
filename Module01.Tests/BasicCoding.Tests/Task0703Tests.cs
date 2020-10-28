//-----------------------------------------------------------------------
// <copyright file="Task0703Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task03
    /// </summary>
    internal class Task0703Tests
    {
        [TestCase(new double[] { 1.0, 2.0, 3.0, 4.0, 3.0, 1.0, 2.0 }, ExpectedResult = 3)]
        [TestCase(new double[] { -2.0 }, ExpectedResult = -1)]
        [TestCase(new double[] { -2.0, 3.5 }, ExpectedResult = -1)]
        [TestCase(new double[] { -2.0, 3.0, -2.0 }, ExpectedResult = 1)]
        [TestCase(new double[] { -2.5, -6.0, 1.5, 8.0, 2.376, 1.0 }, ExpectedResult = 4)]

        /// <summary>Method to check whether index of the element that divides the array into two parts is found correctly.
        /// The sum of elements in each part is the same.
        /// </summary>
        /// <param name="arr">The given array of real numbers</param>
        /// <returns>The index of the element</returns>
        public int CheckGetFirstMedian(double[] arr)
        {
            var task0703 = new Task0703(arr);
            return task0703.GetFirstMedian();
        }
    }
}
