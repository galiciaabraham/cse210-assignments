using System;
using System.Linq;

public class Scripture{

    private static string _scripture;

    public List<string> _wordByWord;

    private List<string> _scriptures;

    private int _scriptureLenght;

    public Scripture(){
        _scriptures = new List<string>{"The Natural Man is an Enemy of God", "Remember lots Wife","Adam fell that men might be; and men are, that they might have joy.","For God so loveth the world that gaveth his son so the world can be saved"};

    }
    public Scripture(List<string>scriptures){
        _scriptures = scriptures;
    }

    public string GetScripture(){
        return _scripture;
    }

    public void  PickRandomScripture(){
        var random = new Random();
       int index = random.Next(_scriptures.Count);

        _scripture = _scriptures[index];
    }
    public void SplitScripture(){
        _wordByWord =  _scripture.Split(' ').ToList();
    }

}