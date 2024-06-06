using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string PackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in _products)
        {
            label.AppendLine($"{product.ProductName} (ID: {product.ProductId})");
        }
        return label.ToString();
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address.ToString()}";
    }
}
