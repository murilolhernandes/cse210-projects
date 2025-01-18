using System;
using System.Formats.Asn1;

// As an additional function to my project, I added an extra list to store the entries, so the program will add new entries only to our journal file. 
// By adding this, the program will not overwrite the old entries, nor will it duplicate the entries if the user chooses 
// to write more entries after saving them to the journal file. You can find it in the Journal class as a local variable (_savedEntries),
// and then as a member variable of the SaveToFile method (unique Entries). Finally, we clear the _entries list after loading them from the file which is
// done in the LoadFromFile method.
// Small additions were made to prevent the user from trying to load an empty file or a file that does not exist, or by typing the wrong option in the menu.

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