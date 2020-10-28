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
            var task0701 = new Task0701();
            int number1, number2, firstBit, lastBit;
            number1 = ProcessInput("Please enter first number:");
            number2 = ProcessInput("Please enter second number:");
            firstBit = ProcessInput("Please enter first bit:");
            lastBit = ProcessInput("Please enter last bit:");
            
            Console.WriteLine($"Result: {task0701.InsertNumber(number1, number2, firstBit, lastBit)}");
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
