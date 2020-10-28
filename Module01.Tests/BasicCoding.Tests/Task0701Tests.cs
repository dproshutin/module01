//-----------------------------------------------------------------------
// <copyright file="Task0701Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task01
    /// </summary>
    internal class Task0701Tests
    {
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        [TestCase(-8, 15, 3, 8, ExpectedResult = -392)]
        [TestCase(-8, -15, 3, 8, ExpectedResult = -120)]
        [TestCase(int.MaxValue, 0, 0, 0, ExpectedResult = int.MaxValue - 1)]
        [TestCase(int.MaxValue, 0, 0, 2, ExpectedResult = int.MaxValue - 7)]
        [TestCase(int.MaxValue, int.MinValue, 0, 30, ExpectedResult = 0)]
        [TestCase(int.MaxValue, int.MinValue, 0, 31, ExpectedResult = int.MinValue)]
        [TestCase(int.MinValue, int.MaxValue, 0, 30, ExpectedResult = -1)]

        /// <summary>Method to get result of inserting selected bits of the second number into the first one
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <param name="i">The first selected bit</param>
        /// <param name="j">The last selected bit</param>
        /// <returns>The result of insert</returns>
        public int CheckInsertNumber(int a, int b, int i, int j)
        {
            var task0701 = new Task0701();
            return task0701.InsertNumber(a, b, i, j);
        }
    }
}
