using System;
using System.Linq;

public class Scripture{

    public string _scripture;

    public List<string> _wordByWord;

    private List<string> _scriptures;

    public Scripture(List<string>scriptures){
        _scriptures = scriptures;
    }

    public void SplitScripture(){
        _wordByWord =  _scripture.Split(' ').ToList();
    }

    public void  PickRandomScripture(List<string>scriptures){
        var random = new Random();
       int index = random.Next(scriptures.Count);

        _scripture = scriptures[index];
    }

}