using System;
using System.Linq;

public class Scripture{

    private static string _scripture;

    private List<string> _wordByWord;

    private List<string> _scriptures;

    private int _scriptureLenght;

    private int _index;

    public Scripture(){
        _scriptures = new List<string>{"The Natural Man is an Enemy of God", "Remember lots Wife","Adam fell that men might be; and men are, that they might have joy.","For God so loveth the world that gaveth his son so the world can be saved"};
        PickRandomScripture();
        SplitScripture();

    }

    /*Keep this constructor for testing, you can set the list of scriptures to what's needed for testing. 
    public Scripture(List<string>scriptures){
        _scriptures = scriptures;
        PickRandomScripture();
        SplitScripture();
    }
    */

    public int GetIndex(){
        return _index;
    }
    public List<string> GetWordbyWord(){
        return _wordByWord;
    }
    public string GetScripture(){
        return _scripture;
    }

    private void  PickRandomScripture(){
        var random = new Random();
        _index = random.Next(_scriptures.Count);

        _scripture = _scriptures[_index];
    }
    private void SplitScripture(){
        _wordByWord =  _scripture.Split(' ').ToList();
    }

}