//-----------------------------------------------------------------------
// <copyright file="Task0706.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The class for solving task06 in 07.BasicCoding
    /// </summary>
    public class Task0706
    {
        /// <summary>Method to filter sequence of integer numbers by those having specified digit
        /// </summary>
        ///  <param name="digit">A digit from 0 to 9</param>
        ///  <param name="numbers">The array of integers</param>
        /// <returns>The array of filtered numbers</returns>
        public static int[] FilterDigit(int digit, params int[] numbers)
        {
            List<int> filteredNumbers = new List<int>();
            string digitString = Convert.ToString(digit);
            for (int i = 0; i < numbers.Length; i++)
            {
                string numberString = Convert.ToString(numbers[i]);
                if (numberString.Contains(digitString))
                {
                    filteredNumbers.Add(numbers[i]);
                }
            }

            return filteredNumbers.ToArray();
        }
    }
}
