using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserNameInMain = PromptUserName();
        int UserNumberInMain = PromtUserNumber();
        int SquaredNumberInMain = SquareNumber(UserNumberInMain, UserNumberInMain);
    }

    static void DisplayWelcome(){
    Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.WriteLine("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }

    static int PromtUserNumber(){
        Console.WriteLine("Please enter your favorite number: ");
        string UserNumberInString = Console.ReadLine();
        int UserNumber = int.Parse(UserNumberInString);

        return UserNumber;
    }

    static int SquareNumber(int first, int second){ 
        int SquaredNumberInFunction = first * second;
        return SquaredNumberInFunction;
    }

}