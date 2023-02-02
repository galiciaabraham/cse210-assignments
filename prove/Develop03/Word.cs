using System;
using System.Collections.Generic;

public class Word {

    public string _word;

    private List<string> _hiddenWords;

    private int _wordCount;


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

    public  void PickRandomWord(List<string>listOfWords){
        var random = new Random();
       int index = random.Next(listOfWords.Count);

        _word = listOfWords[index];
    }

    




}