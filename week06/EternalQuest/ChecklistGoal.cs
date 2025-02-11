public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
  {
    _target = target;
    _bonus = bonus;
  }
  public override void RecordEvent()
  {
    _amountCompleted++;
    if (IsComplete())
    {
      _points += _bonus;
    }
  }

  public override bool IsComplete()
  {
    if (_amountCompleted >= _target)
    {
      return true;
    }
    return false;
  }

  public override string GetStringRepresentation()
  {
    return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
  }

  public override string GetDetailsString()
  {
    if (IsComplete())
    {
      return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    else
    {
      return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
  }

  public int SetAmountCompleted(int amountCompleted)
  {
    return _amountCompleted = amountCompleted;
  }
}