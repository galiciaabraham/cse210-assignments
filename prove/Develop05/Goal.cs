using System;

public abstract class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private string _serializedGoal;
    private List<Goal> _deserializedGoal;
    private string _score;
    private string toEditGoal;
    private Boolean _completed;

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public void SetGoalName(string goalName)
    {
        Console.Write("What is the name of your goal? ");
        _goalName = goalName;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalDescription(string goalDescription)
    {
        Console.Write("What is a short description of it? ");
        _goalType = goalDescription;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalPoints(string goalPoints)
    {
        Console.Write("What are the points associated with this goal? ");
        _goalPoints = Int32.Parse(goalPoints);
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }

    public void SetScore(string score)
    {
        _score = score;
    }

    public string GetScore()
    {
        return _score;
    }
    public void DisplayScore()
    {
        Console.WriteLine(_score);
    }

    public abstract List<string> DeserializeGoal();
    public abstract string SerializeGoal();
    public abstract void RecordEvent();
    public abstract int CalculateScore();
    public abstract Boolean CheckCompletion();
    public abstract void MarkCompletion();

}