using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal simple = new SimpleGoal();
        Menu menu = new Menu();
        Level level = new Level();
        List<string> _serializedGoals = new List<string>();
        GoalFile goaltreatment = new GoalFile(_serializedGoals);

    

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
                string goalType = simple.GetGoalType();
                Console.Write("What is the name of your goal?");
                simple.SetGoalName(Console.ReadLine());
                string goalName = simple.GetGoalName();
                Console.Write("What is a short description of it? ");
                simple.SetGoalDescription(Console.ReadLine());
                string goalDescription = simple.GetGoalDescription();
                Console.Write("What are the points associated with this goal? ");
                simple.SetGoalPoints(Console.ReadLine());
                string goalPoints = simple.GetGoalPoints().ToString();
                string iscomplete = simple.GetCompleted();
                string formated = $"{iscomplete} - {goalType},{goalName},{goalDescription},{goalPoints}";
                _serializedGoals.Add(formated);
            }   

        //List Goals.
        } else if (menu.GetOption() == "2")
        {
            goaltreatment.ListGoals(_serializedGoals);
        // Save Goals. 
        } else if(menu.GetOption() == "3")
        {
            goaltreatment.SaveGoals(111,0);
        //Load Goals.
        } else if(menu.GetOption() == "4")
        {
            _serializedGoals = goaltreatment.LoadGoals();
        //RecordEvent.
        } else if(menu.GetOption() == "5")
        {
            goaltreatment.ListGoals(_serializedGoals);
            Console.Write("Which goal would you like to edit?");
            int selectedIndex = Int16.Parse(Console.ReadLine());
            if (selectedIndex == 1)
            {
            simple.SetSelectedGoalToEdit(_serializedGoals[selectedIndex]);
            simple.MarkCompletion();
            }
        } 


        } while (menu.GetOption() != "6");
}
}