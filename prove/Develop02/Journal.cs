/* Responsibility: To display through all the entries in the selected Journal file. */
using System;
using System.IO;

public class Journal{

    public string _selectedJournal;


    public string GetJournalName(){
        /*Purpose: To get the user input to get the selected journal*/
        return _selectedJournal = Console.ReadLine();
    }

    public void GetEntries(){
        string fileName = _selectedJournal;
        string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(line);
        }
         
    }
    public void SaveEntry(List<string> tempEntries, string journal){
        using(StreamWriter outputFile = new StreamWriter(journal))
        foreach(string line in tempEntries){
            {
            outputFile.WriteLine(line);
        }
        }
    }
}