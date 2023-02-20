using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
        BreathingActivity breath = new BreathingActivity("Welcome to the Breathing Activity","Well done!!","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breath.BreathMessage();
    }
}