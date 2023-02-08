using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        Word word = new Word();
        foreach(string element in word._listOfWords){
            Console.WriteLine(element);
        }
      ;
        do{
        menu.Display();
        menu.Input();
        word.DisplayNewScripture();
        } while(menu._quit != "quit" || word.CountHiddenWords() != word._listOfWords.Count);
    }
}