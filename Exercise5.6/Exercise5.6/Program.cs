using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._6
{
    // Task: Write a program that continually asks a user for a number until they type "ok". Then display the sum of all of the numbers on the console.
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int sum = 0;
            do
            {
                Console.WriteLine("Please type a number, if you are done type ok: ");
                input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            while (input.ToLower() != "ok");

            Console.WriteLine("The sum of the numbers you typed in is {0}", sum);
        }
    }
}
