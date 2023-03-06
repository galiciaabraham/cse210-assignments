using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> deserializedExample = new List<string>{"Hello World","Hello mom","Hello Moose","Goodbye moon"};

        List<string> serializedExample = new List<string>{""};

        GoalFile filetest1 = new GoalFile(deserializedExample,serializedExample);

        filetest1.SetFileName(Console.ReadLine());
        filetest1.ListGoals();
        Console.WriteLine(filetest1.GetFileName());
        filetest1.LoadGoals();
        filetest1.ListGoals();

    }
}