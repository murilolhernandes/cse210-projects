using System;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // Console.Write("There will not be a newline after this.");
        // Console.Write("What is your favorite color? ");
        // string color = Console.ReadLine();
        // Console.WriteLine($"Your favorite color is {color}.");
        // if (x > y)
        // {
        //     Console.WriteLine("greater");
        // }
        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}");
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");
    }
}