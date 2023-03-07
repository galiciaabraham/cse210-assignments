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
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalType = goalDescription;
    }
    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
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

    public abstract string DeserializeGoal();
    public abstract List<Goal> SerializeGoal();
    public abstract void RecordEvent();
    public abstract int CalculateScore();
    public abstract Boolean CheckCompletion();
    public abstract void MarkCompletion();







}