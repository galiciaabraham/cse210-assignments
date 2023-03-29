using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, string activity, int laps) : base(date,length,activity)
    {
        _laps = laps;
    }


    public override void DisplaySummary()
    {      
        Console.WriteLine($"{_date} {_activity} ({_length}) - Distance {_distance}, Speed {_speed} km/h, Laps: {_laps} min per kilometer");  
    }

    public override float CalculateSpeed()
    {
        _speed = (_distance / _length) * 60;
        return Convert.ToSingle(Math.Round(_speed,2));
    }
    public override float CalculateDistance()
    {
        _distance = (_laps * 50) / 1000;
        return Convert.ToSingle(Math.Round(_distance,2));
    }
    
}