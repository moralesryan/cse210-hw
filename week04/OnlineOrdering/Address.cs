using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Address
{
    public string _streetAddress;
    public string _city;
    public string _province;
    public string _country;

    public Address(string streetAddress, string city, string province, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool InUsa()
    {
        return _country.Trim().ToLower() == "United States";
    }

    public string Display()
    {
        return $"{_streetAddress}, {_city}, {_province}, {_country}";
    }
}