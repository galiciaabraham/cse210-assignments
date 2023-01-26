/*Responsibility: To Display a menu of options, I created this so I didn't have to put it on the Main class. */
using System;

public class Menu {    
            
    public string _choise;

    public string GetChoise(){
        Console.WriteLine("Welcome to the Journal app!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        return _choise = Console.ReadLine();
    }

    public void MasterFunction(){
        string choise = _choise;
        do {
            Prompt prompts = new Prompt ();
            Entry entry1 = new Entry ();
            Journal journals = new Journal ();

            GetChoise();
            choise = _choise;
            string tempString = "";
            string displayStringTest = entry1._finalEntry;
            string newFileName = "";
            string saveFileName = "";
            string prompt = "";

            if(choise == "1"){
                prompts._prompts = new List<string>{"What brings you joy?", "Describe a place where you felt happiest.", "What was your greatest fear, and how did you conquer it?", "Write a letter to someone that you always want to thank but have never had the chance to do so.", "What is something that you would like to change about yourself? How can you change it?", "Write a letter to someone that you care about to tell them how you feel.","Reflect and write letters to yourself with constructive feedback to improve yourself.", "I am grateful for… ...", "What would make today great? ...", "Daily affirmation.", "3 Amazing things that happened today...", "How could I have made today even better?"};
                prompt = prompts._selectedPrompt;
                prompt = prompts.GetRandomPrompt();
                prompts.Display();
                tempString = entry1.GetInput();
                entry1.GetDate();
                entry1.FormatInput();
                entry1.SaveTemporalEntry(prompt);
            }

            else if (choise == "2"){
                Console.WriteLine(tempString);
                Console.WriteLine(displayStringTest);

            }

            else if (choise == "3"){
                newFileName = journals.GetJournalName();
                journals.GetEntries();
            }

            else if (choise == "4"){
                saveFileName = journals.GetJournalName();
                if (saveFileName == newFileName){
                    journals.SaveEntry(tempString, saveFileName); 
                }
      
            }

        } while(choise != "5");
    }
}
