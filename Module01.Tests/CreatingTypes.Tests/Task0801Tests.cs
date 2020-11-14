//-----------------------------------------------------------------------
// <copyright file="Task0801Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using System;
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task0801
    /// </summary>
    internal class Task0801Tests
    {
        [Test]
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]

        /// <summary>Method to assert that Nth root is found with a given accuracy
        /// </summary>
        /// <param name="number">A real number</param>
        /// <param name="orderOfRoot">An integer positive number</param>
        /// <param name="accuracy">A real positive number</param>
        /// <param name="expectedResult">A real number as the expected result</param>
        public void ShouldFindNthRoot_WithTolerance(double number, int orderOfRoot, double accuracy, double? expectedResult)
        {
            var result = Task0801.FindNthRoot(number, orderOfRoot, accuracy);
            Assert.That(result, Is.EqualTo(expectedResult).Within(accuracy)); 
        }

        [Test]
        [TestCase(-0.01, 2, 0.0001)]
        [TestCase(0.001, -2, 0.0001)]
        [TestCase(0.01, 2, -1)]

        /// <summary>Method to assert that ArgumentOutOfRangeException is raised in some cases
        /// </summary>
        /// <param name="number">A real number</param>
        /// <param name="orderOfRoot">An integer positive number</param>
        /// <param name="accuracy">A real positive number</param>
        public void ShouldFindNthRoot_ArgumentOutOfRangeException(double number, int orderOfRoot, double accuracy)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Task0801.FindNthRoot(number, orderOfRoot, accuracy));
        }
    }
}
