// As an additional feature to my project, I added an extra step to items 2 and 5 of the menu. After the user creates a new goal or
// records an event, they are asked if they want to create another goal or record another event. The option will continue to loop until
// the user chooses 'N' for either option.  

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager start = new GoalManager();
        start.Start();
    }
}