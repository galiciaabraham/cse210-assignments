/*Responsibility: To Display a menu of options, I created this so I didn't have to put it on the Main class. */
using System;

public class Menu {    
            
    public string _choise;

    public void GetChoise(){
        Console.WriteLine("Welcome to the Journal app!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        _choise = Console.ReadLine();
    }


    public void MasterFunction(){
        Login login = new Login();
        Prompt prompts = new Prompt ();
        Entry entry1 = new Entry ();
        Journal journals = new Journal ();
        entry1._temporalEntries = new List<string>{};


        do {
            GetChoise();
            entry1._finalEntry = "";
            prompts._selectedPrompt = "";
            journals._selectedJournal = "";

            if(_choise == "1"){
                prompts._prompts = new List<string>{"What brings you joy?", "Describe a place where you felt happiest.", "What was your greatest fear, and how did you conquer it?", "Write a letter to someone that you always want to thank but have never had the chance to do so.", "What is something that you would like to change about yourself? How can you change it?", "Write a letter to someone that you care about to tell them how you feel.","Reflect and write letters to yourself with constructive feedback to improve yourself.", "I am grateful for… ...", "What would make today great? ...", "Daily affirmation.", "3 Amazing things that happened today...", "How could I have made today even better?"};
                prompts.GetRandomPrompt();
                prompts.Display();

                entry1.GetInput();
                entry1.SaveTemporalEntry(prompts._selectedPrompt);

                entry1._temporalEntries.Add(entry1._finalEntry);
            }

            else if (_choise == "2"){
                foreach(string line in entry1._temporalEntries){
                Console.WriteLine(line);
                Console.WriteLine("");
                }
            }

            else if (_choise == "3"){
                Console.Write("Please enter the file name: ");
                journals.GetJournalName();
                login.VerifyPIN();
                if(login._pass == true){
                    journals.GetEntries();
                }
                else{
                    Console.WriteLine("Wrong PIN! Please try again...");
                    _choise = "3";
                };
            }

            else if (_choise == "4"){
                journals.GetJournalName();
                journals.SaveEntry(entry1._temporalEntries, journals._selectedJournal); 
            }
            
        } while(_choise != "5");
    }
}
