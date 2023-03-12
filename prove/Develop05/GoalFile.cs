using System;
using System.IO;

public class GoalFile
{
    private string _fileName;
    private List<Goal> _serializedGoals = new List<Goal>();

    public GoalFile (List<Goal> serialized)
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
            foreach(Goal goal in _serializedGoals)
            {
                outputFile.WriteLine($"{goal}");
            }     
        }
    }
    public List<Goal> LoadGoals(List<Goal> serialized)
    {
        _serializedGoals.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach(string line in lines)
        {      
            serialized.Add(line);      
        }
        return serialized;
    }

    public void ListGoals(List<string> goals)
    {
        foreach (string item in goals)
        {
            Console.WriteLine(item);
        }
    }
}