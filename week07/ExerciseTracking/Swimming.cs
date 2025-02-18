public class Swimming : Activity
{
  private double _laps;
  public Swimming(string name, string date, int time, double laps) : base(name, date, time)
  {
    _laps = laps;
  }

  protected override double Distance()
  {
    return _laps * 50 / 1000 * 0.62;
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