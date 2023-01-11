using System;

class Program
{
    static void Main(string[] args)
    {
        {
        Console.WriteLine("What is the magic number?");
        string magicNumberinString = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberinString);

        int guessNumber = 0;

        while (guessNumber != magicNumber)
        {

        Console.WriteLine("What is your guess?");
        string guessNumberinString = Console.ReadLine();
        guessNumber = int.Parse(guessNumberinString);

        if (guessNumber > magicNumber){
            Console.WriteLine("Lower");
        } else if (guessNumber < magicNumber){
            Console.WriteLine("Higher");
        } else {
            Console.WriteLine("You guessed it!");
            
        }
    }
        }}}