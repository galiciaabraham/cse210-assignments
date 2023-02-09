using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        Word word = new Word();
        Scripture scrip = new Scripture();
        Reference refer = new Reference(scrip._index);
        Trivia trivia = new Trivia(refer._reference);

        string joint = " ";
        string initialScritpure = String.Join(joint ,word._listOfWords);
        Console.WriteLine(initialScritpure);
        trivia.GetAnswer();
        trivia.CheckAnswer();
        if(trivia._isCorrect){
            Console.WriteLine("That is correct! A righteous one you are!");
            refer.DisplayReference();

        }else{
            Console.WriteLine("That is incorrect :( better luck next time!");
            refer.DisplayReference();

        }
    
        Console.WriteLine(initialScritpure);

        do{
        menu.Display();
        if (menu.Input()){
            menu._quit = "quit";
        }else{
        menu._quit = word.DisplayNewScripture();
        }
    }while(menu._quit != "quit");
   
}
}