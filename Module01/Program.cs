//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------
namespace Module01
{
    using System;
    
    /// <summary>
    /// The main class in the project
    /// </summary>
    public class Program
    {
        /// <summary>Main is an entry point for class Program
        /// </summary>
        /// <param name="args">Used to pass text to be printed</param>
        public static void Main(string[] args)
        {
            // run of task01
            /*
            var task0701 = new Task0701();
            int number1, number2, firstBit, lastBit;
            number1 = ProcessInput("Please enter first number:");
            number2 = ProcessInput("Please enter second number:");
            firstBit = ProcessInput("Please enter first bit:");
            lastBit = ProcessInput("Please enter last bit:");
            
            Console.WriteLine($"Result: {task0701.InsertNumber(number1, number2, firstBit, lastBit)}");
            */

            // run of task02
            /*
            int[] arr = new int[] { 2, 3, -5, 0, 17, 2, 7, 9 };
            var task0702 = new Task0702(arr);
            Console.WriteLine($"Максимальный элемент: {task0702.MaxElement}");
            */

            // run of task03
            /*
            double[] arr = new double[] { 1.0, 2.0, 3.0, 4.0, 3.0, 1.0, 2.0 };
            var task0703 = new Task0703(arr);
            Console.WriteLine(task0703.GetFirstMedian());
            */

            // run of task04
            /*
            string output = Task0704.ConcatenateStringExcludingRepeats("abcdef", "defghklmn");
            Console.WriteLine(output);
            */

            // run of task05
            int result = Task0705.FindNextBiggerNumber(3456432);
            Console.WriteLine(result);

            // run of task06
            /*
            int[] array = Task0706.FilterDigit(7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17);
            Console.WriteLine(string.Join(", ", array));
            */
        }

        /// <summary>ProcessInput is the method for parsing user input into an integer number
        /// </summary>
        /// <param name="requestForNumber">User input as a string</param>
        /// <returns>The result of string parsing</returns>
        private static int ProcessInput(string requestForNumber)
        {
            string strNumber;
            int number;
            do
            {
                Console.Write(requestForNumber);
                strNumber = Console.ReadLine();
            }
            while (!int.TryParse(strNumber, out number));
            return number;
        }
    }
}
