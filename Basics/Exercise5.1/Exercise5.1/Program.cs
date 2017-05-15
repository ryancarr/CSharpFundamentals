using System;

namespace Exercise5._1
{
    // Task: Write a program and ask the user to enter a number. The number should be between 1 and 10. If the number is in this range it is valid.
    //       If the number is outside this range it is invalid. Return the result to the user.
    class Program
    {
        static string ValidateNumber(int input, int min, int max)
        {
            string result;
            if (input <= max && input >= min)
                result = "Valid";
            else
                result = "Invalid";

            return result;
        }

        static void Main(string[] args)
        {
            const int min = 1;
            const int max = 10;
            int input;

            Console.Write("Please enter a number between {0} and {1}: ", min, max);
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ValidateNumber(input, min, max));
        }
    }
}
