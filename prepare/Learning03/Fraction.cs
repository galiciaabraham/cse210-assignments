using System;

public class Fraction{


    private int _top;
    private int _bottom;

    public Fraction(){

        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top){

        _top = top;
        _bottom = 5;
    }

    public Fraction(int top, int bottom){
        
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString(){
        string numerator = _top.ToString();
        string denominator = _bottom.ToString();
        return $" {numerator}/{denominator}";
    }

}