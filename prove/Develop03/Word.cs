using System;
using System.Collections.Generic;

public class Word {

    public string _word;

    public string _hiddenWord;
    private List<string> _hiddenWords;

    public List<string> _listOfWords;


    private int _wordCount;


    public Word(List<string>listofWords){
        _word = "";
        _listOfWords = listofWords;
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
        int i=0;
        int count = 0;
        for (i = 0; i < _wordCount; i+= i){
            count += i;
        }
        return count;

        //ToDo: For now this function is pretty much doing anything but my idea is to make the program stop once the count matches the number of words in the scripture.
    }

    public  void PickRandomWord(){
        var random = new Random();
       int index = random.Next(_listOfWords.Count);

        _word = _listOfWords[index];
    }

    public string HideWord(){
        foreach(char letter in _word){
            _hiddenWord += "_";
        }
        return _hiddenWord;
    }

    public string ReturnHidenScripture(){
        return "a new list of strings that will match the chosen word with the string of _____";
    }

    public void HideAndBuild(){
        HideWord();
        ReturnHidenScripture();
    }

    public void DisplayNewScripture(){
        Console.WriteLine("New scripture with hidden words");
    }


    




}