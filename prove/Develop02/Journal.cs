/* Responsibility: To display through all the entries in the selected Journal file. */
using System;
using System.IO;

public class Journal{

    public string _selectedJournal;

    public string _availableJournals;

    public string GetJournalName(){
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
}