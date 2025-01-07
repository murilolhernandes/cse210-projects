using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();
        // PromptUserName();
        // PromptUserNumb
        
    }
    static void DisplayMessage()
{
    Console.WriteLine("Welcome to the program!");
}
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int favoriteNumber = int.Parse(number);
        return favoriteNumber;
    }
    static int SquareNumber(favoriteNumber)
    {
        int favoriteNumber = PromptUserNumber() * PromptUserNumber();
        return favoriteNumber;
    }
    static string DisplayResult()
    {
        return $"{PromptUserName()}, the square of your number is {SquareNumber()}";
    }
}

