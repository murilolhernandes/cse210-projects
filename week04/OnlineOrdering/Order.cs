public class Order
{
  private List<Product> _products = new List<Product>();
  private Custumer _costumer;

  public Order(Custumer costumer)
  {

    _costumer = costumer;
  }
  public void GetProduct(Product product)
  {
    _products.Add(product);
  }
  public double TotalCost()
  {
    double totalCost = 0;
    foreach (Product product in _products)
    {
      totalCost += product.ProductCost();
    }
    if (_costumer.IsInUSA())
    {
      totalCost += 5;
    }
    else
    {
      totalCost += 35;
    }
    return totalCost;
  }
  public string DisplayPackingLabel()
  {
    string packingLabel = "";
    foreach (Product product in _products)
    {
      packingLabel += $"{product.DisplayProductInfo()}\n";
    }
    return packingLabel;
  }
  public string DisplayShippingLabel()
  {
    return _costumer.DisplayCostumerInfo();
  }
  public void DisplayOrderInfo()
  {
    Console.WriteLine(DisplayPackingLabel());
    Console.WriteLine(DisplayShippingLabel());
    Console.WriteLine($"Total Cost: ${Math.Round(TotalCost(), 2)}");
  }
}