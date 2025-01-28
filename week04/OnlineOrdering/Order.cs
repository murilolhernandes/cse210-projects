public class Order
{
  private List<Product> _products = new List<Product>();
  private Product _product;
  private Costumer _costumer;

  public Order(Costumer costumer, Product product)
  {
    _product = product;
    _products.Add(_product);
    _costumer = costumer;
  }
  public double TotalCost()
  {
    double cost = _product.ProductCost();
    double totalCost;
    if (_costumer.IsInUSA())
    {
      totalCost = cost + 5;
    }
    else
    {
      totalCost = cost + 35;
    }
    return totalCost;
  }
  public void DisplayPackingLabel()
  {
    _product.DisplayProductInfo();
  }
  public void DisplayShippingLabel()
  {
    _costumer.DisplayCostumerInfo();
  }
  public void DisplayOrderInfo()
  {
    _costumer.DisplayCostumerInfo();
    _product.DisplayProductInfo();
    Console.WriteLine($"Total Cost: ${Math.Round(TotalCost(), 2)}");
  }
}