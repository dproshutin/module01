//-----------------------------------------------------------------------
// <copyright file="Task0702.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------
namespace Module01
{
    using System.Collections.Generic;

    /// <summary>
    /// The class for solving task02 in 07.BasicCoding
    /// </summary>
    public class Task0702
    {
        /// <summary>Initializes a new instance of the <see cref="Task0702"/> class
        /// </summary>
        /// <param name="arr">The given array of integer elements</param>
        public Task0702(int[] arr)
        {
            this.IntegerArray = arr;
            this.MaxElement = this.FindMaxValue(this.IntegerArray);
        }

        /// <summary>Gets maximal element of the array</summary>
        public int MaxElement { get; }

        /// <summary>Gets or sets of integer array</summary>
        public int[] IntegerArray { get; set; }

        /// <summary>Recursive method to get maximal element of the given array
        /// </summary>
        /// <param name="integerArray">The given array of integer elements</param>
        /// <returns>The maximal element of array</returns>
        private int FindMaxValue(int[] integerArray)
        {
            if (integerArray.Length == 1)
            {
                return integerArray[0];
            }

            int lastElement = integerArray[integerArray.Length - 1];
            List<int> list = new List<int>(integerArray);
            list.RemoveAt(integerArray.Length - 1);
            int[] truncatedArray = list.ToArray();
            int result = (lastElement >= this.FindMaxValue(truncatedArray)) ? lastElement : this.FindMaxValue(truncatedArray);
            return result;
        }
    }
}
