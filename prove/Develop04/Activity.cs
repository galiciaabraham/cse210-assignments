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

    public void DisplayEndingMessage(){
        Console.WriteLine(_ending);
    }

    public void DisplayGetReady(){
        Console.WriteLine(_getReady);
    }

    public void DisplayInstructions(){
        Console.WriteLine(_instructions);
    }
    public void GetSeconds(){
        Console.Write("For how long (in seconds) would you like to perform this activity?");
       string seconds = Console.ReadLine();
       _seconds = Int32.Parse(seconds);
    }

    public void ShowSpinner(){
        for (int i = 0; i < 10; i++)
    {
        Console.Write("\b|");
        Thread.Sleep(500);
        Console.Write("\b/");
        Thread.Sleep(500);
        Console.Write("\b-");
        Thread.Sleep(500);
        Console.Write("\b\\");
        Thread.Sleep(500);
    }
    }
    public void CountDown(){
    {
        Console.Write("\b3...\b\b\b");
        Thread.Sleep(2000);
        Console.Write("\b2...\b\b\b");
        Thread.Sleep(2000);
        Console.Write("\b1...\b\b\b");
        Thread.Sleep(2000);
        Console.Clear();
    }
    }
}