using System;
using System.Collections.Generic;

namespace enumerated_types
{
    // enumerated types
    enum Menu
    {
        Start, // name = Start | value = 0
        Rules, // name = Rules | value = 1
        Quit   // name = Quit  | value = 2
    }

    class Program
    {
        static void Main(string[] args)
        {
            // list
            List<string> menu = new List<string> { "Start", "Rules", "Quit" };

            Menu selectedMenu;
            selectedMenu = Menu.Start;

            Console.WriteLine(selectedMenu);

            selectedMenu = Menu.Rules;
            Console.WriteLine(selectedMenu);

            Menu disableMenu;
            disableMenu = Menu.Quit;

            Console.WriteLine(disableMenu);

            // get value by casting enum name to int
            int menuID = (int)Menu.Rules;
            Console.WriteLine("Menu ID for rules is: " + menuID);

            // get name from value 
            Menu menuItem = (Menu)2;
            Console.WriteLine("Name of menu value 2: " + menuItem);

            // loop through enums
            foreach (string mItem in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("Menu item - " + mItem);
            }

            foreach (int mItem in Enum.GetValues(typeof(Menu)))
            {
                Menu name = (Menu)mItem;
                Console.WriteLine("Menu item" + name "has value" + mItem);
            }
        }
    }
}
