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
                breath.DisplayInitialMessage();
                breath.DisplayInstructions();
                breath.SetSeconds();
                Console.Clear();
                breath.DisplayGetReady();
                breath.ShowSpinner();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(breath.GetSeconds());
                while (DateTime.Now < futureTime)
                {
                breath.BreathMessage();
                Thread.Sleep(500);
                }
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
                reflect.DisplayQuestion();
                reflect.UserReady();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(reflect.GetSeconds());
                Console.WriteLine("Now ponder on each of the following questions:");
                reflect.CountDown();
                while (DateTime.Now < futureTime)
                {
                reflect.DisplayPrompt();
                Thread.Sleep(5000);
                reflect.ShowSpinner();
                }
                reflect.DisplayEndingMessage("Reflecting Activity");
                reflect.ShowSpinner();
                Console.Clear();

            } else if (menu.GetQuit() == "3"){
                list.DisplayInitialMessage();
                list.DisplayInstructions();
                list.SetSeconds();
                Console.Clear();
                list.DisplayGetReady();
                list.ShowSpinner();
                list.DisplayPrompt();
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(list.GetSeconds());
                list.CountDown();
                while (DateTime.Now < futureTime)
                {
                list.GetInput();
                Thread.Sleep(500);
                }
                list.DisplayFinalCount();
                list.DisplayEndingMessage("Listing Activity");
                list.ShowSpinner();
                Console.Clear();
            } else
            {
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