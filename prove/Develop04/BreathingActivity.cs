using System;

public class BreathingActivity : Activity{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity(string welcome,string ending,string instructions) : base (welcome, ending, instructions)
    {
        _breathIn = "BreathIn...";
        _breathOut = "BreathOut...";
    }

    public void BreathMessage(){
        Console.WriteLine();
        Console.WriteLine(_breathIn);
        base.CountDown();
        Console.WriteLine(_breathOut);
        base.CountDown();  
    }
}