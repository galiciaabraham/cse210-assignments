using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        SimpleGoal simplegoal = new SimpleGoal();

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
            }   
        }
        } while (menu.GetOption() != "6");


    }
}