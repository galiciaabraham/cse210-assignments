using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _serializedGoals = new List<string>{};
        GoalFile goaltreatment = new GoalFile(_serializedGoals);
        SimpleGoal simple = new SimpleGoal();

        simple.SetGoalType("1");
        simple.SetGoalName();
        simple.SetGoalDescription();
        simple.SetGoalPoints();

        simple.DeserializeGoal();
        _serializedGoals.Add(simple.SerializeGoal());


        goaltreatment.SetFileName();
        goaltreatment.SaveGoals();
        _serializedGoals = goaltreatment.LoadGoals();
        foreach(string item in _serializedGoals)
        {        
        Console.Write(item);
        }
    }
}