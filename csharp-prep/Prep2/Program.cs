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
    }
}