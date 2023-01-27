/*Responsibility: To storage the input from the user with the date in a clean format. */
using System;
using System.IO;
public class Entry {

    public List<string> _temporalEntries;
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
        string TrimInput(){
            string trimmed = _input.Trim(); 
            return trimmed;
        }
        string ConverToUpper(string trimmed){
            if (string.IsNullOrEmpty(trimmed))
            {
                return string.Empty;
            }
            return $"{trimmed[0].ToString().ToUpper()}{trimmed.Substring(1)}";
        }

        _formatedInput = TrimInput();
        _formatedInput = ConverToUpper(_input);
        return _formatedInput;
    }

    public void SaveTemporalEntry(string prompt){
        FormatInput();
        GetDate();
        _finalEntry = $"{_date} -- Prompt:{prompt} -- {_formatedInput}";
        }
    
}
