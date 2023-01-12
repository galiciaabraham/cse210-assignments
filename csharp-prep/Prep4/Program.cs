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

        int sum = 0;

        foreach (int number in numbers){
            sum = sum + number;
        }

        int listCount = numbers.Count;
        float average = sum / listCount;
        int max = numbers.Max();

        Console.WriteLine($"The total sum of your numbers is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The max number is {max}");

    }
}