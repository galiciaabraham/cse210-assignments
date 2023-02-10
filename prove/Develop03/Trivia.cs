using System;

public class Trivia{

    private string _inputReference;

    private string _correctReference;

    private bool _isCorrect;


    public Trivia(){
        _inputReference = "";
        _correctReference = "key";
    }

    public Trivia(string correctReference){
        _correctReference = correctReference;
    }
    public Trivia(string reference, string correctReference){

        _inputReference = reference;
        _correctReference = correctReference;

    }


    private void GetAnswer(){
        Console.WriteLine("What is the reference of this scripture?");
        _inputReference = Console.ReadLine();
    }

    private void CheckAnswer(){
        if(_inputReference == _correctReference){
        _isCorrect = true;
        } else {
            _isCorrect = false;
        }
    }

    public void TriviaGame(){
        GetAnswer();
        CheckAnswer();
        if(_isCorrect){
            Console.WriteLine("That is correct! A righteous one you are!");
        }else{
            Console.WriteLine("That is incorrect :( better luck next time!");
        }
    }
}


