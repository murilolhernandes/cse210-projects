using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Journal Project.");
        Journal theJournal = new Journal();
        string exit = "no";
        while (exit != "yes")
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();
                newEntry.Display();
                string userInput = Console.ReadLine();
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

            }
            else if (choice == "5")
            {
                exit = "yes";
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }
        }

        // PromptGenerator promptGenerator = new PromptGenerator();
        // Console.WriteLine(promptGenerator.GetRandomPrompt());
        // Console.WriteLine(promptGenerator.GetRandomPrompt());
        // Console.WriteLine(promptGenerator.GetRandomPrompt());
    }
}