using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string type, string weather) : base(title,description,date,time,address,type)
    {
        _weather = weather;
    }

    public void DisplayDetails()
    {
        base.DisplayStandard();
        Console.WriteLine($"Come ready for a {_weather} day!");
    }
}