using System;

namespace Exercise5._4
{
    // Task: Ask user for the speed limit. Then the speed of the car. If the car isn't speeding display 'OK'.
    //       If the car is speeding calculate the number of demerit points. for every 5km/h over the speedlimit 1 demerit point is acquired.
    //       If the driver earns more than 12 demerit points output 'License Suspended' to console.
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int carSpeed;
            int difference;
            int points;

            Console.Write("What is the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What speed is the car going: ");
            carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                difference = carSpeed - speedLimit;

                points = difference / 5;

                if (points > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("The driver has earned {0} demerit points", points);
            }
            else
                Console.WriteLine("The car isn't speeding...");            
        }
    }
}