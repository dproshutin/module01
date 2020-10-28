//-----------------------------------------------------------------------
// <copyright file="Task0704.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01
{
    /// <summary>
    /// The class for solving task04 in 07.BasicCoding
    /// </summary>
    public class Task0704
    {
        /// <summary>Method to get the concatenation of two strings, excluding repeated symbols
        /// </summary>
        ///  <param name="str1">The first string</param>
        ///  <param name="str2">The second string</param>
        /// <returns>The concatenation of two strings, excluding repeated symbols</returns>
        public static string ConcatenateStringExcludingRepeats(string str1, string str2)
        {
            int lengthOfRepeat = str2.Length;
            string resultOfConcat = null;
            while (lengthOfRepeat >= 0)
            {
                string repeat = str2.Substring(0, lengthOfRepeat);
                if (str1.EndsWith(repeat))
                {
                    resultOfConcat = str1 + str2.Substring(lengthOfRepeat);
                    break;
                }

                lengthOfRepeat--;
            }

            return resultOfConcat;
        }
    }
}
