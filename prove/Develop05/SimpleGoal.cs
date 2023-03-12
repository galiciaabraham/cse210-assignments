using System;

public class SimpleGoal : Goal
{
    private string _serializedGoal;
    private List<string> _deserializedGoal = new List<string>{};
    private int _goalPoints;
    private string _toEditGoal;
    private string _completed = "[]";

    public SimpleGoal(){

    }
/*
    public SimpleGoal(string name, string description, string points){
        base.SetGoalName(name);
        base.SetGoalDescription(description);
        base.SetGoalPoints(points);
    }


    public override List<string> DeserializeGoal()
    {
        _deserializedGoal.Clear();
        _deserializedGoal.Add(base.GetCompleted());
        _deserializedGoal.Add(base.GetGoalType());
        _deserializedGoal.Add(base.GetGoalName());
        _deserializedGoal.Add(base.GetGoalDescription());
        _deserializedGoal.Add(base.GetGoalPoints().ToString());        
        return _deserializedGoal;
    }


    public override string SerializeGoal()
    {
        _serializedGoal = string.Join(",",_deserializedGoal);
        return _serializedGoal;
    }
 */   
    public override void RecordEvent()
    {
        Console.Write("Which goal would you like to edit?: ");
        _toEditGoal = Console.ReadLine();
    }
    public override string CalculateScore(int score)
    {
        int scoreResult = _goalPoints += score;
        base.SetScore(scoreResult.ToString()) ;
        return base.GetScore();
    }

    public void SetSelectedGoalToEdit(string selected)
    {
        _toEditGoal = selected;
    }
    public override void MarkCompletion()
    {
        _completed = "[x]";
    }
}