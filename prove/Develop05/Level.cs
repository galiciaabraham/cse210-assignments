using System;

public class Level
{
    private string _level;

    public Level()
    {
        _level = "0";
    }

    public void SetLevel(string level)
    {
        _level = level;
    }

    public string GetLevel()
    {
        return _level;
    }

    public void DisplayLevel()
    {
        Console.Write($"Your current level is: {_level}");
    }
}