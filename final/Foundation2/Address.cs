using System;

public class Address
{
    private string _street;
    private string _country;

    public Address(string street, string country){
    _street = street;
    _country = country;
}

    public string ReturnAddress()
    {
        return $"{ _street}, {_country}";
    }

}


