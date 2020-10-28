//-----------------------------------------------------------------------
// <copyright file="Task0704Tests.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01.Tests
{
    using NUnit.Framework;
    [TestFixture]

    /// <summary>
    /// The NUnit test class for task04
    /// </summary>
    internal class Task0704Tests
    {
        [TestCase("zxcvbnm", "asdfghj", ExpectedResult = "zxcvbnmasdfghj")]
        [TestCase("zxcvbnm", "bnmfghj", ExpectedResult = "zxcvbnmfghj")]
        [TestCase("zxcvBnm", "bnmfghj", ExpectedResult = "zxcvBnmbnmfghj")]
        [TestCase("zxcvBnm", "zxcvBnm", ExpectedResult = "zxcvBnm")]
        [TestCase("zxcvBnm", "", ExpectedResult = "zxcvBnm")]
        [TestCase("", "zxcvBnm", ExpectedResult = "zxcvBnm")]
        [TestCase("zxcvbnm ", " asdfghj", ExpectedResult = "zxcvbnm asdfghj")]

        /// <summary>Method to check whether it gets the concatenation of two strings, excluding repeated symbols.
        /// The sum of elements in each part is the same.
        /// </summary>
        ///  <param name="str1">The first string</param>
        ///  <param name="str2">The second string</param>
        /// <returns>The concatenation of two strings, excluding repeated symbols</returns>
        public string CheckConcatenateStringExcludingRepeats(string str1, string str2)
        {
            return Task0704.ConcatenateStringExcludingRepeats(str1, str2);
        }
    }
}
