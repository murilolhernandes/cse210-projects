using System.IO;

public class GoalManager : List<Goal>
{
  private List<Goal> _goals = new List<Goal>();
  private int _score;
  public GoalManager()
  {

  }

  public void Start()
  {
    while (true)
    {
      Console.Write("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
      string input = Console.ReadLine();
      if (input == "1")
      {
        CreateGoal();
        DisplayPlayerInfo();
      }
      else if (input == "2")
      {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
          Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
        }
        DisplayPlayerInfo();
      }
      else if (input == "3")
      {
        SaveGoals();
        DisplayPlayerInfo();
      }
      else if (input == "4")
      {
        LoadGoals();
        DisplayPlayerInfo();
      }
      else if (input == "5")
      {
        RecordEvent();
        DisplayPlayerInfo();
      }
      else if (input == "6")
      {
        break;
      }
      else
      {
        Console.WriteLine("Please select a valid option.");
      }
    }
  }

  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"\nYou have {_score} points.\n");
  }

  public void ListGoalNames()
  {
    Console.WriteLine("\nThe goals are:");
    foreach (Goal goal in _goals)
    {
      int index = _goals.IndexOf(goal);
      Console.WriteLine($"{index + 1}. {goal.GetShortName()}");
    }
  }

  public void ListGoalDetails()
  {
    foreach (Goal goal in _goals)
    {
      Console.WriteLine(goal.GetDescription());
    }
  }

  public void CreateGoal()
  {
    Console.Write("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of goal would you like to create? ");
    string type = Console.ReadLine();
    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();
    Console.Write("What is a short description of it? ");
    string description = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    int points = int.Parse(Console.ReadLine());
    if (type == "1")
    {
      SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
      _goals.Add(simpleGoal);
    }
    else if (type == "2")
    {
      EternalGoal eternalGoal = new EternalGoal(name, description, points);
      _goals.Add(eternalGoal);
    }
    else if (type == "3")
    {
      Console.Write("How many times does this goal need to be accomplished for a bonus? ");
      int target = int.Parse(Console.ReadLine());
      Console.Write("What is the bonus for accomplishing it that many times? ");
      int bonus = int.Parse(Console.ReadLine());
      ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
      _goals.Add(checklistGoal);
    }
    else
    {
      Console.WriteLine("Please select a valid option.");
    }
  }

  public void RecordEvent()
  {
    ListGoalNames();
    Console.Write("Which goal did you accomplish? ");
    int index = int.Parse(Console.ReadLine());
    if (index < 1 || index > _goals.Count)
    {
      Console.WriteLine("Please select a valid option.");
      return;
    }
    else
    {
      _goals[index - 1].RecordEvent();
      _score += _goals[index - 1].GetPoints();
      Console.WriteLine($"Congratulations! You have earned {_goals[index - 1].GetPoints()} points!");
      Console.WriteLine($"You now have {_score} points.");
    }
  }

  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Path.Combine("..", "..", "..", Console.ReadLine());
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      outputFile.WriteLine(_score);
      foreach (Goal goal in _goals)
      {
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Path.Combine("..", "..", "..", Console.ReadLine());

    try
    {
      using (StreamReader reader = new StreamReader(fileName))
      {
        _score = int.Parse(reader.ReadLine());

        string line;
        while ((line = reader.ReadLine()) != null)
        {
          string[] parts = line.Split(",");
          string goalType = parts[0].Split(":")[0].Trim();
          string name = parts[0].Split(":")[1].Trim();
          string description = parts[1].Trim();
          int points = int.Parse(parts[2].Trim());

          switch (goalType)
          {
            case "SimpleGoal":
              bool isComplete = bool.Parse(parts[3].Trim());
              SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
              if (isComplete)
              {
                simpleGoal.RecordEvent();
              }
              _goals.Add(simpleGoal);
              break;

            case "EternalGoal":
              EternalGoal eternalGoal = new EternalGoal(name, description, points);
              _goals.Add(eternalGoal);
              break;

            case "ChecklistGoal":
              int bonus = int.Parse(parts[3].Trim());
              int target = int.Parse(parts[4].Trim());
              int amountCompleted = int.Parse(parts[5].Trim());
              ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
              checklistGoal.SetAmountCompleted(amountCompleted);
              _goals.Add(checklistGoal);
              break;

            default:
              Console.WriteLine("Unknown goal type.");
              break;
          }
        }
      }
    }
    catch (FileNotFoundException)
    {
      Console.WriteLine("File is not found. Please try again.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occurred: {ex.Message}");
    }
  }
}