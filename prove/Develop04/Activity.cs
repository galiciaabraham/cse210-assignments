using System;

public class Activity {
   private string _welcome;
   private string _instructions;
   private string _ending;
   private int _seconds;
   private string _spinner;
   private string _countDownNumber;

   public Activity(){
    _welcome = "This is the activity tals";
   }

    public void DisplayInitialMessage(){
        Console.WriteLine(_welcome);
    }

    public void GetSeconds(){
        Console.Write("For how long (in seconds) would you like to perform this activity?");
       string seconds = Console.ReadLine();
       _seconds = Int32.Parse(seconds);
    }
}