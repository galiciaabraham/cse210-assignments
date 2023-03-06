using System;
using System.IO;

public class GoalFile
{
    private string _fileName;
    private List<string> _deserializedGoals;
    private List<string> _serializedGoals;
    private string _formatedGoal;

    public GoalFile (List<string>deserialized, List<string>serialized)
    {
        _serializedGoals = serialized;
        _deserializedGoals = deserialized; 
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

    public void SaveGoals(string serialized)
    {
        _serializedGoals.Add(serialized);
        using(StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(string goal in _serializedGoals)
            {
                outputFile.WriteLine($"{goal}");
            }     
        }
    }

    private string ArrayToString(string[] array)
    {
        var result = string.Empty;
        foreach (var item in array)
        {
            result += item;
        }
        return result;
    }
    public void LoadGoals()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach(string line in lines)
        {
            string[] parts = line.Split(",");
            string newLine = ArrayToString(parts);
            _deserializedGoals.Add(newLine);
        }
    }
}