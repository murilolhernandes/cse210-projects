public class Activity
{
  protected string _name;
  protected string _description;
  protected int _duration;

  public Activity()
  {

  }

  protected void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name} Activity.\n");
    Console.WriteLine($"{_description}\n");
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Get Ready...");
    ShowSpinner(5);

  }

  protected void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine("Well done!");
    ShowSpinner(5);
    Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
    ShowSpinner(5);
    Thread.Sleep(1000);
  }

  protected void ShowSpinner(int seconds)
  {
    List<string> animationStrings = new List<string> { "\\", "|", "/", "-" };

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
      string animation = animationStrings[i];
      Console.CursorVisible = false;
      Console.Write(animation);
      Thread.Sleep(500);
      Console.Write("\b \b");
      i++;
      if (i >= animationStrings.Count)
      {
        i = 0;
      }
    }
    Console.CursorVisible = true;
  }

  protected void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.CursorVisible = false;
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
    Console.WriteLine();
    Console.CursorVisible = true;
  }

  protected string GetRandom(List<string> list)
  {
    Random random = new Random();
    int index = random.Next(list.Count);
    return list[index];
  }
}