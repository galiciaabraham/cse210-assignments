using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _serializedGoals = new List<string>{};
        List<Goal> _goals = new List<Goal>{};
        GoalFile goaltreatment = new GoalFile(_serializedGoals);
        SimpleGoal simple = new SimpleGoal();
        Menu menu = new Menu();
        Level level = new Level();

        int initialScore = 0;
        string initiallevel = "0";
        level.SetLevel(initiallevel);
        simple.CalculateScore(initialScore);    


         do{
        level.DisplayLevel();
        simple.DisplayScore();
        menu.DisplayMenu();
        menu.SetOption(Console.ReadLine());

        //Create New Goal.
        if(menu.GetOption() == "1")
        {
            
            menu.DisplayGoalTypes();
            menu.SetGoalType(Console.ReadLine());
            if(menu.GetGoalType() == "1")
            {
                simple.SetGoalType(menu.GetGoalType());
                Console.Write("What is the name of your goal?");
                simple.SetGoalName(Console.ReadLine());
                Console.Write("What is a short description of it? ");
                simple.SetGoalDescription(Console.ReadLine());
                Console.Write("What are the points associated with this goal? ");
                simple.SetGoalPoints(Console.ReadLine());
                simple.DeserializeGoal();
                _serializedGoals.Add(simple.SerializeGoal());
            }   
        //List Goals.
        } else if (menu.GetOption() == "2")
        {
            foreach (string line in _serializedGoals)
            {
                List<string> result = line.Split(",").ToList();
                if(result[1] == "1")
                {
                    simple.SetGoalType(menu.GetGoalType());
                    simple.SetGoalName(result[2]);
                    simple.SetGoalDescription(result[3]);
                    simple.SetGoalPoints(result[4]);
                    List<string> simpleDeserialized = simple.DeserializeGoal();
                    Console.WriteLine($"{simpleDeserialized[0]} {simpleDeserialized[1]}{simpleDeserialized[2]}{simpleDeserialized[3]}");
                }
                
            
            }
        // Save Goals. 
        } else if(menu.GetOption() == "3")
        {
            goaltreatment.SaveGoals(111,0);
        //Load Goals.
        } else if(menu.GetOption() == "4")
        {
            _serializedGoals = goaltreatment.LoadGoals();
        }

        } while (menu.GetOption() != "6");
}
}