using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserNameInMain = PromptUserName();
        int UserNumberInMain = PromtUserNumber();
        int SquaredNumberInMain = SquareNumber(UserNumberInMain, UserNumberInMain);
        DisplayResult(UserNameInMain, SquaredNumberInMain);
    }

    static void DisplayWelcome(){
    Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string UserName = Console.ReadLine();
        return UserName;
    }

    static int PromtUserNumber(){
        Console.Write("Please enter your favorite number: ");
        string UserNumberInString = Console.ReadLine();
        int UserNumber = int.Parse(UserNumberInString);

        return UserNumber;
    }

    static int SquareNumber(int first, int second){ 
        int SquaredNumberInFunction = first * second;
        return SquaredNumberInFunction;
    }

    static void DisplayResult(string UserName, int NumberSquared){
        Console.Write($"All right {UserName}, the square of your number is {NumberSquared}");
    }

}