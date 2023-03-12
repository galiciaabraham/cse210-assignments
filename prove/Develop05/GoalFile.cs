using System;
using System.IO;

public class GoalFile
{
    private string _fileName;
    private List<string> _serializedGoals = new List<string>();

    public GoalFile (List<string> serialized)
    {
        _serializedGoals = serialized;
    }

    public void SetFileName()
    {
        Console.Write("What is the name of the file name?: ");
        _fileName = Console.ReadLine();
    }

    public string GetFileName()
    {
        return _fileName;
    }
    public void SaveGoals(int score, int level)
    {
        using(StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{level}");
            outputFile.WriteLine($"{score}");
            foreach(string goal in _serializedGoals)
            {
                outputFile.WriteLine($"{goal}");
            }     
        }
    }
    public List<string> LoadGoals()
    {
        _serializedGoals.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach(string line in lines)
        {
                _serializedGoals.Add(line);      
        }
        return _serializedGoals;
    }

    public void ListGoals(List<string> goals)
    {
        foreach (string item in goals)
        {
            Console.WriteLine(item);
        }
    }
}