using System;

namespace Exercise5._9
{
    // Tasks: Write a program that asks a user to enter a string of numbers separated by commas. Then display the maximum number to the console.
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int max = -10*10000;

            Console.WriteLine("Please write a series of numbers separated by commas");
            input = Console.ReadLine();

            var convertedInput = input.Split(',');

            foreach (var number in convertedInput)
            {
                var temp = Convert.ToInt32(number);
                if (temp > max)
                    max = temp;
                else
                    continue;
            }

            Console.WriteLine("The max number is: {0}",max);
        }
    }
}
