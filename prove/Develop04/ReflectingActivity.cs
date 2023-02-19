using System;

public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private string _ready;
    private string _selectedPrompt;
    private int _index;
    private List<int> _alreadySelected = new List<int>{};

    public string UserReady(){
        return _ready = Console.ReadLine();
    }

    public string PickRandomPrompt(){
        do{
        var random = new Random();
        _index = random.Next(_prompts.Count);
        }while(_alreadySelected.Contains(_index));
        _alreadySelected.Add(_index); 
        return _selectedPrompt = _prompts[_index];     
        } 

    public int GetIndex(){
        return _index;
    }

    public void DisplayPrompt(){
        Console.WriteLine(_selectedPrompt);
    }


}