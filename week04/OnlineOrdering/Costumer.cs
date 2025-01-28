public class Costumer
{
  private string _name;
  private Address _address;

  public Costumer(string name, string streetName, string city, string state, int zipCode, string country)
  {
    _name = name;
    _address = new Address(streetName, city, state, zipCode, country);
  }
  public bool IsInUSA()
  {
    return _address.IsInUSA();  
  }
  public void DisplayCostumerInfo()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine($"Address: {_address.AddressString()}");
  }
}