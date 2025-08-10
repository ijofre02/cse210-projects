using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _product;
    private Customer _customer;

    public Order(Customer customer)
    {
        _product = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _product)
        {
            total += product.GetTotalCost();
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

    public string GetPackingLabel()
    {
        string label = "packing Label:\n";
        foreach (Product product in _product)
        {
            label += $"{product.GetProductName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressObject().GetAddress()}";
    }
}