using System;

public class Activity
{
    private string _date;
    private int _length;
    private float _distance;
    private float _speed;

    public Activity(string date, int length, string activity)
    {
        _date = date;
        _length = length;

    }


    public virtual void DisplaySummary()
    {        
    }

    public virtual float CalculateSpeed()
    {
        return _speed;
    }

    public virtual float CalculatePace()
    {
        return 0.0f;
    }

    public virtual float CalculateDistance()
    {
        return _distance;
    }

    
}