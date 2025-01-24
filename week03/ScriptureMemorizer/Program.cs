// As an additional function to my project, I added an extra step to method HideRandomWords under the Scripture class. This step is to make sure that the words 
// are won't be replaced twice as the user presses enter. It also guarantees that every time the user presses enter, 3 new words will be hidden,
// so there won't be a single time where the user will press enter and only one, two or no word will be hidden, but 3 words that weren't hidden before
// will be hidden until all the words are hidden, then the program will be terminated.

using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.Clear();
        Reference reference = new Reference("D&C", 9, 8, 9);
        Word word = new Word("But, behold, I say unto you, that you must study it out in your mind; then you must ask me if it be right, and if it is right I will cause that your bosom shall burn within you; therefore, you shall feel that it is right. But if it be not right you shall have no such feelings, but you shall have a stupor of thought that shall cause you to forget the thing which is wrong; therefore, you cannot write that which is sacred save it be given you from me.");
        Scripture scripture = new Scripture(reference, word.GetDisplayText());
        while (!scripture.IsCompletelyHidden() || false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input == "")
            {
                scripture.HideRandomWords(3);
                continue;

            }
            else if (input == "quit")
            {
                break;
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        Console.WriteLine();
    }
}