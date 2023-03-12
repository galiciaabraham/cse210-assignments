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
                
                string type = goal.GetGoalType();
                string name = goal.GetGoalName();
                string description = goal.GetGoalDescription();
                string value = goal.GetGoalPoints().ToString();
                int objective = goal.GetObjective();
                int bonus = goal.GetBonus();
                if (type == "1")
                {
                    outputFile.WriteLine($"{type},{name},{description},{value}");
                } else if (type == "2")
                {
                    outputFile.WriteLine($"{type},{name},{description},{value}");
                } else 
                {
                    outputFile.WriteLine($"{type},{name},{description},{value},{objective},{bonus}");
                }
                
            }     
        }
    }  
public List<Goal> LoadGoals()
{
    _serializedGoals.Clear();
    string[] lines = System.IO.File.ReadAllLines(_fileName).Skip(2).ToArray();
    
    foreach (string line in lines)
    {
        string[] data = line.Split(',');
        string type = data[0];
        string name = data[1];
        string description = data[2];
        int value = int.Parse(data[3]);
        int objective = int.Parse(data[4]);
        int bonus = int.Parse(data[5]);
        if (type == "1")
        {
           Goal simplegoal = new SimpleGoal(name,description,value);
           _serializedGoals.Add(simplegoal);
        } else if(type == "2"){
            Goal eternalgoal = new EternalGoal(name,description,value);
            _serializedGoals.Add(eternalgoal);
        } else {
            Goal checklistgoal = new CheckListGoal(name,description,value,objective,bonus);
            _serializedGoals.Add(checklistgoal);
        }
    }
    return _serializedGoals;
}

public int LoadScore()
{
     int score;
    string[] lines = System.IO.File.ReadAllLines(_fileName);
    score = Int16.Parse(lines[1]);  
    return score;
}
public int LoadLevel()
{
    int level;
    string[] lines = System.IO.File.ReadAllLines(_fileName);
    level = Int16.Parse(lines[0]);  
    return level;
}
}