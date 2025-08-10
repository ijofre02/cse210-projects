using System;
public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    //The constructor
    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productID = productId;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public string GetProductName()
    {
        return _productName;
    }


}