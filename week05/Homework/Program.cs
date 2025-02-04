using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");
        // Assignment assignment1 = new Assignment("Murilo Hernandes", "C#");
        // Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("Murilo Hernandes", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Murilo Hernandes", "European History", "The Causes of World War II");
        Console.WriteLine(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}