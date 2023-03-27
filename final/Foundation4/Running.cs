using System;

public class Running : Activity
{
    private float _pace;

    public Running(string date, int length, string activity) : base(date,length,activity)
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