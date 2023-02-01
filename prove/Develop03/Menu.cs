using System;

public class Menu {

    private string _prompt;
    
    public string _quit;


    public Menu (){
        _prompt = "Press enter to erase words or 'quit' for ending the program";
    
    }

    public Menu(string quit){
        _prompt = "Press enter to erase words or 'quit' for ending the program";
        _quit = quit;
    }

    public bool Input(){
        _quit  = Console.ReadLine();
        if (_quit == "quit"){
            return true;
        } else{
            return false;
        }
    }

    public void Display(){
        Console.WriteLine(_prompt);
    }
}