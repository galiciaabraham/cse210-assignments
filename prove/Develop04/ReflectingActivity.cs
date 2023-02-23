using System;

public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;
    private string _ready;
    private string _selectedPrompt;
    private string _selectedQuestion;
    private int _indexPrompts;
    private int _indexQuestions;
    private List<int> _alreadySelectedPrompts = new List<int>{};
    private List<int> _alreadySelectedQuestions = new List<int>{};

    public ReflectingActivity (string welcome, string ending, string instructions) : base(welcome, ending, instructions){

        _prompts = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
        _questions = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    }

    private string UserReady(){
        Console.WriteLine();
        Console.WriteLine("Once you're ready hit enter:");
        return _ready = Console.ReadLine();
    }


    private string PickRandomItem(int index, List<int> selectedList, List<string> nonSelectedList, string selected){
        //TODO: I need to set a way for the the program to know that all prompts have already been used, probably something with the _alreadyUsed list that will let me know when all index numbers in _prompts have been used.
        if (selectedList.Count != nonSelectedList.Count){
            return selected = Randomness(index,selectedList,nonSelectedList,selected);
            } else{
                selectedList.Clear();
                return selected = Randomness(index,selectedList,nonSelectedList,selected);
            } 

    }  

    private string Randomness(int index, List<int> selectedList, List<string> nonSelectedList, string selected){
        do{
        var random = new Random();
        index = random.Next(nonSelectedList.Count);
        }while(selectedList.Contains(index));
        selectedList.Add(index); 
        return selected = nonSelectedList[index];
        }

    public void DisplayPrompt(){
        _selectedQuestion = PickRandomItem(_indexQuestions,_alreadySelectedQuestions,_questions,_selectedQuestion);
        Console.WriteLine(_selectedQuestion);
        UserReady();
        if (_ready == ""){
        for (int i = 0; i < base.GetSeconds(); i++){
        _selectedPrompt = PickRandomItem(_indexPrompts,_alreadySelectedPrompts,_prompts,_selectedPrompt);
        Console.WriteLine(_selectedPrompt);
        } 
        } else {
            UserReady();
        }
    }
    }
    