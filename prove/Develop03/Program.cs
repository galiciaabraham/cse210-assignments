using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        Word word = new Word();
        Scripture scrip = new Scripture();
        Reference refer = new Reference(scrip._index);

        refer.DisplayReference();
        string joint = " ";
        string initialScritpure = String.Join(joint ,word._listOfWords);
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