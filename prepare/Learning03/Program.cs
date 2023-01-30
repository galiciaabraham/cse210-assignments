using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction newFraction = new Fraction();
        Console.WriteLine(newFraction.GetTop());
        Console.WriteLine(newFraction.GetBottom());
        newFraction.SetBottom(15);
        newFraction.SetTop(4);
        Console.WriteLine(newFraction.GetTop());
        Console.WriteLine(newFraction.GetBottom());

        

        Fraction newFraction2 = new Fraction(6);
        Console.WriteLine();

        Fraction newFraction3 = new Fraction(7,6);
        Console.WriteLine();
    }
}