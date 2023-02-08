using System;
using System.Collections.Generic;

public class Word {

    private string _word;

    public string _hiddenWord;
    public List<string> _hiddenWords = new List<string>{};

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
//Set an if condition to check wether the word has been selected before or not. if it has then pick another one!
        var random = new Random();
       int index = random.Next(_listOfWords.Count);

        _word = _listOfWords[index];
        return index;
    }

    public void HideWord(){
        foreach(char letter in _word){
            _hiddenWord += "_";
        }
        _hiddenWords.Add(_word);
    }

    public void ReturnHiddenScripture(int index){
        _listOfWords[index] = _hiddenWord;

    }

    public void HideAndBuild(){
        int HiddenIndex = PickRandomWord();
        HideWord();
        ReturnHiddenScripture(HiddenIndex);
    }

    public void DisplayNewScripture(){
        HideAndBuild();
        string joint = " ";
        string displayedScripture = String.Join(joint, _listOfWords);
        Console.WriteLine(displayedScripture);
    }


    




}