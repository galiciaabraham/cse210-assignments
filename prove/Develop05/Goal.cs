using System;
public abstract class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private string _score;
    private string _completed = "[]";

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
        _goalName = goalName;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public void SetGoalPoints(string goalPoints)
    {
        _goalPoints = Int32.Parse(goalPoints);
    }
        public int GetGoalPoints()
    {
        return _goalPoints;
    }
    public void SetCompleted(string completed)
    {
        _completed = completed;
    }
    public string GetCompleted()
    {
        return _completed;
    }
    public void SetScore(string score)
    {
        _score = score;
    }
    public string GetScore()
    {
        return _score;
    }
    public virtual void RecordEvent(){
    }
    public abstract string CalculateScore(int score);

    public virtual string CheckCompletion(){
        return $"{_completed} {_goalName} - {_goalDescription} - {_goalPoints}";
    }
}