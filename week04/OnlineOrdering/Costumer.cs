public class Custumer
{
  private string _name;
  private Address _address;

  public Custumer(string name, string streetName, string city, string state, int zipCode, string country)
  {
    _name = name;
    _address = new Address(streetName, city, state, zipCode, country);
  }
  public bool IsInUSA()
  {
    return _address.IsInUSA();  
  }
  public string DisplayCostumerInfo()
  {
    return $"Name: {_name}\nAddress: {_address.AddressString()}";
  }
}