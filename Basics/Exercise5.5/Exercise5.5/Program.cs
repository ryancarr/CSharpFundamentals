using System;

namespace Exercise5._5
{
    // Task: Write a program to count how many numbers between 1 and 100 are evenly divisible by 3. Display the count on the console
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count += 1;
            }

            Console.WriteLine("There are {0} numbers evenly divided by 3 between 1 and 100.", count);
        }
    }
}
