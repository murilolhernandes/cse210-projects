public abstract class Activity
{
  protected string _name;
  protected string _date;
  protected int _time;

  public Activity(string name, string date, int time)
  {
    _name = name;
    _date = date;
    _time = time;
  }

  protected abstract double Distance();

  protected abstract double Speed();

  protected abstract double Pace();

  public virtual string GetSummary()
  {
    return $"{_date} {_name} ({_time} min)";
  }
}