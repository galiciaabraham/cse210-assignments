using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        BreathingActivity breath = new BreathingActivity("Welcome to the Breathing Activity","Well done!!","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    
        ReflectingActivity reflect = new ReflectingActivity("Welcome to the Reflecting Activity","Well done like a steak!!","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        ListingActivity list = new ListingActivity("Welcome to the Reflecting Activity","The force is strong in this one!!","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        do {
            menu.DisplayMenu();
            if(menu.GetQuit() == "1"){
                breath.SetSeconds();
                breath.DisplayInitialMessage();
                breath.DisplayInstructions();
                breath.DisplayGetReady();
                breath.BreathMessage();
                breath.DisplayEndingMessage("Breathing Activity");

            } else if (menu.GetQuit() == "2"){
                reflect.SetSeconds();
                reflect.DisplayInitialMessage();
                reflect.DisplayInstructions();
                reflect.DisplayGetReady();
                reflect.DisplayPrompt();
                reflect.DisplayEndingMessage("Reflecting Activity");
            } else if (menu.GetQuit() == "3"){
                list.SetSeconds();
                list.DisplayInitialMessage();
                list.DisplayInstructions();
                list.DisplayGetReady();
                list.DisplayPrompt();
                list.DisplayEndingMessage("Listing Activity");
            } else{
                Console.WriteLine("option not valid");
            }
        } while (menu.GetQuit() != "4");
    }
}