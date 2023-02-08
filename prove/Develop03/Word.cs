using System;
using System.Collections.Generic;

public class Word {

    private string _word;

    private int _chosenIndex;

    public string _hiddenWord;
    public List<int> _hiddenWords = new List<int>{};

    public List<string> _listOfWords;

    private int _wordCount;

    public Word(){
        Scripture scripture = new Scripture();
        scripture.PickRandomScripture();
        scripture.SplitScripture();
        _word = "";
        _listOfWords = scripture._wordByWord;

    }
    public Word(string word){
        _word = word;

        //The point of constructors is to only give access to what you need to access and keep the functionallity of your methods as planned
    }

    public Word(string word, int scripturelength){
        _word = word;
        _wordCount = scripturelength;
    }

    public int CountHiddenWords(){
        int count = 0;
            count += _hiddenWords.Count;
        return count;

        }

//ToDo: For now this function is pretty much doing anything but my idea is to make the program stop once the count matches the number of words in the scripture.

    public  int PickRandomWord(){
        var random = new Random();
        _chosenIndex = random.Next(_listOfWords.Count);
        _word = _listOfWords[_chosenIndex];
        return _chosenIndex;
    }

    public void HideWord(){
        _hiddenWord = "";
        foreach(char letter in _word){
            _hiddenWord += "_";
        }
        _hiddenWords.Add(_chosenIndex);
    }

    public void ReturnHiddenScripture(int index){
        _listOfWords[index] = _hiddenWord;

    }

    public void HideAndBuild(){
        int HiddenIndex = PickRandomWord();
        do{
            HiddenIndex = PickRandomWord();
        }while(_hiddenWords.Contains(_chosenIndex));
        HideWord();
        ReturnHiddenScripture(HiddenIndex);
    }

    public string DisplayNewScripture(){
        if(CountHiddenWords() != _listOfWords.Count){
        HideAndBuild();
        CountHiddenWords();
        string joint = " ";
        string displayedScripture = String.Join(joint, _listOfWords);
        Console.WriteLine(displayedScripture);
        return "";
        } else {
            return "quit";
        };
    
    }


    




}