using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._1
{
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
