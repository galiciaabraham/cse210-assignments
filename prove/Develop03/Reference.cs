using System;

public class Reference{
    public string _reference;

    public Reference(string reference){
        _reference = reference;
    }

    public string GetReference(){
        return _reference;
    }

    public void SetReference(string reference){
        _reference = reference;
    }

    public void DisplayReference(){
        Console.WriteLine(_reference);
    }

}