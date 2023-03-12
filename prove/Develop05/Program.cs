using System;
class Program
{

static List<Goal> goals = new List<Goal>();
    static void Main(string[] args){
    Menu menu = new Menu();
    Level level = new Level();
    GoalFile goaltreatment = new GoalFile(goals);

        int initialScore = 0;
        int initiallevel = 0;
        level.SetLevel(initiallevel);

    do{
        
        level.DisplayLevel();
        Console.WriteLine($"Your score is: {initialScore}");
        menu.DisplayMenu();
        menu.SetOption(Console.ReadLine());
        //Create New Goal.
        if(menu.GetOption() == "1")
        {
            menu.DisplayGoalTypes();
            menu.SetGoalType(Console.ReadLine());
            if (menu.GetGoalType() == "1")
            {
            
            Console.Write("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What are the points associated with this goal? ");
            int value = int.Parse(Console.ReadLine());
            SimpleGoal goal = new SimpleGoal(goalName,goalDescription,value);
            goals.Add(goal);
            } else if (menu.GetGoalType() == "2")
            {
            
            Console.Write("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What are the points associated with this goal? ");
            int value = int.Parse(Console.ReadLine());
            EternalGoal goal = new EternalGoal(goalName,goalDescription,value);
            goals.Add(goal);
            } else if (menu.GetGoalType() == "3")
            {
            Console.Write("What is the name of your goal?");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What are the points associated with this goal? ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("How many times do you need to complete this goal for the bonus? ");
            int objective = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing this goal? ");
            int bonus = int.Parse(Console.ReadLine());
            CheckListGoal goal = new CheckListGoal(goalName,goalDescription,value,objective,bonus);
            goals.Add(goal);
            }
        //List Goals.
        } else if(menu.GetOption() == "2")
        {
            Console.WriteLine("Goals:");
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.CheckCompletion());
            }
        //Save Goals. 
        } else if (menu.GetOption() == "3")
        {
            goaltreatment.SetFileName();
            goaltreatment.SaveGoals(initialScore, initiallevel);
        //Load Goals.
        } else if (menu.GetOption() == "4")
        {
            goaltreatment.SetFileName();
            goaltreatment.LoadGoals();
            initialScore = goaltreatment.LoadScore();
            initiallevel = goaltreatment.LoadLevel();
        //Record Event.
        } else if (menu.GetOption() == "5"){
            Console.WriteLine("Goals:");
            foreach (Goal goal1 in goals)
            {
                Console.WriteLine(goal1.CheckCompletion());
                goal1.CalculateScore(initialScore);
            }
            Console.Write("Enter goal index: ");
            int index = Int16.Parse(Console.ReadLine());
            Goal goal = goals[index];
            goal.RecordEvent();
            level.IncreaseLevel(initialScore);
        }
    } while (menu.GetOption() != "6");
}
}
