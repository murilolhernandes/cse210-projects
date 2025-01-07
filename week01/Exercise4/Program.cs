using System.Collections.Generic;
// using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        // List<int> numbers;
        // List<string> words;
        // numbers = new List<int>();
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }
        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string input = "";
        int listAppend;
        while (input != "0")
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            listAppend = int.Parse(input);
            if (input != "0")
            {
                numbers.Add(listAppend);
            }
        }
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }
    }
}