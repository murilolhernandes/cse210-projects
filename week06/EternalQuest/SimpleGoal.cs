public class SimpleGoal : Goal
{
  private bool _isComplete;

  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {

  }

  public override void RecordEvent()
  {
    _isComplete = true;
  }

  public override bool IsComplete()
  {
    if (_isComplete)
    {
      return true;
    }
    return false;
  }

  public override string GetStringRepresentation()
  {
    return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
  }
}