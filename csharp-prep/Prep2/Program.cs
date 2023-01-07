using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the percentage of your grade? ");
        string gradeInString = Console.ReadLine();
        int grade = int.Parse(gradeInString);

        if (grade >= 90)
        {
            Console.Write("Your grade is A");
        }
        
        else if (grade >= 80)
        {
            Console.Write("Your grade is B");
        }

        else if (grade >= 70)
        {
            Console.Write("Your grade is C");
        }

        else if (grade >= 60)
        {
            Console.Write("Your grade is D");
        }

        else if (grade < 60)
        {
            Console.Write("Your grade is F");
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
        
    }
        
}