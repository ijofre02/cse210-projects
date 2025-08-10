using System;
public class Customer
{
    private string _customerName;
    private Address _address;

    //Lets do a constructor
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetCostumerInfo()
    {
        return $"{_customerName}\n{_address.GetAdress()}";
    }

    //This class need to know if client is in USA or not
    public bool IsInUSA()
    {
        return _address.InUSA();
    }

    public string GetName()
    {
        return _customerName;
    }

    public Address GetAdress()
    {
        return _address;
    }
}