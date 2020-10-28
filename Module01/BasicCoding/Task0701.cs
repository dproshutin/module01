//-----------------------------------------------------------------------
// <copyright file="Task0701.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------
namespace Module01
{
    using System;

    /// <summary>
    /// The class for solving task01 in 07.BasicCoding
    /// </summary>
    public class Task0701
    {
        /// <summary>Method to get result of inserting selected bits of the second number into the first one
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <param name="i">The first selected bit</param>
        /// <param name="j">The last selected bit</param>
        /// <returns>The result of insert</returns>
        public int InsertNumber(int a, int b, int i, int j)
        {
            int mask = 0;

            for (int k = i; k <= j; k++)
            {
                mask += (int)Math.Pow(2.0, (double)k);
            }

            int invertedMask = ~mask;
            return (b << i & mask) | (invertedMask & a);
        }
    }
}