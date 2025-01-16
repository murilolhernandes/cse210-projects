public class Entry
{
  public static string _date;
  // PromptGenerator promptGenerator = new PromptGenerator();
  public static string _promptText = PromptGenerator.GetRandomPrompt();
  public static string _entryText;
  // public static string anEntry = $"{_date} {_promptText}: {_entryText}";


  public void Display()
  {
    // _promptText = PromptGenerator.GetRandomPrompt();
    Console.WriteLine(_promptText);
    // _entryText = Console.ReadLine();
    // Console.WriteLine($"You entered: {_entryText}");
  }
}