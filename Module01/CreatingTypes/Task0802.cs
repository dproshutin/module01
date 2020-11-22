//-----------------------------------------------------------------------
// <copyright file="Task0802.cs" company="Epam External Training">
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
    /// Types of conditions to sort elements by.
    /// </summary>
    public enum Condition
    {
        /// <summary>Sort by the sum of elements</summary>
        Sum = 1,

        /// <summary>Sort by the maximal element</summary>
        Max = 2,
 
        /// <summary>Sort by the minimal element</summary>
        Min = 3
    }

    /// <summary>
    /// Types for sort order.
    /// </summary>
    public enum Option
    {
        /// <summary>The ascending order</summary>
        Asc = 1,
        
        /// <summary>The descending order</summary>
        Desc = 2
    }

    /// <summary>
    /// The class for solving task02 in 08.CreatingTypes
    /// </summary>
    public class Task0802
    {
        /// <summary>Method to sort a given jagged array of integer numbers by condition and sort direction
        /// </summary>
        /// <param name="unsortedArray">A jagged array of integer numbers to be sorted</param>
        /// <param name="condition">A parameter to define condition: 1 - by sum of elements, 2 - by maximal element, 3 - by minimal element</param>
        /// <param name="option">A sort direction: 1 - ascending, 2 - descending</param>
        /// <returns>The sorted List of arrays</returns>
        public static List<int[]> BubbleSortForJaggedArray(int[][] unsortedArray, int condition = 1, int option = 1)
        {
            if (!Enum.IsDefined(typeof(Condition), condition)) 
            {
                throw new NotImplementedException("сортировка массива должна быть по одному из трех критериев - сумме элементов, максимальному или минимальному элементу");
            }

            if (!Enum.IsDefined(typeof(Option), option))
            {
                throw new NotImplementedException("сортировка может быть или по возрастанию критерия, или по его убыванию");
            }

            Console.WriteLine("Заданный ступенчатый массив:");
            PrintValues(unsortedArray);
                
            var auxArray = new Elem[unsortedArray.Length];
            var sb = new StringBuilder();
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                int parameterForSorting = unsortedArray[i][0];
                for (int j = 1; j < unsortedArray[i].Length; j++)
                {
                    switch (condition)
                    {
                        case 1:
                            if (sb.Length == 0)
                            {
                                sb.Append("по сумме элементов, ");
                            }

                            parameterForSorting += unsortedArray[i][j];
                            break;
                        case 2:
                            if (sb.Length == 0)
                            {
                                sb.Append("по максимальному элементу, ");
                            }

                            if (unsortedArray[i][j] > parameterForSorting)
                            {
                                parameterForSorting = unsortedArray[i][j];
                            }

                            break;
                        case 3:
                            if (sb.Length == 0)
                            {
                                sb.Append("по минимальному элементу, ");
                            }

                            if (unsortedArray[i][j] < parameterForSorting)
                            {
                                parameterForSorting = unsortedArray[i][j];
                            }

                            break;
                    }
                }

                auxArray[i] = new Elem(i, parameterForSorting);
            }

            var arrs = new List<int[]>();

            switch (option)
            {
                case 1:
                    BubbleSortAscendingForOneDimensionalArray(auxArray);
                    foreach (var item in auxArray)
                    {
                        arrs.Add(unsortedArray[item.ElemIndex]);
                    }

                    sb.Append("с возрастанием");
                    break;
                case 2:
                    BubbleSortDescendingForOneDimensionalArray(auxArray);
                    foreach (var item in auxArray)
                    {
                        arrs.Add(unsortedArray[item.ElemIndex]);
                    }

                    sb.Append("с убыванием");
                    break;
            }

            Console.WriteLine("Отсортированный ступенчатый массив ({0}):", sb);
            PrintValues(arrs);
            return arrs;
        }

        /// <summary>Method to print elements of a list of integer numbers' arrays
        /// </summary>
        /// <param name="myList">A list of integer numbers' arrays</param>
        public static void PrintValues(List<int[]> myList)
        {
            foreach (int[] arr in myList)
            {
                foreach (int i in arr)
                {
                    Console.Write("\t{0}", i);
                }

                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------------------------------------------------");
        }

        /// <summary>Method to sort elements of an array in an ascending order by bubble sorting
        /// </summary>
        /// <param name="arr">An array of Elem objects</param>
        public static void BubbleSortAscendingForOneDimensionalArray(Elem[] arr)
        {
            for (int sortedPartStartingIndex = arr.Length - 1; sortedPartStartingIndex > 0; sortedPartStartingIndex--)
            {
                for (int i = 0; i < sortedPartStartingIndex; i++)
                {
                    if (arr[i].ElemParameter > arr[i + 1].ElemParameter)
                    {
                        SwapElements(arr, i, i + 1);
                    }
                }
            }
        }

        /// <summary>Method to sort elements of an array in an descending order by bubble sorting
        /// </summary>
        /// <param name="arr">An array of Elem objects</param>
        public static void BubbleSortDescendingForOneDimensionalArray(Elem[] arr)
        {
            for (int sortedPartStartingIndex = arr.Length - 1; sortedPartStartingIndex > 0; sortedPartStartingIndex--)
            {
                for (int i = 0; i < sortedPartStartingIndex; i++)
                {
                    if (arr[i].ElemParameter < arr[i + 1].ElemParameter)
                    {
                        SwapElements(arr, i, i + 1);
                    }
                }
            }
        }

        /// <summary>Method to swap elements of an Elem objects' for given indexes
        /// </summary>
        /// <param name="arr">Array of Elem objects</param>
        /// <param name="i">First index</param>
        /// <param name="j">Second index</param>
        private static void SwapElements(Elem[] arr, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            Elem temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>Method to print elements of a jagged array of integer numbers
        /// </summary>
        /// <param name="jaggedArray">A jagged array of integer numbers to be printed</param>
        private static void PrintValues(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("\t{0}", jaggedArray[i][j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------------------------------------------------");
        }
    }
}
