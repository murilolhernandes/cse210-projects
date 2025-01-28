public class Product
{
  private string _productName;
  private int _productId;
  private double _productPrice;
  private int _productQuantity;

  public Product(string productName, int productId, double productPrice, int productQuantity)
  {
    _productName = productName;
    _productId = productId;
    _productPrice = productPrice;
    _productQuantity = productQuantity;
  }
  public double ProductCost()
  {
    return _productPrice * _productQuantity;
  }
  public string DisplayProductInfo()
  {
    string productInfo = $"Name: {_productName}, ID: {_productId}, Price: ${Math.Round(_productPrice, 2)}, Quantity: {_productQuantity}\nCost: ${Math.Round(ProductCost(), 2)}";
    return productInfo;
  }
}