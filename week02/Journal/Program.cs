using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        string exit = "no";
        while (exit != "yes")
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry newEntry = new Entry();
                newEntry.Display();
            }
            else if (choice == "2")
            {
                Journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                Journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                Journal.SaveToFile(fileName);
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
    }
}