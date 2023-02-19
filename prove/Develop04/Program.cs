using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
        BreathingActivity breath = new BreathingActivity("Welcome test1", "thank you bye","Just breath!!");
        breath.BreathMessage();
    }
}