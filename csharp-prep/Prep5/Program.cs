using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserNameInMain = PromptUserName();
        
    }

    static void DisplayWelcome(){
    Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.WriteLine("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }
}