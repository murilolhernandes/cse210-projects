public class Entry
{
  public string _date;
  public string _promptText;
  public string _entryText;

  public void Display()
  {
    _promptText = PromptGenerator.GetRandomPrompt();
    Console.WriteLine(_promptText);

    _entryText = Console.ReadLine();

    _date = DateTime.Now.ToString("MM/dd/yyyy");

    Entry anEntry = new Entry();
    anEntry._entryText = $"Date: {_date} - Prompt: {_promptText}\n{_entryText}";

    Journal.AddEntry(anEntry);
  }
}