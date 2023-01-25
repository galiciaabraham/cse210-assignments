using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt prompts = new Prompt ();
        prompts._prompts = new List<string>{"What brings you joy?", "Describe a place where you felt happiest.", "What was your greatest fear, and how did you conquer it?", "Write a letter to someone that you always want to thank but have never had the chance to do so.", "What is something that you would like to change about yourself? How can you change it?", "Write a letter to someone that you care about to tell them how you feel.","Reflect and write letters to yourself with constructive feedback to improve yourself.", "I am grateful for… ...", "What would make today great? ...", "Daily affirmation.", "3 Amazing things that happened today...", "How could I have made today even better?"};

        prompts.Display();

        Entry entry1 = new Entry ();

        entry1.GetDate();
        entry1.GetInput();
        entry1.SaveEntry();


    }
}