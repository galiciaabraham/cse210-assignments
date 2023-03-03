using System;

public class Menu
{
    private string _prompt;
    private string _option;

    public Menu()
    {
        _prompt = "Menu Options\n1.Create new goal\n2.List goals\n3.Save Goals\n4.Load Goals\n5.Record Event\n6.Quit\nSelect an option fromt the menu: ";
    }

    public void SetOption(string option)
    {
        _option = option;
    }

    public string GetOption()
    {
        return _option;
    }

    public void DisplayMenu()
    {
        Console.Write(_prompt);
    }
}