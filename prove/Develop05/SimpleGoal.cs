using System;

public class SimpleGoal : Goal
{
    private string _serializedGoal;
    private List<string> _deserializedGoal = new List<string>{};
    private int _goalPoints;
    private string toEditGoal;


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
    public override void RecordEvent()
    {
        Console.Write("Which goal would you like to edit?: ");
        toEditGoal = Console.ReadLine();
    }
    public override int CalculateScore()
    {
        
        return _goalPoints;
    }
    
}