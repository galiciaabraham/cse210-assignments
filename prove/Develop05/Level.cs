using System;

public class Level
{
    private int _level;

    public Level()
    {
        _level = 0;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public int GetLevel()
    {
        return _level;
    }

    public void IncreaseLevel(int score)
    {
        if(score <= 1000)
        {
            _level = 1;
        } else if(score <= 5000){
            _level = 2;
        }else if(score <= 10000){
            _level = 3;
        }else if(score <= 15000){
            _level = 4;
        }else if(score <= 20000){
            _level = 5;
        }
    }

    public void DisplayLevel()
    {
        Console.Write($"Your current level is: {_level}");
        Console.WriteLine();
    }
}