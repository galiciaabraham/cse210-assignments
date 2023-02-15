using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Sloan", "Inheritance");
        Console.WriteLine(assignment1.GetSummary());
    }
}