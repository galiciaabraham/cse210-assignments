/*Responsibility: To storage the input from the user with the date in a clean format. */
using System;
using System.IO;
public class Entry {

    public string _fileName;
    public string _input;
    public string _date;
    public string _formatedInput;

    public string _finalEntry;

    public string GetInput(){
        Console.Write(">");
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

    public string SaveTemporalEntry(string prompt){
        return _finalEntry = $"{_date} -- Prompt:{prompt} -- {_formatedInput}";
        }
    
}
