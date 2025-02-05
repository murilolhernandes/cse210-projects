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
