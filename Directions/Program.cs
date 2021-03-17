using System;

namespace Directions
{
    class Program
    {
        enum Directions
        {
            north = 1,
            east,
            south,
            west
        }

        static void Main(string[] args)
        {
            //snap niet wrm ik deze aan moet maken
            Directions playerDirection;
            //gebruik 'm toch niet

            Console.WriteLine("Please tell me which way you are headed: ");
            Console.WriteLine("[1] north");
            Console.WriteLine("[2] east");
            Console.WriteLine("[3] south");
            Console.WriteLine("[4] west\n");
            int DirectionsID = int.Parse(Console.ReadLine());

            playerDirection = (Directions)DirectionsID;

            if (DirectionsID == 1)
            {
                Console.WriteLine("\nLooks like you are headed to the north.");
            } else if(DirectionsID == 2)
            {
                Console.WriteLine("\nYou're headed to the east, aye?");
            } else if(DirectionsID == 3)
            {
                Console.WriteLine("\nTo the south? Seriously?");
            } else if(DirectionsID == 4)
            {
                Console.WriteLine("\nI never liked the west.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That answer is invalid!");
                Console.WriteLine("\nGoodbye!");
                Environment.Exit(0);
            }
            Console.WriteLine($"\nWell then, I'll go with you to the {playerDirection}.");
        }
    }
}
