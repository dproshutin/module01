//-----------------------------------------------------------------------
// <copyright file="Task0702Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task02
    /// </summary>
    internal class Task0702Tests
    {
        [TestCase(new int[] { 2, 3, -5, 0, 17, 2, 7, 9 }, ExpectedResult = 17)]
        [TestCase(new int[] { -2 }, ExpectedResult = -2)]

        /// <summary>Method to get maximal element of the given array
        /// </summary>
        /// <param name="arr">The given array of integer elements</param>
        /// <returns>The maximal element of array</returns>
        public int CheckFindMaxValue(int[] arr)
        {
            var task0702 = new Task0702(arr);
            return task0702.MaxElement;
        }
    }
}
