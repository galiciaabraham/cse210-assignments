using System;

public class Menu
{
    private string _prompt;
    private string _option;
    private string _goalType;

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

    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public void DisplayGoalTypes()
    {
        Console.Write("The types of Goals are:\n1. Simple Goal\n2.Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to select?: ");
    }
}