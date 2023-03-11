using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _serializedGoals = new List<string>{",Goal one,not completed, with this name, this description, 100","Goal two, with this name, this description 2, 200","Goal three, completed, with this name, this description, 300,1000,5/5"};
        GoalFile goaltreatment = new GoalFile(_serializedGoals);
        goaltreatment.SetFileName();
        goaltreatment.SaveGoals();
        _serializedGoals = goaltreatment.LoadGoals();

    }
}