/* Responsibility: To generate a random prompt from a list of prompts and display it to the user */
using System;

public class Prompt{

    public List<string> _prompts;

    public string _selectedPrompt;

    public void GetRandomPrompt(){
        var random = new Random();
        int index = random.Next(_prompts.Count);
        _selectedPrompt = _prompts[index];
    }

    public void Display(){
        Console.WriteLine($"{_selectedPrompt}");
    }
}