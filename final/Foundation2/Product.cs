using System;

public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productId, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string ProductName { get { return _productName; } }
    public string ProductId { get { return _productId; } }
    public decimal Price { get { return _price; } }
    public int Quantity { get { return _quantity; } }

    public decimal TotalCost()
    {
        return _price * _quantity;
    }
}
