// As an additional function to my project, I added an option for the user to see all the items they listed in the listing activity.
// If the list is empty the program will display a message to the user and encourage them to start the listing activity.
// To accomplish this I added a new method to the ListingActivity class called DisplayListedItems.
// In order to access the items listed, I created a member variable called listing (see line 13 on this file) that will initialize a new
// ListingActivity object but its value is set to null, then once the user selects the option to start the Listing Activity the program will
// set the value of the listing variable to a new ListingActivity object and then when the user chooses to see the listed items the program will
// call the DisplayListedItems method through the variable listing.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        ListingActivity listing = null;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. See listed items\n  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (input == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (input == "3")
            {
                if (listing == null)
                {
                    listing = new ListingActivity();
                }
                listing.Run();
            }
            else if (input == "4")
            {
                if (listing != null)
                {
                    listing.DisplayListedItems();
                }
                else
                {
                    Console.WriteLine("No items have been listed yet. Please start the listing activity first.");
                    Console.WriteLine("Press enter to return to the menu.");
                    Console.ReadLine();
                }
            }
            else if (input == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please select a valid option.");
            }

        }
    }
}
