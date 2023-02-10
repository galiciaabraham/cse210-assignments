using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        Scripture scrip = new Scripture();
        Word word = new Word(scrip.GetWordbyWord());
        Reference refer = new Reference(scrip.GetIndex());
        Trivia trivia = new Trivia(refer._reference);
 //TODO: Set all variables to private and write get and set functions to get out whatever info I need outside of the class without compromising the encapsulation of it. OR have the methods return the needed information and then call the methods instead of getting the variables data outside of the class.
        Console.WriteLine(scrip.GetScripture());
        trivia.GetAnswer();
        trivia.CheckAnswer();
        if(trivia._isCorrect){
            Console.WriteLine("That is correct! A righteous one you are!");
            refer.DisplayReference();

        }else{
            Console.WriteLine("That is incorrect :( better luck next time!");
            refer.DisplayReference();

        }
    
        Console.WriteLine(scrip.GetScripture());

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