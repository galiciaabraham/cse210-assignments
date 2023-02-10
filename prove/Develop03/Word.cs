using System;
using System.Collections.Generic;

public class Word {

    private string _word;

    private int _chosenIndex;

    private string _hiddenWord;
    private List<int> _hiddenWords = new List<int>{};

    private List<string> _listOfWords;

    public Word(List<string> wordbyword){
        _word = "";
        _listOfWords = wordbyword;
    }
    public Word(string word){
        _word = word;

    }
    public int CountHiddenWords(){
        int count = 0;
            count += _hiddenWords.Count;
        return count;
        }

//ToDo: For now this function is pretty much doing anything but my idea is to make the program stop once the count matches the number of words in the scripture.

    private  int PickRandomWord(){
        var random = new Random();
        _chosenIndex = random.Next(_listOfWords.Count);
        _word = _listOfWords[_chosenIndex];
        return _chosenIndex;
    }

    private void HideWord(){
        _hiddenWord = "";
        foreach(char letter in _word){
            _hiddenWord += "_";
        }
        _hiddenWords.Add(_chosenIndex);
    }

    private void HideAndBuild(){
        int HiddenIndex = PickRandomWord();
        do{
            HiddenIndex = PickRandomWord();
        }while(_hiddenWords.Contains(_chosenIndex));
        HideWord();
        _listOfWords[HiddenIndex] = _hiddenWord;
    }

    public string DisplayNewScripture(){
        if(CountHiddenWords() != _listOfWords.Count){
        HideAndBuild();
        Console.Clear();
        string joint = " ";
        string displayedScripture = String.Join(joint, _listOfWords);
        Console.WriteLine(displayedScripture);
        return "";
        } else {
            return "quit";
        };
    }
}