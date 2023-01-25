/*Responsibility: To storage the input from the user with the date in a clean format. */
using System;
using System.IO;
public class Entry {

    public string _fileName;
    public string _input;
    public string _date;
    public string _formatedInput;

    public string GetInput(){
        return _input = Console.ReadLine();
    }
    public string GetDate(){
        DateTime theCurrentTime = DateTime.Now;
        return _date = theCurrentTime.ToString("dd/MM/yyy HH:mm:ss");
    }
    public string FormatInput(){
        string TrimInput(string input){
            string trimmed = input.Trim(); 
            return trimmed;
        }
        string ConverToUpper(string input){
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return $"{input[0].ToString().ToUpper()}{input.Substring(1)}";
        }
        _formatedInput = TrimInput(_input);
        _formatedInput = ConverToUpper(_input);
        return _formatedInput;
    }

    public void SaveEntry(){
        Console.Write(_date);
        FormatInput();
        Console.WriteLine(_formatedInput);
        /*
        using (StreamWriter outputFile = new StreamWriter(_fileName)){
        outputFile.WriteLine(_date);
        outputFile.WriteLine($"{_formatedInput}");
        }
        */
    }

}