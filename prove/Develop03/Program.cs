using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        Scripture scripture = new Scripture();
        do{
        scripture.SplitScripture();
        Word word = new Word(scripture._wordByWord);
        word.PickRandomWord();
        Console.Write(word._word);
        Console.Write(word.HideWord());
        menu.Display();
        menu.Input();



        } while(menu._quit != "quit");
    }
}