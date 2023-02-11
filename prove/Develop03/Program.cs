using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        Scripture scrip = new Scripture();
        Word word = new Word(scrip.GetWordbyWord());
        Reference refer = new Reference(scrip.GetIndex());
        Trivia trivia = new Trivia(refer.GetReference());

        
        Console.WriteLine(scrip.GetScripture());
        trivia.TriviaGame();
        refer.DisplayReference();
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