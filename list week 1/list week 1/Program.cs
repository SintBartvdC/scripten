using System;
using System.Collections.Generic;

namespace list_week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 1

            // Make a list of 5 items
            var FiveItems = new List<string>() { "tabble", "chair", "laptop", "motor", "car" };

            // make a list of 3 items
            var ThreeItems = new List<string>() { "bottle", "food", "headphones" };

            // add the items of list one to list two
            ThreeItems.AddRange(FiveItems);

            // Print the list content to the console
            ThreeItems.ForEach(Console.WriteLine);

            // part 2

            // Ask the user to enter an item
            Console.WriteLine("Please enter an item");
            string AddInput = Console.ReadLine();
            ThreeItems.Add(AddInput);

            // Check if the item is in the list

            Console.WriteLine("Does the list contain your input? : " + ThreeItems.Contains(AddInput));

            // Let the user know if the selected item is in the list
            Console.WriteLine("please select an item");
            string SelectInput = Console.ReadLine();
            Console.WriteLine("Does the list have your selected item? : " + ThreeItems.Contains(SelectInput));

            // part 3

            // Remove a random item from the list
            Random rnd = new Random();
            int randomInt = rnd.Next(0, ThreeItems.Count);
            ThreeItems.Remove(ThreeItems[randomInt]);

            // Sort the list and print the list to the console
            ThreeItems.Sort();
            ThreeItems.ForEach(Console.WriteLine);
            Console.WriteLine();

            // part 4

            //Remove all items after position 4 of you list
            ThreeItems.RemoveRange();
            
        }
    }
}
