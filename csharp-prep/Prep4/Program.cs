using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        List<int> numbers = new List<int>();

        do{

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number:");
        string userNumberinString = Console.ReadLine();
        userNumber = int.Parse(userNumberinString);
        numbers.Add(userNumber);

        } while (userNumber != 0);

    }
}