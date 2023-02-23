using System;

public class ListingActivity : Activity{
    private List<string> _prompts;
    private string _selectedPrompt;
    private string _input;
    private int _inputCount;
    private int _index;
    private List<int> _alreadySelected= new List<int>{};

    public ListingActivity (string welcome, string ending, string instructions) : base(welcome, ending, instructions){

        _prompts = new List<string>{"Who are people that you appreciate","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    }

    private string GetInput(){
        Console.Write(">");
        _input = Console.ReadLine();
        _inputCount+= 1;
        return _input;

    }

    private string PickRandomPrompt(){
        if (_alreadySelected.Count != _prompts.Count){
                return Randomness();
            } else {
                _alreadySelected.Clear();
                return Randomness();
            }
        }  

    private string Randomness(){
        do{
            var random = new Random();
            _index = random.Next(_prompts.Count);
        }while(_alreadySelected.Contains(_index));
            _alreadySelected.Add(_index); 
            return _selectedPrompt = _prompts[_index];
    }
    public void DisplayPrompt(){
        //TODO: I need to make sure I'm using this method for what it was designed for, I also need to make sure I keep a list of the already selected prompts that will surive through the looping of the Whole program so if the user decides to start the same activity more than once the same prompt is not repeated until all prompts have been displayed. Make sure you display the prompt and storage the number of inputs from the user.
        PickRandomPrompt();
        Console.WriteLine(_selectedPrompt);
        do {
        GetInput();
        }while(base.GetSeconds() != 30);
    }
}
