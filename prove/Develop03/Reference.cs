using System;

public class Reference{
    private string _reference;

    private List<string>_references;

    
    public Reference(int referenceIndex){
        _references = new List<string>{"Mosiah 3:19","Luke 17:32","2 Nephi 2:something","John 3:16"};
        _reference = _references[referenceIndex];
    }

    /*Keep this constructor for testing, you can use it to set the reference to what's needed for testing.
    public Reference(string reference){
        _reference = reference;
    }
    */
    public string GetReference(){
        return _reference;
    }

    public void DisplayReference(){
        Console.WriteLine(_reference);
    }

}