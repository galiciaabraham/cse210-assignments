using System;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, string date, string time, Address address, string type)
    {   
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;

    }

    public void DisplayStandard()
    {

    }

    public void DisplayShort()
    {
        
    }
}
