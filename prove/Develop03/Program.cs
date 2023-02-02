using System;

class Program
{
    static void Main(string[] args)
    {
        
        Menu menu = new Menu();
        Scripture scripture = new Scripture();
        do{
        scripture.PickRandomScripture();
        menu.Display();
        menu.Input();



        } while(menu._quit != "quit");
    }
}