using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private int _zipCode;

    public Address(string street,string city, string state, string country,int zip){

    _street = street;
    _city = city;
    _state = state;
    _country = country;
    _zipCode = zip;
}

    public string BuildAddress()
    {
        return $"{_street},{_city},{_state},{_country} - {_zipCode}";
    }

    public bool CheckCountry()
    {
        if(_country == "US" || _country == "United States")
        {
            return true;
        } else{
            return false;
        }

    }

}


