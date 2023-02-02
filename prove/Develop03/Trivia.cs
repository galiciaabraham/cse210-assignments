using System;

public class Trivia{

    public string _inputReference;

    public string _correctReference;

    private bool _isCorrect;


    public Trivia(){
        _inputReference = "";
        _correctReference = "key";
    }
    public Trivia(string reference, string correctReference){

        _inputReference = reference;
        _correctReference = correctReference;

    }

    public void GetAnswer(){
        _inputReference = Console.ReadLine();
    }

    public void CheckAnswer(){
        if(_inputReference == _correctReference){
        _isCorrect = true;
        } else {
            _isCorrect = false;
        }
    }
}


