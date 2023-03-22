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
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_description);
        Console.WriteLine(_date);
        Console.WriteLine(_address.BuildAddress());
    }

    public void DisplayShort()
    {
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_date);
    }
}
