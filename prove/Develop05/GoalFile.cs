using System;

public class GoalFile
{
    private string _fileName;
    private List<string> _deserializedGoals;
    private List<string> _serializedGoals;

    private string _formatedGoal;

    public GoalFile (List<string>deserialized, List<string>serialized)
    {
        _deserializedGoals = deserialized;
        _serializedGoals = serialized; 
    }

    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }

    public string GetFileName()
    {
        return _fileName;
    }

    public void ListGoals()
    {
        foreach(string element in _deserializedGoals)
        {
            Console.WriteLine(element);
        }
    }

    public string SaveGoals()
    {
        foreach(string element in _deserializedGoals)
        {
            _formatedGoal += $"{element}, ";
        }
        _serializedGoals.Add(_formatedGoal);
        return _formatedGoal;
    }

}