using System;
class Program
{

static List<Goal> goals = new List<Goal>();
    static void Main(string[] args){
    Menu menu = new Menu();
    Level level = new Level();
    GoalFile goaltreatment = new GoalFile(goals);


        goaltreatment.LoadGoals(goals);

        int initialScore = 0;
        string initiallevel = "0";
        level.SetLevel(initiallevel);

    do{
        level.DisplayLevel();
        menu.DisplayMenu();
        menu.SetOption(Console.ReadLine());
        //Create New Goal.
        if(menu.GetOption() == "1")
        {
            menu.DisplayGoalTypes();
            menu.SetGoalType(Console.ReadLine());
        }
    } while (menu.GetOption() != "6");
    }
}
