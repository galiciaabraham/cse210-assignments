using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percentage of your grade? ");
        string gradeInString = Console.ReadLine();
        int grade = int.Parse(gradeInString);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        
        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("");
            Console.Write("Well done like a steak! You passed!");
        }

        else
        {
            Console.WriteLine("");
            Console.Write("Unfortunately you did't pass...Learn from your mistakes and don't give up!");
        }

        Console.Write($"Your grade is {letter}");
        
    }
        
}