using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction newFraction = new Fraction();
        Console.WriteLine(newFraction.GetFractionString());

        Fraction newFraction2 = new Fraction(6);
        Console.WriteLine(newFraction2.GetFractionString());

        Fraction newFraction3 = new Fraction(7,6);
        Console.WriteLine(newFraction3.GetFractionString());
    }
}