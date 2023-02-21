using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        BreathingActivity breath = new BreathingActivity("Welcome to the Breathing Activity","Well done!!","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Activity activity1 = new Activity();
    
        ReflectingActivity reflect = new ReflectingActivity("Welcome to the Reflecting Activity","Well done like a steak!!","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        reflect.SetSeconds();
        reflect.DisplayPrompt();
        
    }
}