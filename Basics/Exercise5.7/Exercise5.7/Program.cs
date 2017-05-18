using System;

namespace Exercise5._7
{
    // Task: Write a program that asks a user for a number then computes the factorial for the number.
    //       Display output to console in format 5! = 120
    class Program
    {
        /// <summary>
        /// Factorial uses recursion to find the factorial of a given number.
        /// </summary>
        /// <param name="number">Integer to calculate the factorial of.</param>
        /// <returns>An integer representing the factorial of a given number.</returns>
        static int Factorial(int number)
        {
            int result;

            if (number == 0)
                result = 1;
            else
                result = Factorial(number - 1) * number;

            return result;
        }

        static void Main(string[] args)
        {
            string input;
            int factorial;

            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();

            factorial = Factorial(Convert.ToInt32(input));
            Console.WriteLine("{0}! = {1}", input, factorial);
        }
    }
}
