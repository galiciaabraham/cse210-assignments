using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, string activity) : base(date,length,activity)
    {

    }


    public override void DisplaySummary()
    {      
          
    }

    public override float CalculateSpeed()
    {
        return base._speed;
    }
    public override float CalculateDistance()
    {
        return base._distance;
    }
    
}