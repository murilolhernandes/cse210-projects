using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        // Console.Write("Enter number: ");
        // string valueFromUser = Console.ReadLine();

        // int x = int.Parse(valueFromUser);
        // // int x = 5;
        // int y = 2;
        // int z = 5;

        // if (x > y && x > z)
        // {
        //     Console.WriteLine("greater");
        // }
        // else if (x < y || x < z)
        // {
        //     Console.WriteLine("less");
        // }
        // else
        // {
        //     Console.WriteLine("equal");
        // }
        Console.Write("Enter your grade percentage: ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        string letter = "";
        int lastDigit = percent % 10;
        string signal = "";

        if (lastDigit >= 7 && !(percent >= 90) && percent >= 60)
        {
            signal = "+";
        }
        else if (lastDigit < 3 && percent >= 60)
        {
            signal = "-";
        }

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter + signal}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed :(");
        }
    }
}