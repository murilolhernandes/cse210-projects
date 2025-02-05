public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts = new List<string>();
  private List<string> _userResponses = new List<string>();
  
  public ListingActivity()
  {
    _name = "Listing";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
  }

  public void Run()
  {
    DisplayStartingMessage();
    _userResponses = GetListFromUser();
    DisplayEndingMessage();
  }

  private string GetRandomPrompt()
  {
    _prompts.Add("Who are people that you appreciate?");
    _prompts.Add("What are personal strengths of yours?");
    _prompts.Add("Who are people that you have helped this week?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("Who are some of your personal heroes?");
    return GetRandom(_prompts);
  }

  private List<string> GetListFromUser()
  {
    List<string> input = new List<string>();
    Console.WriteLine("\nList as many responses you can to the following prompt:");
    Console.WriteLine($"--- {GetRandomPrompt()} ---");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("> ");
      string response = Console.ReadLine();
      input.Add(response);
      _count++;
    }
    Console.WriteLine($"You listed {_count} items!");
    return input;
  }

  public void DisplayListedItems()
  {
    Console.WriteLine("Here are the items you listed: ");
    if (_userResponses.Count == 0)
    {
      Console.WriteLine("No items listed yet.");
    }
    else 
    {
      foreach (string input in _userResponses)
      {
        Console.WriteLine($"- {input}");
      }
    }
    Console.WriteLine("Press enter to return to the menu.");
    Console.ReadLine();
  }
}