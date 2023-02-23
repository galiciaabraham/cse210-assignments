using System;

public class Activity {
   private string _welcome;
   private string _instructions;
   private string _ending;
   private string _getReady;
   private int _seconds;

   public Activity(){
    _welcome = "Welcome ma frend";
    _ending = "Goodbye ma frend";
    _getReady = "Get Ready...";
    _instructions = "these will be the instructions";
   }
   public Activity(string welcome, string ending, string instructions){
    _welcome = welcome;
    _ending = ending;
    _instructions = instructions;
    _getReady = "Get Ready...";
   }


    public void DisplayInitialMessage(){
        Console.WriteLine(_welcome);
    }

    public void DisplayEndingMessage(string activity){
        string seconds = GetSeconds().ToString();
        Console.WriteLine(" ");
        Console.WriteLine(_ending);
        ShowSpinner();
        Console.WriteLine($"You have completed {seconds} seconds of the {activity};");
    }

    public void DisplayGetReady(){
        Console.WriteLine(_getReady);
    }

    public void DisplayInstructions(){
        Console.WriteLine();
        Console.WriteLine(_instructions);
        Console.WriteLine();
    }

    public void SetSeconds(){
        Console.WriteLine();
        Console.Write("For how long (in seconds) would you like to perform this activity?");
       string seconds = Console.ReadLine();
       _seconds = Int32.Parse(seconds);
    }

    public int GetSeconds(){
        return _seconds;
    }

    public void ShowSpinner(){
        for (int i = 0; i < 3; i++)
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b/");
        Thread.Sleep(500);
        Console.Write("\b-");
        Thread.Sleep(500);
        Console.Write("\b\\");
        Thread.Sleep(500);
        Console.Write("\b\b");
    }
    }
    public void CountDown(){
    {
        Console.Write("3...\b\b\b");
        Thread.Sleep(500);
        Console.Write("\b2...\b\b\b\b");
        Thread.Sleep(500);
        Console.Write("1...\b\b\b");
        Thread.Sleep(500);
        Console.Write("\b\b\b\b");
        Console.WriteLine();
    }
    }
}