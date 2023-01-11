using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string magicNumberinString = Console.ReadLine();
        Console.WriteLine("What is your guess?");
        string guessNumberinString = Console.ReadLine();

        int magicNumber = int.Parse(magicNumberinString);
        int guessNumber = int.Parse(guessNumberinString);

        if (guessNumber == magicNumber){
            Console.WriteLine("You guessed it!");
        } else if (guessNumber < magicNumber){
            Console.WriteLine("Higher");
        } else {
            Console.WriteLine("Lower");
        }
    }
}