//-----------------------------------------------------------------------
// <copyright file="Task0705Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task05
    /// </summary>
    internal class Task0705Tests
    {
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]

        /// <summary>Method to test correctness of finding next bigger number for the given number that has the same digits
        /// </summary>
        ///  <param name="number">A positive integer number</param>
        /// <returns>The next bigger number, if exists. Otherwise, -1.</returns>
        public int CheckFindNextBiggerNumber(int number)
        {
            return Task0705.FindNextBiggerNumber(number);
        }
    }
}
