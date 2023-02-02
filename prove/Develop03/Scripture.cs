using System;
using System.Linq;

public class Scripture{

    private string _scripture;

    public List<string> _wordByWord;

    private List<string> _scriptures;

    public Scripture(){
        _scriptures = new List<string>{"Jesus Wept", "Remember lots Wife","Adam fell that men might be; and men are, that they might have joy."};
    }
    public Scripture(List<string>scriptures){
        _scriptures = scriptures;
    }

    public string GetScripture(){
        return _scripture;
    }

    public void SplitScripture(){
        _wordByWord =  _scripture.Split(' ').ToList();
    }

    public void  PickRandomScripture(){
        var random = new Random();
       int index = random.Next(_scriptures.Count);

        _scripture = _scriptures[index];
    }

}