using System;

namespace Exercise_5._3
{
    // Task: Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            string orientation;

            Console.Write("Please enter the width of the picture: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the height of the picture: ");
            height = Convert.ToInt32(Console.ReadLine());

            if (height > width)
                orientation = "The picture is in portrait orientation.";
            else
                orientation = "The picture is in landscape orientation.";

            Console.WriteLine(orientation);
        }
    }
}
