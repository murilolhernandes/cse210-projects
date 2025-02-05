using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit");
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
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (input == "4")
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
