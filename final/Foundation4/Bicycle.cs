using System;

public class Bicycle : Activity
{
    private float _pace;

    public Bicycle(string date, int length, string activity) : base(date,length,activity)
    {
    }


    public override void DisplaySummary()
    {        
    }

    public override float CalculateSpeed()
    {
        return base._speed;
    }

    public override float CalculatePace()
    {
        return _pace;
    }

    public override float CalculateDistance()
    {
        return base._distance;
    }

    
}