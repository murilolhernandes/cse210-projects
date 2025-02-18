public class Cycling : Activity
{
  private double _distance;
  public Cycling(string name, string date, int time, double distance) : base(name, date, time)
  {
    _distance = distance;
  }

  protected override double Distance()
  {
    return _distance;
  }

  protected override double Speed()
  {
    return (Distance() / _time) * 60;
  }

  protected override double Pace()
  {
    return _time / Distance();
  }

  public override string GetSummary()
  {
    return $"{_date} {_name} ({_time} min) - Distance: {Distance():F1} miles, Speed: {60 / Pace():F1} mph, Pace: {60 / Speed():F1} min per mile";
  }
}