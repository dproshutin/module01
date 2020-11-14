//-----------------------------------------------------------------------
// <copyright file="Task0705.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The class for solving task05 in 07.BasicCoding
    /// </summary>
    public class Task0705
    {
        /// <summary>Method to find next bigger number for the given number that has the same digits
        /// </summary>
        ///  <param name="number">A positive integer number</param>
        /// <returns>The next bigger number, if exists. Otherwise, -1.</returns>
        public static int FindNextBiggerNumber(int number)
        {
            string originalNumberString = number.ToString();
            var digits = originalNumberString.Select(t => int.Parse(t.ToString())).ToArray();
            for (int i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i] > digits[i - 1])
                {
                    int temp = digits[i - 1];
                    for (int j = digits.Length - 1; j >= i; j--)
                    {
                        if (digits[j] > temp)
                        {
                            digits[i - 1] = digits[j];
                            digits[j] = temp;
                            Array.Reverse(digits, i, digits.Length - i);
                            break;
                        }
                    }

                    break;
                }
            }

            var nextBiggerNumberString = string.Empty;
            foreach (int digit in digits)
            {
                nextBiggerNumberString += Convert.ToString(digit);
            }

            return (nextBiggerNumberString == originalNumberString) ? -1 : int.Parse(nextBiggerNumberString);
        }
    }
}
