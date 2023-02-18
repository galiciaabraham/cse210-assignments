using System;

public class Menu {

    private string _prompt;
    
    public string _quit;


    public Menu (){
        _prompt = "Menu Options\n1.Start breathing activity\n2.Start reflecting activity\n3.Start listing activity\n4.quit";
    
    }

    public void DisplayMenu(){
        Console.WriteLine(_prompt);
        _quit = Console.ReadLine();
    }
}