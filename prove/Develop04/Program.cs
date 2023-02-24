using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        
        BreathingActivity breath = new BreathingActivity("Welcome to the Breathing Activity","Well done!!","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    
        ReflectingActivity reflect = new ReflectingActivity("Welcome to the Reflecting Activity","Well done like a steak!!","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        ListingActivity list = new ListingActivity("Welcome to the Reflecting Activity","The force is strong in this one!!","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        do {
            menu.DisplayMenu();
            if(menu.GetQuit() == "1"){
                breath.DisplayInitialMessage();
                breath.DisplayInstructions();
                breath.SetSeconds();
                Console.Clear();
                breath.DisplayGetReady();
                breath.ShowSpinner();
                breath.BreathMessage();
                breath.DisplayEndingMessage("Breathing Activity");
                breath.ShowSpinner();
                Console.Clear();

            } else if (menu.GetQuit() == "2"){
                reflect.DisplayInitialMessage();
                reflect.DisplayInstructions();
                reflect.SetSeconds();
                Console.Clear();
                reflect.DisplayGetReady();
                reflect.ShowSpinner();
                Console.WriteLine();
                reflect.DisplayPrompt();
                reflect.DisplayEndingMessage("Reflecting Activity");
                reflect.ShowSpinner();
                Console.Clear();
            } else if (menu.GetQuit() == "3"){
                list.SetSeconds();
                list.DisplayInitialMessage();
                list.DisplayInstructions();
                list.DisplayGetReady();
                list.DisplayPrompt();
                list.DisplayEndingMessage("Listing Activity");
            } else{
                if (menu.GetQuit() == "4")
                {
                    Console.Write("Thank you for taking the time to take care for yourself, have a nice day.");
                } else{

                Console.WriteLine("option not valid");
                }
            }
        } while (menu.GetQuit() != "4");
    }
}