using System;
using System.Collections.Generic;

namespace Exercise6._1
{
    // Tasks: Create a program that continuously asks the user for names until they are done entering. Output format = [Friend 1], [Friend 2], and 10 others.
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            string input;
            string output = "";
            int count = 0;

            do
            {
                Console.Write("Please enter a name, type ok if you are done: ");
                input = Console.ReadLine();

                if (input.ToLower() != "ok")
                    names.Add(input);

            } while (input.ToLower() != "ok");

            count = names.Count;

            switch(count)
            {
                case 0:
                    break;
                case 1:
                    output = String.Format("{0} liked your status.", names[0]);
                    break;
                case 2:
                    output = String.Format("{0} and {1} liked your status.", names[0], names[1]);
                    break;
                default:
                    output = String.Format("{0}, {1} and {2} others liked your status.", names[0], names[1], count - 2);
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
