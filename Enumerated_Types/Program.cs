using System;
using System.Collections.Generic;

namespace Enumerated_Types
{
    class Program
    {
        enum Menu
        {
            Start, // name = Start | Value = 0
            Rules, // name = Rules | Value = 1
            Quit   // name = Quit  | Value = 2
        }

        static void Main(string[] args)
        {
            List<string> menu = new List<string> { "start", "rules", "quit" };

            Menu selectedMenu;
            selectedMenu = Menu.Start;
            Console.WriteLine(selectedMenu);

            selectedMenu = Menu.Rules;
            Console.WriteLine(selectedMenu);
            
            Menu disabledMenu;
            disabledMenu = Menu.Quit;

            Console.WriteLine(disabledMenu);


            // get value by casting enum name to int
            int MenuID = (int)Menu.Rules;
            Console.WriteLine($"Menu ID for rules is: {MenuID}.");

            // get name from value
            Menu MenuItem = (Menu)2;
            Console.WriteLine($"Name that corosponds to Menu value 2 is: {MenuItem}.");

            // loop through enums
            foreach (string mItem in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("Menu item - " + mItem);
            }

            foreach (int mItem in Enum.GetValues(typeof(Menu)))
            {
                Menu name = (Menu)mItem;
                Console.WriteLine("Menu item " + name + " has value - " + mItem);
            }

        }
    }
}
