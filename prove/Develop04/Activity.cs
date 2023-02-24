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

        List<string> lines = new List<string>{"|","/","-","\\"};
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            string character = lines[i];
            Console.Write(character);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= lines.Count)
            {
                i = 0;
            }

        }


    }
    public void CountDown(){
    {
        List<string> lines = new List<string>{"5","4","3","2","1"};
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        while (DateTime.Now < endTime)
        {
            string character = lines[i];
            Console.Write(character);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= lines.Count)
            {
                i = 0;
            }

        }

    }
    }
}