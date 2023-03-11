using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        SimpleGoal simplegoal = new SimpleGoal();

        List<Goal> goals = new List<Goal>{simplegoal};
        List<string> serializedgoals = new List<string>{};

        GoalFile goaltreatment = new GoalFile(goals,serializedgoals);

        do{
        menu.DisplayMenu();
        menu.SetOption(Console.ReadLine());
        if(menu.GetOption() == "1")
        {
            menu.DisplayGoalTypes();
            menu.SetGoalType(Console.ReadLine());
            if(menu.GetGoalType() == "1")
            {
                simplegoal.SetGoalType(menu.GetGoalType());
                simplegoal.SetGoalName();
                simplegoal.SetGoalDescription();
                simplegoal.SetGoalPoints();
                simplegoal.DeserializeGoal();
                simplegoal.SerializeGoal();
                serializedgoals.Add(simplegoal.GetSerializedGoal());
            }   
        }
        else if (menu.GetOption() == "2")
        {
            foreach(Goal goal in goals)
            {
                goal.DeserializeGoal();
            }
            goaltreatment.ListGoals();   
        }
        } while (menu.GetOption() != "6");


    }
}