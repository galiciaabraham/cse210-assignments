using System;

public class Menu {

    private string _prompt;
    
    private string _quit;


    public Menu (){
        _prompt = "Menu Options\n1.Start breathing activity\n2.Start reflecting activity\n3.Start listing activity\n4.quit";
    
    }

    public string GetQuit(){
        return _quit;
    }

    public void DisplayMenu(){
        Console.WriteLine(_prompt);
        Console.Write("Select an option from the menu:");
        _quit = Console.ReadLine();
    }
}