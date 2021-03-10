using System;
using System.Collections.Generic;
namespace Scripten5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region kutten/testen
            var names = new List<string>() { "Joep", "Poep" };

            Console.WriteLine("What is your name?");
            names.Add(Console.ReadLine());

            Console.WriteLine("This is the amount of names we have right now: " + names.Count + "\n");
            Console.WriteLine("Do you want to see the names? yes or no?\n");

            string answer;

            answer = Console.ReadLine();

            if(answer == "yes")
            {
                for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine("\n" + names[i]);
                    }
            } else if(answer == "no")
            {
                Console.WriteLine("\nok");
            }
            else
            {
                Console.WriteLine("\nBruh -_-");
            }
            #endregion

            Console.WriteLine("\n=======================================\n");

            #region opdracht
            #region part 1
            var vijf = new List<string>() { "een", "twee", "drie", "vier", "vijf" };
            var drie = new List<string>() { "zes", "zeven", "acht" };

            vijf.AddRange(drie);

            for (int i = 0; i < vijf.Count; i++)
            {
                Console.WriteLine(vijf[i]);
            }
            #endregion

            Console.WriteLine("\n=======================================\n");

            #region part 2
            var part2 = new List<string>() { "poep", "banaan", "appel" };

            Console.WriteLine("Here's a list of words: ");
            for (int i = 0; i < part2.Count; i++)
            {
                Console.WriteLine(part2[i]);
            }
            Console.WriteLine("\nPlease add a word to the list: ");

            string AddAnswer = Console.ReadLine();

            if(part2.Contains(AddAnswer) == false)
            {
                part2.Add(AddAnswer);
                Console.WriteLine($"\nYou added '{AddAnswer}' to the list.");
                Console.WriteLine("Here's the list: ");
                for (int i = 0; i < part2.Count; i++)
                {
                    Console.WriteLine(part2[i]);
                }
            }
            else if(part2.Contains(AddAnswer) == true)
            {
                Console.WriteLine("\nDamn that one already exists.");
                for (int i = 0; i < part2.Count; i++)
                {
                    Console.WriteLine(part2[i]);
                }
                Console.WriteLine("\nSee..");
            }
            #endregion

            Console.WriteLine("\n=======================================\n");

            #region part 3
            int Roll;

            Random rnd = new Random();

            Roll = rnd.Next(1, part2.Count);

            int RandomDel = Roll;

            for (int i = 0; i < part2.Count; i++)
            {
                Console.WriteLine(part2[i]);
            }

            Console.WriteLine("\nOk, yea, that's too long let's delete one");
            part2.RemoveAt(RandomDel);
            Console.WriteLine("Deleting...");
            Console.WriteLine("\nPRESS ENTER TO SEE THE LIST AGAIN");
            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i < part2.Count; i++)
                {
                    Console.WriteLine(part2[i]);
                }

            Console.WriteLine("\nPRESS ENTER TO SORT THE LIST");
            Console.ReadLine();
            part2.Sort();
            for (int i = 0; i < part2.Count; i++)
                {
                    Console.WriteLine(part2[i]);
                }
            #endregion

            Console.WriteLine("\n=======================================\n");

            #region part 4
            var part4 = new List<string>() { "banana", "apple", "lemon", "melon", "gg", "car", "FOERIJOES", "JHASGJDKAHSDJ"};

            for (int i = 0; i < part4.Count; i++)
            {
                Console.WriteLine(part4[i]);
            }

            Console.WriteLine("\nYea nah, that's too long let's delete everything but the first four.\n");
            for (int i = 0; i < part4.Count - 4; i++)
            {
                Console.WriteLine("Deleting...");
            }

            Console.WriteLine("");
            part4.RemoveRange(4, part4.Count-4);
            
            for (int i = 0; i < part4.Count; i++)
            {
                Console.WriteLine(part4[i]);
            }

            Console.WriteLine("\nThat looks alot better!");
            Console.WriteLine("Could you help me sort it a bit by typing 'sort in reverse'?");
            
            string SortAnswer = Console.ReadLine();

            if(SortAnswer == "sort in reverse")
            {
                part4.Reverse();
                Console.Clear();
            }
            else
            {
                while (SortAnswer != "sort in reverse")
                {
                    Console.WriteLine("\nYou're not helping.");
                    Console.WriteLine("Please try again: ");
                    SortAnswer = Console.ReadLine();
                }Console.Clear();
            }
            
            Console.WriteLine("Thank you!");
            Console.WriteLine("\nThis is the list now: ");
            for (int i = 0; i < part4.Count; i++)
            {
                Console.WriteLine(part4[i]);
            }
            Console.WriteLine("\nWay better!");
            Console.WriteLine("\nGoodbye!");
            #endregion
            #endregion
        }
    }
}
