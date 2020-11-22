//-----------------------------------------------------------------------
// <copyright file="Task0802Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task0802
    /// </summary>
    internal class Task0802Tests
    {
        /// <summary>
        /// Data for test cases
        /// </summary>
        private static readonly object[] Data =
    {
        // ascending sort by sum of elements
        new object[] { new[] { new[] { -2, 5, 0 }, new[] { 0, 14, -3, 2 }, new[] { 1, 2, 3 } }, 1, 1, new List<int[]> { new[] { -2, 5, 0 }, new[] { 1, 2, 3 }, new[] { 0, 14, -3, 2 } } },
        
        // decending sort by sum of elements
        new object[] { new[] { new[] { -2, 5, 0 }, new[] { 0, 14, -3, 2 }, new[] { 1, 2, 3 } }, 1, 2, new List<int[]> { new[] { 0, 14, -3, 2 }, new[] { 1, 2, 3 }, new[] { -2, 5, 0 } } },
        
        // ascending sort by maximal element
        new object[] { new[] { new[] { -2, -1, 17 }, new[] { 1, 16, -3, -2 }, new[] { 15, 2, 3 } }, 2, 1, new List<int[]> { new[] { 15, 2, 3 }, new[] { 1, 16, -3, -2 }, new[] { -2, -1, 17 } } },
        
        // descending sort by maximal element
        new object[] { new[] { new[] { -2, -1, 17 }, new[] { 1, 16, -3, -2 }, new[] { 15, 2, 3 } }, 2, 2, new List<int[]> { new[] { -2, -1, 17 }, new[] { 1, 16, -3, -2 }, new[] { 15, 2, 3 } } },
        
        // ascending sort by minimal element
        new object[] { new[] { new[] { -2, -1, 17 }, new[] { 1, 16, -3, -2 }, new[] { 15, 2, 3 } }, 3, 1, new List<int[]> { new[] { 1, 16, -3, -2 }, new[] { -2, -1, 17 }, new[] { 15, 2, 3 } } },
        
        // descending sort by minimal element
        new object[] { new[] { new[] { -2, -1, 17 }, new[] { 1, 16, -3, -2 }, new[] { 15, 2, 3 } }, 3, 2, new List<int[]> { new[] { 15, 2, 3 }, new[] { -2, -1, 17 }, new[] { 1, 16, -3, -2 } } }
    };
        [Test, TestCaseSource(nameof(Data))]

        /// <summary>Method to assert that the correct sorting is done
        /// </summary>
        /// <param name="unsortedArray">A jagged array of integer numbers to be sorted</param>
        /// <param name="condition">A parameter to define condition: 1 - by sum of elements, 2 - by maximal element, 3 - by minimal element</param>
        /// <param name="option">A sort direction: 1 - ascending, 2 - descending</param>
        /// <param name="expectedResult">The result to assert with</param>
        public void ShouldBubbleSortForJaggedArray(int[][] unsortedArray, int condition, int option, List<int[]> expectedResult)
        {
            var result = Task0802.BubbleSortForJaggedArray(unsortedArray, condition, option);
            Assert.That(result, Is.EquivalentTo(expectedResult)); 
        }
    }
}
