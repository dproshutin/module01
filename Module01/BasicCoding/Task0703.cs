//-----------------------------------------------------------------------
// <copyright file="Task0703.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class for solving task03 in 07.BasicCoding
    /// </summary>
    public class Task0703
    {
        /// <summary>Initializes a new instance of the <see cref="Task0703"/> class</summary>
        /// <param name="arr">The given array of real numbers</param>
        public Task0703(double[] arr)
        {
            this.ArrayOfDoubles = arr;
        }

        /// <summary>Gets or sets of real numbers array</summary>
        public double[] ArrayOfDoubles { get; set; }

        /// <summary>Method to find index of the element that divides the array into two parts. The sum of elements in each part is the same.
        /// </summary>
        /// <returns>The index of the element</returns>
        public int GetFirstMedian()
        {
            int length = this.ArrayOfDoubles.Length;

            if (length <= 2)
            {
                return -1;
            }

            for (int i = 1; i < length - 1; i++)
            {
                double leftSum = this.GetSumOfElements(0, i - 1);
                double rightSum = this.GetSumOfElements(i + 1, length - 1);

                if (leftSum == rightSum)
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>Method to calculate sum of the elements in the inclusive range between two indexes
        /// </summary>
        /// <param name="index1">The first index of the range</param>
        /// <param name="index2">The last index of the range</param>
        /// <returns>The maximal element of array</returns>
        private double GetSumOfElements(int index1, int index2)
        {
            double result = 0;
            for (int i = index1; i <= index2; i++)
            {
                result += this.ArrayOfDoubles[i];
            }

            return result;
        }
    }
}
