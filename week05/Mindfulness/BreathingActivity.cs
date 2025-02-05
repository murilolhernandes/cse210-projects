public class BreathingActivity : Activity
{
  public BreathingActivity()
  {
    _name = "Breathing";
    _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  private void DisplayBreathingInstructions()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    int cycle = 1;

    while (DateTime.Now < endTime)
    {
      Console.WriteLine();
      Console.Write("Breath in...");
      ShowCountDown(2 + cycle - 1);
      Console.Write("Now breath out...");
      ShowCountDown(3 + cycle - 1);
      
      cycle++;
    }
  }

  public void Run()
  {
    DisplayStartingMessage();
    DisplayBreathingInstructions();
    DisplayEndingMessage();
  }
}