using System;

namespace Exercise5._8
{
    // Task: Number guessing game between 1 and 10, 4 tries to win.
    class Program
    {
        static int GetRandomNumber(int max)
        {
            var random = new Random();

            return random.Next(max);
        }

        static void Main(string[] args)
        {
            const int max = 10;
            const int maxAttempts = 4;
            var hiddenNumber = GetRandomNumber(max);
            var numberOfTries = 0;
            int guess;
            var guessed = false;

            while(numberOfTries <= maxAttempts)
            {
                Console.WriteLine("Please guess a number between 1 and {0}: ", max);
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == hiddenNumber)
                {
                    Console.WriteLine("Good job! The number was {0}", hiddenNumber);
                    guessed = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect! {0} guesses remaining.", maxAttempts - numberOfTries);
                    numberOfTries++;
                }
            }

            if (numberOfTries > maxAttempts && !guessed)
                Console.WriteLine("I'm sorry, you've run out of guesses. The number was: {0}", hiddenNumber);
        }
    }
}
