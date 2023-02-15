using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Sloan", "Inheritance");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("James Baxter","Algebra","Section 123.2","Problems 10-29");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Curious George", "Sociology", "The amazing story of how the world went bananas");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWrittingInformation());
    }
}