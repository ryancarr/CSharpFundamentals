using System;

namespace Exercise5._2
{
    // Task: Write a program which takes two numbers from the console and displays the maximum of the two.
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.Write("Please enter a number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter another number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (secondNumber > firstNumber)
                Console.WriteLine("{0} is greater than {1}", secondNumber, firstNumber);
            else
                Console.WriteLine("{0} is greater than {1}", firstNumber, secondNumber);
        }
    }
}
