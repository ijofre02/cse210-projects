using System;
public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //Create the constructor to set some values:
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    public bool InUSA()
    {
        return _country.ToLower() == "usa";
    }
    public string GetAdress()
    {
        return $"{_street}\n{_city}\n{_stateOrProvince}\n{_country} ";
    }
}