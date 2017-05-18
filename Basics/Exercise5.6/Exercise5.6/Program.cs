using System;

namespace Exercise5._6
{
    // Task: Continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the numbers the user has entered and display it.
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input;

            while (true)
            {
                Console.WriteLine("Please enter a number or type 'Ok' to exit: ");
                input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    Console.WriteLine("The sum is: " + sum);
                    break;
                }

                sum += Convert.ToInt32(input);

            }
            
        }
    }
}
